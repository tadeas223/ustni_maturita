# Integrita dat, bezpečnost, logování, kontrola vstupů, zpracování chyb

## Integrita dat
- Zajištění konzistentních a správných dat
- Správné datové typy, kontrola vstupu, CHECK v SQL

## Bezpečnost
- Ochrana dat před neoprávněným přístupem

- Šifrování dat
- Ověření identity
- Zabezpečení proti SQL Injection, XSS scripting, HTML injection atd...

## Logování
- Zaznamenávání stavu programu, výpis varování, chyb a info
- Používá se pro debugging

- Logger -> singleton třída

## Kontrola vstupů
- Pokud se nekontrolují vstupní data od uživatele, uživatel toho může využít
- V C se musí kontrolovat délka vstupních dat, buffer overflow
- SQL Injection, HTML Injection
- Data od uživatele se nesmí napřímo vkládat do jiných dokumentů, příkazů

## Zpracování chyb
- Káždá chyba je třeba logovat a odchytit

**výjimky**
- try / catch / finally

**errors as values**
- Result / Option


