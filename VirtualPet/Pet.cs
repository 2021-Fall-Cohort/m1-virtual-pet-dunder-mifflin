using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        string name;
        int hunger;
        int boredom;
        int health;
        public Pet(string name)
        {
            this.name = name;
            this.hunger = 0;
            this.boredom = 0;
            this.health = 100;
        }

        public Pet()
        {
            this.name = "Default Pet";
            this.hunger = 0;
            this.boredom = 0;
            this.health = 100;
        }

        public void Feed()
        {
            // what does feeding do?
        }
        public void Feed(int amt)
        {
            // what does feeding a specific amount of food do?
        }
        public void Doctor()
        {
            // what does doctoring do?
        }
        public void Play()
        {
            // what does playing do?
        }

        public void Update()
        {
            // increases hunger
            // decreases health
            // ...
        }
    }

}

//Create Pet Class (properties and method should go in PET class and not Program
/*Ability for players to see the current status of a pet, such as hunger, boredom, and health
Ability for players to interact with pet, such as feed, play, and take to doctor
As players interact with pet, the pet’s status changes
//constructor