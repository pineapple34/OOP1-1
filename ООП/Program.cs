using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП
{
    class Program
    {
        static void Main(string[] args)
        {
            Buyer buyer1 = new Buyer();
            buyer1.Soname = "Иванов";
            buyer1.Name = "Иван";
            buyer1.Patronymic = "Иванович";
            buyer1.Address = "г. Москва, ул. Ленина, 1, 11";
            buyer1.CardNum = "1234567890123456";
            buyer1.BankNum = "12345678901234567890";

            Console.Write("Фамилия \t" + buyer1.Soname + "\n");
            Console.Write("Имя \t" + buyer1.Name + "\n");
            Console.Write("Отчество \t" + buyer1.Patronymic + "\n");
            Console.Write("Адрес \t" + buyer1.Address + "\n");
            Console.Write("Номер карты \t" + buyer1.CardNum + "\n");
            Console.Write("Номер банковского счета \t" + buyer1.BankNum + "\n");

            Console.ReadKey();
        }
    }

    class Buyer
    {
        public string Soname, Name, Patronymic, Address, CardNum, BankNum;
    }
}
