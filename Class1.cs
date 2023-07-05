using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Driver
{
    public string Name { get; set; }
    public string Class { get; set; }
    public List<Auto> Autos { get; set; }

    public Driver(string name, string driverClass)
    {
        Name = name;
        Class = driverClass;
        Autos = new List<Auto>(); //Ефимова Маргарита
    }

    public void AddAuto(Auto auto)
    {
        Autos.Add(auto);
    }

    public void Show()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Class: " + Class);
    }

    public void ShowAll()
    {
        foreach (Auto auto in Autos)
        {
            auto.Show();
        }
    }
}

public class Auto : IComparable<Auto> //Ефимова Маргарита
{
    public string Title { get; set; }
    public string Number { get; set; }

    public Auto(string title, string number)
    {
        Title = title;
        Number = number;
    }

    public void Show()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Number: " + Number);
    }

    public int CompareTo(Auto other)
    {
        return this.Title.CompareTo(other.Title); //Ефимова Маргарита
    }
}
