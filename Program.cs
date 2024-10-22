// 1. När man söker på siffror och djur dyker personal[0] upp?!
// 3. lägg till resten av funktionerna
// 4.5 Ha massor med "Ogiltig inmatning" när det blir fel! 
// 5. Gör systemet oförstörbart!
// 6. spelar ingen roll om användarens inmatning är stora eller små bokstäver, blir automatiskt att den första är stor!
//Vi använder StringComparison.OrdinalIgnoreCase för att göra jämförelsen case-insensitive (dvs. inmatningen "fantasy" matchar "Fantasy").
// 7. 
// 8. filsparning via json

        // public void SaveJson(string filePath) // Denna metod tar emot en filväg som parameter, konverterar en lista av OrderItem till en JSON-sträng och skriver den till filen.
        // {
        //     string json = JsonConvert.SerializeObject(list, Formatting.Indented);
        //     File.WriteAllText(filePath, json);
        // }
        // public void LoadJson(string filePath) // Denna metod kontrollerar om filen existerar, läser JSON-strängen från filen, och deserialiserar den till en lista av OrderItem.
        // {
        //     if (File.Exists(filePath))
        //     {
        //         string json = File.ReadAllText(filePath);
        //         list = JsonConvert.DeserializeObject<List<OrderItem>>(json);
        //     }
        // }
namespace Djurparken
{
    class Program
    {

        public static List<Staff> stafflist = new(); //gör den static så behövs ingen objektreferens
        static void Main(string[] args)
        {
            Program program = new();
            Staff staff = new();
            Animal animal = new();

            Staff staff01 = new Staff("Natali Harju", 6, "CEO", Staff.Jobs.kontorsarbete);
            Staff staff02 = new Staff("Matilda Harju", 43, "Head of cleaning poopies", Staff.Jobs.skottar); // staff.Job
            Animal animal01 = new Animal("Esko", 2, "Dog", "Sverige", animal.RegistrationNumber);
            Animal animal02 = new Animal("Tingeling", 23, "Horse", "Sverige", animal.RegistrationNumber);

            animal.animallist.Add(animal01);
            animal.animallist.Add(animal02);
            stafflist.Add(staff01);
            stafflist.Add(staff02);

            animal.LastCheckup = DateTime.Today.AddMonths(-2); // Vi är bara här tillfälligt!
            animal.NextCheckup = DateTime.Today.AddMonths(2); // Vi är bara här tillfälligt!
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            StartMenu(staff, animal);


        }
        public static void StartMenu(Staff staff, Animal animal)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("VÄLKOMMEN TILL DJURPARKEN!");
                Console.WriteLine("\n(D)jur");
                Console.WriteLine("(P)ersonal");
                Console.WriteLine("\n(A)dministratör");
                Console.Write("Gör ett val: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                ConsoleKey key = keyInfo.Key;
                Console.Clear();
                switch (key)
                {
                    case ConsoleKey.D: //DJUR 

                        Console.WriteLine("\n(L)ägg till ett djur");
                        Console.WriteLine("(T)a bort ett djur");
                        Console.WriteLine("(B)esök veterinären med ett djur");
                        Console.WriteLine("(K)olla alla djurs hälsa");
                        Console.WriteLine("(S)e all djurinfo");
                        Console.WriteLine("(Q): Tillbaka");
                        Console.Write("Gör ett val: ");
                        ConsoleKeyInfo innerKeyInfoA = Console.ReadKey(intercept: true);
                        ConsoleKey innerKeyA = innerKeyInfoA.Key;
                        Console.Clear();
                        switch (innerKeyA)
                        {
                            case ConsoleKey.L:
                                AnimalHandler.AddAnimal(animal);
                                break;
                            case ConsoleKey.T:
                                AnimalHandler.RemoveAnimal(animal);
                                break;
                            case ConsoleKey.B:
                                AnimalHandler.VisitVeterinary(animal);
                                break;
                            case ConsoleKey.K:
                                AnimalHandler.CheckHealth(animal);
                                Console.WriteLine(" Tryck valfri knapp för att fortsätta");
                                break;
                            case ConsoleKey.S:
                                animal.PrintAnimal(animal.animallist);
                                Console.WriteLine(" Tryck valfri knapp för att fortsätta");
                                break;
                            case ConsoleKey.Q:
                                Console.WriteLine("Tillbaka, Tryck valfri knapp för att fortsätta");
                                break;
                            default:
                                Console.WriteLine("Fel knapptryckning, försök igen!");
                                break;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.P:// PERSONAL
                        Console.WriteLine("\n(L)ägg till personal");
                        Console.WriteLine("(T)a bort personal");
                        Console.WriteLine("(U)ppdatera arbetsuppgift");
                        Console.WriteLine("(S)e all personalinfo");
                        ConsoleKeyInfo innerKeyInfoS = Console.ReadKey(intercept: true);
                        ConsoleKey innerKeyS = innerKeyInfoS.Key;
                        switch (innerKeyS)
                        {
                            case ConsoleKey.L:
                                StaffHandler.AddStaff(staff);
                                break;
                            case ConsoleKey.T:
                                StaffHandler.RemoveStaff(staff);
                                break;
                            case ConsoleKey.U:
                                StaffHandler.AddWork(staff);
                                break;
                            case ConsoleKey.S:
                                staff.PrintStaff(stafflist);
                                break;
                            case ConsoleKey.Q:
                                Console.WriteLine("Tillbaka, Tryck valfri knapp för att fortsätta");
                                break;
                            default:
                                Console.WriteLine("Fel knapptryckning, försök igen!");
                                break;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case ConsoleKey.A: // ADMIN
                        Console.WriteLine("(S)ök efter ett vad som helst");
                        Console.WriteLine("(U)ppdatera personal eller djur");
                        Console.WriteLine("(M)atningschema");
                        Console.Write("Gör ett val: ");
                        ConsoleKeyInfo innerKeyInfoAd = Console.ReadKey(intercept: true);
                        ConsoleKey innerKeyAd = innerKeyInfoAd.Key;
                        switch (innerKeyAd)
                        {

                            case ConsoleKey.S:
                                Admin.SearchForObject(staff, animal);
                                break;
                            case ConsoleKey.U:
                                Admin.UpdateObject(staff, animal);
                                break;
                            case ConsoleKey.M:
                                break;
                            default:
                                Console.WriteLine("Fel knapptryckning, försök igen!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Fel knapptryckning, försök igen!");
                        break;

                }

            }

        }


    }

}




