# Automatic Font Replacement Program for Planetside 2

A program that allows users to (somewhat) automatically replace their game font for Planetside 2 using Windows' Event Logging for launch detection.

## How use
1. Download program
2. Move to primary game folder (the one with Launchpad.exe and Planetside2_x64.exe)
3. Start at same time as game launcher
4. Configure with desired font (USE .TTF ONLY)
5. Enjoy

## Why?
Messing with fonts is fun.
It is (at least originally, and no recent comments contradict) [dev sanctioned](https://pastebin.com/RBsV9PRK).
Planetside 2's font files are not stored in the .pack2 files typically associated with most game assets.
These font files are not checked by game's anticheat, nor do they set off any post-launch file check.
They are only checked by the game launcher when it starts.
Replacing these files still technically violates the game's file manifest, and as such the launcher "fixes" any changes made.
As such, *not* using a script or other program to make these changes necessitates that the user manually copy and overwrite the desired files on each game launch.

## How work?
Upon first use this program makes its own config file to note down the file paths for the user's desired replacement fonts (iniEdit.ini).
When Planetside 2 starts (after clicking play on the launcher), and because it uses BE, Windows' Event Log logs a service start/install (Event ID 7045) for BEDaisy.
Assuming the PC is not using a very slow, spinning-disk hard drive, there is enough time to catch this event and replace the normal font files before the game actually starts.
After catching said event, this program does this copy/replace operation, then closes itself.

## What files are replaced?
The font files are located in `...\PlanetSide 2\UI\Resource\Fonts`

At least for the English version of the game as of Dec 2024, the replaced files are:

For most of the game: `...\Fonts\Ps2GeoMdRosaVerde.ttf`

For the chatbox: `...\Fonts\ARIALUNI.ttf`

## On Font Selection
Not all fonts work particularly well in Planetside 2, as the game uses Scaleform for its UI with few UI elements being made to support and properly display any font other than what the game was designed for.
Many elements have fixed maximum sizes all text must fit in or else be cut off, and do not reduce font size to compensate.
As such, particularly bold fonts, or fonts with wider spaces between characters, such as monospaced fonts, can lead to text being cut off.
Do experiment with different fonts, there are literally tens of thousands of them.
The font you originally wanted may not end up being your favorite.
