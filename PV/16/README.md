# Soubory a serializace - Ukládání a načítání dat, formáty souborů

## Soubor v OS
- Program nemůže pracovat se soubory napřímo.
- Program pracuje se soubory přes systemcally.
- OS vrátí File Descriptor (ID soubory).
- Po ukončení práce se souborem je třeba ho zavřít.

## Formáty souborů

**Binární**
- Obsahují raw data
- Obrázky, videa, audio

**Textové**
- Obsahují text


V kódu se musí vybrat v jakém módu se soubor otevře.
Textové soubory jsou dekódovány a new line charaktery jsou správné.

