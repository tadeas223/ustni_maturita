# Typy datových struktur - Pole, Spojový seznam, Strom, Fronta, Zásobník, Halda 

Datové struktury jsou způsob jak ukládat data v PC.

## Pole
- Konstantní velikost
- Velmi rychlý přístup

**časová složitost**
- Read - O(1)

## Spojový seznam (Linked-List)
- Části spojené pointry

- Doubly linked list -> node má ukazadel i na předešlý node
    - Dobré pro rychlejší vkládání dat
    - Rychlé vkládání na oba konce

- Špatný pro cache
- Pro získání prvku se musí cestovat po částech

**časová složitost**
- Push / Pop / Peek - O(1)
- Add - O(n)
- Read - O(n)

## Strom
- Má kořen a listy

## fronta (queue)
- fifo
- implementovaná jako dynamické pole a nebo linked list
- data se mohou vkládat pouze na začátek a vybírat z konce

- queue a dequeue operace

## zásobník (stack)
- lifo
- Pole a stack pointer
- implementovaná jako dynamické pole a nebo linked list
- data se mohou vkládat a vybírat pouze z konece

- push a pop operace

## halda (heap)
- Seřazená stromová struktura

**max-heap**
    - kořen má největší hodnotu

**min-heap**
    - kořen má nejmenší hodnotu

**časová složitost**
- Delete - O(log n)
- Add - O(log n)
- Read Min | Max - O(1)

