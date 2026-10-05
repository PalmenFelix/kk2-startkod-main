## Fel 1
Terminalen klagar på ShoppingList.Load() på line 90, terminalen klagar även på line 2 i program.cs
Jag lade till en if-sats i foreach loopen så att programmet inte krashade när det fanns en tom rad. If-satsen kontrollerar då om en line är tom och om den är det så kör programmet continue; så att den skippar om en rad är tom och progrmamet inte kraschar.
## Fel 2
Andra felet är att varorna/items som är i items.txt inte skrivs ut i terminalen. Problemet var att \r var ett osynligt tecken som
låg kvar i slutet av varje rad. 

Detta löste jag genin att jag använde mig av metoden Trim(). Trim() metoden tar bort tomrum och whitespace och det är precis det \r räknas som. 