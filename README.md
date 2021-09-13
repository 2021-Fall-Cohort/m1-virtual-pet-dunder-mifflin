# Virtual Pets Amok
## [Iteration 1: Let's create a virtual pet and interact with it](docs/ITERATION1.md)
Do you remember Cyberpet? Tamagotchi? Digimon? Petz? Virtual pets like these were born in 1996. With your help, they will be reborn. Virtual Toys, Inc. wants you to build the next iteration of virtual pets to market to adults who enjoy updated versions of the toys and games they played in their youth.  This game will be like the virtual pets of 1996...but so much more. It’s Virtual Pets Amok!

Virtual Toys, Inc. requires:

- Development of a console application
- Use of Test Driven Development
- Clean code
- Appropriate use of Git and access to your application on GitHub
- An interactive user interface
- Ability for players to enter the game, play as long as they’d like, and leave the game when they want
- Ability for players to enter a name and species for a pet
- Ability for players to see the current status of a pet, such as hunger, boredom, and health
- Ability for players to interact with pet, such as feed, play, and take to doctor
- As players interact with pet, the pet’s status changes
- As "time" ticks by, the pet's status changes negatively

---- 

## [Iteration 2: Our pet is lonely. Let's add more virtual pets into our shelter.](docs/ITERATION2.md)
Our pets are housed in a shelter and cared for by you. You can interact with one pet at a time, or all pets. They can be adopted.

Virtual Toys, Inc. requires:

- Ability for players to admit pets into the shelter or adopt them
- Ability for players to see a list of all pets in the shelter
- Ability for players to see the current status of all pets at once, such as hunger, boredom, and health
- Ability for players to choose to interact with one pet or multiple pets, such as feed, play, and take to doctor

---

## [Iteration 3: Our shelter now has robotic pets, and they act differently than organic pets.](docs/ITERATION3.md)
Our pets are organic and robotic! They have unique personalities.

Virtual Toys, Inc. requires:

- Player’s choice of adding, interacting, or adopting organic or robotic pets
- As players interact with pets, the pet’s status changes differently for organic and robotic pets
- As "time" ticks by, the pet's status changes negatively. The passing of time is measured by how often the player interacts with the program.
- Useful player instructions in the form of a README.md file

## Grading
#### [Testing Guidelines](docs/TESTING.md)
The VirtualPet.Tests project includes a PetTests class with completed tests. These are the tests that will prove that the code you write in the Pet class is correct. Therefore, it is the logical starting point! The first test Pet_Constructor_Should_Instantiate_Pet_Object() has been written for you, and it passes because you already have a Pet class and can create a Pet object. The remaining tests have been written, but are commented out. Uncomment the code of the first test and add source code to the Pet class to pass the test. Continue with the tests, one by one, and add code until all the tests pass. 

You should write your code by writing tests first. If you do so, each public method you write should have a unit test that covers its behavior. The test classes should also be well maintained and follow the principles of clean code. In order to receive a PASSING grade, all of the following principles must be met:

- The addition of a test class in the VirtualPet. Tests test every new class you add to your VirtualPet project.
- 75% of the public methods you add to any of your classes should be covered by unit tests.
- Tests include appropriate Arrange, Act, and Assert sections.
- All tests pass.
