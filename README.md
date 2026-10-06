## Fel 1
Terminalen klagar på ShoppingList.Load() på line 90, terminalen klagar även på line 2 i program.cs

Jag lade till en if-sats i foreach loopen så att programmet inte krashade när det fanns en tom rad. If-satsen kontrollerar då om 
en line är tom och om den är det så kör programmet continue; så att den skippar om en rad är tom och progrmamet inte kraschar.

## Fel 2
Andra felet är att varorna/items som är i items.txt inte skrivs ut i terminalen. Problemet var att \r var ett osynligt tecken som
låg kvar i slutet av varje rad. 

Detta löste jag genin att jag använde mig av metoden Trim(). Trim() metoden tar bort tomrum och whitespace och det är precis det \r räknas som. 

## Fel 3
Tredje felet jag hittade var att Total() inte blev korrekt eftersom den första varans pris inte räknades med i Total().

Detta löste jag genom att jag ändrade for-loopen i Total() så att indexräkningen började på 0 istället för 1. Eftersom det första en lista börjar räknas på 0.

## Fel 4
Programmet kraschar om man skriver in fel format i priset när en vara ska läggas till. 

Löste detta felet genom att lägga till en while-loop i choice 1. I while loppen bestämde jag att så länge priset som skriv in inte är en integer, så frågas priset om igen och igen tills ett giltligt heltal skrivs in. Då läggs en ny item in i listan med sitt pris.

## Fel 5
Programmet kraschar om man skriver in något som inte är en integer eller ett nummer som inte finns på listan när man väljer choice 2 för att ta bort en vara.

Löste detta felet genom att jag först lade till en while-loop i choice 2 med en int.TryParse som kollar så att det är en integer. Sen i ShoppingList.cs ändrade jag RemoveAt() metoden genom att lägga till en kontroll som kollar att numret som skrivs in är 1 eller högre och att det finns med i listan. Så att programmet inte kan försöka ta bort ett nummer som inte finns i listan.