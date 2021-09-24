using System;
using Xunit;

namespace VirtualPet.Tests
{
    public class RobotTest
    {
        private RobotPet testRobotPet;

        public RobotTest()
        
            {
                testRobotPet = new RobotPet();
            }


            [Fact] // passes
            public void RobotPet_Constructor_Should_Instantiate_Pet_Object()
            {
                // Act
                RobotPet testRobotPet = new RobotPet(true, "George", "dog", 12, "green");

                Assert.NotNull(testRobotPet);
            }


        // INSTRUCTIONS:
        // Uncomment code in the test body one test at a time
        // Add source code to eliminate the build errors (red squiggle) and pass the test

        [Fact] // passes
        public void RobotPet_Should_Have_Name()
        {
            testRobotPet.name = "Pet Name";

            Assert.Equal("Pet Name", testRobotPet.name);
        }

        [Fact] // passes!
        public void RobotPet_Should_Have_Battery()
        {
            testRobotPet.battery = 100;

            Assert.Equal(100, testRobotPet.hunger);
        }

    }
}
