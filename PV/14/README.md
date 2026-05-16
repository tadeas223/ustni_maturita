# Principy objektového programování, agregace a kompozice objektů

# Hlavní idea OOP
- Objekt je organismus
- Objekt přijímá zprávy a vrací odpovědi
- Objekty mezi sebou komunikují

- Objective-C = model reálného OOP

# OOP v reálu
- Třída = template pro objekt
- Objekt = instance třídy

- Dědičnost = získání vlastností z parent třídy


# Agregace
- V uml je to prázdný kosočtverec
- Jeden objekt pracuje s jiným objektem
- Agregované objekty jsou nezávislé a mají vlastní cyklus života
- Objekt A využívá objekt B

``` C#

public class Card 
{
    public string Name {get; set;}

    public Card(string name) 
    {
        Name = name;
    }
}

public class Deck 
{
    private List<Card> cards = new List<Card>();

    public Deck()
    {
        cards.Add(new Card("1"));
        cards.Add(new Card("2"));
        cards.Add(new Card("3"));
        cards.Add(new Card("4"));
    }

    public Card Deal()
    {
        return cards.RemoveAt(0);
    }
}

public class Hand
{
    private List<Card> cards = new List<Card>();
    
    public void Receive(Card card)
    {
        cards.add(card);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Deck deck = new Deck();
        Hand hand = new Hand();

        Card card = deck.Deal();
        hand.Receive(card);
    }
}

```

Karta může existovat nezávisle na ruce, nebo balíčku.

# Kompozice
- V uml je to plný kosočtverec
- Striktní vztah mezi objekty
- Jeden Objekt je součástí jiné ho objekt a nemůže existovat bez něj
- Když se hlavní objekt smaže, smaže se objekt spojený kompozicí
