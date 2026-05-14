# Datové typy, Generika, Výčtové datové typy, Struktury, Anotace, Operátory

## Datové typy
- Vše v počítači je číslo
- Aby jsem rozpoznali co to číslo znamená existuí datové typy

**primitivní datové typy**
- Nejmenší jednota dat
- Maximáné word procesoru (32-bit, 64-bit)
- int, char, short, long, void*
- Přimo zabudované do jazyka

**složené datové typy***

- Struktury a Třídy.
- Jeden typ obsahuje více primitivní a složených typů
- Pro slučování podobných hodnot k sobě (Vector2, User)

## Generika
- Datové typy a metody, která funkgují pro více datových typů
- Implementace závisí ja jazyku

- Generické datové struktury
- Snižují délku kódu

**Java**
- Type erasure
- Každý generický typ se změní na ukazatel, compiler poté nutí správné typy
- Pomalé

**C++, Rust**
- Pro každý datový typ, který byl použit v generikách je zkompilován nový kód
- Větší velikost zkompilovaného kódu

``` C++

template <typename T>
class DArray {
    T* data;
    size_t size;
};

```

**C**
- Nemá generika

## Výčtové datové typy
- Enum
- Několik předem definovaných hodnot
- Pouze číslo, ale lépe pochopitelný kód

## Struktury
- Složený datový typ
- Soubor hodnot

## Anotace
- Doprovodná informace k třídě, metodě, parametru
- C# má atributy, což jsou anotace
- Mohou se využívat pro označení metod / tříd napříkad v MVC (v Java Spring @Controller)

**Java**
`@Override, @Deprecated`

``` Java
public @interface Anotace {
    String name() default "Anotace";
}
```

**C#**
`[Required], [StringLength(50)], [Range(-40, 100)]`

``` C#

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class Atribut : Attribute
{

}

```

## Operátory
- Určení matematických / booleanovských operací nad datovými typy
- Přetěžování operátorů, volání definované metody na místo operátoru

