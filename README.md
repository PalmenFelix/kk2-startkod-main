## Fel 1
Terminalen klagar på ShoppingList.Load() på line 90, terminalen klagar även på line 2 i program.cs
Jag lade till en if-sats i foreach loopen så att programmet inte krashade när det fanns en tom rad. If-satsen kontrollerar då om en line är tom och om den är det så kör programmet continute; så att den skippar om en rad är tom och progrmamet inte kraschar.