Console.WriteLine("Использование суффиксов");
Console.WriteLine();
Console.WriteLine("При присвоении значений надо иметь в виду следующую тонкость: \nвсе вещественные литералы (дробные числа) рассматриваются как значения типа double. \nИ чтобы указать, что дробное число представляет тип float или тип decimal, \nнеобходимо к литералу добавлять суффикс: F/f - для float и M/m - для decimal.");
float a = 3.14F;
float b = 30.6f;
decimal c = 1005.8M;
decimal d = 334.8m;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine();
Console.WriteLine("Подобным образом все целочисленные литералы рассматриваются как значения типа int. Чтобы явным образом указать, \nчто целочисленный литерал представляет значение типа uint, \nнадо использовать суффикс U/u, для типа long - суффикс L/l, а для типа ulong - суффикс UL/ul:");
uint g = 10U;
long e = 20L;
ulong f = 30UL;
Console.WriteLine(g);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine();
Console.WriteLine("Использование системных типов");
Console.WriteLine();
Console.WriteLine("Выше при перечислении всех базовых типов данных для каждого упоминался системный тип. \nПотому что название встроенного типа по сути представляет собой сокращенное обозначение системного типа. \nНапример, следующие переменные будут эквивалентны по типу:");
Console.WriteLine("int h = 4; \nSystem.Int32 j = 4; ");
int h = 4;
System.Int32 j = 4;
Console.WriteLine(h);
Console.WriteLine(j);
Console.WriteLine();
Console.WriteLine("Неявная типизация");
Console.WriteLine("Ранее мы явным образом указывали тип переменных, например, int x;. \nИ компилятор при запуске уже знал, что x хранит целочисленное значение.\nОднако мы можем использовать и модель неявной типизации:");
Console.WriteLine("var hello = \"Hell to World;\"");
Console.WriteLine("var x = 20;");
Console.WriteLine();
var hello = "Hell to World";
Console.WriteLine(hello);
var x = 20;
Console.WriteLine(x);
Console.WriteLine();
Console.WriteLine("Для неявной типизации вместо названия типа данных используется ключевое слово var. \nЗатем уже при компиляции компилятор сам выводит тип данных исходя из присвоенного значения. \nТак как по умолчанию все целочисленные значения рассматриваются \nкак значения типа int, то поэтому в итоге переменная c будет иметь тип int. \nАналогично переменной hello присваивается строка, поэтому эта переменная будет иметь тип string");
Console.WriteLine("Эти переменные подобны обычным, однако они имеют некоторые ограничения.");
Console.WriteLine("Во-первых, мы не можем сначала объявить неявно типизируемую переменную, \nа затем инициализировать:");
Console.WriteLine ("этот код работает");
Console.WriteLine("int q; q = 20;");
int q;
q = 20;
Console.WriteLine(q);
Console.WriteLine("этот код не работает");
Console.WriteLine("w= 20; var w;");

Console.WriteLine("Во-вторых, мы не можем указать в качестве значения неявно типизируемой переменной null: \nэтот код не работает.");
Console.WriteLine("var c=null;");

