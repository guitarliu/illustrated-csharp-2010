﻿using System;

namespace Examples
{
   class Person
   {
      public string Name { get; private set; }
      public Person( string name )
      {
         Name = name;
      }
   }

   class Program
   {
      static public void Main( )
      {
         Person p = new Person( "Capt. Ernest Evans" );
         Console.WriteLine( "Person's name is {0}", p.Name );
      }
   }
}
