using System;
using System.Threading;

namespace VirtualPet
{
    class Program
    {
        public static Pet myPet = new Pet();
        public static Shelter myShelter = new Shelter();
        //public static RobotPet myRobotPet = new RobotPet();
        public static Timer _timer = null; //Status Timer
        public static void Tick(Object o)
        {
            //myPet.Tick();

            myShelter.Tick();
        }

        public static void Main(string[] args)
        {
            Pet testPet = new Pet();
            testPet.name = "Fido";
        
         
            _timer = new Timer(Tick, null, 0, 15000);


            bool keepThinking = true;
            while (keepThinking)
            //Menu of options for Virtual Pet
            {
                Console.Clear();
                Console.WriteLine("Hello! Welcome to Virtual Pets");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add a pet to the Shelter");
                Console.WriteLine("2. Check pet status");
                Console.WriteLine("3. Play with pet");
                Console.WriteLine("4. Feed pet");
                Console.WriteLine("5. Take pet to vet");
                Console.WriteLine("6. Remove Pet");
                Console.WriteLine("7. Check Status of All Pets");
                Console.WriteLine("8. Charge Robotic Pet Battery");
                Console.WriteLine("9. Send Robotic Pet to Factory for Maintenance");
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
                        RemovePet();
                        break;
                    case "7":
                        CheckAllPets();
                        break;
                    case "8":
                        ChargeBattery();
                        break;
                    case "9":
                        PetMaintenance();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        public static void CreatePet()
        {
            // Pet Creation Code
            Console.Clear();
            Console.WriteLine("Create Your Pet\n");

            bool robot;

            Console.WriteLine("Is this a robotic pet or an organic pet?\n 1 for robotic \n 2 for organic ");
            int R = Convert.ToInt32(Console.ReadLine()); 
            if (R == 1)
                robot = true;
            else
                robot = false;
            

            Console.WriteLine("What is the name of your pet");
            string name = Console.ReadLine();

            if (robot == true)
            {
                Console.WriteLine("What is the model of your pet");
            }
            if (robot == false)
            {
                Console.WriteLine("What is the species of your pet");
            }
            string species = Console.ReadLine();

            Console.WriteLine("What is the age of your pet");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the color of your pet");
            string color = Console.ReadLine();

            if (robot)
            {
                myShelter.ListOfPets.Add(new RobotPet(robot, name, species, age, color));
            }
            else
            {
                myShelter.ListOfPets.Add(new Pet(robot, name, species, age, color));
            }
 
            Console.WriteLine("Thank you for bringing this animal to the shelter.  It is in good hands and will be adopted out ASAP!\n");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void CheckPetStatus()
        {
            Console.Clear();
            Console.WriteLine("Check Pet Status\n");

            Console.WriteLine("Select the pet you wish to check on");
            Pet myPet = myShelter.SelectPet();
            myPet.PetStatus();

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void PlayWithPet()
        {
            Console.Clear();
            Console.WriteLine("Play With Your Pet\n");

            // Enter your solution here
            Console.WriteLine("Select the pet you wish to play with");
            Pet myPet = myShelter.SelectPet();
            myPet.Play();
            Console.WriteLine("\n" + myPet.name + " is really happy to get play time with you and is no longer bored!\n");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void FeedPet()
        {
            Console.Clear();
            Console.WriteLine("Feed Your Pet\n");

            // Enter your solution here
            Console.WriteLine("Select the pet you wish to feed");
            Pet myPet = myShelter.SelectPet();
            Console.WriteLine(myPet.name + "'s current hunger level is: " + myPet.hunger);
 
            myPet.Feed();
            Console.WriteLine("\n" + myPet.name + " is happily stuffed!\n");
            Console.WriteLine(myPet.name + "'s updated hunger level is: " + myPet.hunger);
 
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void TakePettoVet()
        {
            Console.Clear();
            Console.WriteLine("Take Pet to Vet\n");

            // Enter your solution here
            Console.WriteLine("Select the pet you wish to take to the doctor");
            Pet myPet = myShelter.SelectPet();
            myPet.Doctor();
            Console.WriteLine("\n" + myPet.name + " is feeling so much better now!\n");
            
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
      
        public static void CheckAllPets()
        {
            Console.Clear();
            Console.WriteLine("Check Status of All Pets\n");
            myShelter.allPetsStatus();
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void RemovePet()
        {
            Console.WriteLine("Welcome to the Shelter!  Here is a list of the pets available for adoption.\n");
            Pet selectedPet = myShelter.SelectPet();
            //selectedPet.shelter();

            myShelter.ListOfPets.Remove(selectedPet);
        }

        public static void ChargeBattery()
        {
            Console.Clear();
            Console.WriteLine("Charge Robotic Pet Battery\n");

            // Enter your solution here
            Console.WriteLine("Select the robotic pet you wish to charge battery");
            RobotPet myPet = (RobotPet)myShelter.SelectPet();
            
            myPet.Charge();
            Console.WriteLine("\n" + myPet.name + " is fully charged!\n");
            
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
 
        public static void PetMaintenance()
        {
            Console.Clear();
            Console.WriteLine("Take Robotic Pet in for Maintenance\n");

            // Enter your solution here
            Console.WriteLine("Select the Robotic pet you wish to take in for maintenance");
            RobotPet myPet = (RobotPet)myShelter.SelectPet();
            myPet.Factory();
            Console.WriteLine("\n" + myPet.name + " is feeling so much better now!\n");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}


