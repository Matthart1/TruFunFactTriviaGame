using System;

namespace Game2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("Well hey there friend! Would you like to play a little game? Yes or No? fyi, we are case sensitive here ;)");
            var yesOrNo = Console.ReadLine();
            if (yesOrNo == "Yes")
            {
                Console.WriteLine("Hell Yeah!! Lets get started!");
                questionOne();
                questionTwo();
                questionThree();
                questionFour();
                questionFive();
                questionSix();
                questionSeven();
                questionEight();
                theEnd();
            }
            else if (yesOrNo == "No")
            {
                no();
            }
            else
            {
                no();
            }
            static void questionOne()
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
            static void questionTwo()
            {
                Console.WriteLine("There is one letter that isnt used in any US state name, can you guess it?");
                var answer2 = Console.ReadLine();
                if (answer2 == "Q")
                {
                    Console.WriteLine("Thats right!");
                }
                else
                {
                    Console.WriteLine("Sorry, try another one.");
                }
            }
            static void questionThree()
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
            static void questionFour()
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
            static void questionFive()
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
            static void questionSix()
            {
                Console.WriteLine("So like most large businesses, the CIA has a starbucks in the building. Whats " +
                    "different about this one? A:Its been the location of two assasinations. " +
                    "B:They dont write names on the cups." +
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
            static void questionSeven()
            {
                Console.WriteLine("How much was the original script of 'Terminator' sold for? A: &10,000 B: $100,000 C: $1");
                bool correct = true;
                do
                {
                    var question7 = Console.ReadLine();

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
            static void questionEight()
            {
                Console.WriteLine("How long can a giraffe tongue get in inches?");
                bool correct = false;
                do
                {
                    var answer8 =int.Parse(Console.ReadLine());
                    if (answer8 >= 21)
                    {
                        Console.WriteLine("Go down some!");
                    }
                    else if (answer8 <= 5)
                    {
                        Console.WriteLine("Way off! Up.");
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
                } while (correct == false);
            }
            static void theEnd()
            {
                Console.WriteLine("So did you like the game?");
                bool game = true;
                do
                {
                    var answer7 = Console.ReadLine();
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
                } while (game == true);
            }
            static void no()
            {
                Console.WriteLine("Well i guess we dont have to play rigth now.");

            }
        }
    }
}
