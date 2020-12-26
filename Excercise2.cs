using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

class excercise2 
{
  
static void timeConversion (string s) 
  {
    
DateTime d = DateTime.Parse (s);
    
Console.WriteLine ("Format 12 Jam:");
    
Console.WriteLine ("07:05:45 pm");
    
Console.WriteLine ("Format 24 Jam:");
    
Console.WriteLine (d.ToString ("HH:mm:ss"));
    
Console.ReadLine ();
  
} 
static void Main (string[]args) 
  {
    
string s = "07:05:45 pm";
    
timeConversion (s);

} 
} 
