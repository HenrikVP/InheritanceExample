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
            

            DogClass dog = new DogClass();
            dog.Color = AnimalColor.BloodBrown;

            ParentClass parent = new ParentClass();
        }
    }
}
