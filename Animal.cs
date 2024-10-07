namespace Djurparken
{
    public class Animal
    {
        
        public string NameTag {get; set;}
        public int Age {get; set;}
        public string Species {get; set;}
        public string CountyOfOrigin {get; set;}
        public List<Animal> animallist = new ();

        public Animal (string nameTag, int age, string species, string countyOfOrigin) // konstruktorn tar emot amdmin-instansen
        {
            NameTag = nameTag;
            Age = age;
            Species = species; 
            CountyOfOrigin = countyOfOrigin;

        }
        public void PrintAnimal()
        { 
            foreach (Animal a in animallist)
            {

            Console.WriteLine($"Name: {a.NameTag}. Age: {a.Age} Species: {a.Species} Country of origin: {a.CountyOfOrigin}");

                            
            }
        }
            public void AddAnimal() //  lägga till nya djur till djurparken och ta bort djur som inte längre finns kvar
    {
        Console.WriteLine("LÄGG TILL DJUR");
        Console.Write("Skriv in djurets namn: ");
        string name = Console.ReadLine();
        Console.Write("Ålder i år: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Ras: ");
        string race = Console.ReadLine();
        Console.Write("Ursprungsland: ");
        string country = Console.ReadLine();
        Animal animal = new Animal(name,age,race,country); 
        animallist.Add(animal); 
    }

    public void RemoveAnimal()

    {   
        Console.WriteLine("TA BORT DJUR");
        Console.WriteLine("Här är hela listan: ");
        PrintAnimal();

        Console.WriteLine("Skriv in namnet på djuret du vill ta bort, q för att avsluta: ");
        string choice = Console.ReadLine();
        for (int i = 0; i < animallist.Count; i++)
        {
            if (choice == "q")
            {
                break; // tas tillbaka till startmeny
            
            } 
            else if (choice == animallist[i].NameTag)
            {
                animallist.RemoveAt(i);
            }
        }

    }
        public void CheckHealth () // Hälsokontroller av djur
// För varje djur ska systemet kunna hålla reda på när djuret senast fick en hälsokontroll, 
// samt när nästa kontroll är planerad.
    {

    }
    public void SearchForAnimal() //Det ska vara möjligt att söka efter djur baserat på art, 
    //namn, eller ursprungsland, samt att söka efter personal baserat på arbetsuppgifter.
    {

    }

    }
}