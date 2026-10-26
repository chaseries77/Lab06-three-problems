/*
 * Name: Chase Ries
 * Course: CSCI 1250, Section 002
 * Assignment: Lab 06, Three Short Problems
 * Date: October 23, 2026
 * Description: A menu that keeps running until the user quits, offering three
 * independent exercises or all three at once. Each exercise 
 * practices decisions and one of the four loops.
 */


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

    if (choice == 1 || choice == 4)
    {
        Console.WriteLine(" === Step 1: The Grade Checker ===");
        Console.Write("Enter a score between 0 and 100: ");
        int score = Convert.ToInt32(Console.ReadLine());
        while(score < 0 && score > 100)
        {
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


if (choice == 2 || choice == 4)
    {
        System.Console.WriteLine("=== Exercise 2: The Dice Table ===");
        int rollNumber = 1;
        int winNumber = 0;
        bool diceGameActive = true;

        do
        {
        
            int die1 = rng.Next(1,7);
            int die2 = rng.Next(1,7);
            
            //Output message
            System.Console.Write($"Roll {rollNumber}: {die1} and {die2}, total {die1+die2}. ");
            
            if(die1 == 1 && die2 == 1)
            {
                System.Console.WriteLine("Snake Eyes.");
            }
            else if(die1 == die2)
            {
                System.Console.WriteLine("Doubles!");
            }
            else if(die1+die2 == 7 || die1+die2 == 11)
            {
                System.Console.WriteLine("A winner.");
                ++winNumber;
            }
            else
            {
                System.Console.Write("");
            }

            Console.Write("Would you like to play again? Yes or no?");
            char rollAgain = Console.ReadLine().ToUpper()[0];

            while(rollAgain != 'Y' && rollAgain != 'N')
        {
            Console.Write("Invalid answer.Roll again? Yes or no? ");
            rollAgain = Console.ReadLine().ToUpper()[0];
        }
        
            if(rollAgain == 'N')
            {
                DiceGameCheck(rollNumber, winNumber);
                Console.Write("");
                diceGameActive = false;
            }
            if(rollAgain == 'Y')
            {
                ++rollNumber;
            }
        }while(diceGameActive);

    }
    
    if (choice == 3 || choice == 4)
    {
        
        System.Console.WriteLine("=== Exercise 3: The Score Report ===");
        int[] scores = new int[5];
        
        for(int i = 0; i < scores.Length; i++)
        {
            scores[i] = Convert.ToInt32(Console.ReadLine());
            while(scores[i] < 0 && scores[i] > 100)
            {
            Console.WriteLine("Choose a score: ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }
        }
        int highestGrade = scores[0];
        int totalGrade = 0;
        int passingGrade = 0;
        foreach(int score in scores)
        {
            totalGrade += score;
            if(score > highestGrade)
            {
                highestGrade = score;
            }
            if(score > 60)
            {
                ++passingGrade;
            }

        }
        double avg = (double)totalGrade/scores.Length;

        System.Console.WriteLine($"Scores entered: {scores.Length}");
        System.Console.WriteLine($"Total: {totalGrade}");
        System.Console.WriteLine($"Average: {avg:F1}");
        System.Console.WriteLine($"Highest: {highestGrade}");
        System.Console.WriteLine($"Passing {passingGrade} of {scores.Length}");

    }

}while(choice != 5);

System.Console.WriteLine("Goodbye.");

static void DiceGameCheck(int rollNumber, int wins)
{
    if(rollNumber == 1)
    {
        if(wins == 0)
        {
            System.Console.WriteLine($"You rolled once and lost.");
        }
        else
        {
            System.Console.WriteLine($"You rolled once and won.");
        }
        
    }
    else
    {
        if(wins == 0)
        {
            System.Console.WriteLine($"You rolled {rollNumber} times and lost every game.");
        }
        else if(wins == 1)
        {
            System.Console.WriteLine($"You rolled {rollNumber} times and won once.");
        }
        else if(wins > 1)
        {
            System.Console.WriteLine($"You rolled {rollNumber} times and won {wins} times.");
        }
    }
}