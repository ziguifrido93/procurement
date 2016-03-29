# Introduction #

Procurement 1.1.0 has added the ability to only download/update specific tabs on login.

# Details #

To enable this functionality, simple edit settings.xml and add the tabs you want updated on login :


```
    <List name="MyTabs">
        <Item value="Shop" />
    </List>
```

By default, the list is empty so Procurement will download all tabs. Note that this list is for all leagues.