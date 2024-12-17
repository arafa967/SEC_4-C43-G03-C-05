namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (1)

            //int num = 10;
            //update(num);
            //Console.WriteLine(num);  //Not Changes (num = 5)
            //// 2- Passing by Reference:
            ////the memory address of the original variable is passed to the method.
            ////This means that any changes made to the parameter inside the method will
            ////affect the original variable outside the method.
            //updatere(ref num);
            //Console.WriteLine(num); // output(num = 20)
            #endregion

            #region  (2)  

            //Person person = new Person { Name = "John" };
            //update(person); // Passing by value
            //Console.WriteLine("Person's Name after method call: " + person.Name);
            ////2- Passing Reference Type by Reference:
            //// the method receives the memory address of the original object.
            //// This means the method can modify the original reference itself,
            //// not just the object it points to.
            //// and will affect the original variable in the calling method
            //Person person00 = new Person { Name = "John" };
            //updatere(ref person00); // Passing by reference using 'ref'
            //Console.WriteLine("Person's Name after method call: " + person.Name); // Output: "Mohamed"
            #endregion

            #region (3) 
            //Console.Write("Enter The 1st Number: ");
            //int.TryParse(Console.ReadLine(), out int num1);
            //Console.Write("Enter The 2nd Number: ");
            //int.TryParse(Console.ReadLine(), out int num2);
            //calculator(num1, num2, out int sum, out int sub);
            //Console.WriteLine($"{num1} + {num2} = {sum}\n{num1} - {num2} = {sub}");
            #endregion

            #region (4) 
            //Console.Write("Enter A Number: ");
            //int.TryParse(Console.ReadLine(), out int sum);
            //Console.WriteLine($"The Sum Of The Digits Of The Number {sum}: {sumDigits(sum)}");
            #endregion

            #region (5) 
            //Console.Write("Enter A Number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine(IsPrime(num));
            #endregion

            #region (6) 
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size < 2)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1}: ");
            //        while (!(int.TryParse(Console.ReadLine(), out arr[i])))
            //            Console.WriteLine("Please Enter An Integer");
            //    }
            //    MinMaxArray(arr, out int max, out int min);
            //    Console.WriteLine($"The Maximum Number: {max}\nThe Minimum Number: {min}");
            //}
            #endregion

            #region (7) 
            //bool flag;
            //int num;
            //do
            //{
            //    Console.Write("Enter The Number: ");
            //    flag = int.TryParse(Console.ReadLine(), out  num);
            //} while (!flag || num == 0);
            //Console.WriteLine($"Factorial of {num} is: { Factorial(num)}");
            #endregion

            #region (8) 
            //Console.Write("Enter The Text: ");
            //string str = Console.ReadLine();
            //Console.Write("Enter The Position: ");
            //int.TryParse(Console.ReadLine(), out int pos);
            //Console.Write("Enter The New Char: ");
            //char.TryParse(Console.ReadLine(), out char c);
            //string newStr = ChangeChar(str, pos, c);
            //Console.WriteLine($"Original string: {str}");
            //Console.WriteLine($"Modified string: {newStr}");
            #endregion

        }
    }
}
