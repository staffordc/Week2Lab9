using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lab9RefactoringLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            var Repeat = true;
            while (Repeat)
            {
                //infos about students [3 rows matrix]
                Console.WriteLine("want to hear about students from another dimension? I know of twenty of them. input 1 to 20");
                List<List<string>> StudentsInformation = new List<List<string>>()
                {
                    new List<string>(){"Grimblo Bim", "Puce", "Grimbrew's Brew","Adventures of Bimblo"},
                    new List<string>(){"Beefaroni Phoney", "Purple", "Phoney Baloney", "Adventures of Simblo Bim" },
                    new List<string>(){"Shmaple Apple", "Red Delicious", "Apple Thumpkin Gang", "Adventures of Wimblo" },
                    new List<string>(){"Figgy Pudding", "Goldenrod", "Gromblo's Brew", "Bimblo's Adventures" },
                    new List<string>(){"Ham Hocks", "Gold", "Apple Thumpkin Ale", "Bimblo's WILD Adventures" },
                    new List<string>(){"Little Debbie", "Fire Brick", "Gromb's Cookie Stout", "Bimblo's Adventures Z:Absolute" },
                    new List<string>(){"Hanonymus Bosch", "Peach Puff", "Gromb's Peach Delight", "Bimblo's Adventures Zettai" },
                    new List<string>(){"Billy billy von Billy", "Deep Sky Blue", "Blue Gold Apple", "Bimblo's Adventures the Beginning" },
                    new List<string>(){"Fitzhugh Nicely", "Pale Turquoise", "Skrumpkin Lager", "Bimblo's Absolute Adventure" },
                    new List<string>(){"Bob the Beggar", "Plum", "Skrumpkin Ale", "Bimblo's WILD Romp" },
                    new List<string>(){"Half-wit Henry", "Medium Sea Green", "Skrumpkin Stout", "Bimblo's WILD Rompin' Stomp" },
                    new List<string>(){"Legs Akimbo", "Beige", "Grimbrew's Brew: Gold", "Bimblo's Adventures: The Next Generation" },
                    new List<string>(){"Rott Weiler", "Green", "Grimbrew's St. Paddy's Day Cider", "Bimblo's Romp" },
                    new List<string>(){"Tito Watts", "Chartreuse", "Gromblo's Ale" , "Bimblo's Adventure"},
                    new List<string>(){"Henry Bo Benry", "Medium Purple", "Gromblo's Stout" , "Adventures of Wimblo: Z"},
                    new List<string>(){"John Silva", "Tan", "Gromblo's Pommblo Stout", "Adventures of Wimblo & Bimblo" },
                    new List<string>(){"Gnome Johnson", "Orange", "Gromblo's Orange Saison", "Adventures of Simblo & Bimblo" },
                    new List<string>(){"Jerome Smonson", "Dark Green", "Gromblo's Light Ale", "Adventures of Simblo Bim Bimblo" },
                    new List<string>(){"Som Wattson", "Green Yellow", "Gromblo's Lemon Shandy", "Simblo: Adventures"},
                    new List<string>(){"Ratt Chatterson", "Burly Wood", "Grimbrew's Yummy Scrumptious Stout", "Simblo: Adventures:Z"},
                };

                //student nums; name out
                var number = ReadLineButItHasToBeANumberBetweenOneAndTwenty();
                //student is...
                
                var index = number - 1;
                var student = StudentsInformation[index];
                Console.WriteLine($"student {number} is {student[0]}");
                //student info 1, or info 2?
                Console.WriteLine($"would you like to know more about {student[0]}? put in either favorite color or favorite beer or favorite show.");
                int choice = returnEitherFavColorOrFavBeer();
                if (choice == 1)
                {
                    Console.WriteLine($"Their favorite color is {student[1]}");
                }
                else if (choice == 2)
                {
                    Console.WriteLine($"Their favorite beer is {student[2]}");
                }
                else if (choice == 3)
                {
                    Console.WriteLine($"Their favorite show is {student[3]}");
                }
                Repeat = Retry();
            }

        }

        static int returnEitherFavColorOrFavBeer()
        {
            var input = Console.ReadLine().ToLower();
            if (input == "favorite color")
            {
                return 1;
            }
            else if (input == "favorite beer")
            {
                return 2;
            }
            else if (input ==  "favorite show")
            {
                return 3;
            }
            else
            {
                Console.WriteLine("please input favorite beer or favorite color");
                return returnEitherFavColorOrFavBeer();
            }
        }

        static int ReadLineButItHasToBeANumberBetweenOneAndTwenty()
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out var number) && number >= 1 && number <= 20)
            {
                return number;
            }
            else
            {
                Console.WriteLine("i noticed this is not a number between 1 and 20. could you make it be a number between one and twenty?");
                return ReadLineButItHasToBeANumberBetweenOneAndTwenty();
            }
        }

        static bool Retry()
        {
            Console.WriteLine("\ncontinue? yes or no please.");
            String Answer = Console.ReadLine().ToUpper();

            if (Answer == "Y" || Answer == "YES")
            {
                return true;
            }
            else if (Answer == "N" || Answer == "NO")
            {
                return false;
            }
            else
            {
                Console.WriteLine("\ni don't know that. please input y or n.");
                return Retry();
            }
        }
    }
}
