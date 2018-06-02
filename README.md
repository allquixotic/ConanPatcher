# Conan Exiles Steam Workshop Mod Patcher

This tool is designed to allow *manual* syncing of specific versions of a mod-set to Conan Exiles players. It is designed to be configured by a Dedicated Server host; then, clients (players on the server) can download the .NET client and run it to patch.

## What problem does it solve?

This tool solves the problem of players and the server having different mod versions, which will be incompatible and players get errors joining the server.

If you have players always download the latest version of the mods from Steam Workshop, players may have an inconsistent version because, basically, Steam *absolutely sucks* at mod version management and sometimes is very delayed in getting players an updated version, and occasionally even corrupts the files when patching them! Also, each patch would require a restart of your game server, which bumps everyone offline.

Instead, you can manually control *when* you want to update mods (like, when you see a new feature your players want, or a bug fix that's important to you, in the changelog), rather than allowing mod authors' rapid fire releases to dictate your update schedule.

This only works, however, if you ensure that your players have the **bit-exact** same versions of every mod that your server is running. Steam doesn't allow you to install old versions of mods, so the only way a player can use an older mod is if we install them out of band (i.e., not using Steam).

## How does it work?

1. The person(s) GMing/administering a Dedicated Server with mods will configure the appropriate server software (see "Server Setup" below.)
2. (Optional) For convenience, bundle a file called conanpatcher_config.json along with the client software in a zip file and host it for your users.
3. Your players will download conanpatcher.exe (along with its other dependencies) as per the Releases page on Github or your own custom distribution.
4. Players will launch conanpatcher, point it at the correct config file if it isn't bundled, then click the "Patch!" button. They very rarely will need to modify any of the settings.
5. The patcher will automatically use the `rsync` algorithm to download the player's mod data correctly for Conan. The download comes from *your server*, not Steam, allowing *you* to control exactly when the players will receive a new version of the mods and ensuring that any corrupted files are fixed, while minimizing the amount of data that has to be transferred (good for slow connections).
6. The patcher will also, if a modlist.txt is specified in the json file, overwrite the player's Conan Exiles modlist.txt with the one you supply. This makes it virtually impossible that the player will get this file wrong.

## Switching from Steam Workshop to manual mod version management

Migrating from the old Steam Workshop style mod distribution is easy:

1. At your option, instruct players to unsubscribe from your mods on the Steam workshop using the Steam UI.
2. Have them run conanpatcher and click Patch! No further explanation is needed if you bundle a conanpatcher_config.json with the download.

**Warning:** At present, mods pertaining to other servers will be **deleted** without warning when running this patcher. Make sure your users know this!

## Client Info

- Should be compiled with .NET 4.0 for maximum compatibility with older systems (e.g. Win7)
- A 64-bit operating system is required at this time - not a problem since Conan is 64-bit only
- If you bundle the client with a file called conanpatcher_config.json with the appropriate config, your users won't have to do anything except launch the executable click the Patch! button.

## Server Setup

 - Currently the "server" is a series of scripts based on steamcmd. The scripts are given in the server-tools directory. First follow the setup instructions to get steamcmd on the command line (I'm assuming your server is hosted on Linux): https://developer.valvesoftware.com/wiki/SteamCMD
 - You need to run an rsync server to make this work. It should have all your mod files in a common place labeled "files" by the rsync daemon. rsync should run on Windows, Mac and Linux, but it's really designed to run best on Linux, so you should host your patch files on Linux even if your game server is hosted on Linux (they don't have to be on the same box).
 - If you're hosting this, you need to change the rsync server URI (rsync://something.com:port/path) - mine is only applicable for the server I'm playing on right now.
 - You can keep your server-side mod files up to date using steamcmd and update.sh. You should run update.sh at the same exact instant as you're updating your mods on your Conan game server.
 - conan_steamcmd.txt is the list of commands sent to steamcmd.
  - 440900 is currently? (or permanently I hope) the Conan Exiles steam app ID
  - The other numbers are the Steam workshop IDs of each mod in my particular server. You can get these numbers from the steamapps/workshop/content/440900 folder.
 - conan-rsync.sh is the daemon script. Set this to launch on system startup using your favorite init daemon.
 - Run update.sh whenever a mod updates.
 - These scripts assume steamcmd.sh exists and runs steamcmd in the current working directory and ~/conan is where you have all this stuff.
 - For example client deployment usage see [here](https://smcnam.me/greyfalls-conanpatcher.zip)
 
## License

**Legal Disclaimer:** This tool is in no way affiliated with or endorsed by Valve Corporation, Funcom, Microsoft, or any other corporate entity. This program is free software developed by a private individual citizen of the United States of America. It is intended for, but not exclusively limited to, entertainment purposes for working with the 2018 video game Conan Exiles for the PC platform. This tool does not compete with or in any way interfere with the Conan Exiles product, and only interacts with it in ways that are explicitly supported for hobbyist game "modification" purposes by the developers/publishers of Conan Exiles. 
 
Conan Exiles Steam Workshop Mod Patcher
Copyright (C) 2018 Sean McNamara <smcnam@gmail.com>

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html