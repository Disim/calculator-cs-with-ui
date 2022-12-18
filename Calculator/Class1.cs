using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace first
{
    class Class1
    {
        double height;
        double width;
        List<double> list;
        List<string> text = new List<string> { "Введите хоть что-то", "Вы напугали деда", "Введите высоту" };
        Random random = new Random();

        public Class1(Label firstLabel, Label label1, Label label2)
        {
            label2.Text = (text[random.Next(0, text.Count - 1)] + "\nДля ввода высоты перейдите на вторую\nвкладку");
            height = firstLabel.Height;
            //Class1 val = new Class1(firstLabel, label1, label2, Convert.ToInt32(read()));
        }

        public Class1(Label firstLabel, Label label1, Label label2, double height, double width)
        {

            this.height = height;
            this.width = width;
            label2.Text = "";
            if (height <= 0)
            {
                label2.Text += ("Представим что высота 20?\n");
                height = 20;
            }

            if (width <= 0)
            {
                label2.Text += ("Пускай ширина равна 20\n");
                width = 20;
            }

            if (height * width > 800)
            {
                label2.Text += ("Вот это апартаменты!\n");
            }
            else
            {
                label2.Text += ("Ну, пойдёт\n");
            }

            //obiem(width, height);
            //label2.Text += ("Только сегодня, вы можете узнать объём аквариума, абсолютно бесплатно!");
            //label2.Text += ("Введите 1, если хотите воспользоваться услугой. Иначе, введите что угодно: ");
            //int val = Convert.ToInt32(Console.ReadLine());
            //perimetr(val);
        }

        public Class1(Label firstLabel, Label label1, Label label2, double height)
        {
            this.height = height;
            if (height <= 0)
            {
                label2.Text = "Быть такого не может. Наверное, ты хотел сказать 20?";
                height = 20;
            }
            else if (height <= 15 && height > 0)
            {
                label2.Text = ("Низковат будет. Ну да ладно.");
            }
            else
            {
                label2.Text = ("Ого, ничё так высота для аквариума.");
            }
            label2.Text += (" Мы можем \nпосчитать лицевую площадь\nна следющей вкладке");
            //Class1 var = new Class1(firstLabel, label1, label2, height, Convert.ToInt32(read()));
        }

        //void perimetr(int val)
        //{
        //    switch (val)
        //    {
        //        case 1:
        //            {
        //                print("Мудрый выбор! Введите длину аквариума:");

        //                double length = Convert.ToSingle(Console.ReadLine());
        //                if (length <= 0)
        //                {
        //                    print("Врушка. Я то знаю что его длина 20!");
        //                    length = 20;
        //                }
        //                print("Вау, его объём: " + (height * width * length));
        //                fillWater(height, width, length);
        //                break;
        //            }
        //        default:
        //            {
        //                print("Ну ладно, пока");
        //                break;
        //            }
        //    }
        //}
        //void obiem(double width, double height)
        //{
        //    double p = width * height;
        //    print("Его площадь " + p);
        //    if (p <= 100)
        //    {
        //        print("Ути малюська");
        //    }
        //    else if (p <= 800)
        //    {
        //        print("Нормально!");
        //    }
        //    else
        //    {
        //        print("Я бы тут и сам жил!");
        //    }

        //}

        //void fillWater(double height, double width, double length = 0)
        //{
        //    print("Сколько нальём литров воды? ");
        //    double litr = Convert.ToDouble(Console.ReadLine());
        //    double v = height * width * length;
        //    double mimo = (litr * 1000 - v) / 1000;
        //    print("В аквариум с объёмом " + v + " вливаем");
        //    if (mimo < 0)
        //    {
        //        print("Графин недозаполнен на " + Math.Abs(mimo) + " литр(ов)");
        //    }
        //    else if (mimo == 0)
        //    {
        //        print("Графин полностью заполнен");
        //    }
        //    else
        //    {
        //        print("Вылилось на пол: " + mimo + " литр(ов)");
        //    }
        //}

    }

}
