using System;
using Packt.CS7;
using static System.Console;

namespace Ch06_PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Name = "Don Jones";
            p1.DateOfBirth = new DateTime(1947, 10, 26);
            WriteLine($"{p1.Name} was born on {p1.DateOfBirth:dddd, d MMMM yyyy}");

            var p2 = new Person {
                Name = "David Abrahamowitz",
                DateOfBirth = new DateTime(1934, 7, 6)
            };
            WriteLine($"{p2.Name} was born on {p2.DateOfBirth:d MMM yy}");

            p1.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            WriteLine($"{p1.Name}'s favorite wonder is {p1.FavoriteAncientWonder}");

            p1.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |
                WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            //p1.BucketList = (WondersOfTheAncientWorld)18;
            WriteLine($"{p1.Name}'s bucket list is {p1.BucketList}");

            p1.Children.Add(new Person());
            p1.Children.Add(new Person());
            WriteLine($"{p1.Name} has {p1.Children.Count} children.");

            WriteLine($"{p1.Name} comes from {p1.HomePlanet}");
            WriteLine($"{p2.Name} comes from {p2.HomePlanet}");

            BankAccount.InterestRate = 0.012M;
            var ba1 = new BankAccount();
            ba1.AccountName = "Mr. Abrahamowitz";
            ba1.Balance = 21387.16M;
            WriteLine($"{ba1.AccountName} earned {ba1.Balance*BankAccount.InterestRate:C} interest.");
            var ba2 = new BankAccount();
            ba2.AccountName = "Mr. Morris";
            ba2.Balance = 62.48M;
            WriteLine($"{ba2.AccountName} earned {ba2.Balance*BankAccount.InterestRate:C} interest.");

        }
    }
}