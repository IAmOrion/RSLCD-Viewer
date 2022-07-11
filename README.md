# RSLCD Viewer
A program I wrote for easily viewing AIDA64 RemoteSensor Panels independently from a web browser.
In theory, his is more streamlined and built for a specific purpose.

# Libraries Used (Install via 'Manage NuGet Packages')
https://github.com/Taiizor/ReaLTaiizor
https://github.com/yhuse/SunnyUI

# NuGet Packages Required
- WebView2
- ReaLTaiizor
- SunnyUI (Installing this automatically installs SunnyUI Common)

![packages_installed](https://user-images.githubusercontent.com/3501380/178166687-ffe69396-9e4f-4329-bf77-c84e9f5596cc.png)

# Requirements
- AIDA64 (Durr!) + RSLCD Enabled (RemoteSensor)
  https://www.aida64.com/downloads

- Microsoft Edge WebView2
  Windows 10 and Windows 11 should already have this I believe.
  https://developer.microsoft.com/en-us/microsoft-edge/webview2/#download-section
  
- .NET Framework 4.8 Runtime
  https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48
  
# Releases
Releases are 'packed' using a program called Engima Virtual Box
https://enigmaprotector.com/en/aboutvb.html
The purpose of this is to simply bundle everything up into one single, portable, exe file.

# Installation
Simply make a new folder in your 'Program File' or 'Program Files (x86)' folder, name it anything you like (I suggest 'RSLCD Viewer')\
Put the .exe file in this folder.  Create a shortcut on desktop if required.
As it's portable, you can run this from any location on your hard drive.
One important thing to bear in mind however is the "Run At Startup" option.  This simply adds (or removes when unselecting) itself to the registry
under ```Computer\HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run```
If you set it to run automatically, and then you move the .exe, you will have to toggle the Run At Startup off, then back on.
I will try and address this in a later update to include checking if the key exists or not etc

# Sonic RSLCD Seen in demo:
Created by AliOXen on AIDA64 Forums
Post: https://forums.aida64.com/topic/667-share-your-sensorpanel/?do=findComment&comment=42988
Download: https://forums.aida64.com/topic/667-share-your-sensorpanel/?do=findComment&comment=42989

# Notes
This is Open Source.  I picked what I thought was the best license, but I'm not good with that stuff so no idea if it's quite right.
Here's the TL:DR of me publishing and sharing my code.
1) You can do anything you want, including commercial applications, but here's the stipulations...
2) You MUST credit me, and link to this GitHub Page
3) You MUST publish your modified / updated source on GitHub and it MUST be Open Source available to the public
4) I've probably not thought of something, so... TBC
