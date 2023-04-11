//8. Вычислить площадь круга радиуса R. Максимально задействовать 
//имеющиеся в распоряжении функции модуля «Математика».
//Головачёва Полина 22ис-21
using System;
class HelloWorld {
  static void Main() {
    double r = Convert.ToDouble(Console.ReadLine());
    double S;
    double pi = 3.14;
    S = pi * Math.Pow(r,2);
    Console.WriteLine(S);
  }
}
