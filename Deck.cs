    using System;
using System.Collections.Generic;


namespace DeckCards
{
    

class Card : IComparable<Card>
{
    public string Suit { get; }
    public string Rank { get; }

    public Card(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }

    // Implement the comparison method based on your desired sorting order
    public int CompareTo(Card other)
    {
        // First, sort by suit (Hearts < Diamonds < Clubs < Spades)
        int suitComparison = String.Compare(Suit, other.Suit, StringComparison.Ordinal);
        if (suitComparison != 0)
            return suitComparison;

        // If suits are the same, sort by rank (2 < 3 < ... < 10 < Jack < Queen < King < Ace)
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        int thisRankIndex = Array.IndexOf(ranks, Rank);
        int otherRankIndex = Array.IndexOf(ranks, other.Rank);

        return thisRankIndex.CompareTo(otherRankIndex);
    }
}

class Program
{
    static void Main()
    {
        List<Card> deck = new List<Card>
        {
            new Card("Hearts", "2"),
            new Card("Spades", "Ace"),
            new Card("Clubs", "7"),
            new Card("Diamonds", "King"),
            new Card("Hearts", "10"),
            new Card("Spades", "3"),
            new Card("Clubs", "Jack"),
            new Card("Diamonds", "Queen")
            // Add more cards as needed
        };

        // Print the deck
        foreach (var card in deck)
        {
            Console.WriteLine($"{card.Rank} of {card.Suit}");
        }

        // Shuffle the deck (optional)
        deck.Sort();
        

        // Print the sorted deck
        foreach (var card in deck)
        {
            Console.WriteLine($"{card.Rank} of {card.Suit}");
        }
    }
}
}