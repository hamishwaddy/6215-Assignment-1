﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOneCommon
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("****** Task 1: User Registration Form *******");
            Console.WriteLine("******* Hamish Wadsworth, ID: 9835077 *******");
            Console.WriteLine("*********************************************\n\n");
        }

        public static void ExitApp()
        {
            Console.WriteLine("\n\nYou have completed this program.\nPress any key to exit");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You didn't enter a valid {fieldName}.");
        }

        
    }
}
