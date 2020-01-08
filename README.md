using System;

namespace Operations

{

    public class Addition

    {


        public static int Sum (int a, int b)

        {

            return a + b;
        }

        public static double Sum(double a, double b)
        {
            return a + b;

        }


        public static double Sum(double[] arrayA)



        {



            double c = 0.0;







            foreach (double a in arrayA) 



            {



                c = Sum(a, c);



            }



            return c;



        }







        public static int Sum(int[] arrayB)



        {



            int d = 0;







            foreach (int a in arrayB)



            {



                d = Sum(a, d);



            }



            return d;



        }







    }



}
44 Operations/Division.cs 



@@ -0,0 +1,44 @@



using System;



using System.Collections.Generic;



using System.Text;







namespace Operations



{



    public class Division



    {







        public static int Divide(int a, int b)



        {



            return a / b;



        }







        public static double Divide(double a, double b)



        {



            return a / b;



        }







        public static double Divide(double[] arrayA)



        {



            double c = arrayA[0];







            foreach (double a in arrayA)



            {



                c = Divide(c, a);



            }



            double d = c * arrayA[0];



            return d;



        }







        public static int Divide(int[] arrayB)



        {



            int d = arrayB[0];







            for (int i = 1; i < arrayB.Length; i++)



            {



                d = Divide(d, arrayB[i]);



            }



            return d;



        }







    }



}
44 Operations/Multiply.cs 



@@ -0,0 +1,44 @@



using System;



using System.Collections.Generic;



using System.Text;







namespace Operations



{



    public class Multiply



    {



        public static int Product(int a, int b)



        {



            return a * b;



        }


        public static double Product(double a, double b)




        {



            return a * b;



        }







        public static double Product(double[] arrayA)



        {



            double c = arrayA[0];







            foreach (double a in arrayA)



            {



                c = Product(a, c);



            }




            double d = c / arrayA[0];



            return d;



        }

        public static int Product(int[] arrayB)



        {



            int d = 1;







            foreach (int a in arrayB)



            {



                d = Product(a, d);



            }



            return d;



        }

    }



}
7 Operations/Operations.csproj 



@@ -0,0 +1,7 @@



<Project Sdk="Microsoft.NET.Sdk">







  <PropertyGroup>



    <TargetFramework>netcoreapp3.1</TargetFramework>



  </PropertyGroup>







</Project>
11 Operations/RandomAdd.cs 



@@ -0,0 +1,11 @@



using System;



using System.Collections.Generic;



using System.Text;







namespace Operations



{



    class RandomAdd



    {



    }



}
20 Operations/Square.cs 



@@ -0,0 +1,20 @@



using System;



using System.Collections.Generic;



using System.Text;







namespace Operations



{



    public class Square



    {



        public static int Sqaured(int a)



        {



            return a * a;



        }







        public static double Squared(double a)



        {



            return a * a;



        }







    }



}
22 Operations/SquareRoot.cs 



@@ -0,0 +1,22 @@



using System;



using System.Collections.Generic;



using System.Text;







namespace Operations



{



    public class SquareRoot



    {



        public static int Root(int a)



        {



            double b = Math.Sqrt(a);



            int c = Convert.ToInt32(b);



            return c;



        }







        public static double Root(double a)



        {



            double b = Math.Sqrt(a);



            return b;



        }



    }



}
43 Operations/Subtraction.cs 



@@ -0,0 +1,43 @@



using System;



using System.Collections.Generic;



using System.Text;







namespace Operations



{



    public class Subtraction



    {



        public static int Difference(int a, int b)



        {



            return a - b;



        }







        public static double Difference(double a, double b)



        {



            return a - b;



        }







        public static double Difference(double[] arrayA)



        {



            double c = arrayA[0];







            foreach (double a in arrayA)



            {



                c = Difference(c, a);



            }



            double d = c + arrayA[0];



            return d;



        }







        public static int Difference(int[] arrayB)



        {



            int d = arrayB[0];







            foreach (int a in arrayB)



            {



                d = Difference(d, a);



            }



            int e = d + arrayB[0];



            return e;



        }



    }



}
46 OperationsTests/AdditionTests.cs 



@@ -0,0 +1,46 @@



using Microsoft.VisualStudio.TestTools.UnitTesting;



using Operations;



using System;



using System.Collections.Generic;



using System.Text;







namespace Operations.Tests



{



    [TestClass()]



    public class AdditionTests



    {



        private readonly int a = 10;



        private readonly int b = 20;



        private readonly double c = 10.5;



        private readonly double d = 20.5;



        private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07, 5, 6, 7, 8, 9, 10 };



        //private readonly int[] arrayB = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };











    [TestMethod()]



        public void SumTest()



        {



            Assert.AreEqual(30, Addition.Sum(a,b));



        }







        [TestMethod()]



        public void SumDoubleTest()



        {



            Assert.AreEqual(31, Addition.Sum(c, d));



        }







        [TestMethod()]



        public void SumDoubleArrayTest()



        {



            Assert.AreEqual(55.18, Addition.Sum(arrayA));



        }







        [TestMethod()]



        public void SumIntArrayTest()



        {



            Assert.AreEqual(55, Addition.Sum(arrayB));



        }











    }



} 
45 OperationsTests/DivisionTests.cs 



@@ -0,0 +1,45 @@



using Microsoft.VisualStudio.TestTools.UnitTesting;



using Operations;



using System;



using System.Collections.Generic;



using System.Text;







namespace Operations.Tests



{



    [TestClass()]



    public class DivisionTests



    {



        private readonly int a = 100;



        private readonly int b = 20;



        private readonly double c = 10.5;



        private readonly double d = 2.5;



        private readonly double[] arrayA = { 20.0, 2.5, 3.5, 4 };



        private readonly int[] arrayB = { 16, 2, 2 };











        [TestMethod()]



        public void DivideTest()



        {



            Assert.AreEqual(5, Division.Divide(a, b));



        }







        [TestMethod()]



        public void DivideDoubleTest()



        {



            Assert.AreEqual(4.2, Division.Divide(c, d));



        }







        [TestMethod()]



        public void DivideDoubleArrayTest()



        {



            Assert.AreEqual(0.5714285714285715, Division.Divide(arrayA));



        }







        [TestMethod()]



        public void DivideIntArrayTest()



        {



            Assert.AreEqual(4, Division.Divide(arrayB));



        }
 }



}




44 OperationsTests/MultiplyTests.cs 



@@ -0,0 +1,44 @@



using Microsoft.VisualStudio.TestTools.UnitTesting;



using Operations;



using System;



using System.Collections.Generic;



using System.Text;







namespace Operations.Tests



{



    [TestClass()]



    public class MultiplyTests



    {



        private readonly int a = 10;



        private readonly int b = 20;



        private readonly double c = 1.5;



        private readonly double d = 2.5;



        private readonly double[] arrayA = { 2.0, 2.5, 3.5, 4 };



        private readonly int[] arrayB = { 1, 2, 3, 4 };











        [TestMethod()]



        public void ProductTest()



        {



            Assert.AreEqual(200, Multiply.Product(a, b));



        }







        [TestMethod()]



        public void ProductDoubleTest()



        {



            Assert.AreEqual(3.75, Multiply.Product(c, d));



        }







        [TestMethod()]



        public void ProductDoubleArrayTest()



        {



            Assert.AreEqual(70, Multiply.Product(arrayA));



        }







        [TestMethod()]



        public void ProductIntArrayTest()



        {



            Assert.AreEqual(24, Multiply.Product(arrayB));



        }



    }



} 
20 OperationsTests/OperationsTests.csproj 



@@ -0,0 +1,20 @@



<Project Sdk="Microsoft.NET.Sdk">







  <PropertyGroup>



    <TargetFramework>netcoreapp3.1</TargetFramework>







    <IsPackable>false</IsPackable>



  </PropertyGroup>







  <ItemGroup>



    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.2.0" />



    <PackageReference Include="MSTest.TestAdapter" Version="2.0.0" />



    <PackageReference Include="MSTest.TestFramework" Version="2.0.0" />



    <PackageReference Include="coverlet.collector" Version="1.0.1" />



  </ItemGroup>







  <ItemGroup>



    <ProjectReference Include="..\Operations\Operations.csproj" />



  </ItemGroup>







</Project>
27 OperationsTests/SquareRootTests.cs 



@@ -0,0 +1,27 @@



using Microsoft.VisualStudio.TestTools.UnitTesting;



using Operations;



using System;



using System.Collections.Generic;



using System.Text;







namespace Operations.Tests



{



    [TestClass()]



    public class SquareRootTests



    {



        private readonly int a = 144;



        private readonly double b = 2.25;







        [TestMethod()]



        public void SquareRootTest()



        {



            Assert.AreEqual(12, SquareRoot.Root(a));



        }







        [TestMethod()]



        public void SquareRootDoubleTest()



        {



            Assert.AreEqual(1.5, SquareRoot.Root(b));



        }



    }



} 
28 OperationsTests/SquareTests.cs 



@@ -0,0 +1,28 @@



using Microsoft.VisualStudio.TestTools.UnitTesting;



using Operations;



using System;



using System.Collections.Generic;



using System.Text;







namespace Operations.Tests



{



    [TestClass()]



    public class SquareTests



    {



        private readonly int a = 12;



        private readonly double b = 1.5;







        [TestMethod()]



        public void SquareTest()



        {



            Assert.AreEqual(144, Square.Squared(a));



        }







        [TestMethod()]



        public void SquareDoubleTest()



        {



            Assert.AreEqual(2.25, Square.Squared(b));



        }







    }



} 
44 OperationsTests/SubtractionTests.cs 



@@ -0,0 +1,44 @@



using Microsoft.VisualStudio.TestTools.UnitTesting;



using Operations;



using System;



using System.Collections.Generic;



using System.Text;







namespace Operations.Tests



{



    [TestClass()]



    public class SubtractionTests



    {



        private readonly int a = 100;



        private readonly int b = 20;



        private readonly double c = 30.5;



        private readonly double d = 20.5;



        private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07};



        private readonly int[] arrayB = {26, 7, 8, 5, 2 };











        [TestMethod()]



        public void DifferenceTest()



        {



            Assert.AreEqual(80, Subtraction.Difference(a, b));



        }







        [TestMethod()]



        public void DifferenceDoubleTest()



        {



            Assert.AreEqual(10, Subtraction.Difference(c, d));



        }







        [TestMethod()]



        public void DifferenceDoubleArrayTest()



        {



            Assert.AreEqual(-8.16, Subtraction.Difference(arrayA));



        }







        [TestMethod()]



        public void DifferenceIntArrayTest()



        {



            Assert.AreEqual(4, Subtraction.Difference(arrayB));



        }



    }



} 
