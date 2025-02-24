using System;


namespace OOP_Course.Linear_System_
{
    internal class LinearSystem
    {
        public LinearSystem(double []array) 
        {
            if (array.GetLength(0) == array.GetLength(1))
                Array = array;
            else
                Console.WriteLine("Can not find solution");
        }
        public double[] Array;

        private void LinearSystem_01(double [,]array,double[] vars,double [,]results)
        {
             

        }
    }
}
