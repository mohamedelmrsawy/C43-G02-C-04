using System.Text;

namespace assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Q1 -  Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //int.TryParse(Console.ReadLine(),out int x);
            //for (int i = 0; i < x; i++) { Console.WriteLine(i+1); }

            #endregion

            #region Q2 - Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //for (int i = 5; i <= 60; i += 5) { Console.WriteLine(i); }
            #endregion

            #region Q3 - Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //for (int i = 2; i < 15; i += 2) { Console.WriteLine(i); }

            #endregion

            #region Q4 - Write a program that takes two integers then prints the power.

            //double num = Math.Pow(4, 3);
            //Console.WriteLine(num);

            #endregion

            #region Q5 - Write a program to enter marks of five subjects and calculate total, average and percentage.

            //int result = 0;

            //int[] marks = new int[5];

            //for (int i = 0; i < marks.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out marks[i]);

            //    result += marks[i];

            //}

            //Console.WriteLine(result); // 300

            //int avg = result / marks.Length;
            //Console.WriteLine(avg); // 60

            //int maximum = 500;

            //int percentage = (result / maximum) * 100;
            //Console.WriteLine(percentage);


            #endregion

            #region Q6 -  Write a program to allow the user to enter a string and print the REVERSE of it.

            //string? message = Console.ReadLine();

            //StringBuilder sb = new StringBuilder();        

            //for (int i = message.Length - 1; i >= 0; i--) { sb.Append(message[i]); } 
            //Console.WriteLine(sb);


            #endregion

            #region Q7 - Write a program to allow the user to enter int and print the REVERSED of it.


            //int[] num = new int[5];

            //for (int i = 0; i < num.Length; i++)
            //{
            //   int.TryParse(Console.ReadLine(), out num[i]);

            //}

            //Array.Reverse(num);

            //Console.WriteLine("==================================");

            //foreach (int i in num) 
            //    Console.WriteLine(i);

            #endregion

            #region Q8 - Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("enter first number : ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("enter second number : ");
            //int num2 = int.Parse(Console.ReadLine());

            //for (int i = num1; i < num2; i++)
            //{

            //    if (num2 % i == 0)
            //    {
            //        Console.WriteLine(i + "test");

            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }

            //}


            #endregion

            #region Q9 - Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("enter number : ");
            //int number01 = int.Parse(Console.ReadLine());
            //int result;
            //string result02 = string.Empty;
            //while( number01 > 0 )
            //{
            //    result = number01 % 2;
            //    number01 /= 2;
            //    result02 = result.ToString() + result02 ;
            //}

            //Console.WriteLine($"binary : {result02}");

            #endregion

            #region Q10 - Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.Write("enter x1: ");
            //int x1 = int.Parse(Console.ReadLine() ?? " null ");

            //Console.Write("enter x2: ");
            //int x2 = int.Parse(Console.ReadLine() ?? " null ");

            //Console.Write("enter x3: ");
            //int x3 = int.Parse(Console.ReadLine() ?? " null ");

            //Console.WriteLine("=========================================");

            //Console.Write("enter y1: ");
            //int y1 = int.Parse(Console.ReadLine() ?? " null ");

            //Console.Write("enter y2: ");
            //int y2 = int.Parse(Console.ReadLine() ?? " null ");

            //Console.Write("enter y3: ");
            //int y3 = int.Parse(Console.ReadLine() ?? " null ");


            //int line1 = (y2 - y1) * (x3 - x2);
            //int line2 = (y3 - y2) * (x2 - x1);

            //if (line1 == line2)
            //    Console.WriteLine("One straight line");
            //else
            //    Console.WriteLine("Not a single straight line lies");


            #endregion

            #region Q11 - Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write("enter number : ");
            //double num = double.Parse(Console.ReadLine() ?? " null ");

            //for (int i = 0; i < num; i++)
            //{

            //    for (int j = 0; j < num; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q12 - Write a program in C# Sharp to find the sum of all elements of the array.

            //Console.Write("size array : ");
            //int x = int.Parse(Console.ReadLine());
            //int[] marks = new int[x];
            //int result = 0;

            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.Write("enter number : ");
            //    int.TryParse(Console.ReadLine(), out marks[i]);

            //    result += marks[i];

            //}

            //Console.WriteLine(result);

            #endregion

            #region Q13 - Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            // Console.Write("size array : ");
            // int x = int.Parse(Console.ReadLine() ?? " null ");
            // int[] array1 = new int[x];
            // int[] array2 = new int[x];


            // for (int i = 0; i < array1.Length; i++)
            // {
            //     Console.Write("enter number (array1) : ");
            //     int.TryParse(Console.ReadLine(), out array1[i]);
            //     Console.WriteLine("==========================");

            // }

            // for (int i = 0;i < array2.Length; i++)
            // {
            //     Console.Write("enter number (array2) : ");
            //     int.TryParse(Console.ReadLine(), out array2[i]);
            //     Console.WriteLine("==========================");
            // }

            // int[] array3 = new int[x * 2];

            //// Array.Copy(array1 , array3, array1.Length);

            // for (int i = 0; i < x; i++)
            // {
            //     array3[ i] = array1[i];
            //     array3 [i + x] = array2[i];
            // }



            // Array.Sort(array3);

            // foreach (int i in array3) { Console.WriteLine(i); }

            #endregion

            #region Q14 - Write a program in C# Sharp to count the frequency of each element of an array.
            //Console.Write("size array : ");
            //int x = int.Parse(Console.ReadLine() ?? " null ");
            //int[] array1 = new int[x];

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    Console.Write("enter number (array1) : ");
            //    int.TryParse(Console.ReadLine(), out array1[i]);
            //    Console.WriteLine("==========================");

            //}

            //int num01 = 0; 

            //for (int i = 0; i < array1.Length; i++)
            //{

            //    if (array1[i] ==  2 ) {  num01++;  }

            //    //Console.WriteLine(array1[i]);
            //}

            //Console.WriteLine($"number 2 : {num01}");



            #endregion

            #region Q15 - Write a program in C# Sharp to find maximum and minimum element in an array
            //Console.Write("size array : ");
            //int x = int.Parse(Console.ReadLine() ?? " null ");
            //int[] array1 = new int[x];

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    Console.Write("enter number (array1) : ");
            //    int.TryParse(Console.ReadLine(), out array1[i]);
            //    Console.WriteLine("==========================");

            //}

            //int minimum = int.MaxValue;
            //int maximum = 0;

            //foreach(int i in array1)
            //{
            //    if (i < minimum) {  minimum = i; }
            //    if (i > maximum) { maximum = i; }
            //}


            //Console.WriteLine($"maximum : {maximum}");
            //Console.WriteLine($"minimum : {minimum}");


            #endregion

            #region Q16 - Write a program in C# Sharp to find the second largest element in an array.

            //Console.Write("size array : ");
            //int x = int.Parse(Console.ReadLine() ?? " null ");
            //int[] array1 = new int[x];

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    Console.Write("enter number (array1) : ");
            //    int.TryParse(Console.ReadLine(), out array1[i]);
            //    Console.WriteLine("==========================");

            //}

            //Array.Sort(array1);

            //Console.WriteLine(array1[array1.Length - 2]);


            #endregion

            #region Q17 - Consider an Array of Integer values with size N, having values as in this Example   

            //Console.Write("size array : ");
            //int x = int.Parse(Console.ReadLine() ?? " null ");
            //int[] array1 = new int[x];

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    Console.Write("enter number (array1) : ");
            //    int.TryParse(Console.ReadLine(), out array1[i]);

            //    Console.WriteLine("==========================");

            //}

            //int result = 0;


            //for (int i = 0;i < array1.Length; i++)
            //{
            //    if (array1[i] == 3)
            //    {
            //        result++;
            //    }
            //}

            //Console.WriteLine(result);

            #endregion

            #region Q18 - Given a list of space separated words, reverse the order of the words.

            //string test = "this is a test";
            //string[] test01 = test.Split(' ');

            //Array.Reverse(test01);

            //for (int i = 0; i < test01.Length; i++) { Console.Write(test01[i]); Console.Write(" "); }

            #endregion

            #region Q19 - Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.


            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("Enter the number of columns: ");
            //int columns = int.Parse(Console.ReadLine());


            //int[,] array1 = new int[3, 3];
            //int[,] array2 = new int[3, 3];



            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; )
            //    {
            //        Console.Write($"Element {i + 1}, {j + 1}: ");
            //        bool test = int.TryParse(Console.ReadLine(), out array1[i, j]);

            //        if (test) { j++; }
            //    }
            //}



            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; )
            //    {
            //        bool test2 = int.TryParse(Console.ReadLine(), out array2[i, j]);

            //        if (test2) { j++; }
            //    }
            //}

            //for (int i = 0; i <3; i++)
            //{
            //    Console.WriteLine($"row : {i+1} ");

            //    for (int j = 0;j < 3; j++)
            //    {
            //        Console.WriteLine($"{array1[i,j]}");
            //        Console.WriteLine($"{array2[i,j]}");
            //    }


            //}

            #endregion

            #region Q20 -  Write a Program to Print One Dimensional Array in Reverse Order

            Console.Write("size array : ");
            int x = int.Parse(Console.ReadLine() ?? " null ");
            int[] array1 = new int[x];

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("enter number (array1) : ");
                int.TryParse(Console.ReadLine(), out array1[i]);
                Console.WriteLine("==========================");

            }

            Array.Reverse(array1);

            foreach (int i in array1) { Console.WriteLine(i); }  

            #endregion

        }
    }
}
