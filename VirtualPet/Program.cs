using System;
using System.Threading;

namespace VirtualPet
{
    class Program
    {
        //public static Pet myPet = new Pet();
        public static Shelter myShelter = new Shelter();
        public static Timer _timer = null; //Status Timer

        static void Tick(Object o)
        {
            //myPet.Update();
            //myShelter.Update();
        }

        static void Main(string[] args)
        {

            _timer = new Timer(Tick, null, 0, 2000);




            bool keepThinking = true;
            while (keepThinking)
            //Menu of options for Virtual Pet
            {
                Console.Clear();
                Console.WriteLine("Hello! Welcome to Virtual Pets");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Create a pet");
                Console.WriteLine("2. Check pet status");
                Console.WriteLine("3. Play with pet");
                Console.WriteLine("4. Feed pet");
                Console.WriteLine("5. Take pet to vet");
                Console.WriteLine("6. Add Another Pet To The Shelter");
                Console.WriteLine("7. Adopt a Pet from the Shelter");
                Console.WriteLine("8. Get List of All Pets in the Shelter");
                //Console.WriteLine("9. Which Name is Longer?");
                //Console.WriteLine("10. Are these Names the Same?");
                //Console.WriteLine("11. Name and Place of Birth");
                Console.WriteLine("Press Q to quit");
                string userChoice = Console.ReadLine().ToLower();
                switch (userChoice)
                {
                    case "1":
                        CreatePet();
                        break;
                    case "2":
                        CheckPetStatus();
                        break;
                    case "3":
                        PlayWithPet();
                        break;
                    case "4":
                        FeedPet();
                        break;
                    case "5":
                        TakePettoVet();
                        break;
                    case "6":
                        AddPetToShelter();
                        break;
                    case "7":
                        //AdoptPetFromShelter();
                        break;
                    case "8":
                        //GetListOfPetsInShelter();
                        break;
                    //case "9":
                    //    WhichNameIsLonger();
                    //    break;
                    //case "10":
                    //    AreNamesSame();
                    //    break;
                    //case "11":
                    //    NameAndBirthplace();
                    //    break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void CreatePet()
        {
            // Pet Creation Code
            Console.Clear();
            Console.WriteLine("Create Your Pet\n");

            Console.WriteLine("What is the name of your pet");


            string name = Console.ReadLine();
            Console.WriteLine("What is the species of your pet");


            string species = Console.ReadLine();

            Console.WriteLine("What is the age of your pet");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the color of your pet");


            string color = Console.ReadLine();



            Pet pet = new Pet(name, species, age, color);
            myShelter.ListOfPets.Add(pet);



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void CheckPetStatus()
        {

            Console.Clear();
            Console.WriteLine("Check Pet Status\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void PlayWithPet()
        {

            Console.Clear();
            Console.WriteLine("Play With Your Pet\n");

            // Enter your solution here
            //myPet.Play();
            Pet myPet = myShelter.SelectPet();

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void FeedPet()
        {

            Console.Clear();
            Console.WriteLine("Feed Your Pet\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void TakePettoVet()
        {


            Console.Clear();
            Console.WriteLine("Take Pet to Vet\n");

            // Enter your solution here

            Pet selectedPet = myShelter.SelectPet();
            selectedPet.Doctor();

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }


        //Add a Pet to shelter

        static void AddPetToShelter()
        { 
            Console.Clear();
            Console.WriteLine("Add a Pet to the Shelter\n");

            // Enter your solution here
            // Create shelter pet list

            Console.Clear();
            Console.WriteLine("Create Your Pet\n");

            Console.WriteLine("What is the name of your pet");


            string name = Console.ReadLine();
            Console.WriteLine("What is the species of your pet");


            string species = Console.ReadLine();

            Console.WriteLine("What is the age of your pet");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the color of your pet");


            string color = Console.ReadLine();



            Pet pet = new Pet(name, species, age, color);
            myShelter.ListOfPets.Add(pet);

            Console.WriteLine("Thank you for bringing this animal to the shelter.  It is in good hands and will be adopted out ASAP!\n");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}

