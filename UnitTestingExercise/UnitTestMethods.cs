﻿using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int add(int num1, int num2, int num3)
        {
            //throw new NotImplementedException(); 
            return num1 + num2 + num3;
        }
        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        public int subract(int minuend, int subtrahend)
        {
            //throw new NotImplementedException();
            return minuend - subtrahend;
        }
        // Create a Multiply method that passes 2 integers
        public int multiply(int num1, int num2)
        {
            //throw new NotImplementedException();
            return num1 * num2;
        }

        // Create a Divide method that passes 2 integers

        public int divide(int num1, int num2)
        {
            //throw new NotImplementedException();
            return num1 / num2;
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote
        public int factmul()
        {
            return 2 * 3;
        }
        public int factdiv()
        {
            return 6 / 3;
        }
        
    }
}
