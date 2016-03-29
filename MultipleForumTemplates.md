In order to add an additional forum export template, for example for a leveling shop or if you have both a SC and HC shop, all you have to do is the following :

  * Open settings.xml in the Procurement folder
  * Edit the following line:
```
        <List name="AdditionalTemplates">
            <!--Add yours own templates here. Eg-->
            <!--<Item value="LvlingShop.txt"/>-->
        </List>
```
  * And add a line for each of the templates you require:
```
        <List name="AdditionalTemplates">
            <Item value="HardcoreShop.txt"/>
            <Item value="SoftcoreShop.txt"/>
        </List>
```

  * Save and close the settings file
  * Run Procurement, in the Trading screen the templates you added will now be in the dropdown
  * Note that when you first add a template, it will use the default layout, you can then edit the template and save it