using System;

namespace projec {

    class cs {

        static void Main() {
            //console: dotnet run || run
            //--------lesson 1----------------------
            // Console.WriteLine("Hello word!...");
            // Console.Write("Hello");
            // Console.Write("Hello");
            // Console.ReadKey();
            // Console.ReadLine();
            //--------------------------------------
            
            //--------lesson 2----------------------
            // int number = -10; содержайт цифры больших значений, только целых чисел 
            // uint number = 10; содержайт только целый и неминусный чисело
            // byte number = 10; содержайт цифры не боляше чем 225
            // short number = 10;содержайт цифры не боляше чем 32600
            // long number = 10; содержайт цифры огромных значений
            // float number = 1.54f; содержайт цифры больших значений, целый, нецелый и минусный чисел 
            // double number = 10.541d; содержайт цифры огромных значений, целый, нецелый и минусный чисел 
            // string - кароче это str
            // double number = 10.541d;
            // string word = "Переменная: ";

            // bool isHappy = true; true false

            // Console.WriteLine(word + number);
            // ---------------------------------
            // |||||||||||||||||||||||||||||||||
            // -------------Program-------------
            // int num_1 = 0, num_2 = 0; 

            // num_1 = Convert.ToInt32(Console.ReadLine());
            // num_2 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("First: " + num_1 + ". Second:" + num_2);
            // ---------------------------------
            // |||||||||||||||||||||||||||||||||
            // -------------lesson 3------------
            // Console.Write("Введите число с точкой: ");
            // // user_input = Convert.ToDouble(Console.ReadLine());
            // float user_input = float.Parse(Console.ReadLine()); 

            // float result;
            // result = user_input + 10f;

            // result *= 2f;

            // result--;
            // // result = user_input * 10f;
            // // result = user_input * 10f;
            // // result = user_input / 10f;
            // // result = user_input % 10f;

            // // int a =  5, b = 6;
            // // int res = a % b;

            // Console.WriteLine("Переменная: " + result);
            // -------------------------------------------
            // Console.WriteLine(Math.Abs(-20));
            // Console.WriteLine(Math.Ceiling(4.56f));
            // Console.WriteLine(Math.Floor(4.99f));
            // // Console.WriteLine(Math.Round(4.54f));
            // Console.WriteLine(Math.Min(4, 5));
            // Console.WriteLine(Math.Max(4, 5));
            // Console.WriteLine(Math.Pow(5, 3));
            // -------------------------------------------
            // System.Console.WriteLine("Введите радиус круга: ");
            // double radius = Convert.ToDouble(Console.ReadLine());
            // double area = Math.PI * Math.Pow(radius, 2);
            // System.Console.WriteLine("Площадь круга с радиусом {0} равна {1}", radius, area);
            // -------------------------------------------
            // |||||||||||||||||||||||||||||||||||||||||||
            // --------------lesson 5---------------------
            // != - Неравно
            int a = 5;

            if(a !=5) {
                System.Console.WriteLine("Number is 5");
            } else{
                System.Console.WriteLine("Number is not 5");
            }
        }
    }

}