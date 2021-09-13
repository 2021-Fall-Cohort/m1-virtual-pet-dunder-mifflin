# Virtual Pets Amok Testing
The following is a list of the tests given to you in the first Virtual Pet assignment, along with a more detailed explanation.

**Remember, you are not expected to modify or add to the code in the PetTests.cs test class. Use the title of the test, and the explanation below, to guide you in writing source code to the Pet.cs class.**

> Pet_Constructor_Should_Instantiate_Pet_Object()

This test already passes. It proves that you can create a Pet object.

> Pet_Should_Have_Name()

The Pet class should have a Name property to store the pet's name (e.g., "Horace").

This is a poorly written test, so don't worry if it fails after creating the Name property. You can rewrite the test as shown below if you want to make it pass:
```
[Fact]
public void Pet_Should_Have_Name()
{
    testPet.Name = "Pet Name";

    Assert.Equal("Pet Name", testPet.Name);
}
```
> SetName_Should_Assign_Pet_Name_Property()

The Pet class should have a SetName() method that takes in a string (e.g., "Fluffy"), and assigns the value of the string to the Name property.

> GetName_Should_Get_Pet_Name_Value()

The Pet class should have a GetName() method that gets the value stored in the Name property (e.g. "Fido"), and returns it to the caller of the method.

> Pet_Should_Have_Species()

The Pet class should have a Species property to store the pet's species (e.g., "Hippo").

This is a poorly written test, so don't worry if it fails after creating the Species property. You can rewrite the test as shown below if you want to make it pass:
```
[Fact]
public void Pet_Should_Have_Species()
{
    testPet.Species = "Pet Species";

    Assert.Equal("Pet Species", testPet.Species);
}
```

> SetSpecies_Should_Assign_Pet_Species_Property()

The Pet class should have a SetSpecies() method that takes in a string (e.g., "Cat"), and assigns the value of the string to the Species property.

> GetSpecies_Should_Get_Pet_Species_Value()

The Pet class should have a GetSpecies() method that gets the value stored in the Species property (e.g. "Dog"), and returns it to the caller of the method.

> Pet_Should_Have_Hunger()

The Pet class should have a Hunger property to store the pet's hunger level (e.g., 25).
This is a poorly written test, so don't worry if it fails after creating the Hunger property. You can rewrite the test as shown below if you want to make it pass:
```
[Fact]
public void Pet_Should_Have_Hunger()
{
    testPet.Hunger = 100;

    Assert.Equal(100, testPet.Hunger);
}
```

> GetHunger_Should_Return_Initial_Hunger_Level_Of_50()

The Pet class should have a GetHunger() method that gets the value stored in the Hunger property, and returns it to the caller of the method. When a Pet object is created (i.e., instantiated), it should have a default Hunger value of 50.

> Pet_Should_Have_Boredom()

The Pet class should have a Boredom property to store the pet's boredom level (e.g., 40).

This is a poorly written test, so don't worry if it fails after creating the Boredom property. You can rewrite the test as shown below if you want to make it pass:
```
[Fact]
public void Pet_Should_Have_Boredom()
{
    testPet.Boredom = 100;

    Assert.Equal(100, testPet.Boredom);
}
```

> GetBoredom_Should_Return_Initial_Boredom_Level_Of_60()

The Pet class should have a GetBoredom() method that gets the value stored in the Boredom property, and returns it to the caller of the method. When a Pet object is created (i.e., instantiated), it should have a default Boredom value of 60.

> Pet_Should_Have_Health()

The Pet class should have a Health property to store the pet's health level (e.g., 70).

This is a poorly written test, so don't worry if it fails after creating the Health property. You can rewrite the test as shown below if you want to make it pass:
```
[Fact]
public void Pet_Should_Have_Health()
{
    testPet.Health = 100;

    Assert.Equal(100, testPet.Health);
}
```

> GetHealth_Should_Return_Initial_Health_Level_Of_30()

The Pet class should have a GetHealth() method that gets the value stored in the Health property, and returns it to the caller of the method. When a Pet object is created (i.e., instantiated), it should have a default Health value of 30.

> Feed_Should_Decrease_Hunger_By_40()

The Pet class should have a Feed() method that decreases the value of the Hunger property by 40.

> SeeDoctor_Should_Increase_Health_By_30()

The Pet class should have a SeeDoctor() method that increases the value of the Health property by 30.

> Play_Should_Increase_Hunger_By_10()

The Pet class should have a Play() method that increases the value of the Hunger property by 10.

> Play_Should_Decrease_Boredom_By_20

The Play() method should also decrease the value of the Boredom property by 20.

> Play_Should_Increase_Health_By_10

The Play() method should also increase the value of the Health property by 10.

> Tick_Should_Increase_Hunger_By_5

The Pet class should have a Tick() method that increases the value of the Hunger property by 5.

> Tick_Should_Increase_Boredom_By_5

The Tick() method should also increase the value of the Boredom property by 5.

> Tick_Should_Decrease_Health_By_5()

The Tick() method should also decrease the value of the Health property by 5.
