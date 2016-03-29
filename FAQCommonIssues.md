

# Introduction #

This wiki page covers frequently asked questions, as well as cover some of the more common issues/errors people receive with Procurement, and how to resolve them.


# FAQ #

### Do I have to enter my username and password? ###

No, when we released Procurement 1.0.0 we added the ability to login using [sessionID](https://code.google.com/p/procurement/wiki/LoginWithSessionID).


### How do I make Procurement only download only my league? ###

Follow the [wiki guide](https://code.google.com/p/procurement/wiki/HowToOnlyDownloadSelectedLeagues) (Includes video)!

### How do I customize the export template? What tags are there? ###

Follow the [forum tempalte](https://code.google.com/p/procurement/wiki/ForumTemplates) wiki guide!

### How do I customize the export template? What tags are there? ###

Follow the [multiple forum templates](https://code.google.com/p/procurement/wiki/MultipleForumTemplates) wiki guide!

### Procurement doesn't fit on my resolution! How do I make it fit? ###

Settings -> Enable Compact Mode -> Restart Procurement.

If you're unable to see the save button, edit settings.xml and set CompactMode to True, save, close settings file and start Procurement.


### I use steam and don't have an email/password, how do I use Procurement ###

Follow the [sessionID](https://code.google.com/p/procurement/wiki/LoginWithSessionID) wiki guide

### A new version of Procurement is out, how do I copy over my buyouts? ###

Open the settings.xml file from the old version, and copy everything in the buyouts section:

```
  <Buyouts>
         ...
  </Buyouts>
```

Then open the new settings file, and replace the existing buyouts tag.


### Why does Procurement download images every time? ###

It doesn't. Images are cached in the Common folder, during login when Procurement displays "Loading image for xyz", it first checks the common folder and loads from disk if it's already there. This should be pretty noticable if you have an SSD.

# Common Issues #

### Unauthorized Access Exception/Error ###

This error will create a debuglog entry starting with:

`System.UnauthorizedAccessException: 'POEApi.Infrastructure.dll'`

This error is because Procurement is trying to load one of its files, and it can't. Either Windows is not allowing it access or the file is missing, in all the cases so far the file it is trying to access is POEApi.Infrastructure.dll.

To resolve this issue:

  * Make 100% sure you have ALL the files from the Procurement zip file extracted.

  * Make sure that you have full admin rights on the folder.

  * Make sure that none of the files are locked by another process (rebooting can solve this)

  * Make sure you do not have Procurement installed to a windows "special folder", test this by running from C:\Procurement or D:\Procurement