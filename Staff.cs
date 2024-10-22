namespace Djurparken
{
    public class Staff
    {
        public string Name { get; set; }
        public int IDNumber { get; set; }
        public string Title { get; set; }
        public string Job { get; set; }
        public List<Staff> stafflist = new();
        public List<string> worklist = new();

        public Staff()
        {
            Name = "N/A";
            IDNumber = 0000;
            Title = "N/A";
            Job = "ledig";

        }
        public Staff(string name, int idNumber, string title, string job)
        {
            Name = name;
            IDNumber = idNumber;
            Title = title;
            Job = job;

        }
        public List<Staff> PrintStaff(List<Staff> stafflist)
        {
            Console.WriteLine("Här har vi personallistan:");
            foreach (Staff s in stafflist)
            {
                Console.WriteLine("ID-Nummer: " + s.IDNumber);
                Console.WriteLine(s.Name);
                Console.WriteLine("Titel: " + s.Title);
                Console.WriteLine("Nuvarande arbetssyssla: " + s.Job);
                Console.WriteLine("______________________________");
                Console.WriteLine(" Tryck valfri knapp för att fortsätta");
            }
            return stafflist;
        }
    }

    public static class StaffHandler
    {

        public static void PrintWorklist(Staff staff) //TODO Gör denna till enum 
        {
            staff.worklist.Add("sällskap");
            staff.worklist.Add("matning");
            staff.worklist.Add("rengöring");
            staff.worklist.Add("promenad");
            staff.worklist.Add("skottar");
            staff.worklist.Add("kontorsarbete");
            staff.worklist.Add("vilar med fötterna på skrivbordet");

            int i = 1;
            foreach (var w in staff.worklist)
            {

                Console.WriteLine(i + ". " + w);
                i++;
            }

        }

        public static void AddWork(Staff staff) // TODO denna fungerar inte som den ska, den lägger inte in arbetsuppgiften.
        {

            staff.PrintStaff(staff.stafflist);

            Console.Write("Välj personal att schemalägga utifrån ID-nummer: ");
            int choice1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < staff.stafflist.Count; i++)
            { // Sök efter match i stafflist
                if (choice1 == staff.stafflist[i].IDNumber)
                { // Om en match är hittad
                    PrintWorklist(staff);
                    Console.Write("Välj arbetssyssla utifrån siffor: ");
                    int choice2 = int.Parse(Console.ReadLine());
                    for (int j = 1; j < staff.worklist.Count; j++) // sök efter match i worklist
                    {

                        if (choice2 == j + 1)  // om match är hittad
                        {
                            staff.stafflist[i].Job = staff.worklist[j];
                            Console.WriteLine(staff.stafflist[i].Name + " har just nu arbetsuppgiften " + staff.stafflist[i].Job);// skriv ut
                            staff.PrintStaff(staff.stafflist);
                            break;
                        }

                    }

                }

            }

        }

        public static void AddStaff(Staff staff)
        {
            Console.Write("Skriv in personalens namn: ");
            string name = Console.ReadLine();
            Console.Write("ID-nummer: ");
            int idNumber = int.Parse(Console.ReadLine());
            Console.Write("Titel: ");
            string title = Console.ReadLine();

            Staff staff01 = new Staff(name, idNumber, title, staff.Job);
            staff.stafflist.Add(staff01);

            staff.PrintStaff(staff.stafflist);


        }
        public static void RemoveStaff(Staff staff)
        { 
            staff.PrintStaff(staff.stafflist);
            Console.Write("Välj personal att ta bort utifrån ID-nummer: ");
            int remove = int.Parse(Console.ReadLine());

            for (int i = 0; i < staff.stafflist.Count; i++)
            {
                if (remove == staff.stafflist[i].IDNumber)
                {
                    Console.WriteLine(staff.stafflist[i].Name + " är borttagen! Tryck valfri knapp för att fortsätta");
                    staff.stafflist.RemoveAt(i);
                    break;
                }
                else if (remove != staff.stafflist[i].IDNumber)
                {
                    Console.WriteLine("Det finns ingen personal med det ID-nummret. Försök igen.");
                    break; // tas tillbaka till startmeny
                }
                else if (remove == 0)
                {
                    break; //TODO tas tillbaka till startmeny
                }
            }
        }

    }

}