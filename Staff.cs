namespace Djurparken
{
    public class Staff
    {
        public string Name {get; set;}
        public int IDNumber {get; set;}
        public string Job {get; set;}
        Admin admin = new Admin();
        public Staff (string name, int idNumber, string job)
        {
            Name = name; 
            IDNumber = idNumber;
            Job = job;
        }

        public void PrintStaff()
        {
            foreach (Staff s in admin.stafflist)
            {
                Console.WriteLine(s.Name +" - " + s.IDNumber + " Titel: " + Job); 
            }
        }
    }
}