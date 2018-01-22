using System;
namespace Calculator_application_ca
{
    public class calculator
    {
        
    // calculates the square of a number
    public int Square(int num)  
    {  
        return num * num;  
    }  
    // Addition function  
    public int Add(int num1, int num2)  
    {  
        return num1 + num2;  
    }  
  
    // multiplication of a set of number
    public int Multiply(int num1, int num2)  
    {  
        return num1 * num2;  
    }  
    // Subtraction function  
    public int Subtract(int num1, int num2)  
    {  
            if (num1 > num2)  
            {  
                return num1 - num2;  
            }  
  
            return num2 - num1;  
  
        }  
        // Division on two float variables.  
    public float Division(float num1, float num2)   
    {  
        return num1 / num2;  
    }  


    }
}
