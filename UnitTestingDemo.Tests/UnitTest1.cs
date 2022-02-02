using System;
using Xunit;

namespace UnitTestingDemo.Tests
{
    public class UnitTest1
    {
        
        
        
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers

        public int Add(int x, int y, int b)

        {
            return x + y + b;
        }






        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend

        public int Sub(int x, int y)

        {
            return x - y;
        }




        // Create a Multiply method that passes 2 integers

        public int Mul(int x, int b)

        {
            return x * b;
        }


        // Create a Divide method that passes 2 integers
        public int Div(int b, int x)

        {
            return b / x;
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote

       
    } 
}
