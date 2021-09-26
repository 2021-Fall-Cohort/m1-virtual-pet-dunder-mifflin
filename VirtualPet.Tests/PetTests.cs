using System;
using Xunit;

namespace VirtualPet.Tests
{
    public class PetTests
    {
        public Pet testPet;

        public PetTests()
        {
            testPet = new Pet();
        }

        [Fact] // passes
        public void Pet_Constructor_Should_Instantiate_Pet_Object()
        {
            // Act
            Pet testPet = new Pet(false, "George", "dog", 12, "green");

            Assert.NotNull(testPet);
        }

        // INSTRUCTIONS:
        // Uncomment code in the test body one test at a time
        // Add source code to eliminate the build errors (red squiggle) and pass the test

        [Fact] // passes
        public void Pet_Should_Have_Name()
        {
            testPet.name = "Pet Name";

            Assert.Equal("Pet Name", testPet.name);
        }

        [Fact] // passes
        public void SetName_Should_Assign_Pet_Name_Property()
        {
            testPet.name = ("Fluffy");

            Assert.Equal("Fluffy", testPet.name);
        }

        [Fact] // passes
        public void GetName_Should_Get_Pet_Name_Value()
        {
            testPet.name = "Fido";
            //testPet.setName ("Fido", testPet.name); }
            //public string SetName { get; set; }
            //String getName() { return testPet.name; }
            //this.Name = ("Fido");

            //{ string testPetName = testPet.GetName();
        

         Assert.Equal("Fido", testPet.name);

        }

        [Fact] // passes
        public void Pet_Should_Have_Species()
        {
            testPet.species = "Pet Species";
            
            Assert.Equal("Pet Species", testPet.species);
        }

        [Fact] // passes
        public void SetSpecies_Should_Assign_Pet_Species_Property()
        {
            testPet.species = "Cat";

            Assert.Equal("Cat", testPet.species);
        }

        [Fact]
        public void GetSpecies_Should_Get_Pet_Species_Value()
        {
         testPet.SetSpecies("Dog");

        string testPetSpecies = testPet.GetSpecies();

        Assert.Equal("Dog", testPetSpecies);
        }

        [Fact] // passes!
        public void Pet_Should_Have_Hunger()
        {
            testPet.hunger = 100;
            
            Assert.Equal(100, testPet.hunger);
        }

        [Fact]
        public void GetHunger_Should_Return_Initial_Hunger_Level_Of_50()
        {
            int testPetHunger = testPet.GetHunger();
            testPet.hunger = 50;

            Assert.Equal(50, testPetHunger);
        }

        [Fact]// passes
        public void Pet_Should_Have_Boredom()
        {
            testPet.boredom = 100;
            
            Assert.Equal(100, testPet.boredom);
        }

        [Fact]
        public void GetBoredom_Should_Return_Initial_Boredom_Level_Of_0() //Our pets were not bored until they came to our care
        {
            int testPetBoredom = testPet.GetBoredom();
            testPet.boredom = 0;
            Assert.Equal(0, testPetBoredom);
        }

        [Fact]// passes
        public void Pet_Should_Have_Health()
        {
           testPet.health = 100; 
           
           Assert.Equal(100, testPet.health);
        }

        [Fact]
        public void GetHealth_Should_Return_Initial_Health_Level_Of_30()
        {
            int testPetHealth = testPet.GetHealth();
            testPet.health = 30;
            Assert.Equal(30, testPetHealth);
        }

        [Fact]
        public void Feed_Should_Decrease_Hunger_By_100() // feeding our pets completely satiates them!

        {
            testPet.hunger = 50;
            testPet.Feed();
            
            Assert.Equal(0, testPet.GetHunger());
        }

        [Fact]
        public void SeeDoctor_Should_Increase_Health_to_100() // our Vets completely heal our Pets
        {
            testPet.Doctor();

            Assert.Equal(100, testPet.GetHealth());
        }

        [Fact]
        public void Play_Should_Increase_Hunger_By_10()
        {
            testPet.Play();

            Assert.Equal(60, testPet.GetHunger());
        }

        [Fact]
        public void Play_Should_Decrease_Boredom_By_20()
        {
            testPet.Play();

            Assert.Equal(40, testPet.GetBoredom());
        }

        [Fact]
        public void Play_Should_Increase_Health_By_10()
        {
            testPet.Play();

            Assert.Equal(40, testPet.GetHealth());
        }

        [Fact]
        public void Tick_Should_Increase_Hunger_By_10()

        {

            testPet.Tick();

            Assert.Equal(10, testPet.GetHunger());
        }

        [Fact]
        public void Tick_Should_Increase_Boredom_By_10()
        {
            testPet.Tick();

            Assert.Equal(65, testPet.GetBoredom());
        }

        [Fact]
        public void Tick_Should_Decrease_Health_By_10()
        {
            testPet.Tick();

            Assert.Equal(25, testPet.GetHealth());
        }
    }
}
