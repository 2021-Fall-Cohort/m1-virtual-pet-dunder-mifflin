using System;
using System.Collections.Generic;
using System.Text;


namespace VirtualPet
{
    public class Pet
    { 
        public void SetName(string name) { }
        public void SetSpecies(string species)
    { }
    
        public string name;
        public string species;
        public int age;
        public string color;
        public int hunger;
        public int boredom;
        public int health;
        public bool robot;
        public int battery;
        public int maintenance;
        public string model;
        public Pet(bool robot, string name, string species, int age, string color)
        {
            this.robot = robot;
            this.name = name;
            this.species = species;
            this.age = age;
            this.color = color;
            this.hunger = 0;
            this.boredom = 0;
            this.health = 100;
            this.battery = 100;
            this.maintenance = 100;
        }

        public Pet()
        {
            this.robot = false;
            this.name = "Default Pet";
            this.species = null;
            this.age = 0;
            this.color = null;
            this.hunger = 0;
            this.boredom = 0;
            this.health = 100;
            this.battery = 100;
            this.maintenance = 100;
            this.model = null;
        }

        public void Feed()
        {
            // what does feeding do?
            this.hunger = 0;

        }


        public void Feed(int amt)
        {
            // what does feeding a specific amount of food do?
        }

        public int GetBoredom ()
        { return boredom; }

        public int GetHealth ()
        { return health; }

        public int GetHunger()
        { return hunger; }

        public string GetSpecies()
        { return species; }

        public void Doctor()
        { this.health = 100; }
        public void Play()
        {
            // what does playing do?
            this.boredom = 0;
            this.hunger += 10;
            this.health += 10;
        }
        
       
        public void Tick()
        {
            // increases hunger
            // decreases health
            // ...
            hunger += 10;
            boredom += 10;
            health -= 10;
            battery -= 10;
            boredom += 10;
            maintenance -= 10;

        }

        public void PetStatus()
        {
            if (this.robot == false)
            {
                Console.WriteLine("Your Pet Status is: Hunger: " + this.hunger + " Health: " + this.health + " Boredom: " + this.boredom);
                Console.WriteLine("Your Pet Attributes are: Name: " + this.name + " Species: " + this.species + " Age: " + this.age + " Color: " + this.color);
                Console.WriteLine(this.name + " is an organic pet.\n");
            }

            if (this.robot == true)
            {
                {
                    Console.WriteLine("Your Pet Status is: Battery Level: " + this.battery + " Maintenance: " + this.maintenance + " Boredom: " + this.boredom);
                    Console.WriteLine("Your Pet Attributes are: Name: " + this.name + " Model: " + this.species + " Age: " + this.age + " Color: " + this.color);
                    Console.WriteLine(this.name + " is a robotic pet.\n");
                }
            }
        }
           


    }


    //Create Pet Class (properties and method should go in PET class and not Program
    //*Ability for players to see the current status of a pet, such as hunger, boredom, and health
    //Ability for players to interact with pet, such as feed, play, and take to doctor
    //As players interact with pet, the pet’s status changes
    //constructor
}