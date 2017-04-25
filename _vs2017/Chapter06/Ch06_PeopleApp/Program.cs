using System;
using Packt.CS7;
using static System.Console;

namespace Ch06_PeopleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

            var p0 = new Person();
            p0.inst();

            var p1 = new Person();
            p1.Name = "Don Jones";
            p1.DateOfBirth = new DateTime(1947, 10, 26);
            var datetime = new DateTime();
            p1.inst();
            WriteLine(p1.GetOrigin(datetime));
            ReadLine();
            var p2 = new Person {
                Name = "David Abrahamowitz",
                DateOfBirth = new DateTime(1934, 7, 6)
            };
            p2.inst();
            WriteLine(p2.GetOrigin(datetime));
            ReadLine();

            p1.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            WriteLine($"{p1.Name}'s favorite wonder is {p1.FavoriteAncientWonder}");
            ReadLine();

            p1.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |
                WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            //p1.BucketList = (WondersOfTheAncientWorld)18;
            WriteLine($"{p1.Name}'s bucket list is {p1.BucketList}");
            ReadLine();
            p1.Children.Add(new Person());
            p1.Children.Add(new Person());
            WriteLine($"{p1.Name} has {p1.Children.Count} children.");
            ReadLine();

            string homeplanet = "";
            WriteLine(p1.GetOrigin(homeplanet));
            WriteLine(p2.GetOrigin(homeplanet));
            ReadLine();

            BankAccount.InterestRate = 0.012M;
            var acct1 = new BankAccount();
            acct1.AccountName = "Mr. Abrahamowitz";
            acct1.Balance = 21387.16M;
            WriteLine($"{acct1.AccountName} earned {acct1.Balance*BankAccount.InterestRate:C} interest.");
            var acct2 = new BankAccount();
            acct2.AccountName = "Mr. Morris";
            acct2.Balance = 62.48M;
            WriteLine($"{acct2.AccountName} earned {acct2.Balance*BankAccount.InterestRate:C} interest.");
            ReadLine();
            
            var p3 = new Person("Alfador");
            p3.inst();

            // C#4 tuple
            Tuple<string, int> oldfruit = p1.GetFruitCS4();
            WriteLine($"There are {oldfruit.Item2} {oldfruit.Item1}.");

            // C#7 tuple
            (string, int) newfruit = p1.GetFruitCS7();
            WriteLine($"{newfruit.Item1}, {newfruit.Item2} there are.");
            ReadLine();

            var fruitNamed = p1.GetNamedFruit();
            WriteLine($"You say there are {fruitNamed.Number} {fruitNamed.Name}?");

            (string fruitName, int fruitNumber) = p1.GetFruitCS7();
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

        }
        
    }
}