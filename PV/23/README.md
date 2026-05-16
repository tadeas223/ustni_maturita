# Vlastnosti datových struktur - Seřazenost a opakování prvků, Indexace, hashování a klíče prvků

Správné vybrání datové struktury je důležité pro rychlost programu

# Statické datové struktury
- Jejich velikost se nedá po vytvoření změnit

**Pole / Array**
- Seznam prvků
- V paměti jsou za sebou
- Indexované

**Tuple**
- Neměnný soubor proměnných
- Prvky jsou ve stejném pořadí jako byly vloženy
- Prvky se nedají přidat / odebrat
- Konstantní velikost
- Využívá indexy


# Dynamické datové struktury

**LinkedList**
- Neseřazený seznam
- Prvky jsou ve stejném pořadí jako byly vloženy
- Může obsahovat duplicitní data
- Využívá indexy

**HashSet**
- Neseřazený seznam
- Prvky nejsou ve stejném pořadí jako byly vloženy
- Nemůže obsahovat duplicitní data
- Využívá Hash pro index
- Ukládaný objekt musí mít HashCode a Equals metody

**Dictionary / HashMap**
- HashSet pro Key Value páry
- Klíč je zahashovaný a spárovaný s hodnotou
- Normálné prvky nejsou ve stejném pořadí ale Python je výjimka
