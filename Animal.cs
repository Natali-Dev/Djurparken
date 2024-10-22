namespace Djurparken
{
    public class Animal
    {

        public string NameTag { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public string CountyOfOrigin { get; set; }
        public int RegistrationNumber { get; set; }

        public DateTime LastCheckup { get; set; }
        public DateTime NextCheckup { get; set; }

        public List<Animal> animallist = new();
        private readonly Random random = new();

        public Animal()
        {
            NameTag = "N/A";
            Age = 0000;
            Species = "N/A";
            CountyOfOrigin = "N/A";
            RegistrationNumber = 0000;

        }
        public Animal(string nameTag, int age, string species, string countyOfOrigin, int registrationNumber)

        {
            NameTag = nameTag;
            Age = age;
            Species = species;
            CountyOfOrigin = countyOfOrigin;
            RegistrationNumber = random.Next(1, 101);
        }
        public List<Animal> PrintAnimal(List<Animal> animallist)
        {
            Console.WriteLine("Här är djurlistan: ");
            foreach (Animal a in animallist)
            {
                Console.WriteLine("Registreringsnummer: " + a.RegistrationNumber);
                Console.WriteLine("Namn: " + a.NameTag);
                Console.WriteLine("Ålder: " + a.Age);
                Console.WriteLine("Ras: " + a.Species);
                Console.WriteLine("Land: " + a.CountyOfOrigin);
                Console.WriteLine("_________________________");

            }
            return animallist;
        }

    }

    public static class AnimalHandler
    {
        //4. Metod med både in- och utdata
        // Används när metoden både tar emot indata för att göra en modifiering och sedan returnerar ett värde (t.ex. en uppdaterad lista).
        // med animal HÄR v så kan vi använda den som en frikking instans!!!!
        public static void AddAnimal(Animal animal) //  lägga till nya djur till djurparken och ta bort djur som inte längre finns kvar
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
            Animal newAnimal = new Animal(name, age, race, country, animal.RegistrationNumber);
            animal.animallist.Add(newAnimal);
            Console.WriteLine(name + " är tillagd! Tryck valfri knapp för att fortsätta");
        }

        public static void RemoveAnimal(Animal animal)

        {
            Console.WriteLine("TA BORT DJUR");
            animal.PrintAnimal(animal.animallist);

            Console.Write("Skriv in registreringsnummer på djuret du vill ta bort, Q för tillbaka: ");
            string choice = Console.ReadLine();
            for (int i = 0; i < animal.animallist.Count; i++)
            {
                if (choice == "Q")
                {
                    Console.WriteLine(" Tryck valfri knapp för att fortsätta");
                    break;

                }
                else if (int.TryParse(choice, out int number)) // TODO kan man göra tvärtom? att konvertera int till string istället och då ha en metod i varje metod BackToMenu();
                    if (number == animal.animallist[i].RegistrationNumber)
                    {
                        Console.WriteLine(animal.animallist[i].NameTag + " är borttagen! Tryck valfri knapp för att fortsätta");
                        animal.animallist.RemoveAt(i);
                    }


            }
        }




        public static void CheckHealth(Animal animal) // Hälsokontroller av djur
                                                      // För varje djur ska systemet kunna hålla reda på när djuret senast fick en hälsokontroll, 
                                                      // samt när nästa kontroll är planerad.
                                                      // ett nytt djur får dagens datum för seanste kontroll
        {
            List<string> moodlist = new List<string> { "glad", "ledsen", "trött", "pigg", "sprallig", "busig" };
            Random random = new Random();

            for (int i = 0; i < animal.animallist.Count; i++)
            {
                var randomMood = random.Next(moodlist.Count);
                var currentMood = moodlist[randomMood];
                Console.WriteLine("Idag är " + animal.animallist[i].NameTag + " " + currentMood);
                Console.WriteLine("Senaste hälsokontroll: " + animal.LastCheckup.ToString("yyyy-MM-dd"));
                Console.WriteLine("Nästa planerade hälsokontroll: " + animal.NextCheckup.ToString("yyyy-MM-dd"));
                Console.WriteLine("Registeringsnummer: " + animal.animallist[i].RegistrationNumber);
                Console.WriteLine("______________________________________");

            }
        }
        public static void VisitVeterinary(Animal animal)
        { //TODO nu uppdateraras alla djur till dt idag!?
            CheckHealth(animal);
            Console.Write("Vilket djur ska besöka veterinären? Mata in registreringsnummer: ");
            int choice = int.Parse(Console.ReadLine());
            for (int i = 0; i < animal.animallist.Count; i++)
            {
                if (choice == animal.animallist[i].RegistrationNumber)
                {
                    animal.LastCheckup = DateTime.Today;
                    animal.NextCheckup = DateTime.Today.AddMonths(3);
                }
            }
            Console.WriteLine("Här kommer den uppdaterade listan: ");
            CheckHealth(animal);
            Console.WriteLine(" Tryck valfri knapp för att fortsätta");
            Console.ReadKey();
        }

        public static void AnimalcareHistory() { } //TODO fixa denna metod

    }
}

/*
// 1. Skapa en personlig relation till varje djur
// Låt användaren ha en "profil" för varje djur, där de inte bara ser när senaste och nästa hälsokontroll är, 
utan även lite extra information som djurets humör, hälsostatus, och till och med ett litet dagboksanteckningssystem. 
Exempelvis kan systemet säga:

//     "Esko, din hund, är glad idag och mår prima! Nästa hälsokontroll är om 5 dagar."
//     "Tingeling, din häst, verkar lite trött och är redo för sin hälsokontroll imorgon."


// 3. Gamification-element

// Introducera små belöningar när användaren tar bra hand om djuren. Till exempel, om de håller koll på kontrollerna regelbundet, 
kan de få "veterinärpoäng" som kan användas för att "uppgradera" eller ge djuren extra omsorg, 
som att köpa virtuella leksaker eller förmåner till dem. Kanske kan djuren få extra stjärnor eller märken när de har fått 
många lyckade kontroller utan att missa något.
// 4. Interaktiva påminnelser och planering

// Gör hälsokontrollerna som en del av en djurskötarkalender där användaren själv kan schemalägga kontrollerna, 
och systemet skickar små notiser eller meddelanden som påminnelser. 
Kanske kan användaren "checka in" djuren när de tar sin hälsokontroll, och djuren ger en rolig 
respons som "Tack för omsorgen!" eller "Nu känner jag mig frisk som en nötkärna!".



*/