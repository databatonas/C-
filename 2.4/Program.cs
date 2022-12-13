// Типы данных
Console.WriteLine();
/*bool: хранит значение true или false (логические литералы). 
Представлен системным типом System.Boolean (Система. Логтческий (перевод))*/
bool alive = true;
bool isDead = false;
Console.WriteLine(alive);
Console.WriteLine(isDead);
Console.WriteLine();
/*byte: хранит целое число от 0 до 255 и занимает 1 байт. 
Представлен системным типом System.Byte*/
byte bit1 = 1;
byte bit2 = 102;
Console.WriteLine(bit1);
Console.WriteLine(bit2);
Console.WriteLine();
/*sbyte: хранит целое число от -128 до 127 и занимает 1 байт. 
Представлен системным типом System.SByte*/
sbyte bit3 = -101;
sbyte bit4 = 102;
Console.WriteLine(bit3);
Console.WriteLine(bit4);
Console.WriteLine();
/*short: хранит целое число от -32768 до 32767 и занимает 2 байта.
Представлен системным типом System.Int16*/
short n1 = 1;
short n2 = 102;
Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine();
/*ushort: хранит целое число от 0 до 65535 и занимает 2 байта. 
Представлен системным типом System.UInt16*/
ushort n3 = 1;
ushort n4 = 102;
Console.WriteLine(n3);
Console.WriteLine(n4);
Console.WriteLine();
/*int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта.
 Представлен системным типом System.Int32. 
 Все целочисленные литералы по умолчанию представляют значения типа int:*/
 int a = 10;
int b = 0b101;  // бинарная форма b =5
int c = 0xFF;   // шестнадцатеричная форма c = 255
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine();
/*uint: хранит целое число от 0 до 4294967295 и занимает 4 байта. 
Представлен системным типом System.UInt32*/
uint d = 10;
uint e = 0b101;
uint f = 0xFF;
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine();
/*long: хранит целое число от –9 223 372 036 854 775 808 
до 9 223 372 036 854 775 807 и занимает 8 байт.
 Представлен системным типом System.Int64*/
long g = -10;
long h = 0b101;
long j = 0xFF;
Console.WriteLine(g);
Console.WriteLine(h);
Console.WriteLine(j);
Console.WriteLine();
/*ulong: хранит целое число от 0 
до 18 446 744 073 709 551 615 и занимает 8 байт. 
Представлен системным типом System.UInt64*/
ulong k = 10;
ulong l = 0b101;
ulong z = 0xFF;
Console.WriteLine(k);
Console.WriteLine(l);
Console.WriteLine(z);
Console.WriteLine();
Console.WriteLine("float: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта. \nПредставлен системным типом System.Single");
Console.WriteLine();
Console.WriteLine("double: хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта. \nПредставлен системным типом System.Double");
Console.WriteLine();
Console.WriteLine("decimal: хранит десятичное дробное число. Если употребляется без десятичной запятой, \nимеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт. Представлен системным типом System.Decimal");
Console.WriteLine();
/*char: хранит одиночный символ в кодировке Unicode и занимает 2 байта. 
Представлен системным типом System.Char. Этому типу соответствуют символьные литералы:*/
char x = 'A';//Соответствует А
char v = '\x5A';//Соответствует Z
char m = '\u0420';//Соответствует P
Console.WriteLine(x);
Console.WriteLine(v);
Console.WriteLine(m);
Console.WriteLine();
/*string: хранит набор символов Unicode. Представлен системным типом System.String.
 Этому типу соответствуют строковые литералы.*/
string hello = "Hello";
string word = "world";
Console.WriteLine(hello);
Console.WriteLine(word);
Console.WriteLine();
/*object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе 
и 8 байт на 64-разрядной платформе. 
Представлен системным типом System.Object, 
который является базовым для всех других типов и классов .NET.*/
object q = 22;
object w = 3.14;
object r = "hello code";
Console.WriteLine(q);
Console.WriteLine(w);
Console.WriteLine(r);
Console.WriteLine();
Console.WriteLine("Например, определим несколько переменных разных типов и выведем их значения на консоль:");
string name = "Tom";
int age = 33;
bool isEmployed = false;
double weight = 78.65;
 /*Для вывода данных на консоль здесь применяется интерполяция: 
 перед строкой ставится знак $ и после этого мы можем вводить в 
 строку в фигурных скобках значения переменных.
  Консольный вывод программы:*/
Console.WriteLine($"Имя: {name}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Вес: {weight}");
Console.WriteLine($"Работает: {isEmployed}");

