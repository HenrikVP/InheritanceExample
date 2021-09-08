using System;

namespace InheritanceExample
{
    public enum AnimalColor { Yellow, BloodBrown, VampireBlack, SnowWhite, FiftyShadesofGary }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CatClass cat = new CatClass();
            cat.AmountOfPettingPerDay = 200;

            DogClass dog = new DogClass();
            dog.Color = AnimalColor.BloodBrown;
            dog.AmountOfPettingPerDay = 2000;
            //Vi kan IKKE oprette en ny instans af en abstrakt klasse!
            //ParentClass parent = new ParentClass();
        }
    }
}
