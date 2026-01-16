using System;
// This class hold and display person's WesternName and EasternName
public class Person
{
    ///Attributes (Variables)
    public string _givenName = "";
    public string _familyName = "";

    //Behaviors (Methods)
    public Person()
    {
    }
    // a method to display ShowWesternName
    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }

    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName}, {_familyName}");
    }
}

// Call this person class by assigning new variable to the class
Person person1 = new Person();
person1._familyName = "Muhire";
person1._givenName = "Bienvenue";
person1.ShowEasternName();