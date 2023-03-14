using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace DZ_2_WPU221_C__
{
    class Jornal
    {
        public string _name;
        public string _age;
        public string _description;
        public string _phone;
        public string _emale;

        public Jornal() //конструктор по умолчанию
        {
            _name = "Radio";
            _age = "1988";
            _description = "Magazine about amateur radio";
            _phone = "8(246)5981135";
            _emale = "radio@gmail.com";
        }

        public Jornal(string name, string age, string description, string phone, string emale) //перегрузка конструктора
        {
            _name = name;
            _age = age;
            _description = description;
            _phone = phone;
            _emale = emale;
        }

        public void PrintJornal() //вывод инфы про журнал
        {
            WriteLine($"Название журнала: {_name}\nГод основания журнала: {_age}\n" +
                $"Описание журнала: {_description}\nТелефон журнала: {_phone}\n" +
                $"Электронный адрес журнала: {_emale}\n");

        }

        public void DataEntry() //ручное заполнение инфы по журналу
        {
            Write("Введите название сайта: ");
            _name = ReadLine();
            Write("Введите год основания журнала: ");
            _age = ReadLine();
            Write("Введите описание журнала: ");
            _description = ReadLine();
            Write("Введите контактный номер телефона журнала: ");
            _phone = ReadLine();
            Write("Введите контактный эл. адрес журнала: ");
            _emale = ReadLine();
            WriteLine();
        }

        public void Correction()
        {
            WriteLine("***Корректировка данных журнала***");
            WriteLine("Выберите один из пунктов меню: \n1 - Изменить название журнала; \n2 - Изменить год основания журнала; " +
                "\n3 - Изменить описание журнала; \n4 - Изменить контактный номер телефона журнала;\n5 - Изменить эл. адрес журнала" +
                " \n0 - Ничего не менять и выйти из программы.");

            int choice = int.Parse(ReadLine());

            if (choice >= 0 && choice <= 5)
            {
                switch (choice)
                {
                    case 1:
                        Write("Введите название журнала: ");
                        _name = ReadLine();
                        break;
                    case 2:
                        _age = ReadLine();
                        Write("Введите год основания журнала: ");
                        break;
                    case 3:
                        Write("Введите описание журнала: ");
                        _description = ReadLine();
                        break;
                    case 4:
                        Write("Введите номер телефона: ");
                        _phone = ReadLine();
                        break;
                    case 5:
                        Write("Введите эл. адрес журнала: ");
                        _emale = ReadLine();
                        break;
                    case 0:
                        break;
                }
            }
            else { WriteLine("Введены не корректные данные"); }

        }
    }
    internal class Jornal1
    {
        static void Main(string[] args)
        {
            Jornal j1 = new Jornal();
            j1.PrintJornal();

            Jornal j2 = new Jornal();
            j2.DataEntry();
            j2.PrintJornal();

            j2.Correction();
            j2.PrintJornal();

        }
    }
}
