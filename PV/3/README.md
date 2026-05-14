# Algoritmizace - Rekurze, Brute Force, Heuristiky, Nedeterministické algoritmy

## Rekurze

- Funkce, která volá sama sebe
- Každé rekurzivní volání se ukládá do zásobníku
- Každá rekurze lze převést do cyklu
- Pokud je rekurze moc hluboko pak může nastat stack overflow [1](../1/1.md#struktura-paměti-programu)
- např. fibonacci

## Brute Force

- Deterministický algoritmus
- Prohledá všechny stavy
- Je pomalý O(n!)
- Velmi rychle roste složitost
- Vždy najde všechna řešení

## Heuristiky

- Algoritmy, které prohledávají stavový prostor podle známých pravidel
- Nemusí vždy najít nejlepší řešení
- Rychlejší než brute force
- A star

## Nedeterministické algoritmy

- Algoritmus, který pro stejné vstupy může vrátit různé výstupy
- Může pro stejný vstup vybrat jiný postup řešení
- Monte-Carlo algoritmus
- Nemusí najít optimální a nebo vůbec žádné řešení

