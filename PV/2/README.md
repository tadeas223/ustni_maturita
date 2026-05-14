# Algoritmizace - Grafy, Prohlédávání stavového prostoru, Řazení

## Grafy

- datová struktura
- G(V, E) -> vrcholy a hrany
- každý vrchol může odkazovat na jiné

- orientovaný / neorientovaný
- ohodnocený / neohodnocený

### reprezentace grafu v kódu

**Matice sousednosti**
- Každý bod určuje hranu mezi dvěma vrocholy

**Matice incidence**
- řádky = hrany
- sloupce = body
- Matice ukazuje který vrchol je spojen s jakou hranou

### prohledávání grafu
- DFS
    - Depth First Search
    - prohledává do hloubky
    - Najde vždy to nejlepší řešení
- BFS
    - Breadth First Search
    - Prohledává do šířky
    - Najde vždy to nejlepší řešení

- Dijkstra
    - Pouze pro kladně ohodnocené grafy

- A star
    - Hledá podle heuristické funkce
    - Ne vždy najde nejlepší cestu
    - Je rychlý, protože projde méně vrcholů

## Stavový prostor

- Orientovaný graf všech možných stavů.
- Semafor

### prohledávání stavového prostoru

**Slepé**
- Prochází celý prostor dokud nenajde správný stav

**Heuristické**
- Prochází celý prostor pomocí známých informací

**Náhodné**


## Řazení

- Bubble sort
- Selection sort
- Insertion sort

- Quick sort
- Merge sort
- Heap sort
