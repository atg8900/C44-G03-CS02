using System.Drawing;

namespace demo_s2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Variables Declaration
            Console.WriteLine("Hello, World!");

            int z = 20;
            int x = 10;
            int y = 0;
            #endregion

            #region Division Check
            if (y != 0)
            {
                Console.WriteLine(x / y);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            #endregion

            #region Data Types Summary

            /*
                Data Types in C#

                Value Type [Primitive Data Types]
                ---------------------------------
                 struct (User-Defined)
                    Examples: 
                        - byte, sbyte     -> 1 Byte
                        - short, ushort   -> 2 Byte
                        - int, uint      -> 4 Byte   
                        - long, ulong     -> 8 Byte
                        - float           -> 4 Byte
                        - double         ->8 Byte
                        - decimal        ->16 Byte
                        - char           ->2 Byte
                        - bool          ->1 Byte
                        - datetime      ->8 Byte

                 enum (User-Defined)
                  Also Value Type
                 Represents a set of named constants
                  

                Reference Type [Non-Primitive Data Types]
              
                 class (User-Defined)
                    Examples (Built-in classes):
                        Object
                       String
                       Array
                        Delegate

                 interface (User-Defined)
                   Defines a contract
                   Can be implemented by class or struct
                   Cannot have implementation (except default methods in C# 8+)
            */

            #endregion

            #region Value Type Data Types

            int num1;
            num1 = 10;

            Int32 num2 = 9;
            num2 = num1;
            num1++;

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            #endregion

            #region Value Type Behavior Explanation

            // Value types are stored in the stack.
            // When assigning one value type to another, the data is copied.
            // Modifying the original variable does NOT affect the copy.

            #endregion

            #region C# Keywords and BCL Types Mapping

            // BCL Type  →     C# Keyword
            // Byte      →     byte
            // Int16     →     short
            // Int32     →     int
            // Int64     →     long
            // Single    →     float
            // Double    →     double
            // Decimal   →     decimal
            // String    →     string   (Reference Type)
            // Char      →     char

            #endregion

            #region Reference Declaration and Memory Allocation


            Points P1;


            P1 = new Points();

            // Steps performed by 'new':
            // 1. Allocate required bytes in the *heap*.
            // 2. Initialize all members to default values.
            // 3. Call the user-defined constructor if it exists.
            // 4. Assign the reference (P1) to point to the allocated object.

            #endregion

            #region Object Copy and Reference Behavior

            // Create a second reference
            Point P2 = new Points();

            // Assign P2 to P1 (both now reference the same object in the heap)
            P2 = P1;

            // Modify the object using P1
            P1.X = 9;

            // Output the value using P2
            Console.WriteLine(P2.X);   // Output: 9


            #endregion


            #region Inherited Methods From Object

            // Object
            // >= is the base type from which all data types (data , behaviors)
            /*
             * Methods: object provides a set of methods that can be used across all types, such as   
            
             *Equals()
             *GetHashCode()
             *GetType()
             * ToString()
            */

            /*

              ToString()

            
            */

            /////////////////////////////////////////////////////////////

            /////////////////// Equals//////////////////////////////////


            // => Case 1
            Points p01 = new Points(1, 1);
            Points p02 = new Points(2, 2);

            Console.WriteLine("Case 1 : " + p01.Equals(p02)); // => fasle



            // => Case 2
            Points p03 = new Points(1, 1);
            Points p04 = new Points(1, 1);


            Console.WriteLine("Case 1 : " + p03.Equals(p04)); // => fasle



            //////////////////////////////////////////////////



            string name1 = "ATG";
            string name2 = "ATG";
            Console.WriteLine(name1.GetHashCode());
            Console.WriteLine(name2.GetHashCode());
            // => Name1 & Name 2 has The same address => Same Value

            Console.WriteLine(name1.Equals(name2));


            // GetType

            Points points = new Points(10, 20);

            Console.WriteLine(points.GetType());
            Console.WriteLine(points.GetType().Name);
            Console.WriteLine(points.GetType().FullName);
            Console.WriteLine(points.GetType().Assembly);


            // Example On Headache in memory 

            object obj = new object();

            obj = 10;
            obj = 1.5;
            obj = true;
            obj = new Points(10, 20);


            #endregion


            //enddddd
        }
    }
}
