/*
 * Name: Chase Ries
 * Course: CSCI 1250, Section 002
 * Assignment: Lab 06, Three Short Problems
 * Date: October 23, 2026
 * Description: A menu that keeps running until the user quits, offering three
 * independent exercises or all three at once. Each exercise 
 * practices decisions and one of the four loops.
 */

bool programActive = true;
int choice = 0;
Random rng = new Random(4000);

do
{
    Console.WriteLine("=== CSCI 1250 Lab 06 ===");
    Console.WriteLine("1. The Grade Checker: ");
    Console.WriteLine("2. The Dice Table: ");
    Console.WriteLine("3. The Score Report: ");
    Console.WriteLine("4. All three: ");
    Console.WriteLine("5. Quit: ");

    Console.Write("Choose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());
    while(choice < 1 && choice > 5)
    {
        Console.WriteLine("Choose a number 1 through 5: ");
        choice = Convert.ToInt32(Console.ReadLine());
    }

    if (choice == 0)
    {
        programActive = false;
    }

    if (choice == 1 || choice == 4)
    {
        Console.WriteLine(" === Step 1: The Grade Checker ===");
        Console.Write("Enter a score between 0 and 100: ");
        int score = Convert.ToInt32(Console.ReadLine());
        while(score < 0 && score > 100)
        {
            Console.Write("Enter a VALID score 0-100");
            score = Convert.ToInt32(Console.ReadLine());
        }


    if(score < 60)
    {
        Console.WriteLine($"{score} earns a letter F.");
    }
    else if(score >= 60 && score < 70)
    {
        Console.WriteLine($"{score} earns a D.");
    }
    else if(score >= 70 && score < 80)
    {
        Console.WriteLine($"{score} earns a C. ");
    }
    else if(score >= 80 && score < 90)
    {
        Console.WriteLine($"{score} earns a B. ");
    }
    else if(score >= 90)
    {
        Console.WriteLine($"{score} earns a A. ");
    }
        
    }

}while (programActive);