namespace Djurparken
{
    public static class Admin
    {

        public static void UpdateObject(Staff staff, Animal animal)
        {
            Console.Write("Välj (d)jur eller (p)ersonal: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "d":
                    animal.PrintAnimal(animal.animallist);
                    Console.Write("\nVälj djur att ändra utifrån registreringsnummer: ");
                    int staffchoice = int.Parse(Console.ReadLine());
                    foreach (Animal a in animal.animallist)
                    { //TODO om den hittar en match, ge menyval att ändra? 
                        if (staffchoice == a.RegistrationNumber)
                        {
                            Console.WriteLine("");
                        }

                    }
                    Console.ReadKey();
                    break;
            }
            Console.WriteLine("Tryck valfri knapp för att fortsätta");
            Console.ReadKey();
        }
        public static void SearchForObject(Staff staff, Animal animal)
        {
            Console.WriteLine("DJUR- & PERSONALSÖKNING");
            Console.Write("Sök på vad som helst: ");
            string search = Console.ReadLine(); // tar emot en string
            foreach (Staff s in staff.stafflist)
            {
                if (search == s.Name || search == s.Title || search == s.Job)    //Sök efter lämplig string i stafflist
                {                                                                  // Om strängen är en stäng, skriv ut
                    Console.WriteLine("Sökningen gav resultatet: ");
                    Console.WriteLine("ID-Nummer: " + s.IDNumber);
                    Console.WriteLine(s.Name);
                    Console.WriteLine("Titel: " + s.Title);
                    Console.WriteLine("Nuvarande arbetssyssla: " + s.Job);
                    Console.WriteLine("______________________________");
                    break;
                }

                else if (int.TryParse(search, out int number))// Om strängen är en int, konvertera och skriv ut

                {
                    if (number == s.IDNumber)
                        Console.WriteLine("Sökningen gav resultatet: ");
                    Console.WriteLine("ID-Nummer: " + s.IDNumber);
                    Console.WriteLine(s.Name);
                    Console.WriteLine("Titel: " + s.Title);
                    Console.WriteLine("Nuvarande arbetssyssla: " + s.Job);
                    Console.WriteLine("______________________________");
                    break;

                }



                foreach (Animal a in animal.animallist)
                {
                    if (search == a.NameTag || search == a.Species || search == a.CountyOfOrigin)
                    {
                        Console.WriteLine("Sökningen gav resultatet: ");
                        Console.WriteLine("Registreringsnummer: " + a.RegistrationNumber);
                        Console.WriteLine("Namn: " + a.NameTag);
                        Console.WriteLine("Ålder: " + a.Age);
                        Console.WriteLine("Ras: " + a.Species);
                        Console.WriteLine("Land: " + a.CountyOfOrigin);
                        Console.WriteLine("Tryck valfri knapp för att fortsätta");
                        Console.ReadKey();
                        return;

                    }
                    else if (int.TryParse(search, out int Anumber))
                    {
                        if (Anumber == a.RegistrationNumber || Anumber == a.Age)
                        {
                            Console.WriteLine("Sökningen gav resultatet: ");
                            Console.WriteLine("Registreringsnummer: " + a.RegistrationNumber);
                            Console.WriteLine("Namn: " + a.NameTag);
                            Console.WriteLine("Ålder: " + a.Age);
                            Console.WriteLine("Ras: " + a.Species);
                            Console.WriteLine("Land: " + a.CountyOfOrigin);
                            Console.WriteLine("Tryck valfri knapp för att fortsätta");
                            Console.ReadKey();
                            break;
                        }
                    }

                }
                Console.WriteLine("Tryck valfri knapp för att fortsätta");
                Console.ReadKey();
            }
        }

        public static void FeedingSchedule() { }

    }

}