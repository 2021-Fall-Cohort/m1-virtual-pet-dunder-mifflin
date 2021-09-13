# Virtual Pets Amok
Our pets are Organic and Robotic! They have unique personalities.

## Details:
We're going to use Encapsulation and Inheritance to create classes that handle the state and behavior of Robotic pets, while minimizing repetition.

In your application you will allow the user to interact with both Organic and Robotic versions of your pets, for example, Organic Cats, Organic Dogs, Robotic Cats, and Robotic Dogs.

Organic pets can be played with, fed, and taken to the doctor. These actions change the pet's hunger, boredom, and health levels. Robots pets can be played with, given oil, and taken for maintenance. These actions change the Robotic pet's oil, boredom, and performance levels.

Both Robotic and Organic pets can be adopted (removed) from the shelter.

As "time" ticks by, the Organic and Robotic pets' status changes negatively.

## Setup:
Inheritance allows us to define a generic base class, and derived classes that inherit all of the base class's properties and methods. Think about the attributes (properties and methods) that are common to both Organic and Robotic pets. Move these into a generic base class. Can some of these methods perform the same action ("Play"), but with a different implementaion? You can use Method Overriding to create different implementations for the same method name. Hint: Use a class diagram to help you visualize this.

If you decide to make your OrganicPet and RoboticPet classes inherit from a Pet base class, remember that an OrganicPet IS A Pet and the RoboticPet IS A Pet. What does this mean? It means that if you have a collection of Pets, it can contain both OrganicPets and RoboticPets and you can interact with all members of the collection as if they are Pets. In other words, any method or property that exists in the Pet class can be applied to an OrganicPet or RoboticPet, because they are both Pets!

In Agile work environments User stories are short, simple descriptions of a feature told from the perspective of the person who desires the new capability, usually a user or customer of the system. Use these User Stories to guide you through the implemention of this Virtual Pet iteration:

## User Stories
### Add Robotic Pets to the Shelter
- As a player, I would like to add robotic pets to the shelter, so I have a different types of pets that I can interact with
- Given I'm a player, when I choose to add a robotic pet to the shelter from the main menu, then I am asked for its name and type. As a player I can repeat this process and add as many robotic pets to the shelter as I'd like.
 
### Play with Robotic Pets
- As a player, I would like to play with robotic pets, so that I can change the status levels of my robotic pets differently than my organic pets
- Given I'm a player, when I choose to play with my robotic pets, then the oil level decreases, the boredom level decreases, and the performance level increases
 
### Give Oil to Robotic Pets
- As a player, I would like to give oil to my robotic pets, so that I change the status level of my robotic pets differently than my organic pets
- Given I'm a player, when I choose to give oil to my robotic pets, then the oil level increases
 
### Take Robotic Pet For Maintenance
- As a player, I would like to take my robotic pet in for maintenance, so that I can change the status levels of my robotic pets differently than my organic pets
- Given I'm a player, when I choose to take my robotic pet in for maintenance, then the oil and performance levels increase

## Required Features:
- All the requirements of Virtual Pet assignment #1
- All the requirements of Virtual Pet Shelter assignment #2
- Allow user to add Robotic pets to the shelter
- The user can clearly see that Organic and Robotic pets have some similarities and some differences in their state and behavior.
- Modification of the README markdown file in your project, to describe your project and give instructions to the user. No fancy formatting is necessary. Just separate paragraphs with an empty line.

## Stretch Tasks:
- Allow for other types of pets. Are they caged? What maintenance do they require?
- Allow an option for giving treats to pets. What sorts of treats do different pets like?
- Introduce a Cage class for each dog, where cleanliness is tracked, keying these on the dog to which each is assigned
