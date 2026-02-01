using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using static System.Collections.Specialized.BitVector32;

namespace CSharpAssignment
{
    class Program
    {
        // Class-level field for scope demonstrations
        static int classField = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           C# FUNDAMENTALS - ASSIGNMENT WITH ANSWERS                ║");
            Console.WriteLine("║                      20 Questions                                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");



            #region Question 1: Regions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q1 / Regions :");
            Console.WriteLine(" - used to organize and group code (put related things together)  into collapsible sections to Improve readability ");
            Console.WriteLine(" - make large code files easier to navigate and maintain ");
            Console.WriteLine(" - they are just for the programmer ,the compiler ignores them and they don’t affect how the program runs");
            //Nested Region Example

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("Q2 / Variable Declaration - Explicit vs Implicit :");

            // EXPLICIT DECLARATION 
            Console.WriteLine("  * EXPLICIT DECLARATION  :");
            Console.WriteLine("   - You clearly specify the variable type yourself.");
            Console.WriteLine("   - The compiler knows the type directly from what you wrote.");
            Console.WriteLine(" Ex /");
            int x = 10;
            float y = 5.5f;
            Console.WriteLine("   int x = 10; \n   float y=5.5f;");

            // IMPLICIT DECLARATION 
            Console.WriteLine("  * IMPLICIT DECLARATION  :");
            Console.WriteLine("   - You use the keyword var, and the compiler knows the type from the value you assign.");
            Console.WriteLine("   - Once the type is known, it’s fixed and cannot be changed");
            Console.WriteLine(" Ex /");
            var t = 10;
            var m = 5.5f;
            Console.WriteLine("   var t = 10; \n   var m=5.5f;");


            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 3: Constants
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("Q3 / Constants :");
            Console.WriteLine(" - To declare a constant in C#, you use the const keyword followed by the type, name, and value of the constant.");
            Console.WriteLine(" - you must initialize its value during declaration");
            Console.WriteLine(" - Its value is fixed at compile time and cannot be changed.");
            Console.WriteLine(" - The compiler can inline it, so it may not occupy separate memory.");
            Console.WriteLine(" Ex /");
            Console.WriteLine("   const double Pi = 3.14159;");

            // Constant examples
            const double Pi = 3.14159;
            const int a = 100;

            //------------------------------------------------------
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 4: Class-level vs Method-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q4 / Class-level vs Method-level Scope :");
            Console.WriteLine("  * Class Level  :");
            Console.WriteLine(" - Variables declared inside a class but outside any method.");
            Console.WriteLine(" - They can be accessed by all methods of the class.");
            Console.WriteLine(" - They exist as long as the object exists (for instance variables) " +
                "or for the lifetime of the program (for static variables).");
            Console.WriteLine("EX / ");
            Console.WriteLine("   * Variables declared inside a class but outside any method " +
                "\nlike : the classField that is declared above inside the class in line 11");
            Console.WriteLine("\n  * Method Level  :");
            Console.WriteLine(" - Variables declared inside a method.");
            Console.WriteLine(" - They can only be accessed inside that method.");
            Console.WriteLine(" - Its lifetime ended when the method execution finished ");
            Console.WriteLine("EX / ");
            Console.WriteLine("   * Variables declared inside a method or its parameters. " +
                "\nlike : ( X & Y ) Variables in PrintX method that exists at the end of the class");
            //------------------------------------------------------
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 5: Block-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q5 / Block-level Scope :");
            Console.WriteLine(" - A variable has block-level scope if it is declared inside a pair of { } braces " +
                "(like in loops, if statements, or any code block).");
            Console.WriteLine(" - The variable can only be accessed inside that block, Outside the block, it does not exist.");
            Console.WriteLine(" - Its lifetime ended when the Block execution finished ");
            Console.WriteLine("EX / ");
            if (classField < 1000) { 
            int o=classField + 50; // y has block-level scope
            }
            Console.WriteLine("  if (classField < 1000) { \r\n            int o=classField + 50; // y has block-level scope\r\n            } ");
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 6: Variable Lifetime - Local vs Static
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q6 / Variable Lifetime - Local vs Static :");
            Console.WriteLine(" - Lifetime is how long a variable exists in memory (from creation to destruction).");
            Console.WriteLine(" - Lifetime of Local Variables :They exist only during the execution of their method once the method ends, they are destroyed.");
            Console.WriteLine(" - Lifetime of Static Variables : They exist for the entire lifetime of the application they are destroyed only when the program ends.");
    
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 7: Garbage Collector
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q7 / Garbage Collector :");
            Console.WriteLine(" - Garbage Collector (GC) is a built-in memory management system in C# exists in CLR ");
            Console.WriteLine(" - It automatically frees memory used by objects that are no longer accessible in your program.");
            Console.WriteLine("  How it affects object lifetime:");
            Console.WriteLine(" - an object exists in memory as long as there are references to it.Once an object is no longer referenced (nothing points to it), the GC can remove it from memory.This means you don’t need to manually free memory");
            Console.WriteLine("\n" + new string('-', 70) + "\n");

            #endregion

            #region Question 8: Variable Shadowing
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q8 / Variable Shadowing :");
            Console.WriteLine(" - Variable Shadowing : occurs when a variable declared in an inner scope has the same name as one in an outer scope, temporarily hiding the outer variable. ");
            Console.WriteLine(" * Does C# allow shadowing in nested blocks within the same method?");
            Console.WriteLine(" - No, C# does not allow shadowing of variables in nested blocks within the same method , If you try to declare a variable with the same name in an inner block of the same method, you get a compile-time error.");
            Console.WriteLine(" - Shadowing is allowed between class-level variables and local variables , but not inside the same method.");
            Console.WriteLine("\n" + new string('-', 70) + "\n");

            #endregion

            #region Question 9: C# Naming Rules
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q9 / C# Naming Rules :");
            Console.WriteLine(" 1- Must start with a letter or underscore. ");
            Console.WriteLine(" 2- Can contain letters, digits, and underscores.");
            Console.WriteLine(" 3- Avoid keywords (or use @ when necessary)");
            Console.WriteLine(" 4- Case-sensitive.");
            Console.WriteLine(" 5- Should be meaningful and readable");
            Console.WriteLine(" 6- Classes, Methods, Properties, Constants => PascalCase");
            Console.WriteLine(" 7- Local variables, Parameters => camelCase");
           

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 10: Naming Conventions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q10 / C# Naming Conventions :");
            Console.WriteLine(" Local variables => camelCase ");
            Console.WriteLine(" Class names => PascalCase ");
            Console.WriteLine(" Constants => PascalCase");
          
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 11: Error Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("Q11 / Error Types :");

            Console.WriteLine("Syntax errors : ");
            Console.WriteLine(" - Detected by the compiler.");
            Console.WriteLine(" - The program cannot compile until they are fixed.");
            Console.WriteLine("EX / ");
            Console.WriteLine("int x = 10  => Missing semicolon");
            Console.WriteLine("int x = \"10\" => Type mismatch");
         
            Console.WriteLine("Runtime errors : ");
            Console.WriteLine(" - Occur while the program is running.");
            Console.WriteLine(" - The program compiles, but fails when executing certain statements.");
            Console.WriteLine(" - Can be caught with try-catch");
            Console.WriteLine("EX / ");
            Console.WriteLine("int x = 10 / 0; => Divide by Zero");
            
            Console.WriteLine("Logical errors : ");
            Console.WriteLine("The program runs without crashing, but produces wrong results.");
            Console.WriteLine("Hardest to detect because there’s no compiler or runtime message.");
            Console.WriteLine("EX / ");
            Console.WriteLine("int sum = 10 + 20 + 30;\nint avg = sum / 2;  => Should be /3");


            Console.WriteLine("\n" + new string('-', 70) + "\n");

            #endregion

            #region Question 12: Exception Handling Importance
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q12 /  Exception Handling Importance :");
            Console.WriteLine(" - Exception handling allows your program to handle errors instead of crashing suddenly. ");
            Console.WriteLine(" - It helps you control the program flow when something unexpected happens .");
            Console.WriteLine(" - It makes the program more reliable and stable .");
            Console.WriteLine("  *  What happens if exceptions are not handled?");
            Console.WriteLine(" - The program will crash at runtime when an exception occurs.");
            Console.WriteLine(" - The application may terminate immediately, losing data or stopping important operations.");
            Console.WriteLine(" - gives a bad user experience.");
            Console.WriteLine("\n" + new string('-', 70) + "\n");

            #endregion

            #region Question 13: try-catch-finally
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.
            //

            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q13 /  try-catch-finally :");
            try
            {
                int b= 10;
                int c = 0;
                int result = b/c;   // Causes DivideByZeroException
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

           
            Console.WriteLine("finally will always execute after try/catch, whether an exception occurs or not.");
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 14: Common Built-in Exceptions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q14 /  Common Built-in Exceptions :");
            Console.WriteLine(" 1- DivideByZeroException :");
            Console.WriteLine("     - Occurs when: You try to divide a number by zero.");
            Console.WriteLine("     - Scenario: Mathematical operations with user input.");
            Console.WriteLine("Ex/ int g=10/0; :");
            Console.WriteLine(" 2- NullReferenceException :");
            Console.WriteLine("     - Occurs when: You try to use an object that is null.");
            Console.WriteLine("     - Scenario: Calling a method or accessing a property on a null object.");
            Console.WriteLine("Ex/ string name = null; \n Console.WriteLine(name.Length); ");
            Console.WriteLine(" 3- IndexOutOfRangeException :");
            Console.WriteLine("      - Occurs when: You access an array or collection with an invalid index.");
            Console.WriteLine("      - Scenario: Looping beyond array bounds.");
            Console.WriteLine("Ex/ int[] arr = {1, 2, 3}; \n Console.WriteLine(arr[5]);  ");
            Console.WriteLine(" 4- FormatException :");
            Console.WriteLine("     - Occurs when: Data is in an invalid format during type conversion.");
            Console.WriteLine("     - Scenario: Converting user input to a number.");
            Console.WriteLine("Ex/ int num = int.Parse(\"abc\");  ");
            Console.WriteLine(" 5- InvalidOperationException :");
            Console.WriteLine("     - Occurs when: A method call is invalid for the object’s current state.");
            Console.WriteLine("     - Scenario: Reading from an empty collection.");
            Console.WriteLine("Ex/ List<int> list = new List<int>();\nint first = list.First();   ");
            Console.WriteLine("\n" + new string('-', 70) + "\n");

            #endregion

            #region Question 15: Multiple catch Blocks
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q15 /  Multiple catch Blocks :");
            Console.WriteLine(" - Order is important because catch blocks are checked from top to bottom and C# always matches the first compatible catch block.");
            Console.WriteLine(" - If a general exception (like Exception) comes before a more specific one,the specific catch block will never be reached.");
            try
            {
                int[] arr = { 1, 2, 3 };
                Console.WriteLine(arr[5]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index is out of range.");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Object is null.");
            }
            catch (Exception e)
            {
                Console.WriteLine("General exception occurred.");
            }

            Console.WriteLine("\n" + new string('-', 70) + "\n");

            #endregion

            #region Question 16: throw Keyword
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q16 /  throw Keyword:");
            Console.WriteLine(" - Throw :");
            Console.WriteLine("     - Re-throws the same exception.");
            Console.WriteLine("     - Preserves the original stack trace.");
           
            Console.WriteLine(" - Throw ex :");
            Console.WriteLine("      - Throws the exception as if it were a new one.");
            Console.WriteLine("      - Resets (loses) the original stack trace.");

            Console.WriteLine(" *** throw preserves the original stack trace. *** ");
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 17: Stack and Heap Memory
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q17 /  Stack and Heap Memory:");

            Console.WriteLine(" - Stack :");
            Console.WriteLine("     - Stores value types and method calls and object references");
            Console.WriteLine("     - Memory is allocated and released automatically using LIFO");
            Console.WriteLine("     - Very fast access.");
            Console.WriteLine("     - Short lived");
            Console.WriteLine("     - stores: int, char, float, bool, struct");
         
            Console.WriteLine(" - Heap :");
            Console.WriteLine("      - stores objects created using new.");
            Console.WriteLine("      - Memory is managed by the Garbage Collector (GC).");
            Console.WriteLine("      - Memory is allocated at runtime.");
            Console.WriteLine("      - Access is slower than stack.");
            Console.WriteLine("      - Stores reference types like : class, object, array, string.");
        
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 18: Value Types vs Reference Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q18 /  Value Types vs Reference Types:");


            Console.WriteLine(" - Value Type :");
            Console.WriteLine("     -Stored in Stack.");
            Console.WriteLine("     - Assigning one variable to another copies the value.");
            Console.WriteLine("     - Changing one variable does not affect the other.");
          // ex :
          int val1 = 10;
          int val2 = 20;
            val1 = 30;
            Console.WriteLine(val1); // 30
            Console.WriteLine(val2); // 20

            Console.WriteLine(" - Reference Type :");
            Console.WriteLine("      - Stored in Heap and its reference in the stack.");
            Console.WriteLine("      - Assigning one variable to another copies the reference.");
            Console.WriteLine("      Changing the object via one variable affects the other, because both refer to the same object.");
            // ex :
            /*  
              Student s1 = new Student();
              s1.Name = "Aya";
             Student s2 = s1;   // copy the reference
              s2.Name = "Ayaaaa";
              Console.WriteLine($" s1.Name = {p1.Name}, s2.Name = {p2.Name}");

             */
            Console.WriteLine("\n" + new string('-', 70) + "\n");

            #endregion

            #region Question 19: Object in C#
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 19: OBJECT IN C#
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is 'object' considered the base type of all types in C#? 
            //    What methods does every type inherit from System.Object?
            //

            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("Q19 /  object in c#:");

            Console.WriteLine(" - Why is 'object' considered the base type of all types in C#?");
            Console.WriteLine("     - In C#, every type (value type or reference type) inherits from System.Object.");
            Console.WriteLine("     - object was often used as a workaround to allow classes and methods to work with different types of data — it was an alternative to Generics before they were introduced in C# 2.0 ");
            Console.WriteLine("     - You can store any type in a variable of type object.");
            Console.WriteLine("     - provides a set of common behaviors (methods) should exist with each and every data type.");
            Console.WriteLine(" -  What methods does every type inherit from System.Object?");
            Console.WriteLine("     - ToString() : Returns a string representation of the object.");
            Console.WriteLine("     - Equals(object obj) : Compares the current object with another object for equality.");
            Console.WriteLine("     - GetHashCode() : Returns a hash code for the object");
            Console.WriteLine("     - GetType() : Returns the runtime type of the object.");
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

        }


        //   #endregion
        public static int PrintX(int y) // Y is Method-level scope
        {
            int x = 10; // X is Method-level scope
            return y + x;
        }
    }

    
}