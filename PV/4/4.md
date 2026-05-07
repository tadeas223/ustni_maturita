# Anonymní metody (Lambda), speciální (magické) metody, statické metody, ukazatel na metodu (delegát)

## Anonymní metody
- Funkce beze jména
- Ukazatel na funkci
- používají se pro lepší zápis krátkých funkcí a callbacků

``` python
sum = lambda x, y: x + y

print(sum(1, 2))
```

``` C#
delegate int sumDelegate(int x, int y)

public class Program 
{
    public static void Main(string[] args)
    {
        sumDelegate sum = (x, y) => x + y;

        Console.WriteLine(sum(1, 2));
    }
}

```

``` Java
interface SumFunction {
    int run(int x, int y);
}

public class Main {
    public static void main(String[] args) {
        SumFunction sum = (x, y) -> x + y;

        System.out.println(sum.run(1, 2));
    }
}
```

## specialní (magické) metody
- Specifické pro Python
- dunder metody

`__len__, __str__, __repr__ atd...`

Metody, které pomocí syntactic sugar ulehčují různé problémy

```
l = [1, 2, 3]

print(len(l)) # 3 (volá funkci l.__len__())
```

V jiných jazycích magické metody nejsou.

Java a C# je nahrazují pomocí přetěžování metod z třídy Object (ToString, HashCode ...)

## statické metody
V OOP jazycích jsou statické metody ty, které se volají na instanci třídy a ne na instanci objektu.

``` C#

public class Greeter
{
    public static void SayHello()
    {
        Console.WriteLine("hello");
    }
}

public class Program 
{
    public static void Main(string[] args)
    {
        Greeter.SayHello(); // není třeba vyzvářet instanci
    }
}

```

## ukazatel na metodu
- V paměti je to pointer co ukazuje do text sekce ve virtuální paměti
- Text sekce obsahuje kód a všechy funkce a je read only

``` Python

def sum_func(x ,y):
    return x + y

sum = sum_func
print(sum(1, 2))

```

``` C#

delegate int sumDelegate(int x, int y)

public class Program 
{
    public static int sumFunc(int x, int y)
    {
        return x + y;
    }

    public static void Main(string[] args)
    {
        sumDelegate sum = sumFunc;

        Console.WriteLine(sum(1, 2));
    }
}

```
