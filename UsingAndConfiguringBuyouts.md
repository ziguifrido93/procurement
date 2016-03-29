

# Introduction #

This page will cover how to use and configure the buyout system introduced in Procurement 1.1.0

# Setting Buyouts #

To set a buyout on an item, simply right click the item, you will be presented with a context menu:

![http://i.imgur.com/Ds7eKVe.png](http://i.imgur.com/Ds7eKVe.png)

Simply enter in the amount, or use the +/- buttons to increase or decrease the amount, and select the orb type, by default chaos is used.

To save the buyout, simply click "Save Buyout", the buyout will be saved without any need to restart Procurement


# Configuring how buyouts are displayed #

Procurement 1.1.0 has introduced two new settings:

```
    <Setting name="EmbedBuyouts" value="True" />
    <Setting name="BuyoutItemsOnlyVisibleInBuyoutsTag" value="False" />
```

The EmbedBuyouts setting will add the buyout for an item inside existing tags/categorys. For example, if you have a great tri res rare chest piece, and you set a 1ex buyout, the buyout will display inside your {TriRes} section as well as {RareChest}. You will no longer need to use the {Buyout} tag (but you still can if you want to!) By default, this setting is enabled.

The long named BuyoutItemsOnlyVisibleInBuyoutsTag setting will make buyouts only display in the {Buyouts} section, and not in the rest of your tags/sections. By default, this setting is disabled.

# Tab wide Buyouts #

Procurement 1.3.0 has added the ability to set a buyout for all items in a tab, this is done via the buyouts.xml (previously settings file) file. For example, you have a tab named "Gear" and you want all items in this tab to be automatically priced for 1 chaos. Open the Buyouts.xml file and update the TabBuyouts section as follows:

```
  <TabBuyouts>
      <Item id="TabNameHere" value="1 chaos" />
  </TabBuyouts>
```

Save the settings file, close and start Procurement. When you generate your forum code, Procurement will now automatically price all those items for 1 chaos, and still maintain your existing categories and spoilers.

Things to keep in mind:

  * Once you have set the buyout, when you update again and new gear is in that tab, it will automatically be priced as per your tab buyout.

  * If you set a buyout on an individual item that is in a tab that has a buyout, the item buyout will take presidence over the tab buyout


  * If you have multiple tabs with the same name, and set a buyout for that tab, it will set the buyout for all tabs with the same name. This includes cross league tabs.