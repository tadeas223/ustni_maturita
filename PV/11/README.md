# Komunikace v síti - tvorba síťových aplikací, Berkeley socket a jeho rozhraní

## Berkeley Socket
- Abstrakce nad internetovým TCP / UDP spojením
- Input a Output Stream
- API pro posílání zpráv přes síť

- Na linuxu má socket File Descriptor a chová se jako soubor

*Berkeley socket API*
- bind()
- accept()
- open()
- read()
- write()
- close()

*Sockety mohou být i mezi procesy na stejném počítači*

## Protokoly

**TCP**
- Stream
- Spolehlivé připojení
- Pomalé

**UDP**
- Rychlé
- Nespolehlivé, packety moho nepřijít a nebo přijít v jiném pořadí

## Client / Server
Jeden process musí otevřít ServerSocket pro naslouchání.
Druhý se na ServerSocket připojí.

Po připojení se na Serveru vytvoří nový socket, který reprezentuje
spojení dvou procesů.

