# Testování, Unit testování a dokumentace zdrojového kódu

Kód se testuje, aby jsme našly chyby ještě před spuštění v produkci

## Typy testování
- Unit testy
- Test Case

## Unit Test
- Testuje správnost jedné funkce v izolaci
- Má se testovat nejvíce částí programu (code coverage)

## Test Case
- Soubor instrukcí na používání aplikace + očekávané chování aplikace
- Test Case testují lidé, co nejsou programátoři aplikace
- Test Report => výsledek testu od testera

## Dokumentace
- Inline dokumenace / v jiném souboru
- Dokumentace není potřeba pokud sám kód je jednoduše pochopitelný
- Self documenting code
- Java Docs / tooling pro inline dokumentace

- v C# je inline dokumentace v XML formátu

**C# keywords dokumentace**
- <summary> = krátký popis
- <param name="x"> = popis vstupních hodnot
- <c> = hezký font
- <code> = block s kódem
- <example> = kód s využitím
- <exception cref="Exception"> = které výjimky může metoda vrátit
- <returns> = co metoda vrací
- <see cref="link"> = odkaz
- <seealso cref="link"> = odkaz
