namespace Djurparken
{
    class Program 
    {
        
        static void Main(string[] args)
        {

            Staff staff01 = new Staff("Natali Harju", 6, "CEO", "Kontor");
            Staff staff02 = new Staff("Matilda Harju", 43, "Head of cleaning poopies", "Skottar");
            Animal animal01 = new Animal("Esko", 2, "Dog", "Sweden");
            Animal animal02 = new Animal("Tingeling", 23, "Horse", "Sweden");

            animal01.animallist.Add(animal01);
            animal01.animallist.Add(animal02);
            staff01.stafflist.Add(staff01);
            staff01.stafflist.Add(staff02);


            // staff02.PrintStaff(); // använd vilket objekt som helst för att skriva ut listan
            // animal01.PrintAnimal();

            staff01.AddWork();
            
        }

    }   

}