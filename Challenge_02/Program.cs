using System;

class Program
{
    static void Main(string[] args)
    {
        string Name, myClass, Race, Stamina, Intellect, Strength, Health, Mana, Dexterity, Armour;

       //Ввод значений переменных - Read DATA CARACTER
        
        Console.WriteLine("Hello and welcome to character creator");

        Console.WriteLine("Please enter your name");
        Name = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Please enter your class");
        myClass = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Please enter your race");
        Race = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Please enter your stamina");
        Stamina = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Please enter your intellect");
        Intellect = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Please enter your strength");
        Strength = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Please enter your health");
        Health = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Please enter your mana");
        Mana = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Please enter your dexterity");
        Dexterity = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Please enter your armour");
        Armour = Console.ReadLine();
        Console.Clear();


        //Print DATA CARACTER

        Console.WriteLine("** CHARACTER  SHEET **");

        Console.WriteLine("Name: {0}",Name);
        Console.WriteLine("Class: {0}", myClass);
        Console.WriteLine("Race: {0}", Race);
        Console.WriteLine("Stamina: {0}",Stamina);
        Console.WriteLine("Intellect: {0}", Intellect);
        Console.WriteLine("Strength: {0}", Strength);
        Console.WriteLine("Health: {0}", Health);
        Console.WriteLine("Mana: {0}", Mana);
        Console.WriteLine("Dexterity: {0}", Dexterity);
        Console.WriteLine("Armour: {0}", Armour);
        Console.ReadLine();


    }
}