using System;
using System.Collections.Generic;
using System.IO;


namespace Capstone_Project
{
    #region  Program Summary
    // *******************************
    // Title: Capstone_Project
    // Description: Main Menu Program for Capstone Project
    // Application Type: Console
    // Author: Cole Crain
    // Dated Created: 11/18/2019
    // Last Modified: 11/30/2019
    // Description: I am changing forground and background color.
    // and I would like to store information on people.
    // *******************************
    #endregion

    class Program
    {
        #region Main Display Screen 

        /// <summary>
        /// Main Display Screens
        /// <summary>
        static void Main(string[] args)
        {
            PreSetTheme();

            DisplayWelcomeScreen();

            // initialize people list
            //List<People> peoples = InitializePeopleList();
            List<People> peoples = ReadFromDataFile();

            DisplayMenuScreen(peoples);
            DisplayClosingScreen();
        }

        #endregion

        //--Todo Reword Theme For Better User Experiece
        #region All Theme

        #region PreSet Theme

        static void PreSetTheme()
        {
            string FdataPath = @"Data\FTheme.txt";
            string foregroundColorString;
            ConsoleColor foregroundColor;

            foregroundColorString = File.ReadAllText(FdataPath);
            Enum.TryParse(foregroundColorString, out foregroundColor);
            Console.ForegroundColor = foregroundColor;

            string BdataPath = @"Data\BTheme.txt";
            string backgroundColorString;
            ConsoleColor backgroundColor;

            backgroundColorString = File.ReadAllText(BdataPath);
            Enum.TryParse(backgroundColorString, out backgroundColor);
            Console.BackgroundColor = backgroundColor;

        }
        #endregion

        #region  Foreground
        static void UpdateForegroundTheme()
        {
            string userResponse;
            string foregroundColorString;
            ConsoleColor foregroundColor;
            string dataPath = @"Data\FTheme.txt";
            bool ValidResponse = false;

            do
            {
                DisplayScreenHeader("Get Fore-Ground Theme");
                Console.WriteLine("Enter The color to set the letters color");
                Console.WriteLine("Color Options: Red, Green, Yellow, Black, Blue, Cyan, Gray, White.");
                Console.WriteLine("Very Important: Write Colors as written");
                Console.Write("Enter the Desired Text Color: ");
                userResponse = Console.ReadLine().Trim();

                switch (userResponse)
                {
                    case "Red":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    case "Green":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    case "Yellow":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    case "Black":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    case "Blue":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    case "Cyan":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    case "White":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    case "Gray":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("This is not a valid color.");
                        Console.WriteLine("Please Enter Correct Color");
                        DisplayContinuePrompt();
                        break;
                }
            } while (!ValidResponse);

            foregroundColorString = File.ReadAllText(dataPath);
            Enum.TryParse(foregroundColorString, out foregroundColor);
            Console.ForegroundColor = foregroundColor;

        }
        #endregion

        #region Background
        static void UpdateBackgroundTheme()
        {
            string userResponse;
            string backgroundColorString;
            ConsoleColor backgroundColor;
            string dataPath = @"Data\BTheme.txt";
            bool ValidResponse = false;

            do
            {
                DisplayScreenHeader("Get Back-Ground Theme");
                Console.WriteLine("Enter The color to set the screen behind the words or font");
                Console.WriteLine("Color Options: Red, Green, Yellow, Black, Blue, Cyan, Gray, White.");
                Console.WriteLine("Very Important: Write Colors as written");
                Console.Write("Enter the Desired Text Color: ");
                userResponse = Console.ReadLine().Trim();

                switch (userResponse)
                {
                    case "Red":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    case "Green":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    case "Yellow":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    case "Black":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    case "Blue":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    case "Cyan":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    case "White":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    case "Gray":
                        ValidResponse = true;
                        File.WriteAllText(dataPath, userResponse);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("This is not a valid color.");
                        Console.WriteLine("Please Enter Correct Color");
                        DisplayContinuePrompt();
                        break;
                }
            } while (!ValidResponse);

            backgroundColorString = File.ReadAllText(dataPath);
            Enum.TryParse(backgroundColorString, out backgroundColor);
            Console.BackgroundColor = backgroundColor;
        }
        #endregion

        #endregion

        /// <summary>
        /// Menu Choices
        /// </summary>
        static void DisplayMenuScreen(List<People> peoples)
        {
            bool quitApplication = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Main Menu Choices");

                // get user menu choice    
                Console.WriteLine("\ta) Change Background and Foreground");
                Console.WriteLine("\tb) List All People");
                Console.WriteLine("\tc) View a People");
                Console.WriteLine("\td) Add a new Person");
                Console.WriteLine("\te) Delete a existing Person");
                Console.WriteLine("\tf) Update People");
                Console.WriteLine("\tg) Add to the Data File");
                Console.WriteLine("\th) Read from Data File");
                Console.WriteLine("\tq) Quit the Application");
                Console.Write("\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                // process user menu choice               
                switch (menuChoice)
                {
                    case "a":
                        YesOrNo();
                        break;

                    case "b":
                        DisplayAllPeoples(peoples);
                        break;

                    case "c":
                        //--Todo Validate Name input
                        DisplayViewPeople(peoples);
                        break;

                    case "d":
                        DisplayAddPeople(peoples);
                        break;

                    case "e":
                        DisplayDeletePeople(peoples);
                        break;

                    case "f":
                        DisplayUpdatePeople(peoples);
                        break;
                                            
                    case "g":
                        DisplayWriteToDataFile(peoples);
                        break;

                    case "h":
                        DisplayFromDataFile();
                        ReadFromDataFile();
                        break;

                    case "q":
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease Enter a letter for the Menu Choices.");
                        DisplayContinuePrompt();
                        break;
                }
            } while (!quitApplication);
        }

        #region Display People

        /// <summary>
        /// Display Update People
        /// </summary>       
        static void DisplayUpdatePeople(List<People> peoples)
        {
            string name;
            string userResponse;
            People selectedPeople = null;
            bool validResponse = false;

            do
            {
                DisplayScreenHeader("Update People");

                // list all people names
                Console.WriteLine("\tList of People");
                Console.WriteLine("\t ****************");
                foreach (People people in peoples)
                {
                    Console.WriteLine("\t" + people.Name);
                }

                // user choose a people
                Console.WriteLine();
                Console.Write("\tEnter Name you would like to update:");
                name = Console.ReadLine();

                // get people object
                foreach (People people in peoples)
                {
                    if (people.Name == name)
                    {
                        selectedPeople = people;
                        validResponse = true;
                        break;
                    }
                }

                // feed back for wrong person name
                if (!validResponse)
                {
                    Console.WriteLine("\tPlease enter correct name");
                    Console.WriteLine("\tto change their the persons details.");
                    DisplayContinuePrompt();
                }
            } while (!validResponse);

            // todo -- add below
            // Update People properties
            Console.WriteLine();
            Console.WriteLine("\tTo keep the existing information, press the enter key.");
            if (selectedPeople != null)
            {
                Console.Write($"\tCurrent Name: {selectedPeople.Name} New Name: ");
                userResponse = Console.ReadLine();
                if (userResponse != "")
                {
                    selectedPeople.Name = userResponse;
                }

                Console.Write($"\tCurrent Age: {selectedPeople.Age} New Age: ");
                userResponse = Console.ReadLine();
                if (userResponse != "")
                {
                    int.TryParse(userResponse, out int age);
                    selectedPeople.Age = age;
                }

                Console.Write($"\tCurrent Attitude: {selectedPeople.Attitude} New Attitude: ");
                userResponse = Console.ReadLine();
                if (userResponse != "")
                {
                    Enum.TryParse(userResponse, out People.EmotionalState attitude);
                    selectedPeople.Attitude = attitude;
                }

                Console.Write($"\tCurrent Favorite Color: {selectedPeople.Color} New Favorite Color: ");
                userResponse = Console.ReadLine();
                if (userResponse != "")
                {
                    Enum.TryParse(userResponse, out People.FavoriteColor color);
                    selectedPeople.Color = color;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"{name} was not found");
            }

            // echo updated people properties
            Console.WriteLine();
            Console.WriteLine("\tNew Persons Properties");
            Console.WriteLine("\t************");
            PeopleInfo(selectedPeople);
            Console.WriteLine();
            Console.WriteLine("\t************");

            DisplayContinuePrompt();
        }

        /// <summary>
        /// Display Delete People
        /// </summary>    
        static void DisplayDeletePeople(List<People> peoples)
        {
            string name;
            People selectedPeople = null;
            bool validResponse = false;

            DisplayScreenHeader("\tDelete People");

            do
            {
                // list all peoples names
                Console.WriteLine("\tList of all the People");
                Console.WriteLine("\t ****************");
                foreach (People people in peoples)
                {
                    Console.WriteLine("\t" + people.Name);
                }

                // user choose a people
                Console.WriteLine();
                Console.Write("\tEnter Name that you want to Delete:");
                name = Console.ReadLine();

                // get people object
                foreach (People people in peoples)
                {
                    if (people.Name == name)
                    {
                        selectedPeople = people;
                        break;
                    }
                }

                // feed back for wrong Person name              
                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("\tPlease enter correct name");
                    Console.WriteLine("\tof the person you want to delete");

                    DisplayContinuePrompt();
                    break;
                }
            } while (!validResponse);

            // Delete people
            if (selectedPeople != null)
            {
                peoples.Remove(selectedPeople);
                Console.WriteLine();
                Console.WriteLine($"\t{selectedPeople.Name} was deleted.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"\tSorry, {name} was not found");
            }
            DisplayContinuePrompt();
        }

        //--Todo Validate Name input
        /// <summary>
        /// Display View People
        /// </summary>
        static void DisplayViewPeople(List<People> peoples)
        {
            string name;
            bool validResponse = true;
            People peopleToView = null;

            DisplayScreenHeader("\tView Peoples Details");
            do
            {
                // list all peoples names
                Console.WriteLine("\tList of all the People");
                Console.WriteLine("\t ****************");

                foreach (People people in peoples)
                {
                    Console.WriteLine("\t" + people.Name);

                }

                // user choose a person
                Console.WriteLine();
                Console.WriteLine("\tName With Proper Capitalization");
                Console.Write("\tEnter Name Here:");
                name = Console.ReadLine();

                //todo Test out for validation
                if (peopleToView == null)
                {
                    name = Console.ReadLine();
                    if (name != "")
                    {
                        peopleToView.Name = name;
                    }
                }

            } while (!validResponse);

            // get person 
            foreach (People people in peoples)
            {
                if (people.Name == name)
                {
                    peopleToView = people;
                    break;
                }
            }
            // display people details
            do
            {
                Console.WriteLine();
                Console.WriteLine("\t*********************");
                PeopleInfo(peopleToView);
                Console.WriteLine("\t*********************");

                DisplayContinuePrompt();

            } while (false);
        }

        /// <summary>
        /// Display Add People
        /// </summary>
        static void DisplayAddPeople(List<People> peoples)
        {
            //--todo validate
            do
            {
                People newPeople = new People();

                DisplayScreenHeader("\tAdd People");

                // get people properties from user
                Console.WriteLine();
                Console.Write("\tEnter Name:");
                newPeople.Name = Console.ReadLine();

                Console.Write("\tEnter Age:");
                int.TryParse(Console.ReadLine(), out int age);
                newPeople.Age = age;

                Console.Write("\tEnter Attitude:");
                Enum.TryParse(Console.ReadLine(), out People.EmotionalState attitude);
                newPeople.Attitude = attitude;

                Console.Write("\tEnter Favorite Color:");
                Enum.TryParse(Console.ReadLine(), out People.FavoriteColor color);
                newPeople.Color = color;

                // echo use properties
                Console.WriteLine();
                Console.WriteLine("\tPeople Properties");
                Console.WriteLine();
                Console.WriteLine("*********************");
                // Console.WriteLine();
                PeopleInfo(newPeople);

                DisplayContinuePrompt();

                peoples.Add(newPeople);

            } while (false);
        }

        /// <summary>
        /// Display All People
        /// </summary>
        static void DisplayAllPeoples(List<People> peoples)
        {
            DisplayScreenHeader("\tAll Peoples");

            Console.WriteLine("\t************************");
            foreach (People people in peoples)
            {
                PeopleInfo(people);
                Console.WriteLine();
                Console.WriteLine("\t************************");
            }
            DisplayContinuePrompt();
        }

        #endregion

        #region FILE I/O METHODS

        /// <summary>
        /// SCREEN: write list of people to data file
        /// </summary>       
        static void DisplayWriteToDataFile(List<People> peoples)
        {
            DisplayScreenHeader("\tWrite to Data File");

            // prompt the user to continue
            Console.WriteLine("\tThe application is ready to write to the data file.");
            Console.Write("\tEnter 'yes' to continue or 'no' to cancel.");

            if (Console.ReadLine().ToLower() == "yes")
            {
                // process I/O exceptions               
                Console.WriteLine();
                WriteToDataFile(peoples);
                Console.WriteLine("\tList Written to the data file.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("\t List not written to the data file.");
            }
            DisplayContinuePrompt();
        }

        /// <summary>
        /// write people list to data file
        /// </summary>      
        static void WriteToDataFile(List<People> peoples)
        {
            string[] peoplesString = new string[peoples.Count];

            //ToDo Write to File
            // create array of people strings           
            for (int index = 0; index < peoples.Count; index++)
            {
                string peopleString =
                    peoples[index].Name + "," +
                    peoples[index].Age + "," +
                    peoples[index].Attitude + "," +
                    peoples[index].Color;

                peoplesString[index] = peopleString;
            }
            File.WriteAllLines(@"Data\Data.txt", peoplesString);
        }

        /// <summary>
        /// read people from data file and return a list of people
        /// </summary>           
        static List<People> ReadFromDataFile()
        {
            List<People> peoples = new List<People>();

            // read all lines in the file
            string[] peoplesString = File.ReadAllLines(@"Data\Data.txt");

            // create people objects and add to the list
            foreach (string PeopleString in peoplesString)
            {
                // get individual properties           
                string[] peopleProperties = PeopleString.Split(',');

                // create people              
                People newPeople = new People();

                // update people property values               
                newPeople.Name = peopleProperties[0];

                int.TryParse(peopleProperties[1], out int age);
                newPeople.Age = age;

                Enum.TryParse(peopleProperties[2], out People.EmotionalState attitude);
                newPeople.Attitude = attitude;

                Enum.TryParse(peopleProperties[3], out People.FavoriteColor color);
                newPeople.Color = color;

                // add new people to list                
                peoples.Add(newPeople);
            }
            return peoples;
        }

        /// <summary>
        /// Display From Data File
        /// </summary>
        static void DisplayFromDataFile()
        {
            DisplayScreenHeader("\tDisplay people from Data File");

            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"Data\Data.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            Console.WriteLine();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();

            DisplayContinuePrompt();
        }

        #endregion

        #region HELPER METHODS

        /// <summary>
        /// To Change theme Yes Or No 
        /// </summary>
        static void YesOrNo()
        {
            string userResponse;

            DisplayScreenHeader("\tAbout Theme");
            Console.WriteLine("\tIf You want to chamge Color of theme Please type: [yes]");
            Console.WriteLine("\tIf You do not want to change theme type: [no]");
            Console.Write("\tEnter Here:");
            userResponse = Console.ReadLine().Trim().ToUpper();

            switch (userResponse)
            {
                case "YES":
                    UpdateForegroundTheme();
                    UpdateBackgroundTheme();
                    break;

                case "NO":
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("\tThis is not a valid option");
                    Console.ReadKey();
                    break;
            }
        }

        /// <summary>
        /// Initialize people list
        /// </summary>
        static List<People> InitializePeopleList()
        {
            List<People> peoples = new List<People>()
            {
                new People()
                {
                    Name = "Sid",
                    Age = 145,
                    Attitude = People.EmotionalState.happy,
                    Color = People.FavoriteColor.green
                },

                new People()
                {
                    Name = "Lusy",
                    Age = 100,
                    Attitude = People.EmotionalState.bored,
                    Color = People.FavoriteColor.purple
                },

                new People()
                {
                    Name = "Bob",
                    Age = 120,
                    Attitude = People.EmotionalState.sad,
                    Color = People.FavoriteColor.blue
                },

                new People()
                {
                    Name = "Hail",
                    Age = 137,
                    Attitude = People.EmotionalState.angry,
                    Color = People.FavoriteColor.red
                },

                 new People()
                {
                    Name = "Gail",
                    Age = 107,
                    Attitude = People.EmotionalState.ok,
                    Color = People.FavoriteColor.none
                }

            };
            return peoples;
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        /// <summary>
        /// display welcome screen
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tWelcome To My Capstone Project");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using This Application!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// Peoples Info
        /// </summary>
        static void PeopleInfo(People people)
        {
            //--Todo Validate Name input

            Console.WriteLine($"\tName: {people.Name}");
            Console.WriteLine($"\tAge: {people.Age}");
            Console.WriteLine($"\tAttitude: {people.Attitude}");
            Console.WriteLine("\t" + people.Greeting());
            Console.WriteLine($"\tColor: {people.Color}");
            Console.WriteLine("\t" + people.FavColor());

        }

        #endregion
    }
}
