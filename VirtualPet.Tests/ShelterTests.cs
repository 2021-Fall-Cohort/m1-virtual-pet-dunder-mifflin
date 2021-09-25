using System;
using Xunit;
using VirtualPet;

namespace VirtualPet.Tests
{
    public class ShelterTests
    {
        public Shelter testShelter;

        public ShelterTests()
        {
            testShelter = new Shelter();
        }
        [Fact]
        public void CreatePet_Should_Return_Pet()
        {

            //arrange
            var testPet = new Pet();
            //act
            var result = testPet = new Pet();
            //assert
            Assert.NotNull(testPet);
     
    }

   }
}

  


