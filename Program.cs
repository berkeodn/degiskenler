byte b = 5;     // 1 byte
sbyte c = 5;    // 1 byte

short s = 5;    // 2 byte
ushort us = 5;  // 2 byte

Int16 i16 = 2;  // 2 byte
int i = 2;      // 4 byte
Int32 i32 = 2;  // 4 byte
Int64 i64 = 2;  // 8 byte

uint ui = 2;    // 4 byte
long l = 4;     // 8 byte
ulong ul = 4;   // 8 byte

//Reel Sayılar
float f = 5;    // 4 byte
double d = 5;   // 8 byte
decimal de = 5; // 16 byte

char ch = '2';  // 2 byte
string str = "Berke"; //sınırsız

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;

Console.WriteLine(dt);

object o1 = "x";
object o2 = 4;
object o3 = 4.3;

//string ifadeler

string str1 = string.Empty;
str1 = "Berke ÖDEN";
string ad = "Berke";
string soyad = "ÖDEN";
string tamIsim = ad + " " + soyad;

//integer tanımlama şekilleri

int int1 = 5;
int int2 = 3;
int int3 = int1 * int2;

//boolean

bool bo1 = 10<2;

//Degisken Dönüsümleri

string str20 = "20";
int int20 = 20;

string yeniDeger = str20 + int20.ToString();

Console.WriteLine(yeniDeger); //çıktısı 2020

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21); //çıktısı 40

int int22 = int20 + int.Parse(str20); //çıktısı 40

// datetime
string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datetime1 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime1);

// saat
string hour = DateTime.Now.ToString("hh:mm");
Console.WriteLine(hour);


