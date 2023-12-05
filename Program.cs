// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Konichiwa, Sekai");
// Console.WriteLine("Konichiwa, Sekai");
// Console.Write("First");
// Console.Write("Second");

// using System;

// namespace HelloWorld
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World");
//         }
//     }
// }


            //// 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows
            // //// Each bit can be worth 0 or 1 of the value it is placed in
            // ////// From the right we start with a value of 1 and double for each digit to the left
            // //// 00000000 = 0
            // //// 00000001 = 1
            // //// 00000010 = 2
            // //// 00000011 = 3
            // //// 00000100 = 4
            // //// 00000101 = 5
            // //// 00000110 = 6
            // //// 00000111 = 7
            // //// 00001000 = 8
 
            // Byte = 8bit
            // Short = 16bit
            // Integer/float = 32bit
            // double = 64bit
            // decimal = 128bit


            //-- Below is min and max values.

            // 1 byte (8 bit) unsigned, where signed means it can be negative
            // byte myByte = 255;
            // byte mySecondByte = 0;
 
            // // 1 byte (8 bit) signed, where signed means it can be negative
            // sbyte mySbyte = 127;
            // sbyte mySecondSbyte = -128;
 
 
            // // 2 byte (16 bit) unsigned, where signed means it can be negative
            // ushort myUshort = 65535;
 
            // // 2 byte (16 bit) signed, where signed means it can be negative
            // short myShort = -32768;
 
            // // 4 byte (32 bit) signed, where signed means it can be negative
            // int myInt = 2147483647;
            // int mySecondInt = -2147483648;
 
            // // 8 byte (64 bit) signed, where signed means it can be negative
            // long myLong = -9223372036854775808;
 
 
            // // 4 byte (32 bit) floating point number
            // float myFloat = 0.751f;
            // float mySecondFloat = 0.75f;
 
            // // 8 byte (64 bit) floating point number
            // double myDouble = 0.751d;
            // double mySecondDouble = 0.75d;
 
            // // 16 byte (128 bit) floating point number
            // decimal myDecimal = 0.751m;
            // decimal mySecondDecimal = 0.75m;
 
            // // Console.WriteLine(myFloat - mySecondFloat);
            // // Console.WriteLine(myDouble - mySecondDouble);
            // // Console.WriteLine(myDecimal - mySecondDecimal);
 
 
 
            // string myString = "Hello World";
            // // Console.WriteLine(myString);
            // string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
            // // Console.WriteLine(myStringWithSymbols);
 
            // bool myBool = true;

            // //-- Arrays
            // string[] myGroceryArray = new string[2];
            // myGroceryArray[0] = "Avocados";
            // myGroceryArray[1] = "Ice Cream";
            // // Console.WriteLine(myGroceryArray[0]);
            // // Console.WriteLine(myGroceryArray[1]);
            // // Console.WriteLine(myGroceryArray[2]);

            // string[] mySecondGroceryArray = {"Blueberries", "Eggs"};
            // // Console.WriteLine(mySecondGroceryArray[0]);

            // //-- Lists
            // List<string> myGroceryList = new List<string>() {"Organic Milk", "Goat's Cheese"};
            // Console.WriteLine(myGroceryList[0]);

            // IEnumerable<string> myGroceryIEnumerable = myGroceryList;

            // Console.WriteLine(myGroceryIEnumerable.First());

            // //-- 2D Arrays
            // string[,] myTwoDimensionalArray = new string[,] {
            //     {"Blueberries", "Eggs"},
            //     {"Organic Milk", "Goat's Cheese"}
            // };

            // Console.WriteLine(myTwoDimensionalArray[1,1]); // Goat's Cheese
            // // For each dimension, add a comma

            // Dictionary<string, string> myGroceryDictionary = new Dictionary<string, string>(){
            //     {"Blueberries", "Fruit"}
            // };

            // Console.WriteLine(myGroceryDictionary["Blueberries"]);

            // // You can have that second string as a string array
            // // You have to declare the array inside the dictionary though.

            // Dictionary<string, string[]> myGroceryDictionary2 = new Dictionary<string, string[]>() {
            //     {"Fruit", new string[]{"Blueberries", "mangoes", "cookies"}}
            // };

            // Console.WriteLine(myGroceryDictionary2["Fruit"][2]);

            // //-- Operators 
            // int myInt = 5;
            // int mySecondInt = 10;

            // Console.WriteLine(Math.Pow(5,2));

            // string myString = "Bilal";

            // myString += " MB.";

            // Console.WriteLine(myString);

            // myString = myString + (" \"Hi!\"");

            // Console.WriteLine(myString);

            // string[] myStringArr = myString.Split(". ");

            // Console.WriteLine(myStringArr[0]);
            // Console.WriteLine(myStringArr[1]);

            // //-- Conditionals (operators)
            //* // same as JS.

            //-- Conditional Statements
            //!! if/else, switch.

            //* if/else, the same as JS  
            string myCow = "cows";
            string myCapitalisedCow = "Cow";
            switch (myCow) {
                case "cow":
                    Console.WriteLine("Lowercase");
                    break;
                case "Cow":
                    Console.WriteLine("Uppercase");
                    break;
                default:
                    Console.WriteLine("Not Equal");
                    break;
            };

            //-- Loops
            //!! for, while, do while, Methods, Arguments, Return and Scope.

            //* , the same as JS  

            
        

            
            




            
