﻿//Declare two string variables and assign them with “Hello” and “World”. 
//Declare an object variable and assign it with the concatenation of the first 
//two variables (mind adding an interval). Declare a third string variable and initialize 
//it with the value of the object variable (you should perform type casting).


using System;

class ConcatenationAndCasting
{
    static void Main()
    {
        string firstPart = "Hello ";
        string secondPart = "World";
        object wholeObj = firstPart + secondPart;
        string wholeString = (string)wholeObj;
    }
}
