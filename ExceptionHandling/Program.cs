// See https://aka.ms/new-console-template for more information

#region IndexOutOfRangeException

Console.Write("Enter position of array: ");
try
{
    int positionOfArr = int.Parse(Console.ReadLine());
    GetArrayPosition(positionOfArr);
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine("Program One Ended\n\n");

#endregion

//Methods ONE to handle IndexOutOfRangeException
static void GetArrayPosition(int position)
{
    int[] arr = { 5, 6, 7, 8, 9 };

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    Console.WriteLine();
    Console.WriteLine($"The position of {position} in the list has value of {arr[position]}");
}

#region DivideByZeroException

try
{
    Console.Write("Enter Value for num1 value: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Enter Value for num2 value: ");
    int num2 = int.Parse(Console.ReadLine());

    Divide(num1, num2);
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine("Program Two Ended\n\n");



#endregion

//Methods TWO to handle DivideByZeroException
static void Divide(int num1, int num2)
{
    int num3 = num1 / num2;
    Console.WriteLine($"The division of {num1} by {num2} is {num3}");

}

#region ArrayTypeMismatchException
Console.WriteLine("Below Handles the ArrayTypeMismatchException");

try
{
    int[] arr1 = { 45, 54 };
    string[] arr2 = { "giddy", "dozie" };
    string[] arr3 = { "yghj", "cgvhj" };
    Array.Copy(arr1, arr3, 2);
}
catch (ArrayTypeMismatchException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine("Program Three Ended\n\n");

#endregion


#region NullReferenceException

try
{
    string value3 = null;
    Console.WriteLine($"text {value3.Length}");
}
catch (NullReferenceException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine("Program Four Ended\n\n");

#endregion

#region IOException

try
{
    string[] numbers = File.ReadAllLines(@"C:\Users\user\Desktop\C#\cypherJorney\Week7\num.txt");

    foreach (var item in numbers)
    {
        Console.WriteLine(item);
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine();
}
Console.WriteLine("Program Five Ended");

#endregion

#region Stack OverFlow Exception

Console.Write("Enter your input number: ");

try
{
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine($"The sum of the integers less than or equal to {num} is {SumOfValues(num)}.");

}
catch (StackOverflowException e)
{

    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine("Program Six Ended\n\n");

//Method 3 
static int SumOfValues(int number)
{
    if (number == 0) return 0;
    else return number + SumOfValues(number - 1);
}

#endregion

#region InvalidCastException 

var miObject = new Object();

try
{
    int num1, num2, num3;
    double num4;
    num1 = 25;
    num4 = 33.54775;

    Console.WriteLine($"Original value is {num4}");
    num2 = (int)num4;

    Console.WriteLine($"Final value is {num2}");
    num3 = (int)miObject;
}
catch (InvalidCastException e)
{
    Console.WriteLine(e.Message);
    
}
Console.WriteLine("Program Seven Ended\n\n");

#endregion