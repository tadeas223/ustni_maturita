# Návrhové vzory - creational design patterns, structural design patterns, behavioral patterns

Návrhové vyzory jsou jako blueprint pro známé problémy v programování

## Creational design patterns
- Používají se pro vytváření nových objektů

- factory method
- abstract factory
- builder + director
- singleton

### factory method
- Změna implementace objektů a jejich jednodužší vytvoření
- Pro objekty, které mají složitou inicializaci

**problém**
- Máme dvě možnosti transportu Loď a Kamion
- Potřebujeme jednoduchý způsob vytváření nových transportů a přidání dalších

``` C#

interface ITransport
{
    public void StartDelivery();
}

class Ship : ITransport
{
    public void StartDelivery()
    {
        Console.WriteLine("Ship");
    }
}

class Truck : ITransport
{
    public void StartDelivery()
    {
        Console.WriteLine("Truck");
    }
}

abstract class Delivery
{
    public abstract ITransport CreateTransport();

    public void Deliver()
    {
        ITransport transport = CreateTransport();

        transport.StartDelivery();
    }
}

class ShipDelivery : Delivery
{
    public ITransport CreateTransport()
    {
        return new Ship();
    }
}

class TruckDelivery : Delivery
{
    public ITransport CreateTransport()
    {
        return new Truck();
    }
}

```

### Abstract factrory
- Využívá se v Dependency Injection
- Objekt nemusí znát jaký objekt vytváří, ani Factry, který používá

### Builder - Deliverer
- Pro inicializaci objektů, které nemají společnou parent třídu

### Singleton
- Pouze jedna globální instance v celém programu

## Structural design patterns
- Zlepšují strukturu kódu pro snadnější orientaci

- Adapter
- Bridge
- Composite
- Decorator
- Facade
- Flyweight
- Proxy

## Behavioral design patterns
- Řešení známých problémů v chování programu

- Chain of Responsibility
- Command
- Iterator
- Mediator
- Memento
- Observer
- State
- Strategy
- Visitor
- Template Method


