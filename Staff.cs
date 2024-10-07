namespace Djurparken
{
    public class Staff
    {
        public string Name {get; set;}
        public int IDNumber {get; set;}
        public string Title {get; set;}
        public string Job {get; set;}
        public int JobNumber {get; set;}
        public List <Staff> stafflist = new();
        public List<string> worklist = new();
            
        public Staff (string name, int idNumber, string title, string Job) 
        {
            Name = name; 
            IDNumber = idNumber;
            Title = title;
            this.Job = "Ingenting";

        }

        public void PrintStaff()
        {   
            Console.WriteLine("Här har vi personallistan:");
            foreach (Staff s in stafflist)
            {
                
                Console.WriteLine(s.Name +" - ID-Number: " + s.IDNumber + ". Job: " + s.Title); 
                
            }
        }
            public void AddWorker() // personalens arbetsscheman. 
            //Det ska finnas möjlighet att lägga till nya personalmedlemmar
    {
        Console.Write("Skriv in personalens namn: ");
        string name = Console.ReadLine();
        Console.Write("ID-nummer: ");
        int idNumber =int.Parse(Console.ReadLine());
        Console.Write("Titel: ");
        string title = Console.ReadLine();

        Staff staff = new Staff(name,idNumber, title, Job); 
        stafflist.Add(staff); 

        PrintStaff();
    } 
    public void PrintWorklist()
    {
        // worklist.Add("sällskap"); 
        // worklist.Add("matning");    
        // worklist.Add("rengöring");  
        // worklist.Add("promenad");   

        // int counter = 1;
        // foreach (var work in worklist)
        // {   
            
        //     Console.WriteLine(counter + ". "+ work);
        //     counter++;
        // }
        string [,] worklist = {{"1","2","3","4"},{"sällskap", "promenad","matning",""}};
    }

    public void AddWork() // och schemalägga dem för olika arbetsuppgifter, exempelvis djurvård, matning, och rengöring.
    {

        PrintStaff();
        Console.WriteLine("____________________");

        Console.Write("Välj personal att schemalägga utifrån ID-nummer: ");
        int choice1 = int.Parse(Console.ReadLine());
        PrintWorklist();
        Console.Write("Välj arbetssyssla utifrån siffor: ");
        int choice2 = int.Parse(Console.ReadLine());
        for (int i = 0; i < stafflist.Count; i++)
        { // Sök efter match i stafflist
            if (choice1 == stafflist[i].IDNumber)
            { // Om en match är hittad
                
                for (int j = 0; j < worklist.Count; j++) // sök efter match i worklist
                    { 

                        if (choice2 == int.Parse(worklist[j]))  // om match är hittad
                        {
                            
                            Console.WriteLine(stafflist[i].Name +" har sysslan "+ worklist[choice2]);// skriv ut
                            break;
                        }
                    }
                    
            }
            
        }


    }
    
    public void AddStaff()
    {

    }
    public void RemoveStaff(){

    }

    }
}