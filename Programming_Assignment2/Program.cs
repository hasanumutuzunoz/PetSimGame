using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment2
{


    class Program
    {
        static void Main(string[] args)
        {
            //Greet Player Function
            string simName = GreetPlayer();
            Pet myPet = new Pet(simName);
            
            int dayCounter = 1;

            //Game loop
            while (true)
            {
            Console.Clear();

            //Stats and day menu at top
            myPet.Stats();

            //Actions list
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nHey you! My name is {0}", simName);
            Console.WriteLine(". What should I do?");
            Console.ResetColor();
            Console.WriteLine("\n1) Sleep {0}", simName);
            Console.WriteLine("2) Feed {0}", simName);
            Console.WriteLine("3) Play {0}", simName);
            Console.WriteLine("4) Watch a movie {0}", simName);
            Console.WriteLine("5) Work {0}", simName);
            Console.WriteLine("");

                int iUserAction = GetUserAction();
            

            //User action possibilities
            switch (iUserAction)
            {

                //If user selected action 1 (Sleep)
                case 1:
                    myPet.Sleep();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("I feel rested!!");
                    Console.ResetColor();
                    Console.ReadLine();
                    break;

                //If user selected action 2 (Feed)
                case 2:
                    myPet.Eat();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Oh thank you that was delicious");
                    Console.ResetColor();
                    Console.ReadLine();
                    break;

                //If user selected action 3 (Play)
                case 3:
                    myPet.Play();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Woooohoooouuwwwwww");
                    Console.ResetColor();
                    Console.ReadLine();
                    break;

                //If user selected action 4 (Watch a movie)
                case 4:
                    myPet.WatchMovie();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("That was a funny movie HAHAHA");
                    Console.ResetColor();
                    Console.ReadLine();
                    break;

                //If user selected action 5 (Work)
                case 5:
                    myPet.Work();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ahhhh I had worked too much and Im tired :(");
                    Console.ResetColor();
                    Console.ReadLine();
                    break;
            }

                //Report at the and of the day
                myPet.Report();

                //Day increases in every two action
                if (dayCounter % 2 == 0)
                    myPet.increaseDay();
                dayCounter++;

                Console.ReadLine();
            }
        }



        //Get the sim name and  it convert to integer. If it`s not string, ask user the name again. 
        static string GreetPlayer()
        {
                Console.WriteLine("Welcome to my SIM game");
                Console.WriteLine("Please enter your SIM name");
                bool isSimName = false;
                string name = "";
                int iSimName = 0;
                while (isSimName == false)
                {
                    //Get the sim name and convert it to integer.
                    Console.ForegroundColor = ConsoleColor.Green;
                    name = Console.ReadLine();
                    Console.ResetColor();

                    //If user input is a number
                    if (int.TryParse(name, out iSimName))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Im sure you dont want to give a number name for your pet. Please input string ");
                        Console.ResetColor();
                    }

                    //If user input is null
                    else if (name == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Really ? Blank ? Come on man!!");
                        Console.ResetColor();
                    }

                    //If user input is string
                    else
                    {
                        Console.Clear();
                        isSimName = true;
                    }

                }
                return name;
            }





            //Get the player action number and convert it to integer. If it`s not number, more than 5 or negative number, ask again. 
            static int GetUserAction()
        {
                bool isUserActionValid = false;
                int iUserAction = 0;
                while (isUserActionValid == false)
                {
                    //Get the player action number.
                    Console.ForegroundColor = ConsoleColor.Green;
                    string action = Console.ReadLine();
                    Console.ResetColor();

                    //Convert player action number to integer.
                    if (int.TryParse(action, out iUserAction))
                    {
                        //If user action number is between 1 to 5
                        if (iUserAction >= 1 && iUserAction <= 5)
                        {
                            isUserActionValid = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You must select a number between 1 to 5");
                            Console.ResetColor();
                        }
                    }
                    //If input was not a number or had invalid characters
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("your input was not a number or had invalid characters");
                        Console.ResetColor();
                    }
                }
                return iUserAction;
            }


        }
    }


