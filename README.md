FIRST OF ALL, THIS IS A QUICK AND EASY GUIDE ON HOW TO PLAY WITH YOUR FRIENDS OR EVEN MAKE A PUBLIC SERVER. IF YOU WANT TO MAKE A COMMUNITY SERVER WITH MANY MODS AND STUFF, THIS GUIDE MIGHT NOT BE FOR YOU!
ALL THE CODE IS OPEN SOURCE ON GITHUB.

GO TO THIS LINK AND DOWNLOAD THE LATEST RELEASE:


**How to use:**

Configure these 3 files before trying to open the cs2-server.exe:

**variables.json**\
REQUIRED FOR THE SERVER TO WORK

**instances.json**\
IN CASE YOU WANT TO OPEN SERVERS DIRECTLY AND SWAP EASILY BETWEEN WORKSHOP MAPS BY JUST REOPENING THE SERVER

**arguments.json**\
IN CASE YOU WANT YOUR SERVER TO START WITH SPECIFIC ARGUMENTS AUTOMATICALLY

=-=-=-=-=-=-=-=-=-=-=-=-=-=\
How to configure **variables.json**:

**CS2Path**\
Open steam, right click on CS2, click browse local files and paste the path of the game inside the quotes.

**SteamGameserverApiCode**\
Open this link: https://steamcommunity.com/dev/managegameservers \
Log in. At the bottom of the page, enter code 730 for CS2 at "App ID of the base game"
and press Create.\
YOU NEED TO HAVE A LINKED PHONE NUMBER TO YOUR STEAM ACCOUNT

**Port**\
Make sure you port forward for the port you have selected and also add it to your firewall.
If you don't know how, use ChatGPT and ask it how.\
I ALSO MADE A GUIDE IN CASE YOU DID ALL THIS AND YOU GET THE ERROR "Unable To Establish a Connection With the Gameserver" IN THE OTHER "How to play with friends" .md FILE!\
ITS THE ONLY SOLUTION I FOUND SO FAR.\
IF YOU CAN'T MANAGE TO PORT FORWARD, YOU CAN ALSO CHECK OUT THE GUIDE ABOVE.

**VacEnabled**\
If you want VAC to be enables (true / false)

**UseWorkshopMap**\
If you want to use one of the instances you created in **instances.json** (true / false)\

=-=-=-=-=-=-=-=-=-=-=-=-=-=\
How to configure **instances.json**:

**Name**\
Give your workshop map instance whatever name you want. Make it suggestive so you remember what map it is.

**MapID**\
Go to the workshop map on steam and copy only the last digits of the link\
Example : https://steamcommunity.com/sharedfiles/filedetails/?id=3124567099 \
ONLY COPY 3124567099

**Arguments**\
If you want to start the server with some specific arguments, like this 
"+sv_cheats 1 +sv_autobunnyhopping 1" - this would enable bunnyhopping on the server automatically when it starts.\
IF YOU DONT WANT ANY LEAVE EMPTY LIKE THIS : ""

=-=-=-=-=-=-=-=-=-=-=-=-=-=\
How to configure **arguments.json**:

THIS MIGHT OVERRIDE ANY ARGUMENTS YOU HAVE SET IN YOUR **instances.json** INSTANCES:\
ISSUE EXAMPLES:\
You have these arguments in your instances.json instance : +sv_cheats 1 +sv_autobunnyhopping, 1 and these arguments in
your **arguments.json**: +sv_cheats 0 +mp_roundtime_defuse 60.\
THIS WOULD RESULT IN HAVING sv_cheats = 0 AND NO BUNNYHOPPING, BUT THE ROUND TIME OF YOUR DEFUSE MATCH EQUAL TO 60 minutes.

**Arguments**\
If you want to start the server with some specific arguments, like this
"+sv_cheats 1 +sv_autobunnyhopping 1" - this would enable bunnyhopping on the server automatically when it starts.\
IF YOU DONT WANT ANY LEAVE EMPTY LIKE THIS : ""