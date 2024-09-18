﻿using System;

namespace PresidentEligibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Are you a natural-born citizen of the United States? (yes/no): ");
            string isCitizen = Console.ReadLine().ToLower(); 

            Console.WriteLine("How many years have you been a resident of the United States?: ");
            int yearsOfResidency = int.Parse(Console.ReadLine());

            Console.WriteLine("How many terms have you served?");
            int termsServed = int.Parse(Console.ReadLine());

            // Determine eligibility based on the user's input
            bool eligible = CheckEligibility(age, isCitizen, yearsOfResidency, termsServed);

            // Display result
            if (eligible)
            {
                Console.WriteLine("You are eligible to become the President of the United States!");
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligible to become the President of the United States.");
            }
        }

        // Ccheck eligibility based on age, citizenship, and residency
        static bool CheckEligibility(int age, string isCitizen, int yearsOfResidency, int termsServed)
        {
            // Eligibility conditions
            bool isOldEnough = age >= 35;
            bool isNaturalBornCitizen = isCitizen == "yes";
            bool hasSufficientResidency = yearsOfResidency >= 14;
            bool termsLeft = termsServed < 2;
            
            return isOldEnough && isNaturalBornCitizen && hasSufficientResidency && termsLeft;
        }
    }
}
