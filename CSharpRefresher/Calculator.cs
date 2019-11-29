using System;

namespace CSharpRefresher
{
    public class Calculator
    {
        // Constructor method: First method that is created
        // at the start of a class. Same name as the class
        // and its public.

        public Calculator()
        {

        }

        public  float Add(float n1, float n2)
        {
            return n1 + n2;
        }

        public  float Multiply(float n1, float n2)
        {
            return n1 * n2;
        }

        public  float Subtract(float n1, float n2)
        {
            return n1 - n2;
        }

        public  float Divide(float n1, float n2)
        {
            return n1 / n2;
        }
    }
}
