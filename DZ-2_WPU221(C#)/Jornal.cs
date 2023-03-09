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
                $"Электронный адрес журнала: {_emale}");
        }
    }
    internal class Jornal1
    {
        static void Main(string[] args)
        {
            Jornal j1 = new Jornal();
            j1.PrintJornal();
        }
    }
}
