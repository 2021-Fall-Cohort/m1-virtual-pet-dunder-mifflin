using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Shelter
    {
        public List<Pet> ListOfPets = new List<Pet>();


        // name
        // list of pets - name only

        // maximum occupancy

        public Pet SelectPet()
        {
            int index = 1;
            foreach (Pet p in ListOfPets)
            {
                Console.WriteLine(index + ". " + p.name);
                index++;
            }
            int indexSelected = Convert.ToInt32(Console.ReadLine());

            return ListOfPets[indexSelected - 1];
        }

            
        
    }
}
