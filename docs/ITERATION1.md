# Virtual Pets Amok Iteration 1
Do you remember Cyberpet? Tamagotchi? Digimon? Petz? Virtual pets like these were born in 1996. With your help, they will be reborn. Virtual Toys, Inc. wants you to build the next iteration of virtual pets to market to adults who enjoy updated versions of the toys and games they played in their youth. This game will be like the virtual pets of 1996...but so much more.

## Details:
Creating a Virtual Pet console application might seem like a daunting task, but when we break this project up into smaller chunks, you will find it to be more manageable.

Think of the instance variables and methods you will need. Remember that instance variables represent the state of your pet. Methods represent the behavior of your pet, which would include its responses to you feeding or playing with it.

Most games include what is called a game loop. This loop allows the user to continue playing the game as long as they’d like. Often this loop redirects the user to a main menu of game actions. We exit the loop when something happens that should cause the game to end, such as choosing “Quit” from the main menu. This loop updates everything in the game, and can be used to represent the passage of time. Note, you may not want to include everything in the game loop! Think about which actions you want to repeat, and which you do not.

Include a method representing the passage of a unit of time. This should do things like update the instance variables of your pet that are time dependent, such as hunger or thirst. You should call this method after the user interacts with the pet. This requirement has some flexibility. You decide what user action(s) will trigger the method, and what instance variables you want to update.

## Setup:
Follow the GitHub Classroom link to accept the Virtual Pet assignment. Clone the project to your machine and open it in Visual Studio. The VirtualPet console application you have been given has been templated with a solution containing a VirtualPet project and a VirtualPet.Tests test project. The VirtualPet project contains the Program class and an empty Pet class. In addition, you have been provided the appropriate .gitignore file.

Your Pet class will encapsulate all attributes (instance variables and behaviors) that describe a Pet. In addition, it will contain the Tick() method. NOTE: If you want to use different attributes or values than the ones referenced in the tests, simply rewrite the tests to reflect the property or method that you want to use!

After code has been added to the Pet class to satisfy the tests, begin adding code to the Main() method of the Program class. The Main() method is the starting point of the application. This is where you will add the game loop and code for your user interface. It is the responsibility of the Program class to write messages to the console and read user input.

## Game Ideas:
These ideas are only suggestions, so have fun with this part! Also, remember that more features != better. Pick a focus for your pet. Maybe go with a theme.

**Examples of states (instance variables) that a virtual pet might have:**
- hunger (feed it)
- thirst (water it)
- waste (let it out to the bathroom)
- boredom (play with it)
- sickness (take it to the doctor)
- sleepiness (give a rest)

**Ideas for activities (methods) that affect a pet’s state:**
- A Feed() method might make hunger go down and thirst go up
- A Water() method might make thirst go down
- A Play() method might make hunger go up, thirst go up, boredom go down, and sleepiness go up
- A VisitDoctor() method might make sickness go down
 
**Attributes that might update when a tick() method is called, representing the passage of time:**
- boredom increases
- hunger increases
- waste increases

**An example user interface is below (yours doesn't need to match this!):**
```
What is the name of your pet?

> Horace

What is the species of your pet?

> Hippo

Horace the Hippo

Hunger: 27

Thirst: 5

Boredom: 5

Tiredness: 50


What do you want to do?
1. Feed Horace
2. Water Horace
3. Play with Horace
4. Put Horace to sleep
5. Do nothing

> 1

You fed Horace.
```

## Required Tasks:
- Create at least three instance variables
- Create at least three methods
- Implement a game loop
- Ask for user input
- Write output to the console
- Create a tick() method that represents the passage of time

## Stretch Tasks:
- Give the pet the ability to take care of some of its own needs. Pets are not robots - they usually have some sort of self-determination! When Tick() is called, you might want to have your pet take a look at its needs and address one, prioritizing whichever need is highest.
- You could also make your pet uncooperative - when the user tries to feed the pet, for example, you might make the pet refuse to eat if it is bored. Remember how we created an instance of the Random class to create a random number generator? You might want to incorporate that.
- Assign favorite foods to your pet, and add a parameter specifying the type of food to the method you use to feed your pet. Your pet should react accordingly. You could also decide which foods it does not like.
- Create a visual representation of your pet. Rather than using numbers to convey your pet's status, you could have some sort of visual representation of the pet. I.e., instead of printing hunger: 50, you could use smileys or ASCII art to show hunger when hunger >= 50.
