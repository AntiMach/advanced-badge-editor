# Advanced Badge Editor
This tool gives you more versatility to edit badge data, allowing for the creation of pixel badges, and entire sets.

If you just want badges right away, use [GYTB](https://github.com/MrCheeze/GYTB). Its easier to use, and gets the job done pretty well.

## Features
- Create badges and sets.
- Edit badge and set information (IDs, quantities, names, etc...)
- "Max out" badge quantities with a single button.
- Import images to on to badges and sets.
- "Pixel Badge Import Mode" for pixel art badges.
- Title ID links.
- Change badge data NNID.
- Delete badges, sets or everything.
- Import native badge arcade files (\*.prb and \*.cab)
- Auto assign badge set IDs.
- Create new badge data from 0.

Download is available [here](https://github.com/AntiMach/advanced-badge-editor/releases).

## How to use it
- Open existing data
	- `File > Open Data` 
	- Select folder where BadgeData.dat and BadgeMngFile.dat are saved.
- Create new data
	- `File > New Data`
	- Make sure to set the NNID!
- Save data
	- `File > Save Data`
	- This will overwrite data if it was opened, and will ask a location to save the data if it was created.
- Save data to
	- Same as save data, but always asks for a new location to save the data to.
- Make a badge
	- `Create new badge > Write name and quantity > Import image`
	- Make sure the image is 64x64
- Make a set
	- `Create new set > Import image`
	- If you get an error stating `You don't have enough unique badges for a new set`, then that means the last set only has one badge, and that badge is the last unique badge.
		- To fix this, create a new badge, and then create the new set

If you have any trouble with the app, please tell me what it is, so that I can help you.

If you see any error pop up, **please report it to me through this repository with the text of the error**.


# Simple Badge Injector
This tool allows you to dump and inject badge data from and to your 3ds. It requires a [modded 3ds](https://3ds.hacks.guide/).

## Download and install
- Download the CIA file from [here](https://github.com/TheMachinumps/Simple_badge_injector/releases/latest).
- Install it through FBI.

## Using the app
- Launch **Simple Badge Injector**
- To dump all badge data:
	- `Dump badge data`
	- The data is saved on the SD card at `/3ds/SimpleBadgeInjector/Dumped`
- To inject badge data:
	- Place your badge data inside `/3ds/SimpleBadgeInjector`
	- `Create ExtData archive 0x14D1 > Inject custom badge data`
- To delete badge data:
	- `Delect ExtData archive 0x14D1`

## Hacky homebrew fix
If for any reason you're using the 3dsx version of **Simple Badge Injector**, if at any point it fails to dump or inject badge data, go back to the homebrew launcher through the `Exit app` option, take your SD card out, put it back in, and finally, relaunch the app. This should fix that.


# Miscellaneous Tips
## Restore your official badge data
To restore official badge data, just open Nintendo Badge Arcade and wait until the last moment it fails to load. After that, your data should have been restored. Do this before Nintendo's servers are shut down!

## Get any official badges
[Follow this guide](https://gbatemp.net/threads/get-any-official-badges-without-other-users-data.476300/)


# Acknowledgements
## Deprecated / Not needed anymore
- [Ohana3ds](https://gbatemp.net/threads/wip-ohana3ds-tool.392576/)
- [Png2bclim](https://github.com/kwsch/png2bclim/releases)

## Research
- [BadgeData structure](https://www.3dbrew.org/wiki/Home_Menu#BadgeData.dat)
- [Nintendo Badge Arcade Hacking - Full Documentation and Progress](https://gbatemp.net/threads/nintendo-badge-arcade-hacking-full-documentation-and-progress.403183/)
- [StackOverflow](https://stackoverflow.com/) and [Youtube](https://youtube.com/)

## Tools
- [Visual Studio 2015 Community](https://www.visualstudio.com/vs/community/)

## Credits
- AntiMach
- redunka
