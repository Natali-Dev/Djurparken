namespace Djurparken
{
    class Program 
    {
        
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            Staff staff = new Staff("Name", 0, "Title");
            Animal anminal = new Animal("Nametag", 0, "Species", "CountyOfOrigin");
            Staff staff01 = new Staff("Natali Harju", 6, "CEO");
            Staff staff02 = new Staff("Matilda Harju", 7, "Head of cleaning poopies");
            Animal animal01 = new Animal("Esko", 2, "Dog", "Sweden");
            Animal animal02 = new Animal("Tingeling", 23, "Horse", "Sweden");
            admin.animallist.Add(animal01);
            admin.animallist.Add(animal02);
            admin.stafflist.Add(staff01);
            admin.stafflist.Add(staff02);
            Console.WriteLine("Hejsan!");
            staff.PrintStaff();
            //admin.AddAnimal();

        }

        
    }   

}