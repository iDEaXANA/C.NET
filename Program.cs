// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Konichiwa, Sekai");
// Console.WriteLine("Konichiwa, Sekai");
// Console.Write("First");
// Console.Write("Second");




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
// double myDouble = 0.751;
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
// using System.Data;

// string myCow = "cows";
//             string myCapitalisedCow = "Cow";
//             switch (myCow) {
//                 case "cow":
//                     Console.WriteLine("Lowercase");
//                     break;
//                 case "Cow":
//                     Console.WriteLine("Uppercase");
//                     break;
//                 default:
//                     Console.WriteLine("Not Equal");
//                     break;
//             };

//-- Loops
//!! for, foreach, while, do while

//* for,while, the same as JS  


// int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 34};

// // 1. add them manually
// // 2. Use For Loop
// DateTime startTime = DateTime.Now;
// int totalValue = 0;

// foreach(int intForCompression in intsToCompress) {
//     if (intForCompression > 20) {
//         totalValue += intForCompression;
//     }
// }
// Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
// Console.WriteLine(totalValue);



// for (int i = 0; i< intsToCompress.Length; i++)
// {
//     totalValue += intsToCompress[i];
// }
// Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
// Console.WriteLine(totalValue);

// startTime = DateTime.Now;
// totalValue = 0;

// foreach(int intForCompression in intsToCompress) {
//     totalValue += intForCompression;
// }

// Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
// Console.WriteLine(totalValue);

// int index = 0;
// totalValue = 0;
// startTime = DateTime.Now;

// while(index < intsToCompress.Length) {
//     totalValue += intsToCompress[index];
//     index++;
// }

// Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
// Console.WriteLine(totalValue);

// startTime = DateTime.Now;
// totalValue = 0;
// index = 0;
// do {
//     // Console.WriteLine(index);
//     // Console.WriteLine(index < intsToCompress.Length)
//     totalValue += intsToCompress[index];
//     index++;
// } while(index < intsToCompress.Length); 

// Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
// Console.WriteLine(totalValue);

// totalValue = 0;
// totalValue = intsToCompress.Sum();

// Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
// Console.WriteLine(totalValue);

using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text.Json;
using C.NET.Data;
using CNET.C.NET.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
// using System.Text.RegularExpressions;
// using System.Globalization;

namespace CNET.C.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //     Console.WriteLine("Hello World");

        //     //-- Methods
        //     //!! Methods, Arguments and Return.   
        //     //* MOSTLY the same as JS  

        
        //     int totalValue = 0;
        //     int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 34};
        //     int[] intsToCompress2 = new int[] {23, 23, 53, 56, 83, 92};
        //     DateTime startTime = DateTime.Now;
        //     totalValue = GetSum(intsToCompress);
        //     Console.WriteLine(totalValue);
        //     Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
        //     totalValue = GetSum(intsToCompress2);
        //     Console.WriteLine(totalValue);
        //     Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            
        //     //-- Scope
        //     //!! Scope.
        //     //* MOSTLY the same as JS  
            
        
        // }
        //     static private int GetSum(int[] array) {
            
        //     int totalValue = 0;
        //     foreach(int intForCompression in array) {
        //         totalValue += intForCompression;
        //     }
        //     return totalValue;
        // }
            //-- Models (Source Mapping), Namespaces, Database Connections (Dapper, Entity Framework), Config
            //!! Methods, Arguments and Return.   
            //* , , the same as JS 

        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        
        DataContextDapper dapper = new DataContextDapper(config);
        
        // DataContextEF entityFramework = new DataContextEF(config);

        // string sqlCommand = "SELECT GETDATE()";
        // DateTime rightNow = dapper.LoadDataSingle<DateTime>(sqlCommand);

        // Console.WriteLine(rightNow);

        //!! Creating Model
        // Computer myComputer = new Computer() {
        //     Motherboard = "Z690",
        //     CPUCores = 4,
        //     HasWifi = true,
        //     HasLTE = false,
        //     ReleaseDate = DateTime.Now,
        //     Price = 943.87m,
        //     VideoCard = "RTX 1"
        // };

        // entityFramework.Add(myComputer);
        // entityFramework.SaveChanges();


        //!! INSERTing into database
        // string sql = @"INSERT INTO TutorialAppSchema.Computer (
        //     Motherboard,
        //     CPUCores,
        //     HasWifi,
        //     HasLTE,
        //     ReleaseDate,
        //     Price,
        //     VideoCard
        // ) VALUES ('" 
        // + myComputer.Motherboard
        // + "','" + myComputer.CPUCores
        // + "','" + myComputer.HasWifi
        // + "','" + myComputer.HasLTE
        // + "','" + myComputer.ReleaseDate
        // + "','" + myComputer.Price
        // + "','" + myComputer.VideoCard
        // + "')";
        
        // File.WriteAllText("log.txt", "\n" + sql + "\n");

        // using StreamWriter openFile = new("log.txt", append: true);
        // openFile.WriteLine("\n" + sql + "\n");

        // openFile.Close();

        string computersJson = File.ReadAllText("Computers.json");

        // Console.WriteLine(computersJson);

        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        IEnumerable<Computer>? computersNewtonSoft = JsonConvert.DeserializeObject<IEnumerable<Computer>>(computersJson)
        ;
        IEnumerable<Computer>? computersSystem = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<Computer>>(computersJson, options);


        if (computersNewtonSoft != null) 
        {
            foreach (Computer computer in computersNewtonSoft)
            {
                // Console.Write("\n" + computer.Motherboard + "\n");
                    string sql = @"INSERT INTO TutorialAppSchema.Computer (
                    Motherboard,
                    HasWifi,
                    HasLTE,
                    ReleaseDate,
                    Price,
                    VideoCard
                ) VALUES ('" 
                + EscapeSingleQuote(computer.Motherboard)
                // + "','" + computer.CPUCores
                + "','" + computer.HasWifi
                + "','" + computer.HasLTE
                + "','" + computer.ReleaseDate
                + "','" + computer.Price
                + "','" + EscapeSingleQuote(computer.VideoCard)
                + "')";
        
                dapper.ExecuteSql(sql);
            }
        }

        JsonSerializerSettings settings = new JsonSerializerSettings() 
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        string computersCopyNewtonsoft = JsonConvert.SerializeObject(computersNewtonSoft, settings);

        File.WriteAllText("computersCopyNewtonsoft.txt", computersCopyNewtonsoft);

        string computersCopySystem = System.Text.Json.JsonSerializer.Serialize(computersSystem, options);

        File.WriteAllText("computersCopySystem.txt", computersCopySystem);

        }

        static string EscapeSingleQuote(string input)
        {
            string output = input.Replace("'", "''");

            return output;
        }
    }
}


// Console.WriteLine(sql);

        // // int result = dapper.ExecuteSqlWithRows(sql);
        // bool result = dapper.ExecuteSql(sql);

        // // Console.WriteLine(result);

        // string sqlSelect = @"SELECT 
        //     Computer.ComputerId,
        //     Computer.Motherboard,
        //     Computer.CPUCores,
        //     Computer.HasWifi,
        //     Computer.HasLTE,
        //     Computer.ReleaseDate,
        //     Computer.Price,
        //     Computer.VideoCard
        //  FROM TutorialAppSchema.Computer";

        //  IEnumerable<Computer> computers = dapper.LoadData<Computer>(sqlSelect);

        // Console.WriteLine("'ComputerId', 'Motherboard', 'CPUCores','HasWifi', 'HasLTE, 'ReleaseDate', 'Price', 'VideoCard'");

        //  foreach(Computer singleComputer in computers) {
        //     Console.WriteLine("'" 
        //         + singleComputer.ComputerId
        //         + "','"  + singleComputer.Motherboard
        //         + "','" + singleComputer.CPUCores
        //         + "','" + singleComputer.HasWifi
        //         + "','" + singleComputer.HasLTE
        //         + "','" + singleComputer.ReleaseDate
        //         + "','" + singleComputer.Price
        //         + "','" + singleComputer.VideoCard
        //         + "'");
        //  }

        // IEnumerable<Computer>? computersEF = entityFramework.Computer?.ToList<Computer>();

        // if (computersEF != null)
        // {
        // Console.WriteLine("'ComputerId', 'Motherboard', 'CPUCores','HasWifi', 'HasLTE, 'ReleaseDate', 'Price', 'VideoCard'");

        // foreach(Computer singleComputer in computers) {
        //     Console.WriteLine("'" 
        //         + singleComputer.ComputerId
        //         + "','"  + singleComputer.Motherboard
        //         + "','" + singleComputer.CPUCores
        //         + "','" + singleComputer.HasWifi
        //         + "','" + singleComputer.HasLTE
        //         + "','" + singleComputer.ReleaseDate
        //         + "','" + singleComputer.Price
        //         + "','" + singleComputer.VideoCard
        //         + "'");
        //  }
        // }

        

        // // Console.WriteLine(myComputer.Motherboard);
        // // Console.WriteLine(myComputer);


// UserName: sa

// Password: SQLConnect1

// For connection strings you will also need to set Trusted_Connection to false and supply a UserName and Password:



// Server=localhost;Database=DotNetCourseDatabase;Trusted_Connection=false;TrustServerCertificate=True;User Id=sa;Password=SQLConnect1;


            






            
        

            
            




            
