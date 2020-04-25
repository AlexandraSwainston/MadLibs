using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    // ***************************************************
    //
    // Title: Capstone Project - MadLibs
    // Description: User Response Story Telling 
    // Application Type: Console
    // Author: Swainston, Alexandra
    // Dated Created: 4/24/2020
    // Last Modified: 4/25/2020
    //
    // ***************************************************

    class Program
    {
        static void Main(string[] args)
        {
            SetTheme();

            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }
        static void SetTheme()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tHello! Welcome to Mad Libs, the official game of the Queendom.");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

     

        /// <summary>
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        /// </summary>
        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Visit the Royal Library!");
                Console.WriteLine("\tb) Learn About Our Local Superheroes!");
                Console.WriteLine("\tc) All Hallows Eve in the Queendom!");
                Console.WriteLine("\td) News from the Parallel Dimension, Earth.");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayRoyalLibrary();
                        break;

                    case "b":
                        DisplaySuperheroes();
                        break;

                    case "c":
                        DisplayWitchyWonders();
                        break;

                    case "d":
                        DisplayEarth();
                        break;

                    case "q":
                        DisplayClosingScreen();
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }

        /// <summary>
        /// *****************************************************************
        /// *                        Royal Library                          *
        /// *****************************************************************
        /// </summary>
        private static void DisplayRoyalLibrary()
        {
            Console.WriteLine("Hello! Welcome to our local library! Queen Alexandra is a huge lover of books, and has been curating a collection for years.");
            Console.WriteLine("Feel free to borrow as many as you would like.");    
            Console.WriteLine();

            Console.Write("Please enter an adjective: ");
            string adjective = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            string noun = Console.ReadLine();

            Console.Write("Please enter a plural noun: ");
            string pluralnoun = Console.ReadLine();

            Console.Write("Please enter the name of a person in the room: ");
            string name = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            string adjective1 = Console.ReadLine();

            Console.Write("Please enter an article of clothing: ");
            string clothing = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Please enter a city: ");
            string city = Console.ReadLine();

            Console.Write("Please enter a plural noun: ");
            string pluralnoun1 = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            string adjective2 = Console.ReadLine();

            Console.Write("Please enter a part of the body: ");
            string bodypart = Console.ReadLine();

            Console.Write("Please enter a letter of the alphabet: ");
            string letter = Console.ReadLine();

            Console.Write("Please enter a magical creature: ");
            string magical = Console.ReadLine();

            Console.Write("Please enter a different (plural) magical creature: ");
            string magical1 = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            string adjective3 = Console.ReadLine();

            Console.Write("Please enter a place: ");
            string place = Console.ReadLine();

            Console.Write("Please enter a part of the body: ");
            string bodypart1 = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"There are many {adjective} ways to chose a/an {noun} to read.");
            Console.WriteLine($"First, you could ask for recommendations from your friends, {pluralnoun}, or even Queen Alexandra herself!");
            Console.WriteLine($"Just don't ask {name} - they only read {adjective1} books with {clothing}-ripping goddesses on the cover.");
            Console.WriteLine();
            Console.WriteLine($"If your friends and {pluralnoun} are no help, try checking out the {noun1} Review in 'The {city} Times'.");
            Console.WriteLine($"If the {pluralnoun1} featured there are too {adjective2} for your taste, try something a little more low-{bodypart},");
            Console.WriteLine($"like {letter}: The {magical} Magazine, or {magical1} Magazine.");
            Console.WriteLine();
            Console.WriteLine($"You could also chose a book the {adjective3}-fashioned way.");
            Console.WriteLine($"Head to our royal library or {place} and browse until something catches your {bodypart1}.");
            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                      Local Superheroes                        *
        /// *****************************************************************
        /// </summary>
        private static void DisplaySuperheroes()
        {
            Console.WriteLine("We have many incredible people in the Queendom! Today we'd like to tell you about one of our favorites.");
            Console.WriteLine();

            Console.Write("Please enter a name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter an unrealistic profession: ");
            string job = Console.ReadLine();

            Console.Write("Please enter a country: ");
            string country = Console.ReadLine();

            Console.Write("Please enter a strong name: ");
            string name3 = Console.ReadLine();

            Console.Write("Please enter a color: ");
            string color = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            string adjective = Console.ReadLine();

            Console.Write("Please enter a sophisticated name: ");
            string name1 = Console.ReadLine();

            Console.Write("Please enter a silly male name: ");
            string name2 = Console.ReadLine();

            Console.Write("Please enter a facial feature: ");
            string facialfeature = Console.ReadLine();

            Console.Write("Please enter a magical creature: ");
            string magic = Console.ReadLine();
            
            Console.Write("Please enter a negative adjective: ");
            string adjective3 = Console.ReadLine();
            
            Console.Write("Please enter an adverb: ");
            string adverb = Console.ReadLine();
            
            Console.Write("Please enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            string noun = Console.ReadLine();

            Console.Write("Please enter a place: ");
            string place = Console.ReadLine();            
            
            Console.Write("Please enter an adjective: ");
            string adjective4 = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Meet our hero, {name}, a super intelligent {job}. (And also a very skilled sorcerer.)");
            Console.WriteLine($"A run in with the {country} military in our neighboring dimension lead him to create his alter ego,");
            Console.WriteLine($"{name3}, the Defender, a/an {color}, {adjective} giant capable of great magnanimity, or destruction.");
            Console.WriteLine($"He defends our Queendom with his romantic partner {name1}");
            Console.WriteLine();
            Console.WriteLine($"Eventually it was discovered that {name}'s long-time colleague {name2}, distinguished by his {facialfeature},");
            Console.WriteLine($"was trying to turn {name} into a weapon, leading to a climactic (if pointless) battle in the downtown of our beloved Queendom.");
            Console.WriteLine($"{name2} is well-known for being an abysmal sorcerer, but once again reminded us by trying to lure a dangerous {magic}");
            Console.WriteLine($"through a/an {adjective3} portal. He failed {adverb}, subdued by {verb}ing him with a {noun}.");
            Console.WriteLine();
            Console.WriteLine($"{name2} has since been sent to our rehabiliation {place}, where we hope he will make a/an {adjective4} recovery.");

            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                     All Hallows Eve                           *
        /// *****************************************************************
        /// </summary>
        private static void DisplayWitchyWonders()
        {
            Console.WriteLine("All Hallows Eve is Queen Alexandra's favorite holiday! We have adopted many of Earth's holiday customs,");
            Console.WriteLine("but it also is a important holiday for us, because the veil between different dimensions is much thinner.");
            Console.WriteLine("Many families take this time to go visit the other realms, be it holidaying in Venice or swimming with the mermaids");
            Console.WriteLine("of Atlantis. You of course, are free to explore wherever you would like.");
            Console.WriteLine();
            
            Console.Write("Please enter a plural noun: ");
            string noun = Console.ReadLine();

            Console.Write("Please enter a plural noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            string noun2 = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            string noun3 = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            string noun4 = Console.ReadLine();

            Console.Write("Please enter a plural noun: ");
            string noun5 = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            string adjective = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            string adjective1 = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            string noun6 = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            string adjective2 = Console.ReadLine();

            Console.Write("Please enter a plural noun: ");
            string noun7 = Console.ReadLine();

            Console.Write("Please enter a plural noun: ");
            string noun8 = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            string adjective3 = Console.ReadLine();
            
            Console.Write("Please enter a noun: ");
            string noun9 = Console.ReadLine();

            Console.Write("Please enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Please enter a plural noun: ");
            string noun10 = Console.ReadLine();

            Console.Write("Please enter a plural noun: ");
            string noun11 = Console.ReadLine();

            Console.Write("Please enter a plural noun: ");
            string lastnounthanktheuniverse = Console.ReadLine();

            Console.Write("Please enter a verb that ends in s: ");
            string verb1 = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"All Hallows Eve is always a lot of fun. We get to dress up in {noun} and visit {noun1}");
            Console.WriteLine($"in our {noun2}, saying '{noun3} or {noun4}!' in exchange for a bag of {noun5}.");
            Console.WriteLine($"It's so {adjective}!");
            Console.WriteLine();
            Console.WriteLine($"Have you thought about what you want to dress up as? Maybe you could be a/an {adjective1} {noun6}!");
            Console.WriteLine($"Queen Alexandra herself likes to make her own costumes with {adjective2} {noun7} and {noun8}, and she");
            Console.WriteLine($"almost always wins the {adjective3} {noun9} contest. It may be rigged.");
            Console.WriteLine();
            Console.WriteLine($"We also love to {verb} {noun10} for All Hallows Eve. We put {noun11} inside, and light it up.");
            Console.WriteLine($"Of course, we also have our own {lastnounthanktheuniverse}, feel free to experience it all, and come back next year for more.");

            DisplayContinuePrompt();

        }

        /// <summary>
        /// *****************************************************************
        /// *                           Yikes                               *
        /// *****************************************************************
        /// </summary>
        static void DisplayEarth()
        {
            Console.Write("Please enter an adjective! ");
            string adjective = Console.ReadLine();

            Console.Write("Please enter a verb ending in 'ing': ");
            string verb = Console.ReadLine();

            Console.WriteLine($"Our parallel dimension, Earth, has been hit with a rampant virus.");
            Console.WriteLine($"The Coronavirus has taken a toll on everyone there, especially {adjective} people.");
            Console.WriteLine($"Queen Alexandra has recommended we cease all {verb} to their realm for the time being.");

            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for playing Mad Libs!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        private static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }
    }
}
