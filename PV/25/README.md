# Zpracování a parsování textových dat, regulární výrazy, kódování a stringy

## Regex
- Speciální jazyk na hledání textových výrazů
- State machine

**Základní příkazy**

- [a-zA-Z] = všechna písmena
- . = všechno
- \d = číslo
- \w = alnum / slovo

**opakování**
- ? = 0 nebo 1
- * = opakovat 0 až do nekonečna
- + = opakovat 1 až do nekonečna
- {číslo} = opakovat daný počet

- regex pro tel. "([+]\\d{3})?([ ]?\\d{3}){3}"

## Proč
- User input se musí vždy kotrolovat, aby nedošlo k chybám jako: 
    - SQL Injection
    - HTML Injection

- Aby se zachovala integrita dat (formát čísla, emalu, jména)
- Viz otázka 9


## Kódováni a stringy

**string**
- struktura, pointer na 1 charakter + počet charakterů (array charakterů)
- nebo pointer na 1 charakter + '\0'

**kódování**
- ascii -> 1 byte
- UTF-8 -> 1 - 4 byte
- UTF-16 -> 2 - 4 byte
- UTF-32 -> 4 byte
- Unicode

