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

        public void DataEntry () //попытка сделать ручное заполнение инфы по сайту
        {
            //WriteLine("Введите наименование сайта: ");
            //Name = ReadLine();
            //WriteLine("Введите адрес сайта: ");
            //Url = ReadLine();
            //WriteLine("Введите описание сайта: ");
            //Description = ReadLine();
            //WriteLine("Введите IP-адрес сайта: ");
            //IP = ReadLine();
        }


    }
    internal class Website_1
    {
        static void Main(string[] args)
        {
            Website emptyness = new Website();
            Website weapon = new Website("weapon", "www.weapon.ua", "Сайт по продаже оружия", "127.0.0.12");
            
            emptyness.PrintWebSite();
            weapon.PrintWebSite();
    
        }
    }
}
