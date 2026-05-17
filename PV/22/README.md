# Vlákna, Paralelní programování, Asynchronní metody, Concurrent design patterns

## Vlákna
- Process, který sdílí virtuální paměť s parrent procesem
- Každé vlákno má vlastní stack
- Dovoluje, aby mohl program dělat více věcí najednou
- Virtuální vlákno, rychĺé střídání dvou procesů na stejném vláknu
- Race condition => dvě vlána přepisují stejnou hodnotu
- Atomické operace => pouze jedna CPU instrukce = zabrání race conditions

## Asynchroní metody
- Asynchroní (Corroutine) běží na jednou vlákně, ale dělá více věcí
- Reálně je to ale pool vláken (C#)

## Concurrent design patterns
- Rozdělení náročného problému na problémy, které mohou běžet souběžně
- Pokud vlákna přistupují na stejná data musí použít Mutex

## Mutex
- Zámek
- Do zamčeného kódu může přistoupit pouze jedno vlákno
- Ostatní vlákna jsou uspána operačním systémem, dokud se zdroj neuvolní
- Řeší race condition
- Deadlock => vlákno zamkne kód a nikdy ho neuvolní, ostatní vlákna navždy čekají

## Concurrent design patterns
- Thread Pool
- Lock
- Monitor
- Read-Write Lock
