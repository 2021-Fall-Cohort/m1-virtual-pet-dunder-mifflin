using System;
using Xunit;

namespace VirtualPet.Tests
{
    public class ShelterTests
    {
        public Shelter testShelter;

        public ShelterTests()
        {
            SetTestShelter(new Shelter());
        }

        public Shelter GetTestShelter()
        {
            return testShelter;
        }

        public void SetTestShelter(Shelter value)
        {
            testShelter = value;
        }

        [Fact]
        public void SelectPet_Should_Increase_List_By_1()
        {
            // Arrange

            // Act
            Shelter.testShelter(new Shelter());

            // Assert
            Assert.Single(Shelter.ListOfPets);
        }

        //adding a pet to the list
        //status update
        //selectpet returns a pet
        //look at carlos's bank tests








    }
}

}
