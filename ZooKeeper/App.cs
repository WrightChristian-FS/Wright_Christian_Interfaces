﻿using System;
using System.Collections.Generic;

namespace ZooKeeper
{
    public class App
    {
        //Requried fields and properties 
        public static List<string> menuList = new List<string>();
        public static List<string> selectedAnimalList = new List<string>();
        public static List<Animals> animalList = new List<Animals>(); 
        public string title; 

        public App()
        {
            //Bool to continue application
            bool continueApp = true;

            //Create list for the main menu & selected animal list 
            AddAnimal();
            AnimalBehavior(); 


            while (continueApp)
            {
                
                //Initiate and print the the Menu
                Menu.Init("Welcome to the Zoo", menuList);
                Menu.Display();


                Console.Write("\r\nPlease enter your selection: ");
                UI.InputUI();
                int animalSelection = Validation.MenuSelectionValidation(Console.ReadLine(), menuList.Count);
                UI.StandardUI();

                //Hold the variable in an Animals variable for later use
                Animals selectedAnimal = animalList[animalSelection - 1];

                
                //Handle the user selection 
                if(animalSelection == (menuList.Count + 1))
                {
                    continueApp = false;
                    Console.WriteLine("\r\nGoodbye..");
                } else
                {
                    //Enter a switch case that will change based on the animal selection

                    Menu.Init(selectedAnimal.Species, selectedAnimalList);
                    Menu.Display();

                    Console.Write("Please select an action: ");

                    UI.InputUI();
                    int userActionChoice = Validation.MenuSelectionValidation(Console.ReadLine(), selectedAnimalList.Count);
                    UI.StandardUI();


                    switch (userActionChoice )
                    {
                        case 1:

                            //Train
                            if (selectedAnimal is ITrainable)
                            {

                                //Clear the console 
                                Console.Clear();

                                //Print the menu header
                                UI.HeaderUI();
                                Console.WriteLine("==========================");
                                Console.WriteLine($"   Train the {animalList[animalSelection - 1].Species}");
                                Console.WriteLine("==========================\r\n");
                                UI.StandardUI();


                                //Ask the user what the behaivor they would like the animal to do?
                                Console.Write($"What new behavior are you training the {animalList[animalSelection -1].Species} to do: ");
                                UI.InputUI();
                                string newTrick = Validation.StringValidation(Console.ReadLine());
                                UI.StandardUI();

                                //Ask the user what signial they will use?
                                Console.Write($"What signial will you use for the {animalList[animalSelection - 1].Species} to {newTrick}: ");
                                UI.InputUI();
                                string trickSignal = Validation.StringValidation(Console.ReadLine());
                                UI.StandardUI();

                  
                                //Handle the train method based on species type
                                if (selectedAnimal.Species == "Chimpanzee")
                                {
                                    ////Send the information to the train function 
                                    Chimpanzee confirmTrick = (Chimpanzee)animalList[animalSelection - 1];
                                    string printTrick = confirmTrick.Train(trickSignal, newTrick);
                                    Console.WriteLine(printTrick);

                                }
                                else if (selectedAnimal.Species == "Dolphin")
                                {
                                    //Send the information to the train function 
                                    Dolphin confirmTrick = (Dolphin)animalList[animalSelection - 1];
                                    string printTrick = confirmTrick.Train(trickSignal, newTrick);
                                    Console.WriteLine(printTrick);


                                }
                                else if (selectedAnimal.Species == "Tiger")
                                {
                                    //Send the information to the train function 
                                    Tiger confirmTrick = (Tiger)animalList[animalSelection - 1];
                                    string printTrick = confirmTrick.Train(trickSignal, newTrick);
                                    Console.WriteLine(printTrick);


                                }


                            } else
                            {
                                Console.WriteLine($"\r\n{animalList[animalSelection -1].Species} is not a trainable animal! ");
                            }


                            break;

                        case 2:

                            //Feed the animal 
                            Animals.Eat(animalList[animalSelection - 1]);    
                            break;

                        case 3:
                            //Signal to preform
                            if (animalList[animalSelection - 1] is ITrainable)
                            {
                                Console.WriteLine("\r\nPerformed a trick!");
                            }
                            else
                            {
                                Console.WriteLine($"\r\n{animalList[animalSelection - 1].Species} can not perform because it is not a trainable animal!");
                            }

                            break;

                        case 4:

                            //Grab the animal noise and print to the console 
                            string animalNoise  = animalList[animalSelection - 1].MakeNoise();
                            Console.WriteLine($"\r\nThe {(animalList[animalSelection - 1]).Species} goes {animalNoise}");
                            break;

                        case 5:
                            //Select Different animal 
                                                    
                            break;

                        case 6:
                            //Exit the program

                            break;
                    }
                }

                Continue();

            }
        }



        public static void AddAnimal()
        {
            menuList.Add("Chimpanzee (Trainable)");
            menuList.Add("Crocodile");
            menuList.Add("Dolphin (Trainable)");
            menuList.Add("Condor");
            menuList.Add("Tiger (Trainable)");
            menuList.Add("Camel");

            Chimpanzee chimpanzee = new Chimpanzee("Chimpanzee", "Banana");
            Crocodile crocodile = new Crocodile("Crocodile", "Turkey");
            Dolphin dolphin = new Dolphin("Dolphin", "Fish");
            Condor condor = new Condor("Condor", "Rat");
            Tiger tiger = new Tiger("Tiger", "Chicken");
            Camel camel = new Camel("Camel", "grains");

            animalList.Add(chimpanzee);
            animalList.Add(crocodile);
            animalList.Add(dolphin);
            animalList.Add(condor);
            animalList.Add(tiger);
            animalList.Add(camel);


        }

        public static void Continue()
        {

            Console.WriteLine("\r\nPress any key to continue..");
            Console.ReadLine();
            Console.Clear(); 
        }

        public static void AnimalBehavior()
        {
            //List to hold the menu options 
            List<string> selectedAnimalMenu = new List<string>();

            selectedAnimalMenu.Add("Train the animal in a new behaivor");
            selectedAnimalMenu.Add("Feed the animal a treat");
            selectedAnimalMenu.Add("Signal the animal to perform a behavior");
            selectedAnimalMenu.Add("Listen to the animal make a noise");
            selectedAnimalMenu.Add("Select a diffent animal");

            //Add to the selected animal list
            selectedAnimalList = selectedAnimalMenu; 
        }
    }
}
