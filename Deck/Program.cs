using System;
using System.Collections.Generic;

// This class realizes Deck's ADT 
class Deck<T>
{
    private T[] arr;
    public Deck()
    {
        arr = new T[0];
    }
    //Fill in the start of Deck
    public void LAppend(T val)
    {
        T[] newArray = new T[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
            newArray[i + 1] = arr[i];
        newArray[0] = val;
        arr = newArray;
    }
    //fill in the end of Deck
    public void RAppend(T val)
    {       
        T[] newArray = new T[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
            newArray[i] = arr[i];
        newArray[arr.Length] = val;
        arr = newArray;
    }
    //Delete start of Deck
    public void LDelete()
    {
        if (arr.Length == 0)
        {
            Console.WriteLine("The Deck is empty");
            return;
        }
          
        T[] newArray = new T[arr.Length-1];
        for (int i = 0; i < newArray.Length; i++)
            newArray[i] = arr[i+1];
        arr = newArray;
    }
    //Delete head of Deck
    public void RDelete()
    {
        if (arr.Length == 0)
        {
            Console.WriteLine("The Deck is empty");
            return;
        }
        T[] newArray = new T[arr.Length - 1];
        for (int i = 0; i < newArray.Length; i++)
            newArray[i] = arr[i];
        arr = newArray;
    }
    //Show start of Deck
    public void ShowFirst()
    {
        Console.WriteLine(arr[0] + " The first element of Deck");
    }
    //show end of Deck
    public void ShowLast()
    {
        Console.WriteLine(arr[arr.Length-1] + " The last element of Deck");
    }

}
class Program
{
    static void Main(string[] args)
    {
        Deck<int> arr = new Deck<int>();
        //Filling our Deck
        for (int i = 1; i < 4; i++)
        {
            Console.WriteLine("Add number " + i * 10 + " in the start of Deck");
            arr.LAppend(i * 10);
        }
        //show start
        arr.ShowLast();
        Console.WriteLine("Add number 50 in the end");
        arr.RAppend(100);
        //filing again
        arr.ShowLast();
        for (int i = 4; i < 7; i++)
        {
            Console.WriteLine("Add number " + i * 10 + " in the start of Deck");
            arr.LAppend(i * 10);
        }
        //show start again 
        arr.ShowFirst();
    }
}

