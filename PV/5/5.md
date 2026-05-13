# Architectural design patterns - MVC, Multitier, Monolithic, P2P, Client/Server

Architektonické návrhové vzory zlepšují organizaci kódu pro budoucí rozšíření

## MVC
MVC je dobrý pro izolaci bussiness logiky od grafiky.

Používá se hlavně při vývoji Web API.

- Model
    - Data z databáze
    - Pouze data, žádná logika
- View
    - Vizualizace dat
    - Data co se vrací uživately (Api response / GUI)
- Controller
    - Bussiness logika
    - Controller získá požadavek od uživatele (Api request)
    - Controller zavolá a předá data View

## Multitier

Rozděluje kód na více menších častí

- třeba Threeteir

Rozděluje i hardware (Browser - Backend - Database)

## Monolithic

- Nemá žádné rozdělení
- Špatná organizace
- Větší rychlost
- Jednoduchost


## P2P
- Peer-To-Peer

- Více rovnocenných uzlů
- Není žádný řídicí server

## Client / Server

- Client - Posílá požadavky
- Server - Zpracovává a vrací data

- Server je centrální bod
- HTTP server pro web
