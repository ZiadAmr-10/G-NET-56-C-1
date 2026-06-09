using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            #region Question 7: Garbage Collector
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 7: GARBAGE COLLECTOR
            //// ══════════════════════════════════════════════════════════════════════
            ////
            //// Q: What is the Garbage Collector in C#? How does it affect the 
            ////    lifetime of objects?
            ////The Garbage Collector manages memory in the heap. It cleans and removes objects from the heap that have no reference in the stack and in the program
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
            #region Question 8: Variable Shadowing
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 8: VARIABLE SHADOWING
            //// ══════════════════════════════════════════════════════════════════════
            //// Q: What is variable shadowing in C#? Does C# allow shadowing in 
            ////    nested blocks within the same method?
            ////Shadowing occurs when a variable declared in an inner scope has the same name as one in an outer scope. 
            //C# allows shadowing in some cases, such as method parameters hiding class fields,
            //but its not allow redeclaring variables in the same method scope.
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
            #region Question 9: C# Naming Rules
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 9: C# NAMING RULES
            //// ══════════════════════════════════════════════════════════════════════
            //// Q: List five rules that must be followed when naming variables in C#.
            //1-Variable names must start with a letter or underscore (_).
            // 2-Names can contain letters, digits, and underscores, but no spaces.
            // 3-C# is case sensitive (name and Name are different).
            // 4-Keywords cannot be used as variable names unless you use @.
            // 5-Names should be meaningful and follow naming conventions(camelCase for variables, PascalCase for classes).
            // ══════════════════════════════════════════════════════════════════════
            #endregion
            #region Question 10: Naming Conventions
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 10: NAMING CONVENTIONS
            //// ══════════════════════════════════════════════════════════════════════
            ////
            //// Q: What naming conventions are recommended for: (a) local variables, 
            ////    (b) class names, (c) constants?
            ////Local variables : camelCase : int userAge 
            ///Class names : PascalCase:  class Student { }      
            //Constants : PascalCase int MaxUsers or All Capital MAX_USERS ->UPPER_CASE
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
            #region Question 11: Error Types
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 11: ERROR TYPES
            //// ══════════════════════════════════════════════════════════════════════
            //// Q: Compare and contrast syntax errors, runtime errors, and logical 
            ////    errors. Provide an example of each.
            ////Syntax Errors : These are errors in the code structure or syntax ,They are detected by the compiler, so the program will not run until they are fixed 
            //Example: int x = "10";
            //Runtime Errors(Exceptions) : Happen while program is running , Crash the program if not handled
            //Example : int x = 10 / 0; - string s = null;
            //Logical Errors : No compiler error, no exception, Program runs but wrong result
            //Example: // Calculate average of 3 numbers
            //int sum = 10 + 20 + 30;
            //int avg = sum / 2;  // ❌ Should be /3
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
            #region Question 12: Exception Handling Importance
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            //// ══════════════════════════════════════════════════════════════════════
            //// Q: Why is exception handling important in C#? What would happen if 
            ////    you don't handle exceptions?
            ///Exception handling is important because it prevents the application from crashing and allows the program to handle runtime errors in a controlled way.
            ////its Prevent application crash-Show user-friendly messages-Log details for debugging-Guarantee cleanup(files, DB connections)
            ///If exceptions are not handled, the program may crash unexpectedly and stop execution
            //Example : int x = 10 / 0;
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
            #region Question 13: try-catch-finally
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 13: TRY-CATCH-FINALLY
            //// ══════════════════════════════════════════════════════════════════════
            //// Q: Write a code example demonstrating try-catch-finally. Explain when 
            ////    the finally block executes.
            ///try
            //{
            //    int x = int.Parse("abc");
            //}
            // catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            // finally
            // {
            //    Console.WriteLine("Done");
            //}
            //The finally block always executes at the end, whether an exception happens or not
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
            #region Question 14: Common Built-in Exceptions
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            //// ══════════════════════════════════════════════════════════════════════
            //// Q: List and explain five common built-in exceptions in C# with 
            ////    scenarios when each would occur.
            // 1 - NullReferenceException:
            //Occurs when you try to use an object that is null.
            //Example:
            //string s = null;
            //Console.WriteLine(s.Length);
            // 2 - FormatException:
            //Occurs when converting a string with an invalid format.
            //Example:
            //int x = int.Parse("abc");
            //3 - DivideByZeroException:
            //Occurs when dividing a number by zero.
            //Example:
            //int x = 10 / 0;
            //4 - IndexOutOfRangeException:
            //Occurs when accessing an invalid index in an array.
            //Example:
            //int[] arr = { 1 };
            //Console.WriteLine(arr[5]);
            //5 - ArgumentNullException:
            //Occurs when a method receives a null argument.
            //Example:
            //File.Open(null, FileMode.Open);
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
            #region Question 15: Multiple catch Blocks
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 15: MULTIPLE CATCH BLOCKS
            //// ══════════════════════════════════════════════════════════════════════
            //// Q: Why is the order of catch blocks important when handling multiple 
            ////    exceptions? Write code showing correct ordering.
            ////use multiple catch blocks to handle different exception types differently. Always place more specific catches before general ones
            //        catch (Exception ex) when(ex is FormatException or OverflowException)
            //     {
            //    Console.WriteLine("Invalid number input!");
            //}
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
            #region Question 16: throw Keyword
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 16: THROW KEYWORD
            //// ══════════════════════════════════════════════════════════════════════
            //// Q: What is the difference between 'throw' and 'throw ex' when 
            ////    re-throwing an exception? Which one preserves the stack trace?
            ////throw preserves the original stack trace and error location,throw ex resets the stack trace and loses the original error location.
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
            #region Question 17: Stack and Heap Memory
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 17: STACK AND HEAP MEMORY
            //// ══════════════════════════════════════════════════════════════════════
            //// Q: Explain the differences between Stack and Heap memory in C#. 
            ////    What types of data are stored in each?
            ////1- Value Types:
            //These include any type under struct or enum such as:
            //int, bool, decimal, float, char.
            //These are stored in the Stack.
            //2- Reference Types:
            //These include any type under class or interface such as:
            //delegate, object, string, array.
            //These are stored partly in the Stack and partly in the Heap.
            //The object data is stored in the Heap, while the reference is stored in the Stack .
            //Stack Characteristics:
            //- Very Fast
            //- Auto Cleanup
            //- Fixed Size
            //- Short Lived
            //- Uses LIFO (Last In First Out)-.>Organize
            //Heap Characteristics:
            //- Large Size
            //-GC Managed
            //- Slower
            //- Long Lived
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
            #region Question 18: Value Types vs Reference Types
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            //// ══════════════════════════════════════════════════════════════════════
            ////
            //// Q: Write a code example showing how value types and reference types 
            ////    behave differently when assigned to another variable.
            ////Value Type
            //int x = 10; 
            //int y = x; ->The same Value
            //Console.WriteLine(y); // 10
            //y = 20;
            //Console.WriteLine(x); // 10
            //Console.WriteLine(y); // 20
            //Reference Type;
            //Point p1 = new Point();
            //p1.X = 10;
            //Point p2 = p1; // p2 refers to the same object as p1 in the heap.
            //p2.X = 50;
            //Console.WriteLine(p1.X); // 50
            //Console.WriteLine(p2.X); // 50
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
            #region Question 19: Object in C#
            //// ══════════════════════════════════════════════════════════════════════
            //// QUESTION 19: OBJECT IN C#
            //// ══════════════════════════════════════════════════════════════════════
            //// Q: Why is 'object' considered the base type of all types in C#? 
            ////    What methods does every type inherit from System.Object?
            ////object is considered the base type of all types in C# because every type in C# (value types and reference types) inherits from System.Object. 
            //It allows different types to be treated in a unified way, especially before Generics were introduced.
            //Methods
            //ToString() → converts object to string representation
            //
            //Equals() → compares two objects
            //
            //GetHashCode() → returns a hash code for the object
            //
            //GetType() → returns the runtime type of the object
            //// ══════════════════════════════════════════════════════════════════════
            #endregion
        }

    } 
}
