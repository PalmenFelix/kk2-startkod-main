# Del 1

## Fel 1 (Load() och items.txt)
Terminalen klagar på ShoppingList.Load() på line 90, terminalen klagar även på line 2 i program.cs. Varorna skriva i items.txt skrivs inte ut i terminalen heller. Programmet måste även kunna starta även om items.txt inte finns.

Jag lade till en if-sats i foreach loopen så att programmet inte kraschade när det fanns en tom rad. If-satsen kontrollerar då om
en line är tom och om den är det så kör programmet continue; så att den skippar om en rad är tom och programmet inte kraschar.
Jag löste problemet att varorna inte skrivs ut genom att använda metoden Trim(). Trim() metoden tar bort tomrum och whitespace och det är precis det \r räknades som. Löste även så att programmet inte kraschar när items.txt-filen inte finns. Jag gjorde det genom att ändra Load() metoden med att lägga till en if-sats som kollar om det finns en sparad fil med hjälp av File.Exists(path). Och om det då inte fanns någon sparad fil så skrivs ett meddelande ut med Console.WriteLine och man går ur Load() metoden med return;.


## Fel 2 (Total() beräkning)
Andra felet jag hittade var att Total() inte blev korrekt eftersom den första varans pris inte räknades med i Total().

Detta löste jag genom att jag ändrade for-loopen i Total() så att indexräkningen började på 0 istället för 1. Eftersom det första en lista börjar räknas på 0.

## Fel 3 (Prishantering)
Programmet kraschar om man skriver in fel format i priset när en vara ska läggas till.

Jag löste detta fel genom att använda int.TryParse i choice 1 för att kontrollera om priset kan omvandlas till en integer. Om priset inte är giltigt skrivs ett felmeddelande ut och programmet går tillbaka till huvudmenyn. Om priset är giltigt läggs en ny Item in i listan med sitt pris.

## Fel 4 (Borttagning av vara)
Programmet kraschar om man skriver in något som inte är en integer eller ett nummer som inte finns på listan när man väljer choice 2 för att ta bort en vara.

Jag löste detta fel genom att först använda int.TryParse i choice 2 för att kontrollera att det som skrivs in är en integer. Sedan ändrade jag RemoveAt()-metoden i ShoppingList.cs genom att lägga till en kontroll som kollar att numret som skrivs in är 1 eller högre och att det finns med i listan. Så att programmet inte kan försöka ta bort ett nummer som inte finns med i listan.

## Fel 5 (Huvudmeny)
När man ska välja ett alternativ i huvudmenyn så kraschar programmet om man inte skriver en integer. 

Jag löste detta genom att använda en if-sats och int.TryParse i Program.cs. TryParse kontrollerar att det som skrivs in kan omvandlas till en integer. Jag lade också till en kontroll så att choice måste vara mellan 1 och 5. Programmet fortsätter också med loopen som visar huvudmenyn igen och igen tills ett alternativ mellan 1 och 5 väljs.

## Fel 6 (Save())
Detta felet döljer att något gick fel. Det ligger en Console.WriteLine som alltid meddelar att listan blir sparad oavsett om den blir det eller inte, eftersom den ligger utanför try-catch. 

Löste detta felet genom att jag flyttade Console.WriteLine som skrev att listan sparas in i try. Jag lade också till en Console.WriteLine i catch som säger att listan inte sparades och jag använde IOException i catch, som tar hand om fel när programmet läser eller skriver till en fil.

# Del 2

## Item ArgumentOutOfRangeException & ArgumentException
Jag ändrade Item så att den inte kunde skapa ett objekt med ogiltiga värden med hjälp av ArgumentOutOfRangeException och ArgumentException.

Om namnet som skrivs in är tomt så kastas en ArgumentException och om priset är negativt så kastas en ArgumentOutOfRangeException. Sen gjorde jag också try-catch i Program.cs som skriver ut ett felmeddelande om dessa exceptions så att programmet inte kraschar och så att man vet vad som var fel.

## Budgettak & Designval
Jag lade till ett budgettak (BudgetRoof) på 1000 kr i ShoppingList.cs. I Add() använde jag bool för att kontrollera om en vara kan läggas till.

I ShoppingList.cs skapade jag först BudgetRoof, som har värdet 1000. I Add() lade jag till en if-sats som kollar så att budgeten inte överskrids. Om budgeten överskrids returneras false och ett meddelande skrivs ut från Program.cs. Om budgeten inte överskrids läggs varan till och true returneras.

Jag valde att använda bool eftersom jag tyckte det passade bra för ett budgettak. Antingen överskrids inte budgeten och då returneras true vilket betyder att varan läggs till. Eller så överskrids budgeten och då returneras false vilket betyder att varan inte läggs till.
