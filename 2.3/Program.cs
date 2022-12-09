﻿// Литералы
Console.WriteLine(true); // Логический литерал "Истина".
Console.WriteLine(false); // Логический литерал "Ложь".

/* С целыми числами в десятичной форме все должно быть понятно,
 так как они используются в повседневной жизни:*/
Console.WriteLine(-11);
Console.WriteLine(5);
Console.WriteLine(505);

/*Числа в двоичной форме предваряются символами 0b, 
после которых идет набор из нулей и единиц:*/
Console.WriteLine(0b11);        // 3
Console.WriteLine(0b1011);      // 11
Console.WriteLine(0b100001);    // 33

/*Для записи числа в шестнадцатеричной форме применяются символы 0x,
 после которых идет набор символов от 0 до 9 и от A до F,
  которые собственно представляют число:*/
Console.WriteLine(0x0A);    // 10
Console.WriteLine(0xFF);    // 255
Console.WriteLine(0xA1);    // 161

//Строковые литералы
/*Строковые литералы представляют строки. Строки заключаются в двойные кавычки:*/
Console.WriteLine("hello");
Console.WriteLine("фыва");
Console.WriteLine("hello word");

/*Если внутри строки необходимо вывести двойную кавычку, 
то такая внутренняя кавычка предваряется обратным слешем:*/
Console.WriteLine("Компания \"Рога и копыта\"");

/*Также в строках можно использовать управляющие последовательности.
 Например, последовательность '\n' осуществляет перевод на новую строку:*/
Console.WriteLine("Привет \nмир");
