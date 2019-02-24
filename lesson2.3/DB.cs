using System;
using System.Collections.Generic;
using System.Text;

namespace lesson2._3
{
    public static class DB
    {

        public static Dictionary<int, int> Articles { get; set; } = new Dictionary<int, int>
        {
            { 1,100},
            { 2,200},
            { 3,300},
            { 4,400},
            { 5,500}
        };

        public static List<Account> Accounts { get; set; } = new List<Account>
        {
            new Account(1, "John", "City7"),
            new Account(2, "Anthony", "Life"),
            new Account(3, "A", "Anaconda")
        };
    }
}
