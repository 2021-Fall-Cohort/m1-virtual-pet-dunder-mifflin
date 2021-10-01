using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class RobotPet : Pet
    {
        public int battery;
        public int maintenance;
        public string model;
        


        public RobotPet(bool robot, string name, string model, int age, string color)
        {
            this.name = name;
            this.robot = robot;
            this.battery = 100;
            this.maintenance = 100;
            this.model = model;
            this.age = age;
            this.color = color;
        }

        public RobotPet()
        {
            this.name = "Default Robot Pet";
            this.battery = 100;
            this.maintenance = 100;
            this.model = null;
            this.robot = true;
            this.age = 0;
            this.color = null;
        }


        //robotic pet charges battery
        public void Charge()
        {
            this.battery = 100;
        }



        //does not get bored

        //robot breaks / maintanance and needs to go to the manufacture / repair shop
        public void Factory()
        {
            this.maintenance = 100;
        }

        //update
        public void Tick()
        {
            // increases hunger
            // decreases health
            // ...
            battery -= 10;
            boredom += 10;
            maintenance -= 10;
        }
       
        //status display
        public void PetStatus()
        {
            Console.WriteLine("Your Pet Status is: Battery Level: " + this.battery + " Maintenance: " + this.maintenance + " Boredom: " + this.boredom);
            Console.WriteLine("Your Pet Attributes are: Name: " + this.name + " Model: " + this.model + " Age: " + this.age + " Color: " + this.color);
            Console.WriteLine(this.name + " is a robotic pet.\n");
        }
       
        



    }
}
