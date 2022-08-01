// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

byte byt = 5;
sbyte sbyt = 5;

short shrt = 5;
ushort ushrt = 5;

int i = 0;
Int16 i16 = 0;
Int32 i32 = 0;
Int64 i64 = 0;

uint  ui = 0;
long lg = 0;
ulong ulg = 0;

float f = 0;
double d = 0;
decimal dc = 0;

char ch = 'A';
string s = "Asım";


bool b = false;
bool b1 = true;

DateTime dateTime = DateTime.Now;

object o1 = null;
object o2 = "y";
object o3 = 'x';
object o4 = 4;
object o5 = 5.5;

string str = string.Empty;
str = "Mehmet Asım Sezer";
string ad = "Mehmet Asım";
string soyad = "Sezer";
string tamisim = ad + " " + soyad;
Console.WriteLine(tamisim);

int sayi1 = 5;
int sayi2 = 3;
int toplam = sayi1 + sayi2;

bool bool1 = 10 > 2;

string str1 = "20";
int int1 = 20;

int top = int1 + Convert.ToInt32(str1);
Console.WriteLine(top);

string yenideger = str1 + int1.ToString();
Console.WriteLine(yenideger);

int int3 = int1 + int.Parse(str1);
Console.WriteLine(int3);

string date = dateTime.ToString("dd.MM.yyyy");
Console.WriteLine(date);