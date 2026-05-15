# Dědičnost, method overriding, function overloading

## Dědičnost
- OOP
- Třídá dědí vlastnosti jiné třídy

# modifikace přístupu

**C#**
- public, protected, private viditelnost

**python**
- _ -> protected / private
- __ -> name mangling
    - Zabrání kolizím při dědění

- Child třída musí inicializovat konstruktorem svojí parent třídu
- Umožňuje lepší organizaci kódu

``` C#
public class Animal
{
    public string Name {get; set;}

    public Animal(string name)
    {
        Name = name;
    }

    public virtual string MakeSound()
    {
        return "generic animal sound";
    }
}

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }
    
    public override string MakeSound()
    {
        return "bark";
    }
}
```

## method overriding
- Prepsání zděděné metody
- ToString
- Metoda má jinou funkci v child třídě, než v parent třídě
- Metoda musí být virtuální.
- Java, Python => každá funkce je virtuální
- C# a C++ => metoda musí být nastavena na virtuální
- Virtuální metoda => Třída má VTable s ukazateli na její metody

**abstraktní tříta**
- Třída, která se MUSÍ dědit.
- Nedá se vytvořít její instance
- Obsahuje metody, které musí child třída implementovat

## function overloading
- Přetěžování funkce
- Funkce se stejným jménem má různé vstupní parametry
- Nelze přetěžovat pouze na základě return hodnoty
- Kompilované programovací jazyky implementují přetěžování pomocí name manglingu

``` C#

public static class Math
{
    public int sum(int x, int y)
    {
        return x + y;
    }

    public int sum(int x, int y, int z)
    {
        return x + y + z;
    }
    
    // public float sum(int x, int y, int z)
    // {
    //     return x + y + z;
    // }
    // Tohle nefunguje, protože se nedá přetěžovat pomocí return hodnoty
}

```
