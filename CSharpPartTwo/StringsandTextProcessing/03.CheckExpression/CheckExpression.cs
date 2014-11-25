using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CheckExpression
{
    /*Write a program to check if in a given expression the brackets are put correctly.
        Example of correct expression: ((a+b)/5-d).
        Example of incorrect expression: )(a+b)).
    */

    //Checks if expression is correct or incorrect
    static void ExpressionCheck(string expression)
    {
        int bracketCount = 0; //Brackets counter

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == ')' && bracketCount == 0) //When ")" occurs bracketCount always must be >0 - if not it's incorrect expression 
            {
                bracketCount = 1; //Sets incorect for the ckeck after the loop
                break;
            }
            if (expression[i] == '(')
            {
                bracketCount++;
            }
            else if (expression[i] == ')')
            {
                bracketCount--;
            }
        }
        if (bracketCount == 0)
        {
            Console.WriteLine("Expression is CORRECT!");
        }
        else
        {
            Console.WriteLine("Expression is INCORRECT!");
        }
    }

    static void Main()
    {
        Console.Write("Expression: ");
        string expression = Console.ReadLine();

        //Pass the expression to method
        ExpressionCheck(expression);
    }
}
