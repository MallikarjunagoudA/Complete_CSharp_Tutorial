// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("\n\nLet's Get Start!!! >>>>>>>>>>>>\n");

//IntoMethod();
//TypeConversion();
DateFormat();

static void IntoMethod()
{
    Console.WriteLine("enter the firstname");

    string firstName = Console.ReadLine();

    Console.WriteLine("\nenter the lastName");

    string lastName = Console.ReadLine();

    Console.WriteLine("\nfullname using concat syntax:" + firstName + "," + lastName);
    Console.WriteLine("\nfullname using placeHolder syntax: {0}, {1}", firstName, "hello  ");

    // int
    int intMin = int.MinValue;
    int intMax = int.MaxValue;
    string intStringContent = "\nint min value:{0} and max value: {1}";

    // string
    string valueInsertedString = string.Format(intStringContent, intMin, intMax);
    Console.WriteLine(intStringContent, intMin, intMax);
    Console.WriteLine(valueInsertedString);

    // float

    float floatVal = 234.32988432432f; //floatVal 234.32988 pricision for float is 7
    Console.WriteLine("\nfloatVal {0}", floatVal);

    // double

    double doubleVal = 234.123456789123456789; //doubleVal 234.12345678912345 pricision for double is 15 - 16
    Console.WriteLine("\ndouble value {0}", doubleVal);

    // decimal
    decimal decimalVal = 234.1234567890123456789012m; //decimalVal 234.1234567890123456789012 pricision for double is 28 - 29
    Console.WriteLine("\ndouble value {0}", decimalVal);

    //boolean
    bool trueVal = true;
    bool falseVal = false;

    Console.WriteLine("\ntrue and false values {0}, {1}", trueVal, falseVal);

}

//type conversion
static void TypeConversion()
{
    // 2 types 1. implicit  2. explicit

    //implicit
    Console.WriteLine("implicit");
    int intVal = 234;
    float floatVal = intVal;
    double doubleVal = floatVal;

    Console.WriteLine($"\nintVal: {intVal}");
    Console.WriteLine($"floatVal: {floatVal}");
    Console.WriteLine($"doubleVal: {doubleVal}");

    // explicit 
    Console.WriteLine("\nExplicit");
    // using direct conversion
    Console.WriteLine($"\nusing direct conversion.");
    float floatVal1 = 453.123f;
    int intVal1 = (int)floatVal1;
    double doubleVal1 = 789.123453d;
    float floatVal2 = (float)doubleVal1;


    Console.WriteLine($"\nfloatVal1: {floatVal1}");
    Console.WriteLine($"intVal1: {intVal1}");
    Console.WriteLine($"doubleVal1: {doubleVal1}");
    Console.WriteLine($"floatVal2: {floatVal2}");

    //using Convert class.
    Console.WriteLine($"\nusing Convert class.");
    float floatVal11 = 453.123f;
    int intVal11 = Convert.ToInt32(floatVal1);

    Console.WriteLine($"\nfloatVal1: {floatVal11}");
    Console.WriteLine($"intVal1: {intVal11}");

    // using .Parse() accept only the string values
    Console.WriteLine($"\nusing .Parse() .");

    string stringNumericVal = "897";
    int intValFromString = int.Parse(stringNumericVal);

    Console.WriteLine($"intValFromString: {intValFromString} \n");

    string stringNumericFloatVal = "897.786675";
    float floatValFromString = float.Parse(stringNumericFloatVal);

    Console.WriteLine($"stringNumericFloatVal: {stringNumericFloatVal}");

}

static void DateFormat()
{
    DateTime dt = DateTime.Now;

    Console.WriteLine("{0}", dt); //as it is
    Console.WriteLine("{0:d}", dt); // short date
    Console.WriteLine("{0:D}", dt); // long date
    Console.WriteLine("{0:f}", dt); // full date short time
    Console.WriteLine("{0:F}", dt); // full date and time
    Console.WriteLine("{0:g}", dt); // general date and time
    Console.WriteLine("{0:ddd}", dt); // abrivation of day of a week
    Console.WriteLine("{0:dddd}", dt); // day of a week
    Console.ReadLine();

}


