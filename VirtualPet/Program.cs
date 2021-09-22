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
                //Console.WriteLine("6. Add Another Pet To The Shelter");
                //Console.WriteLine("7. Age Category");
                //Console.WriteLine("8. Words to Digits");
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
                    //case "6":
                    //    RestaurantBill();
                    //    break;
                    //case "7":
                    //    AgeCategory();
                    //    break;
                    //case "8":
                    //    WordsToDigits();
                    //    break;
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
            Console.WriteLine("Select the pet you wish to play with");
            Pet myPet = myShelter.SelectPet();
            myPet.Play();
            Console.WriteLine("\n" + myPet.name + " is really happy to get play time with you and is no longer bored!\n");


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void FeedPet()
        {
            
            Console.Clear();
            Console.WriteLine("Feed Your Pet\n");

            // Enter your solution here
            Console.WriteLine("Select the pet you wish to feed");
            Pet myPet = myShelter.SelectPet();
            myPet.Feed();
            Console.WriteLine("\n" + myPet.name + " is happily stuffed!\n");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void TakePettoVet()
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

       
        }
    }

