using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U16_modular_calculator
{
    public class Calculator
    {
        //This is a calculator class and below are the member functions 

        //Addittion function 
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        //Subtraction function 
        //Basic validation added to ensure that we subtract the smaller number from larger number
        public double Subtract(double num1, double num2)
        {
            if(num1> num2)
            {
                return num1 - num2;
            }
            return num2 - num1;
        }
        
        //Multiplication function
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        //Division function 
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
