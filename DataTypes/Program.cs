// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
   

// DATA TYPES string name = "Khadija";
int age = 22;
double height = 5.6;
char letter = 'A';
bool isEmployer = false;

Console.WriteLine(age);
Console.Write(letter + "B");
Console.WriteLine(height);
Console.WriteLine(!isEmployer);

// TYPE CASTING
// implicit casting
int a = 8;
double b = a;
Console.WriteLine(b + " " + "int double-a cevrildi");

// explicit casting
double c = 12.3;
int d = (int)c;
Console.WriteLine(d + " " + "double int-a cevrildi");

// String cevrilmesi
string e = "22";
int f = int.Parse(e);
Console.WriteLine(f + " " + "string int-a cevrildi");

int g = 28;
string h = g.ToString();
Console.WriteLine(h + " " + "int string-e cevrildi");


