//class Program
//{
//    static void MyMethod()
//    {
//        Console.WriteLine("Hello, World!");
//    }
//    static void Main(string[] args)
//    {
//        MyMethod();
//    }

//}


//class Program
//{
//    public int Sum (int a, int b)
//    {
//        return a + b;
//    }
//    static void Main(string[] args)
//    {
//        Program p = new Program();
//        int result = p.Sum(12, 23);
//        Console.WriteLine(result);
//    }
//}

//class Cars
//{
//    public string model = string.Empty;
//    public int year;
//    public string color = string.Empty;

//    static void Main(string[] args)
//    {
//        Cars car = new Cars();
//        car.model = "Toyota";
//        car.year = 2022;
//        Console.WriteLine("May car is a" + " " + car.model +" " + "from"+ " " + car.year);
//    }
//}

//Ededin tek ve ya cut oldugunu yoxlayan program

class Program
{
    public static void CheckType(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("eded cutdur");
        }
        else
        {
            Console.WriteLine("eded tekdir");
        }
    }
    public static void Main()
    {
        Console.Write("Ededi daxil edin:");
        int num = Convert.ToInt32(Console.ReadLine());
        CheckType(num);
    }
}