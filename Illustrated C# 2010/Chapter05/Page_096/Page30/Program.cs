﻿using System;

namespace Page30
{
   class MyClass
   {
      public void ListInts( params int[] inVals )
      {
         if ( ( inVals != null ) && ( inVals.Length != 0 ) )
            for ( int i = 0; i < inVals.Length; i++ )     // Process the array.
            {
               inVals[i] = inVals[i] * 10;
               Console.WriteLine( "{0}", inVals[i] );   // Display new value.
            }
      }
   }

   class Program
   {
      static void Main()
      {
         int[] myArr = new int[] { 5, 6, 7 };  // Create and initialize array.

         MyClass mc = new MyClass();
         mc.ListInts( myArr );                   // Call method to print the values.

         foreach ( int x in myArr )
            Console.WriteLine( "{0}", x );       // Print out each element.
      }
   }
}
