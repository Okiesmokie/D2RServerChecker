# D2RServerChecker
Gets the IP address of the server you are currently connected to on D2R.  Used mainly for being on the correct server when a dclone is spawned.

# Instructions
1. Launch D2R and connect to the Lobby
2. Click the "Click this when in lobby" button (You only have to do this once)
3. Enter a game
4. Click "Get server address"

The server's address will appear in the textbox if all steps are followed correctly.

# How it works

When you click the "Click this when in lobby" button, the program stores all of the connections that D2R currently has.

When you join a game and click "Get server address" it does the same thing, except it checks which of those were not connected to while in the lobby.

The resulting connection should theoretically be the IP Address of the server.
