using System;

namespace OOPCourse.Exeption_Handle
{
    internal class Exception_Handling
    {
        public void PrintDivid(int num1,int num2)
        {
            try
            {
                int result = num1 / num2;
                Console.WriteLine($"Result : {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Arr()
        {
            int[] arr = {1,2,3};
            try
            {
                Console.WriteLine(arr[10]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void MultibleCatch()
        {
            try
            {
                int i = int.Parse("ABC");
            }
            catch(Exception ex) when (ex is FormatException || ex is OverflowException)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }
}
