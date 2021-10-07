using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace D2RServerChecker {
    class DiabloServerInfo {
        private int processID = 0;
        private List<string> baselineAddresses = new List<string>();

        public bool getD2RProcessID() {
            Process[] d2rProcess = Process.GetProcessesByName("D2R");

            if(d2rProcess.Length <= 0) {
                return false;
            }

            processID = d2rProcess[0].Id;

            return true;
        }

        public List<string> getConnectedAddresses(bool baseline = false) {
            if(processID <= 0) {
                if(!getD2RProcessID()) {
                    return null;
                }
            }

            List<string> addressList = new List<string>();

            using(Process process = new Process()) {
                process.StartInfo.FileName = "netstat.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.Arguments = "-ano";
                process.Start();

                using(StreamReader reader = process.StandardOutput) {
                    string output = reader.ReadToEnd();
                    process.WaitForExit();

                    string[] lines = output.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                    foreach(string line in lines) {
                        string[] entries = line.Split(' ');
                        if(entries.Length < 5) continue;
                        if(entries.Any(s => s.Contains("Proto"))) continue;


                        List<string> validEntries = new List<string>();

                        foreach(string entry in entries) {
                            if(entry.Trim() == "") continue;

                            validEntries.Add(entry);
                        }

                        if(validEntries.Count < 5) {
                            //System.Windows.Forms.MessageBox.Show("Less than 5 in a valid entry?");
                            continue;
                        }

                        if(validEntries[4] == processID.ToString()) {
                            // D2R Connection
                            if(validEntries[3] == "ESTABLISHED") {
                                string address = validEntries[2].Split(":")[0];
                                addressList.Add(address);
                            }
                        }
                    }
                }
            }

            if(baseline) {
                baselineAddresses.Clear();
                baselineAddresses = addressList;
            }

            return addressList;
        }

        public List<string> getServerAddresses() {
            List<string> serverAddresses = new List<string>();

            List<string> connectedAddresses = getConnectedAddresses();

            foreach(string address in connectedAddresses) {
                if(!baselineAddresses.Any(s => s.Contains(address))) {
                    serverAddresses.Add(address);
                }
            }

            return serverAddresses;
        }
    }
}
