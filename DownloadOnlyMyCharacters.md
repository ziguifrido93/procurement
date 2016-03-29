# Introduction #

Procurement 1.1.0 has added the ability to set which characters you want to download inventory for (if any). This can be used to greatly improve the update time of Procurement.

# Details #

Settings.xml now contains two new settings :

```
   <Setting name="DownloadOnlyMyCharacters" value="False" />
```

```
    <List name="MyCharacters">
      <!--If you only want Procurement to download specific characters list them here, eg :-->
      <!--<Item value="SomeCharacter" />-->
    </List>
```

To enable this, simply set DownloadOnlyMyCharacters to true, and set the names of which characters you want to be kept up to date:


```
   <Setting name="DownloadOnlyMyCharacters" value="True" />
```

```
    <List name="MyCharacters">
      <Item value="MyMainCharacter" />
    </List>
```

If you don't care about character inventory, and don't want ANY character inventory downloaded, simply leave the list empty:

```
    <List name="MyCharacters">
    </List>
```