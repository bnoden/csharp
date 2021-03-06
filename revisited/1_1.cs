/*
1. An old Arabian legend has it that a fabulously wealthy but unthinking king agreed to give a 
beggar one cent and double the amount for 64 days. Then determine on which day the king will 
have paid the beggar a total of one million dollars. Using this information, write at C#
 program that 
displays how much the king must pay the beggar on each day. 
 Output should be displayed in 
dollars with two decimal places, not pennies.   Do not hardcode the values. Outpu
t should look 
similar to below.
Sample Run:  
Day      Amount Owed 
---      ----------- 
 1        0.01 
 2        0.02 
 3        0.04 
 ... 
64        92233720368547760.00
On day 27 the king paid a total of one million dollars 
*/

using System;

class Program {
    static void Main(string[] args) {
        decimal pay = 0.01m;
        int day = 0, bigDay = 0;

        Console.WriteLine("Day\tAmount Owed\n---\t-----------");

        while (day<64) {
            if (pay >= 1_000_000 && bigDay < 1) { bigDay = day; }
            day++;
            Console.WriteLine($"{day}\t{pay:c2}");
            pay*=2;
        }
        Console.WriteLine(
            $"\nOn day {bigDay} the king paid a total of one million dollars."
            );
    }
};