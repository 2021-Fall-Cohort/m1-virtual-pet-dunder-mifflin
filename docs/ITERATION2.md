# Virtual Pets Amok Iteration 2
Our pets are housed in a shelter and cared for by you. You can interact with one pet at a time, or all pets. They can be adopted.

## Details:
We're going to use TDD (Test Driven Development) to drive the creation of an application that simulates you taking care of the pets in a shelter.

But how are we going to interact with a whole shelter of pets, you ask? One at a time, of course. You will use the code you already added into your application to feed and play with one pet, and add in code that will allow us to manage a collection of pets, such as arrays, lists, or dictionaries.

## Setup:
You will add code to your original Virtual Pet console application and turn it into a Virtual Pet Shelter!

Before you get started, add a Shelter class to the VirtualPet project and a ShelterTests class to the VirtualPet.Tests project. Make sure the ShelterTests class has a reference to the Shelter class.

Remember, your Pet class will still encapsulate all attributes that describe a Pet. The same is true for your Shelter class. Only add properties and methods to your Shelter class that belong to a Shelter.

Start with tests! Think about the first behavior you want a Shelter to perform. Then write a test in your ShelterTests class that proves it performs the way you expected. Continue to build your Shelter class, one small test at a time. We will practice some common tests for collections that will help you build these tests.

If you need to add more behaviors to the Pet class, remember to write a test first. Of course these tests belong in the PetTests class.

In your Program class, your game loop should query the user, then call the appropriate method(s) on Shelter and/or Pet classes. In general, your Program class should talk to your Shelter, and your Shelter should talk to your Pet. Try to avoid Program class talking directly to Pet instances, apart from accessing basic information about pets (via Get methods). You may need to refactor and move code you have already written, but hopefully not too much!

## Game Ideas:
**An example user interface:**
```
Thank you for volunteering at Big Al's Virtual Pet Shelter and Delicatessen!

This is the status of your pets:

Name	|Hunger	|Thirst	|Boredom
--------|-------|-------|-------
Joey	|83     |34     |23
Johnny	|69     |49     |2
Dee Dee	|39     |18     |88
Tommy	|59     |19     |37

What would you like to do next?

1. Feed the pets
2. Water the pets
3. Play with a pet
4. Adopt a pet
5. Admit a pet
6. Quit
```
**An example pet selection interface:**
```
Ok, so you'd like to play with a pet. Please choose one:

[Joey] looks like he's seen better days.
[Johnny] is a bit nervous.
[Dee Dee] probably didn't start with that many legs.
[Tommy] smells like a Stargazer lily fresh with morning dew.

Which pet would you like to play with?
> Tommy

Ok, you played with Tommy.
```
## Required Features:
- All the requirements of Virtual Pet assignment #1
- Allow user to intake pets into the shelter (i.e., add them to the shelter list)
- Allow user to see a list of all pet names and their status (e.g., hunger level, boredom level)
- Allow user to interact (e.g., feed, play, take to doctor) with all pets at one time
- Allow user to select a pet from a list before choosing how they would like to interact with it
- Allow user to select a pet from a list for adoption (i.e., removal from the shelter list)
## Stretch Tasks:
- Consider any stretch tasks from last week's project that you did not attempt.
- Keep track of the cleanliness of individual pets' cages and offer an option in the user interface to clean pet cages.
- Assign favorite foods to your pet, and add a parameter specifying the type of food to the method you use to feed your pet. Your pet should react accordingly. You could also decide which foods it does not like.DNA! In order to give your pets individual character, include as part of each pet's state one or more multipliers so that one pet may become hungry, thirsty, bored, etc. at a different rate than another pet. NOTE: You could create a new class to encapsulate this.
