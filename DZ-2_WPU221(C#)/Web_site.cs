using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace DZ_2_WPU221_C__
{
    class Website   //тело класса
    {
        public string Name { get; set; }         //Наименование сайта
        public string Url { get; set; }         //Адрес сайта
        public string Description{ get; set; }  //Описание сайта
        public string IP { get; set; }          //IP-адрес сайта

        public Website() //конструктор по умолчанию
        {
            Name = "Blank Page";
            Url = "www.BlankPage.ua";
            Description = "Этот сайт ещё не наполнен контентом";
            IP = "127.0.0.1";   
        }

        public Website (string name, string url, string description, string iP) //перегрузка конструктора
        {
            Name = name;
            Url = url;
            Description = description;
            IP = iP;
        }   

        public void PrintWebSite() //вывод инфы про сайт
        {
            WriteLine($"Название сайта: {Name}\nПуть к сайту: {Url}\nОписание сайта: {Description}\nIP-адрес сайта: {IP}\n");
        }

        public void DataEntry () //ручное заполнение инфы по сайту
        {
            Write("Введите название сайта: ");
            Name = ReadLine();
            Write("Введите адрес сайта: ");
            Url = ReadLine();
            Write("Введите описание сайта: ");
            Description = ReadLine();
            Write("Введите IP-адрес сайта: ");
            IP = ReadLine();
            WriteLine();
        }

        public void Correction()
        {
            WriteLine("***Корректировка данных сайта***");
            WriteLine ("Выберите один из пунктов меню: \n1 - Изменить имя сайта; \n2 - Изменить адрес сайта; \n3 - Изменить описание сайта;" +
                "\n4 - Изменить IP-адрес сайта; \n0 - Ничего не менять и выйти из программы.");

            int choice = int.Parse(ReadLine());

            if (choice>=0 && choice <=4)
            {
                switch (choice)
                {
                    case 1:
                        Write("Введите название сайта: ");
                        Name = ReadLine();
                        break;
                    case 2:
                        Url = ReadLine();
                        Write("Введите адрес сайта: ");
                        break;
                    case 3:
                        Write("Введите описание сайта: ");
                        Description = ReadLine();
                        break;
                    case 4:
                        Write("Введите IP-адрес сайта: ");
                        IP = ReadLine();
                        break;
                    case 0:
                        break;
                }
            }else { WriteLine("Введены не корректные данные"); }
            
        }


    }
    internal class Website_1
    {
        static void Main(string[] args)
        {
            Website emptyness = new Website(); //создал пустой сайт
            Website weapon = new Website("weapon", "www.weapon.ua", "Сайт по продаже оружия", "127.0.0.12"); //создал сайт с помощью конструктора
            
            emptyness.PrintWebSite();
            weapon.PrintWebSite();

            emptyness.DataEntry(); //вручную изменяем данные сайта
            emptyness.PrintWebSite();//вывод для проверки

            //обращение к отдельным полям класса конкретного объекта
            weapon.Correction();
            weapon.PrintWebSite();
        }
    }
}
