namespace Djurparken
{
    class Admin
    {
        public List<Animal> animallist = new ();
        public List <Staff> stafflist = new();
    
    public void AddAnimal() //  lägga till nya djur till djurparken och ta bort djur som inte längre finns kvar
    {
        Console.Write("Skriv in djurets namn: ");
        string name = Console.ReadLine();
        Console.Write("Ålder i år: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Ras: ");
        string race = Console.ReadLine();
        Console.Write("Ursprungsland: ");
        string country = Console.ReadLine();
        Animal animal03 = new Animal(name,age,race,country); 
        animallist.Add(animal03); 
    }
    public void RemoveAnimal()
    {

    }
    public void AddWork() // personalens arbetsscheman. 
    //Det ska finnas möjlighet att lägga till nya personalmedlemmar och schemalägga dem för olika arbetsuppgifter, 
    //exempelvis djurvård, matning, och rengöring.
    {

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