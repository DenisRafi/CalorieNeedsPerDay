using System;

class ByDenisRafi
{
    static void Main()
    {
        Console.Title = "Calorie Needs per Day";
        Console.WriteLine("Welcome To My Calorie Counter App." + "\n" +
        "Please enter Weight in pounds (lbs.), Height in inches, Age, Gender, Workouts per week."
        + "\n" + "Example : 181, 72, 20, M or F, 3");
        
        decimal weightPounds = decimal.Parse(Console.ReadLine());
        decimal heightInches = decimal.Parse(Console.ReadLine());
        decimal age = decimal.Parse(Console.ReadLine());
        string gender = Console.ReadLine();
        decimal workoutsPerWeek = decimal.Parse(Console.ReadLine());

        decimal weightKg = (weightPounds / 2.2m);
        decimal heightSm = (heightInches * 2.54m);

        decimal menBMR = 0;
        decimal femaleBMR = 0;
        if (gender == "M")
        {
            menBMR = (66.5m + (13.75m * weightKg) + (5.003m * heightSm) - (6.755m * age));
        }
        else if (gender == "F")
        {
            femaleBMR = (655 + (9.563m * weightKg) + (1.850m * heightSm) - (4.676m * age));
        }
        else
        {
            Console.WriteLine("Please Enter \"F\"\"M\"");
        }

        decimal menDCI = 0;
        if (workoutsPerWeek <= 0)
        {
            menDCI = (menBMR * 1.2m);
        }
        else if (workoutsPerWeek == 1 || workoutsPerWeek == 2 || workoutsPerWeek == 3)
        {
            menDCI = (menBMR * 1.375m);
        }
        else if (workoutsPerWeek == 4 || workoutsPerWeek == 5 || workoutsPerWeek == 6)
        {
            menDCI = (menBMR * 1.55m);
        }
        else if (workoutsPerWeek == 7 || workoutsPerWeek == 8 || workoutsPerWeek == 9)
        {
            menDCI = (menBMR * 1.725m);
        }
        else
        {
            menDCI = (menBMR * 1.9m);
        }

        if (gender == "M")
        {
            Console.WriteLine("{0}", Math.Floor(menDCI));
        }
        decimal femaleDCI = 0;
        if (workoutsPerWeek <= 0)
        {
            femaleDCI = (femaleBMR * 1.2m);
        }
        else if (workoutsPerWeek == 1 || workoutsPerWeek == 2 || workoutsPerWeek == 3)
        {
            femaleDCI = (femaleBMR * 1.375m);
        }
        else if (workoutsPerWeek == 4 || workoutsPerWeek == 5 || workoutsPerWeek == 6)
        {
            femaleDCI = (femaleBMR * 1.55m);
        }
        else if (workoutsPerWeek == 7 || workoutsPerWeek == 8 || workoutsPerWeek == 9)
        {
            femaleDCI = (femaleBMR * 1.725m);
        }
        else
        {
            femaleDCI = (femaleBMR * 1.9m);
        }        
        if (gender == "F")
        {
            Console.WriteLine("{0}", Math.Floor(femaleDCI));
        }
        Console.ReadKey();
    }
}
  