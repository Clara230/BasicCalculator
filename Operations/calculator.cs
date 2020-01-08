using System;

using Operations;

namespace BasicCalculator

{

    public class Calculator

    {
        public int result;

        public int Subtract(int a, int b)

        {
            result = Subtraction.Subtract(a, b);

            return result;

        }

        public int Divide(int a, int b)

        {

            result = Division.Divide(a, b);

            return result;

        }

    }

}
