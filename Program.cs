 class Program
{
    public static bool Issame(int num1, int num2)
    {
        // The main idea is using modulos. the quotient of modulo is last digit of the number.there using modulo allows us to compare the last digits
        // so for example 123 mod 10, we get 3 as the remainder which is our last digit for 123. and 456 mod 10 also gives remainder of 6.
        // then we compare 3 and 6 and return true if they same, false if not.
        // using Absulte value since the question asks for the non negetive integers, in this case if we check for example: -12 and 542,
        // using absultoe value for both number, negative signs won't affect the actual value.

        return Math.Abs(num1 % 10) == Math.Abs(num2 % 10);

    }
    public static void Exercise1() 
    {
        
            //QUESTION 1: Write a C# Sharp program to check if two given non-negative integers have the same last digit.

            Console.WriteLine(Issame(123, 456));
            Console.WriteLine(Issame(12, 512));
            Console.WriteLine(Issame(7, 87));
            Console.WriteLine(Issame(12, 45));
            Console.WriteLine(Issame(-321, 41));
    }
    public static void Exercise2() 
    {
        //QUESTION 2: Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
        var count = 0;
        string userid, password;
        do
        {
            Console.Write("Enter userid: ");
            userid = Console.ReadLine();

            Console.Write("Enter password: ");
            password = Console.ReadLine();

            count++;

        }
        while (((userid != "Nana") || (password != "key")) && (count != 3));
        if (count == 3)
            Console.Write("Attempt ends: REJECTED!!");
        else
            Console.Write("Correct Password!");
    }
    public static void Exercise3() 
    {
        //QUESTION 3: program to read roll no, name and marks of three subjects and calculate the total, percentage and division.

        Console.Write("Enter roll number: ");
        var rollnumber = Console.ReadLine();

        Console.Write("Enter name: ");
        var name = Console.ReadLine();

        Console.Write("Enter marks for Physics: ");
        int Physics = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Chemistry: ");
        int chemistry = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Computer Application: ");
        int ComputerApp = Convert.ToInt32(Console.ReadLine());

        int total = Physics + chemistry + ComputerApp;
        double percentage = total / 3;
        // Console.WriteLine("Total marks is: " + total);
        // Console.WriteLine("Percentage is: " + percentage);

        Console.WriteLine("Roll number: " + rollnumber);
        Console.WriteLine("Name of student: " + name);
        Console.WriteLine("Marks in Physics: " + Physics);
        Console.WriteLine("Marks in Chemistry: " + chemistry);
        Console.WriteLine("Marks in Computer App: " + ComputerApp);
        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Percentage: " + percentage);


        //If precentage is greater than 60 then this is "First" division
        //If percentage is between 48 and 60 then this is "Second" division
        //If percentage is between 36 and 40 then this is "Pass" result
        //If precentage is lower than 36 this is "Fail" result

        if (percentage >= 60)
        {
            Console.WriteLine("First Division");

        }
        else if (percentage >= 48 && percentage <= 60)
        {
            Console.WriteLine("Second Division");
        }
        else if (percentage >= 36 && percentage <= 40)
        {
            Console.WriteLine("Pass");
        }
        else
            Console.WriteLine("Fail");

    }
    public static void Exercise4() 
    {
        //QUESTION 4. Write a program in C# Sharp to display the n terms of even natural number and their sum.
        var sum = 0;
        Console.Write("Enter n terms: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i * 2);
            sum += 2 * i;

        }

        Console.WriteLine("The sum of the numbers are: " + sum);

    }
    public static void Exercise5() 
    {
        //QUESTION 5: Write a program in C# Sharp to insert New value in the array (sorted list).
        //Maximum array size may be limited by fixed number of elements (for example, 10).

        //Declare a fixed array of size 10
        int[] myarray = new int[10];
        int position = 0;

        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < n; i++)
        {
            Console.Write("element {0} : ", i);
            Console.Write("Elements in array: ");
            myarray[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Insert new value in the array 
        Console.Write("Enter value to be inserted: ");
        int Newvalue = Convert.ToInt32(Console.ReadLine());
        //var newarray = new int[n + 1];

        Console.WriteLine("The old list: ");
        for (int i = 0; i < n; i++)
            Console.WriteLine(myarray[i]);

        // position of the new element inside the array
        for (int i = 0; i < n; i++)
        {

            if (Newvalue < myarray[i])
            {
                position = i;

            }

        }

        for (int i = n; i >= position; i--)
        {
            myarray[i] = myarray[i - 1];
            myarray[position] = Newvalue;
        }



        Console.WriteLine("After insert, new list of array is: ");
        for (int i = 0; i <= n; i++)
            Console.WriteLine(myarray[i]);
    }
    public static void Exercise6() 
    {
        //QUESTION 6: Write a C# Sharp program to reverse a given string in uppercase
        var mystring = "";
        var reverse = "";
        Console.Write("Enter a string: ");
        mystring = Console.ReadLine();

        //now we need to find the lenght of our entered string
        var length = mystring.Length - 1;
        while (length >= 0)
        {
            reverse = reverse + mystring[length];
            length--;
        }
        Console.WriteLine("The reverse string is {0}", reverse.ToUpper());
    }
    public static void Exercise7() 
    {

        // QUESTION 7: Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
        Console.Write("Enter a digit: ");
        var number = Convert.ToInt32(Console.ReadLine());
        int mod;
        int sum = 0;
        while (number > 0)
        {
            //here we find the modulo of the number 
            mod = number % 10;
            sum = sum + mod;
            number = number / 10;
        }
        Console.WriteLine("The sum is {0}", sum);
    }
    public static void Exercise8() 
    {
        //QUESTION 8: Write a program in C# Sharp to count the number of digits in a number using recursion
        Console.Write("Enter a number: ");
        var number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (number > 0)
        {
            number = number / 10;
            count++;
        }
        Console.WriteLine("The number of digit is {0}", count);
    }
    public static void Exercise9()
    {
        //QUESTION 9: Write a program in C# Sharp to display the top n-th records of List collection using LINQ
        var list = new List<int>() { 5, 7, 13, 24, 6, 9, 8, 7 };
        Console.WriteLine("The elements of the list are: ");

        for (var i = 0; i < list.Count; i++)
            Console.WriteLine(list[i]);

        Console.Write("Enter the n-th records: ");
        var ntop = Convert.ToInt32(Console.ReadLine());

        list.Sort();
        list.Reverse();

        Console.WriteLine("The top n-th records of the list are: ", ntop);
        foreach (int top in list.Take(ntop))
        {
            Console.WriteLine(top);
        }
    }
    public static void Exercise10()
    {
        //Write a program in C# Sharp to create a file and write an array of strings to the file.
        string[] file = new string[] { "This is the frst line", "This is the secondline" };
        File.WriteAllLines("newfile.txt", file);
        using (StreamReader readfile = new StreamReader("newfile.txt"))
        {
            string r = readfile.ReadToEnd();
            Console.WriteLine(r);
        }
    }
    private static void Main(string[] args)
    {
        //Exercise1();
        // Exercise2();
        //Exercise3();
       // Exercise4();
        //Exercise5();
        //Exercise6();
        //Exercise7();
        Exercise8();
        //Exercise9();
        //Exercise10();
    }
}