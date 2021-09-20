using System;
using System.Threading;

namespace VirtualPet
{
    class Program
    {
        public static Pet myPet = new Pet();
        public static Timer _timer = null;

        static void Main(string[] args)
        {
         
            _timer = new Timer(Tick, null, 0, 2000);

           static void Tick(Object o)
            {
                myPet.Update();
            }


            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("Hello! Welcome to Virtual Pets");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Create a pet");
                Console.WriteLine("2. Check pet status");
                Console.WriteLine("3. Play with pet");
                Console.WriteLine("4. Feed pet");
                Console.WriteLine("5. Take pet to vet");
                //Console.WriteLine("6. Restaurant Bill");
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
           
            Console.Clear();
            Console.WriteLine("Create Your Pet\n");

            Console.WriteLine("What would you like to name your pet?");
            myPet.name = Console.ReadLine();

   
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

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        //static void RestaurantBill()
        //{
        //    // At a restaurant, Mike and his three friends decided to divide the bill evenly.
        //    // If each person paid $13 then what was the total bill?
        //    // Use arithmetic operators and print the amount of the total bill to the console.

        //    // Returning to the above problem, replace hard-coded values of 4(number of diners)
        //    // and 13(cost per diner) with values provided by the user.

        //    // How nice!The restaurant is having Customer Appreciation Week.
        //    // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
        //    // Otherwise, they’ll receive a 5 % discount.

        //    Console.Clear();
        //    Console.WriteLine("RESTAURANT BILL\n");

        //    // Enter your solution here

        //    Console.Write("Press enter to return to the Main Menu");
        //    Console.ReadLine();
        //}

        //static void AgeCategory()
        //{
        //    // You're responsible for providing a demographic report for your local school district based on age.
        //    // To do this, you're going to determine which 'category' each person fits into based on their age.
        //    // The person's age will determine which category they should be in:

        //    // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
        //    // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
        //    // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
        //    // From 12 to 14: 'Middle School'
        //    // From 15 to 18: 'High School'
        //    // From 19 to 22: 'College'
        //    // From 23 to 65: 'Working for the Man'
        //    // From 66 to 100: 'The Golden Years'
        //    // If the age of the person is less than 0 or more than 100 - it might be an alien
        //    // print: "This program is for humans".

        //    Console.Clear();
        //    Console.WriteLine("AGE CATEGORY\n");

        //    // Enter your solution here

        //    Console.Write("Press enter to return to the Main Menu");
        //    Console.ReadLine();
        //}

        //static void WordsToDigits()
        //{
        //    // Having a string representation of a number, you need to print the digit form of the number.
        //    // Ask the user to enter a string representation of a number from zero to ten.
        //    // Using switch case, print the digit (0-10) representation of the number.

        //    Console.Clear();
        //    Console.WriteLine("WORDS TO DIGITS\n");

        //    // Enter your solution here

        //    Console.Write("Press enter to return to the Main Menu");
        //    Console.ReadLine();
        //}

        //static void WhichNameIsLonger()
        //{
        //    // Ask the user for their first and last name.

        //    // Print the user's full name.
        //    // If the first name is longer than the last name, print "First is longer."
        //    // If the first name and last name are the same length, print "Same-sies!"
        //    // Otherwise, print "Last must be longer!"

        //    Console.Clear();
        //    Console.WriteLine("WHICH NAME IS LONGER?\n");

        //    // Enter your solution here

        //    Console.Write("Press enter to return to the Main Menu");
        //    Console.ReadLine();
        //}

        //static void AreNamesSame()
        //{
        //    // Ask the user for 2 names.

        //    // If the two names are the same, print "The names are the same."
        //    // If they're not the same, print "The names are different."

        //    Console.Clear();
        //    Console.WriteLine("ARE THESE NAMES THE SAME?\n");

        //    // Enter your solution here

        //    Console.Write("Press enter to return to the Main Menu");
        //    Console.ReadLine();
        //}

        //static void NameAndBirthplace()
        //{
        //    // Ask the user for their first name and where they were born.
        //    // Print a sentence to the console that repeats this information.

        //    Console.Clear();
        //    Console.WriteLine("NAME AND PLACE OF BIRTH\n");

        //    // Enter your solution here

        //    Console.Write("Press enter to return to the Main Menu");
        //    Console.ReadLine();
        //}
    }
}
