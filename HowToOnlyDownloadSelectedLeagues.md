# Introduction #

Procurement v0.0.8 has introduced the ability to set which leagues to update when logging in, for situations where you have a high number of stash tabs, and do not want to update them for every league, every time you login.

# Details #

  * Open settings.xml in the Procurement folder
  * Edit the following line(Note if you're using an old setting file, you can add this manually under the UserSettings section):

```
        <Setting name="DownloadOnlyMyLeagues" value="false" />
```

  * And set DownloadOnlyMyLeagues to true:

```
        <Setting name="DownloadOnlyMyLeagues" value="true" />
```

  * Next, remove leagues you **do not** want to update on login from the MyLeagues section, leaving **only** the leagues you do want updated. For example, if you only want to update Anarchy and Onslaught, MyLeagues should look like this:

```
        <List name="MyLeagues">
            <Item value="Onslaught"/>
            <Item value="Anarchy"/>
        </List>
```

  * Finally save the settings file and run Procurement, it will now only update the leagues you have selected



<a href='http://www.youtube.com/watch?feature=player_embedded&v=FhVMpgLE5sg' target='_blank'><img src='http://img.youtube.com/vi/FhVMpgLE5sg/0.jpg' width='425' height=344 /></a>