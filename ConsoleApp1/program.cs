using System;

        class Num
        {
          public  int num1;
          public  int num2;
        }
class Program
{
    static void Main()
    {
        #region 1
        Console.WriteLine("please enter a number:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("You entered: " + num);
        #endregion

        #region 2
        string input = "12345ab";

        int result = int.Parse(input);

        Console.WriteLine("result " + result);

        // /ms-dotnettools.csharp-2.84.19-linux-x64/.debugger/vsdbg
        // --interpreter=vscode --connection=/tmp/CoreFxPipe_vsdbg-ui-2bb0c738b8704f108d101ddfd519575e 
        // Unhandled exception. System.FormatException:
        // The input string '12345ab' was not in a correct format.
        // at System.Number.ThrowFormatException[TChar](ReadOnlySpan`1 value)
        // at System.Int32.Parse(String s)
        // at Program.Main() in /home/ethar/Desktop/c#_pro/ConsoleApp1/program.cs:line 16

        #endregion

        #region 3

        double num1 = 6.5;
        double num2 = 2.4;

        double result = num1 + num2;

        Console.WriteLine("The result is: " + result);

        // /ms-dotnettools.csharp-2.84.19-linux-x64/.debugger/
        // vsdbg --interpreter=vscode --connection=/tmp/CoreFxPipe_vsdbg-
        // ui -acddcec9dc504b39bb8bc7c305dc7074 
        // The result is: 8.9
        #endregion


        #region 4

        string str = "Ethar osama";

        string SubS = str.Substring(6); 

        Console.WriteLine("Substring: " + SubS);


        #endregion


        #region 5
        int num1 = 10;
        int num2 = 20; 

        num2 = num1;    

        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

        // /ms-dotnettools.csharp-2.84.19-linux-x64/.
        // debugger /vsdbg --interpreter=vscode
        // --connection=/tmp/CoreFxPipe_vsdbg-ui-
        // c99bfc3911194f5f96e88b3329b8b7dc 
        // num1 = 10
        // num2 = 10

        // هنا اخد نسخه من الvar 

        #endregion



        #region 6




        Num a = new Num();
        a.num1 = 10;
        a.num2 = 20;

        Num b = a;

        Console.WriteLine($"a.num1 = {a.num1}");
        Console.WriteLine($"b.num1 = {b.num1}");

        // /ms-dotnettools.csharp-2.84.19-linux-x64/.
        // debugger /vsdbg --interpreter=vscode --connection=/
        // tmp /CoreFxPipe_vsdbg-ui-5a3f390cb84b49ab93150883240fbfb7 
        // a.num1 = 10
        // b.num1 = 10


        // kda 8ero bl2dress bta3o fmemorry



        #endregion



        #region 7


        string Fname = "ethar";
        string Lname = "osama";

        string FullN = Fname+ " "+ Lname;

        Console.WriteLine($"FullName: {FullN}");

        #endregion


        #region 8


        float MMoney = 1000;
        float rate = 5;
        float time = 2; 

        float interest = (MMoney * rate * time) / 100;

        Console.WriteLine("Simple Interest: " + interest);



        #endregion



        #region 9

        double weight = 80;  
        double height = 175; //height in cm

        double BMI = weight / (height * height);

        Console.WriteLine("BMI: " + BMI);



        #endregion



        #region 10

        Console.Write("Enter temp: ");
        int Temp = int.Parse(Console.ReadLine());

        string res;

        if (Temp< 10)
        {
            res = "Just Cold";
        }
        else if (Temp> 30)
        {
            res = "Just Hot";
        }
        else
        {
            res = "Just Good";
        }

        Console.WriteLine("Temp: " + res);




        #endregion



        #region 11


        Console.Write("Enter D: ");
        int D = int.Parse(Console.ReadLine());

        Console.Write("Enter M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Enter Y: ");
        int Y = int.Parse(Console.ReadLine());

        Console.WriteLine($"Today's date : {D} , {M} , {Y}");
        Console.WriteLine($"Today's date : {D} / {M} / {Y}");
        Console.WriteLine($"Today's date : {D} - {M} - {Y}");



        #endregion



        #region 12


        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 3 == 0 && num % 4 == 0)
            Console.WriteLine("Yes");

        else
            Console.WriteLine("No");


        #endregion



        #region 13


        Console.Write("Enter a num: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("negative");
        }
        else
        {  
            Console.WriteLine("positive");
        }

        #endregion


        #region 14


        int[] nums = new int[3];

        for (int i = 0; i < 3; i++)
        { 
            Console.Write($"Enter number {i + 1}: ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        int max = nums[0];
        int min = nums[0];

        for (int i = 1; i < 3; i++)
        {
            if (nums[i] > max)
                max = nums[i];
            if (nums[i] < min)
                min = nums[i];
        }

        Console.WriteLine("Max element = " + max);
        Console.WriteLine("Min element = " + min);


        #endregion


        #region 15


        Console.Write("Enter a num: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("The number is Even.");
        }
        else
        {
            Console.WriteLine("The number is Odd.");
        }

        #endregion


        #region 16


        Console.Write("Enter a character: ");
        char chr = char.Parse(Console.ReadLine());


        if (chr == 'a' || chr == 'e' || chr == 'i' || chr == 'o' || chr == 'u')

            Console.WriteLine("Vowel");

        else

            Console.WriteLine("Consonant");



        #endregion



        #region 17
        

        Console.Write("Enter month number: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int Y= int.Parse(Console.ReadLine());

        int D = 0;

        if (M == 1 || M == 3 || M == 5 || M == 7 ||
            M == 8 || M == 10 || M == 12)
        {
            D = 31;
        }
        else if (M == 4 || M== 6 || M == 9 || M == 11)
        {
            D = 30;
        }
        else if (M == 2)
        {
            if ((Y % 4 == 0 && Y % 100 != 0) || (Y% 400 == 0))
            {
                D = 29;
            }
            else
            {
                D = 28;
            }
        }
        else
            Console.WriteLine("Invalid month number.");
    
     

        Console.WriteLine("Days in Month:" + D);


        #endregion

    }


    
}

