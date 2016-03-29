
# Introduction #

A new feature was introduced with version v1.0.0 of procurement which allows the user to log in without using the traditional email/password combination. When enabled, the user is required to populate an Alias(used for the cache folder) and php session id. To get this, you are required to be logged in to the pathofexile website in your choice of browser.

# Some thoughts on security #

To start, we need to define what the session id is. Then we can get into what can be done with it, how to control it's lifetime, and how it differs logging into procurement using the traditional username/password combination.

For the record, I should mention that I am not a PHP developer by any means. That said however, the concepts at work here are fairly language agnostic.

## Session ID Definition ##

On the POEForums, when you login to the website a session id is created for you. PHP generates a random session id variable and stores it in a cookie, which is by default named PHPSESSID. The server can then track various information about the session without needing username and password to load every subsequent page. In addition, the server will typically also track some state to improve the usability of the website. Last character selected is a good example of this(also the only one I can think of right now!)

## Given a Session ID, what can be done with it ##

As implied above, given this ID, pages from the www.pathofexile.com site can be requested on your behalf. That's it.

This is in fact no different to how procurement works when entering username and password. The only difference in that case is procurement has to authenticate once to create a new session id.

To summarize more visually. The sequence of events goes something like this:

  1. Authenticate using username and password (Username / Password mode starts here)
  1. Get the resulting Session ID. (New SessionID mode starts here)
  1. Download stash, characters images and cache to disk
  1. Return control the the user displaying the stash screen

## Given a Session ID, what can't be done with it ##

Understandably, users may be weary of entering any information that allows procurement to download pages from www.pathofexile.com on their behalf. Thankfully, GGG is a security conscious company, and as such all the "Manage Account" features are gated by a requirement to enter your current password. This information is not available given only a SessionID and as such, operations like changing password or email can't be performed. At worst, a malicious user having a valid SessionID could probably buy you that EK Microtransaction you've always wanted.

## Lifetime of a session ##

Once a session is created, it will persist on the GGG server until it either expires(I haven't seen this happen before), or the user logs out on the website. This is useful, because the validity of the session can be controlled by the user.

For users weary of security, the safest way to use the app would be:
  1. Login to the website, grab the SessionID
  1. Login to procurement
  1. Once procurement has downloaded the information, logout on the website. This process ensures that the information that was given to procurement during login, was only valid for a short period of time.


# How to retrieve the value #

Firstly, open up your browser of choice, make sure you are logged in and the page is open, and then skip to the relevant section below

## Internet Explorer v10 ##

  * Hit F12 - This should open the developer console.
  * In the console window, click the Cache menu and select view cookie information
  * This will open a new page with the cookies listed.
  * Find the item with the name PHPSESSID.
  * Copy the value next to VALUE - this is your session id.

## Internet Explorer v11 ##

  * Start IE11, open pathofexile.com and log in
  * Press F12 to open the Developer Tools
  * Click on the Network button within the Developer Tools
  * Enable capture of network traffic by clicking on the green triangular button in top toolbar
  * Capture some network traffic by interacting with the pathofexile.com page
  * Click on DETAILS (tab at top left), then click on Cookies in the same area
  * Look for SessionID information, right-click COPY
  * Paste copied information into Notepad or other word document software, copy the SessionID code
  * Follow steps in the Procurement wiki for setting up UserSessionID

## Firefox ##
  * Hit the Alt key
  * Select Tools -> Options from the menu
  * Click on the Privacy tab
  * In the history section, there should be a remove individual cookies link. Click this
  * in the Search textbox, type pathofexile.com
  * Locate the item with a cookie name of PHPSESSID and click on it.
  * Copy the value next to Content - this is your session id.

## Chrome ##
  * Hit 12 - This should open the Developer Tools
  * Click the resources item at the top
  * Expand cookies and select the www.pathofexile.com item in the list
  * Find the item in the grid on the right where the name is PHPSESSID
  * Double click on the value, right click copy. Your session id is now in the clipboard.


# How to configure Procurement to use Session ID #

First, update the UseSessionID setting, in settings.xml :

```
<Setting name="UseSessionID" value="True" />
```

Next run Procurement, which will now prompt you for an Alias and SessionID.

![http://i.imgur.com/KeXE3gU.jpg](http://i.imgur.com/KeXE3gU.jpg)

The alias is the name Procurement uses to create a folder, which will store all your character and stash files. You can make the alias whatever you like, but be sure to use the same alias every time for the same account - this will allow offline mode.

Lastly, enter the sessionID that you retrieved from your browser, and click login.

# Procurement Session ID walk-through with Xaelyin #

<a href='http://www.youtube.com/watch?feature=player_embedded&v=o8aHmbvWxAo' target='_blank'><img src='http://img.youtube.com/vi/o8aHmbvWxAo/0.jpg' width='425' height=344 /></a>