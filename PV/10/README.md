# Komunikace s databázovým systémem - Připojení, Ukládání a načítání dat, Mapování entit v OOP

## Databáze
- MSSQL, MySQL, OracleSQL, PostgreSQL
- Služba pro ukládání velkého množství dat
- Rychlejší než ukládání do souborů
- SQL (query jazyk pro interakci s databází)
- V kódu po SQL příkazu databáze vrací ResultSet s daty

## CRUD
- Create / Read / Update / Delete
- Operace, které se provádí s databází

## Připojení
- Každá databáze běží na serveru, má svůj port
- Přihlášení username a heslo
- ConnectionString

## Ukládání
- V ORM se prostě vytvoří nový namapovaný objekt entity.
- Na server se pošle insert SQL příkaz, který databáze vypracuje.

## Načítání dat
1. Na server se pošle SELECT
2. Server vrátí ResultSet s daty
3. Kód přečte ResultSet

## design patterns pro Databáze
**DAO / Table-Gateway**
- Data-Access-Object
- Třída s daty obsahuje metody pro získání dat z databáze

**Repository**
- Třída, která pracuje s databází a vrací objekty s daty

**Active Record**
- Samotná entita, ví jak se vytvořit / smazat
- DAO ale přímo v entitě

*DAO je low-level / Repository je jako datová struktura*

## ORM (Object Relational Mapping)
- Framework pro mapování entit z databáze do tříd v kódu
- Jednodužší práce s databází
- Méně SQL
