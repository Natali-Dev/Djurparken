

namespace Djurparken
{
    public class Staff
    {
        public enum Jobs
        {
            sällskap = 1,
            matning = 2,
            rengöring = 3,
            promenad = 4,
            skottar = 5,
            kontorsarbete = 6,
            vilar_med_fötterna_på_skrivbordet = 7,
            ledig = 8

        }
        public string Name { get; set; }
        public int IDNumber { get; set; }
        public string Title { get; set; }
        public Jobs CurrentJob { get; set; }
        public string Job { get; set; }
        public List<Staff> stafflist = new();

        public Staff()
        {
            Name = "N/A";
            IDNumber = 0000;
            Title = "N/A";
            CurrentJob = Jobs.ledig;

        }
        public Staff(string name, int idNumber, string title, Jobs currentJob) //string job
        {
            Name = name;
            IDNumber = idNumber;
            Title = title;
            CurrentJob = currentJob;

        }
        public List<Staff> PrintStaff(List<Staff> stafflist)
        {
            Console.WriteLine("Här har vi personallistan:");
            foreach (Staff s in stafflist)
            {
                Console.WriteLine("ID-Nummer: " + s.IDNumber);
                Console.WriteLine(s.Name);
                Console.WriteLine("Titel: " + s.Title);
                Console.WriteLine("Nuvarande arbetssyssla: " + s.CurrentJob); //s.Job
                Console.WriteLine("______________________________");
                Console.WriteLine(" Tryck valfri knapp för att fortsätta");
            }
            return stafflist;
        }
    }

    public static class StaffHandler
    {
        public static void PrintJoblist()
        {
            foreach (Staff.Jobs job in Enum.GetValues(typeof(Staff.Jobs)))
            {
                Console.WriteLine((int)job + " " + job); // int skriver ut indexet
            }
        }

        public static void AddWork(Staff staff) 
        {

            staff.PrintStaff(staff.stafflist);

            Console.Write("Välj personal att schemalägga utifrån ID-nummer: ");
            int choice1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < staff.stafflist.Count; i++)
            { // Sök efter match i stafflist
                if (choice1 == staff.stafflist[i].IDNumber)
                { // Om en match är hittad

                    PrintJoblist();
                    Console.Write("Välj arbetssyssla utifrån siffor: ");
                    var jobArray = Enum.GetValues(typeof(Staff.Jobs)); // konvertera enum till en array
                    int choice2 = int.Parse(Console.ReadLine());// sök efter match i enum-lista (heter det ens så?)
                    for (int j = 0; j < jobArray.Length; j++)
                    {

                        if (choice2 == j + 1)  // om match är hittad
                        {
                            staff.stafflist[i].CurrentJob = (Staff.Jobs)jobArray.GetValue(j);
                            // staff.stafflist[i].Job = staff.worklist[j];
                            Console.WriteLine(staff.stafflist[i].Name + " har just nu arbetsuppgiften " + staff.stafflist[i].CurrentJob);// skriv ut
                            staff.PrintStaff(staff.stafflist);
                            break;
                        }

                    }

                }

            }

        }
        public static void SearchJobs() { }

        public static void AddStaff(Staff staff)
        {
            Console.Write("Skriv in personalens namn: ");
            string name = Console.ReadLine();
            Console.Write("ID-nummer: ");
            int idNumber = int.Parse(Console.ReadLine());
            Console.Write("Titel: ");
            string title = Console.ReadLine();

            Staff staff01 = new Staff(name, idNumber, title, staff.CurrentJob); //, staff.Job
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