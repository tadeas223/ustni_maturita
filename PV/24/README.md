# Výjimky a aserce, debugování a zpracování chyb

## Výjimka
- Způsob jak odchytávat chyby v programu
- Kód bez výjimky rychlý
- Vyhození výjimky je pomalé (Stack unwinding)
- Try / Catch / Finally

## Assert
- Zajištění správných hodnot v programu
- Využití v unit testech
- V Release buildu nejsou

## debugování
- Způsob hledání chyb v kódu
- Spouštění kódu řádek po řádku a kontrola jeho stavu
- Externí program

**debugování kompilovaných jazyků**
- Bin soubor neobsahuje source kód a debugger ho nemůže zobrazovat
- Musí se do zkompilovaného kódu vyexportovat debug symboly (gcc --debug)

## Zpracovávání chyb (Error Handling)
- Způsob jak program reaguje na chyby

1. Ignorování chyb
2. Výjimky
    - C#, Python, Java
3. Vracení chybových kódů (Result / Option)
    - Rust, Zig, C
