using System.ComponentModel;
using static System.Formats.Asn1.AsnWriter;

namespace Assighment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1: Regions
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 2: REGIONS
            //// ══════════════════════════════════════════════════════════════════════
            ////
            //// Q: What is the purpose of #region and #endregion directives in C#? 
            ////    How do they help in code organization?
            ///   it's used to organize and group code into collapsible sections, making large code files easier to read and navigate.
            // This helps improve code organization and readability.
            ////
            // ══════════════════════════════════════════════════════════════════════
            ////Nested Region Example
            // Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion
            #region Question 2: Variable Declaration - Explicit vs Implicit
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            //// ══════════════════════════════════════════════════════════════════════
            ////
            //// Q: What is the difference between explicit and implicit variable 
            ////    declaration in C#? Provide examples of both.
            //// Explicit declaration means  the programmer identifies the variable's data type directly 
            // Explicit declaration
            //int age = 20;
            //string name = "Ali";
            //Implicit declaration  means the compiler automatically identifies the variable's data type using the var 
            // Implicit declaration
            //var age = 20;
            //var name = "Ali";
            //// ══════════════════════════════════════════════════════════════════════





            #endregion
            #region Question 3: Constants
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 4: CONSTANTS
            //// ══════════════════════════════════════════════════════════════════════
            ////
            //// Q: Write the syntax for declaring a constant in C#. Why would you use 
            ////    a constant instead of a regular variable? 
            ////using constant when we want the value cannot be changed like mathematical values 
            // const double PI = 3.14159;
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
            #region Question 4: Class-level vs Method-level Scope
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            //// ══════════════════════════════════════════════════════════════════════
            //// Q: Explain the difference between class-level scope and method-level 
            ////    scope with examples.
            //Class - level scope variables declare inside the class can be access by all methods within the class.
            //Method-level scope variables declare inside a method can only access within that method.
            //   class Student
            //  {
            //   string name = "Ali";  // Class-level scope
            //    void PrintName()
            //    {
            //        Console.WriteLine(name);
            //    }
            //    void Age()
            //    {
            //        int age = 20; // Method-level scope
            //        Console.WriteLine(age);
            //    }
            //}
            //// ══════════════════════════════════════════════════════════════════════


            #endregion
            #region Question 5: Block-level Scope
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 5: BLOCK-LEVEL SCOPE
            //// ══════════════════════════════════════════════════════════════════════
            ////
            //// Q: What is block-level scope? Give an example showing a variable that 
            ////    is only accessible within a specific block.
            //Block - level scope means that a variable is only accessible within the block { }
            //such as if ,for, ...
            //Example :
            // class Student
            //     {
            //void PrintAge()
            //{
            //    if (true)
            //    {
            //        int age = 20;
            //        Console.WriteLine(age);
            //    }
            //}
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
            #region Question 6: Variable Lifetime - Local vs Static
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            //// ══════════════════════════════════════════════════════════════════════
            //// Q: What is variable lifetime? Explain the lifetime of local variables 
            ////    vs static variables.
            //// Variable lifetime means the  time of a variable  in memory.
           // Local variables are declared inside a method and created when the method is called, they are destroyed when the method finishes execution
           //Static variables are declared once and exist for the lifetime of the program.They keep their value between method calls.
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
        }

    } 
}
