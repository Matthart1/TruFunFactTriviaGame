using System;

namespace Game2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //If you are reading this code, know that is was writen intentinally. i know it is not best practice but was done to use differing elements and formating.
            //sorry if it becomes hard to read but there are hopefully plenty of notes to help you understand what or why something is what it is.

            Console.WriteLine("Well hey there friend! Would you like to play a little game? Yes or No? fyi, we are case sensitive here ;)");
            var yesOrNo = Console.ReadLine();
            if (yesOrNo == "Yes")
            {
                Console.WriteLine("Hell Yeah!! Lets get started!");
                QuestionTwo();
                QuestionOne();          //Note that questionOne and questionTwo are not in order. Simply to show you can call out of order, or not at all. 
                QuestionThree();
                QuestionFour();
                QuestionFive();
                QuestionSix();          //Everything is called in the order its needed in the main method. Thats all that goes in there.
                QuestionSeven();        //Everything else goes into separate methods and is referenced at its turn
                QuestionEight();
                TheEnd();               //The game runs because the questions are inside the 'Yes' responce
            }
            else if (yesOrNo == "No")
            {
                no();           //'no();' method is called for a negative responce and skips the questions. I.E. Game is over
            }
            else
            {
                no();           //Or for no/incorrect responce in this case
            }
            static void QuestionOne()
            {
                Console.WriteLine("What was the original color of oranges?");
                var answer1 = Console.ReadLine();
                if (answer1 == "Green")
                {
                    Console.WriteLine("Thats correct! Wild right?!");
                }
                else
                {
                    Console.WriteLine("Sorry, maybe you'll get the next one!");
                }
            }
            static void QuestionTwo()           //Method name is Pascal Casing. Remember.
            {
                Console.WriteLine("There is one letter that isnt used in any US state name, can you guess it?");
                var answer2 = Console.ReadLine();   //'answer2' variable is Camel Casing. Remember.
                if (answer2 == "Q")
                {
                    Console.WriteLine("Thats right!");
                }
                else
                {
                    Console.WriteLine("Sorry, try another one.");
                }
            }
            static void QuestionThree()
            {
                Console.WriteLine("The country of Scotland has 421 words for what item?");
                var answer3 = Console.ReadLine();
                if (answer3 == "Snow")
                {
                    Console.WriteLine("Thats Correct!! I guess it snows a lot there!");
                }
                else
                {
                    Console.WriteLine("Good guess! Yet sadly no. :/");
                }
            }
            static void QuestionFour()
            {
                Console.WriteLine("Fun fact: Peanuts are not nuts! So what are they?" +
                    " A:Peas" +
                    " B:Lagoons" +
                    " C:Seeds");
                bool win = false;
                do
                {

                    var answer4 = Console.ReadLine();
                    if (answer4 == "A")
                    {
                        Console.WriteLine("Nope! Give it another go!");
                    }
                    else if (answer4 == "B")
                    {
                        Console.WriteLine("That is correct! Great job!");
                        win = true;
                    }
                    else if (answer4 == "C")
                    {
                        Console.WriteLine("Not quite, Ill let you give it another try this go around!");
                    }
                    else
                    {
                        Console.WriteLine("You have to put A, B, C");
                    }
                } while (win == false);
            }
            static void QuestionFive()
            {
                Console.WriteLine("Most US presidents have had a collection of pets but Teddy Roosevelt had" +
                        " one of the most notable. What pet did he keep? A:Tiger B:Shark C:Hyena");
                bool win = false;
                do
                {
                    var answer5 = Console.ReadLine();
                    if (answer5 == "A")
                    {
                        Console.WriteLine("Sorry, no. Give it another try!");
                    }
                    else if (answer5 == "B")
                    {
                        Console.WriteLine("I wish, that would be so cool. try agian.");
                    }
                    else if (answer5 == "C")
                    {
                        Console.WriteLine("Yes!! I would love a Hyena!! What a bad ass.");
                        win = true;
                    }
                    else
                    {
                        Console.WriteLine("Its got to be A, B, or C");
                    }

                } while (win == false);
            }
            static void QuestionSix()
            {
                Console.WriteLine("So like most large businesses, the CIA has a starbucks in the building. Whats " +
                    "different about this one? A:Its been the location of two assasinations. " +
                    "B:They dont write names on the cups." +                        // I need to figure out how to type a paragraph in console
                    " C:You need a secret password to get in. ");
                bool win = false;
                do
                {
                    var answer6 = Console.ReadLine();
                    if (answer6 == "A")
                    {
                        Console.WriteLine("That would be pretty a neat story but no. Guess again.");
                    }
                    else if (answer6 == "B")
                    {
                        Console.WriteLine("Yes... The lame answer is correct.");
                        win = true;
                    }
                    else if (answer6 == "C")
                    {
                        Console.WriteLine("The password is 'incorrect' which is also what you are, try again. ");
                    }
                    else
                    {
                        Console.WriteLine("The answer needs to be either A, B, or C.");
                    }
                } while (win == false);
            }
            static void QuestionSeven()
            {
                Console.WriteLine("How much was the original script of 'Terminator' sold for? A: &10,000 B: $100,000 C: $1");
                bool correct = true;
                do
                {
                    var question7 = Console.ReadLine();             // this was just a little 'switch case' practice, i know its not necessary.

                    switch (question7)
                    {
                        case "A":
                            Console.WriteLine("Nope! Go Again!");
                            break;
                        case "B":
                            Console.WriteLine("They Wish! Go Again!");
                            break;
                        case "C":
                            Console.WriteLine("Correct! Kinda sad right?");
                            correct = false;
                            break;
                        default:
                            Console.WriteLine("Answer needs to be A, B, or C");
                            break;
                    }
                } while (correct == true);
            }
            static void QuestionEight()
            {
                Console.WriteLine("How long can a giraffe tongue get in inches?");
                bool correct = false;
                do
                {
                    var answer8 =int.Parse(Console.ReadLine());          // This was a test to see if a statement would overlap or stop where another takes over. It stopped.
                    if (answer8 >= 21)
                    {
                        Console.WriteLine("Go down some!");
                    }
                    else if (answer8 <= 5)
                    {
                        Console.WriteLine("Way off! Up.");              //Made to use an extended if statement
                    }
                    else if (answer8 <= 10)
                    {
                        Console.WriteLine("Gonna have to do better! Go up!");
                    }
                    else if (answer8 <= 15)
                    {
                        Console.WriteLine("Not far off but you got to go up some!");
                    }
                    else if (answer8 <= 19)
                    {
                        Console.WriteLine("So close");
                    }
                    else if (answer8 == 20)
                    {
                        Console.WriteLine("Spot on!!");
                        correct = true;
                    }
                    else       //Not nes but sure looks good
                    {
                        Console.WriteLine("Was that even a real answer?");
                    }
                } while (correct == false);
            }
            static void TheEnd()
            {
                Console.WriteLine("So did you like the game?");
                bool game = true;
                do
                {
                    var answer7 = Console.ReadLine();       // Only repeats as long as an invalid responce is applied 
                    if (answer7 == "Yes")
                    {
                        Console.WriteLine("Awesome!! Happy you enjoyed it!");
                        game = false;
                    }
                    else if (answer7 == "No")
                    {
                        Console.WriteLine("Awe, Im sorry you didnt have fun.");
                        game = false;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, i did catch that.");
                    }
                    Console.ReadLine();
                } while (game == true);         //Think of the bool as more of a password to leave out of the loop. the natural value of true/false doesnt matter. just a place holder
            }
            static void no()            // Stands alone until called by a negative statement in the opening question, may never be called... hopefully.
            {
                Console.WriteLine("Well i guess we dont have to play rigth now.");

            }
        }
    }
}
