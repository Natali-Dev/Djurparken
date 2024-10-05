namespace Djurparken
{
    class Animal
    {
        
        public string NameTag {get; set;}
        public int Age {get; set;}
        public string Species {get; set;}
        public string CountyOfOrigin {get; set;}

        public Animal (string nameTag, int age, string species, string countyOfOrigin)
        {
            NameTag = nameTag;
            Age = age;
            Species = species; 
            CountyOfOrigin = countyOfOrigin;

        }
        public void PrintStaff()
        {
            
        }

    }
}