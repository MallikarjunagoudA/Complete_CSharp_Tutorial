// See https://aka.ms/new-console-template for more information
using CsharpIntro;

Console.WriteLine("\n\nLet's Get Start!!! >>>>>>>>>>>>\n");

//IntoMethod();
//TypeConversion();
//DateFormat();
//operatorator();
//ArrayUsage();
//ConditionStatements();
//SwitchExample();
//whileLoop();
//DowhileLoop();
//ForLoop();
//ForEachLoop();
//JumpStatement(); // break, continue, goto, return

#region <<paramter types>>
////Parameter types
//Console.WriteLine("Parameter types\n");
//ParameterTypes a = new ParameterTypes();

////value types
//Console.WriteLine("\nvalue types\n");
//int c = 2;
//a.Calculate(c);
//Console.WriteLine($"value type 'c' is, {c}");

////refernce types
//Console.WriteLine("\nrefernce types\n");
//int d = 3;
//Console.WriteLine($"d before is {d}");
//a.CalculateRef(ref d);
//Console.WriteLine($"d after is {d}");

////Out paramter
//Console.WriteLine("\nOut paramter\n");
//int sumIs = 0;
//int ProductIs = 0;
//a.CalculateOut(10, 20, out sumIs,out ProductIs);
//Console.WriteLine($"sum is {sumIs}");
//Console.WriteLine($"product is {ProductIs}");

////parameter array
//Console.WriteLine("\nparameter array\n");
//int[] arrayIs =new int[] { 1,2,3,4};
//a.ParameterArray(1);
//a.ParameterArray(5,arrayIs);
//a.ParameterArray(2, 9, 8, 7, 6, 5);

#endregion

#region << static and instance class >>

StaticClass sc = new StaticClass(5);
float area1 = sc.CalculateArea();
Console.WriteLine("area 1 is {0}", area1);

StaticClass sc1 = new StaticClass(6);
float area2 = sc1.CalculateArea();
Console.WriteLine( "area 2 is {0}", area2);

#endregion


#region << inheritance >>

childClassFullTimeEmp fte = new childClassFullTimeEmp();
fte.name = "full time employee";
fte.email = "fte.com";
fte.age = 25;
fte.EmployeeDetails();

childClassPartTimeEmp pte = new childClassPartTimeEmp();
pte.name = "full time employee";
pte.email = "fte.com";
pte.age = 25;
pte.EmployeeDetails();

#endregion

Console.WriteLine("\n");

#region << method hiding >>

MethodHiding parentClass = new MethodHiding();
parentClass.show(); // calls the parent class method.

ChildClass cc = new ChildClass();
cc.show(); //calls the child class method.
((MethodHiding)cc).show(); // calls the parent class method.


MethodHiding parentClassObj = new ChildClass();
parentClassObj.show(); // calls the parent class method.

#endregion

Console.WriteLine("\n");

#region << polimorphism override >>

Polymorphism p = new Polymorphism();
p.show();

Polymorphism a = new ChildClassA();
a.show();

ChildClassA aa = new ChildClassA();
aa.show();

Polymorphism b = new ChildClassB();
b.show();

ChildClassB bb = new ChildClassB();
bb.show();
#endregion


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

    // using .Parse() accept only the string values and value should be numerators else throw error
    Console.WriteLine($"\nusing .Parse() .");

    string stringNumericVal = "897";
    int intValFromString = int.Parse(stringNumericVal);

    Console.WriteLine($"intValFromString: {intValFromString} \n");

    string stringNumericFloatVal = "897.786675";
    float floatValFromString = float.Parse(stringNumericFloatVal);

    Console.WriteLine($"stringNumericFloatVal: {stringNumericFloatVal}");

    // using .TryParse() accept only the string values and value should be numerators else not throw error.

    string numVal = "643";
    string numVal2 = "434";

    
    int.TryParse(numVal, out int a);
    int.TryParse(numVal2, out int b);

    Console.WriteLine(a+b);
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

static void operatorator()
{
    //Assignment operator

    string name = "Ramesh Aravind";

    int age = 54;

    int weight = 78;

    //Arithmetic operator
    int addition = age + weight;
    int subtraction = weight - age;
    int devision = weight / age;
    int multiply = weight * age;
    int divident = weight % age;

    Console.WriteLine($"divident: {divident}");

    //comparision operator and conditional operator
    if(age<weight || age>weight || age <= weight ||  age >= weight && age != weight && age == weight)
    {
        Console.WriteLine("comparison operators: == < <= > >= ! != ");
        Console.WriteLine("conditional operators: && ||");
    }

    //ternary operator
    int result = age > weight ? age/weight : weight/age;

    Console.WriteLine($"ternary result:{result}");



    //nullable 
    int? nullValue = null;
    Console.WriteLine(nullValue); // will not generate any compiler error.


    // null coalescing operator

    int? tickOnSele = 100;
    int availableTickets;

    availableTickets = tickOnSele ?? 0;

    Console.WriteLine(availableTickets);

    int? tickOnSele1 = null;
    int availableTickets1;

    availableTickets1 = tickOnSele1 ?? 0;

    Console.WriteLine(availableTickets1);



}

static void ArrayUsage()
{
    //advantages:
    // stongly typed.

    //disadvantages
    // can change the size of the array dynamically
    // fetch the values on indeces might get tidy thing

    //array initialization
    int[] intArray = new int[5];

    //array value assignment
    intArray[0] = 34;
    intArray[1] = 54;
    intArray[3] = 45;

    //display
    Console.WriteLine(intArray[3]);
}

static void ConditionStatements()
{
    int age = int.Parse(Console.ReadLine());

    // if 

    if(age >0 && age < 6)
    {
        Console.WriteLine("children");
    } 

    // this will check both the conditions
    if (age > 0 & age < 6)
    {
        Console.WriteLine("children");
    }

    if (age > 5 ||  age < 18)
    {
        Console.WriteLine("minors");
    }

    // this will check both the conditions
    if (age > 5 | age < 18)
    {
        Console.WriteLine("minors");
    }

    //if else
    if(age < 18)
    {
        Console.WriteLine("not eligible for voting");
    }
    else if(age == 18 && age >18)
    {
        Console.WriteLine("eligible for voting, but elections are not held yet hahhahahaha");
    }
    {
        Console.WriteLine("eligible for voting");
    }

    switch(age)
    {
        case 4: 
            Console.WriteLine("minor");
            break;      
        case 18: 
            Console.WriteLine("major");
            break;
        case 25: 
            Console.WriteLine("adult");
            break;
        default: Console.WriteLine("default");
            break;
    }


}

static void SwitchExample()
{ 
    int priceOfTea = 0;

Start:
    Console.WriteLine("please select 1-small 2-medium 3-large ");
    int chooseValue = int.Parse(Console.ReadLine());
    switch(chooseValue)
    {
        case 1: priceOfTea++; break;
        case 2: priceOfTea += 2; break;
        case 3: priceOfTea += 3; break;
        default:
            Console.WriteLine("invlaid entry"); break;
    }

Decide:
    Console.WriteLine("do you want one more time tea?");
    string yesOrNo = Console.ReadLine();

    switch (yesOrNo.ToLower())
    {
        case "yes": goto Start;
        case "no": break;
        default:
            Console.WriteLine("invalid entry"); goto Decide;
    }

    Console.WriteLine("thank you for shopping with us");
    Console.WriteLine("you total bill is :{0}", priceOfTea);


}

static void whileLoop()
{
    int startNum = 1;
    int target = int.Parse(Console.ReadLine());
   
    while (startNum < target)
    {
        Console.WriteLine(startNum);
        startNum += 2;
        startNum -= 1;
        startNum *= 2;
        startNum /= 2;
        
    }
}

static void DowhileLoop()
{
    Start:
    int startNum = 1;
    Console.WriteLine("please enter the target number");
    int target = int.Parse(Console.ReadLine());
    string chioce;

    while (startNum < target)
    {
        Console.WriteLine(startNum);
        startNum += 2;
        startNum -= 1;
        startNum *= 2;
        startNum /= 2;

    }
    do
    {
        decide:
        Console.WriteLine("do you want to continue: Yes or No");
        chioce = Console.ReadLine().ToUpper();
        switch (chioce)
        {
            case "YES": goto Start;
            case "NO": return;
            default: Console.WriteLine("invalid choice"); goto decide;
        }

    }while (chioce == "YES" || chioce == "NO");

}

static void ForLoop()
{
    int[] arr = new int[5] { 1,2,3,4,5 };

    for(int a=0; a<arr.Length; a++) { Console.WriteLine(arr[a]); }
}

static void ForEachLoop()
{
    int[] arr = new int[5] { 1, 2, 3, 4, 5 };

    foreach(int a in arr) { Console.WriteLine(a); }
}

static void JumpStatement()
{
    Console.WriteLine("Enter the size : 1-small 2-medium 3-large 4-extra large");
    int size = int.Parse(Console.ReadLine());

    start:
    if(size > 4)
    {
        Console.WriteLine("invaid entry");
    }
    else
    {
        Console.WriteLine("the stock is not availalbe");
    }
    switch (size)
    {
        case 1:
            Console.WriteLine("Enter for whom: 1-children 2-ladies");
            int whomItFor = int.Parse(Console.ReadLine());

            switch (whomItFor) {
                case 1:
                    Console.WriteLine("Enter for color you are looking for: 1-blue 2-red, 3-white,4-black, 5-green");
                    int color = int.Parse(Console.ReadLine());
                    switch (color)
                    {
                        case 1: Console.WriteLine("you choosed small size for childen with color blue T shirt"); break;
                        case 2: Console.WriteLine("you choosed small size for childen with color red T shirt"); break;
                        case 3: Console.WriteLine("you choosed small size for childen with color white T shirt"); break;
                        case 4: Console.WriteLine("you choosed small size for childen with color black T shirt"); break;
                        case 5: Console.WriteLine("you choosed small size for childen with color green T shirt"); break;
                    } break;
                case 2:
                    Console.WriteLine("Enter for color you are looking for: 1-blue 2-red, 3-white,4-black, 5-green");
                    int color1 = int.Parse(Console.ReadLine());
                    switch (color1)
                    {
                        case 1: Console.WriteLine("you choosed small size for ladies blue T shirt"); break;
                        case 2: Console.WriteLine("you choosed small size for ladies red T shirt"); break;
                        case 3: Console.WriteLine("you choosed small size for ladies white T shirt"); break;
                        case 4: Console.WriteLine("you choosed small size for ladies black T shirt"); break;
                        case 5: Console.WriteLine("you choosed small size for ladies green T shirt"); break;
                    }
                    break;
            } break;
        case 2: break;
        case 3: goto start;
        case 4: return;
    }

    for(int i = 0; i<size; i++)
    {
        if (size > 4)
        {
            continue;
        }
        Console.WriteLine("size are avilable");
    }
}
