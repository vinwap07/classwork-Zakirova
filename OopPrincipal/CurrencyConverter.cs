using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopPrincipal;

    public static class CurrencyConverter // в статическом классе нельзя использовать не статические поля
    {
        //public int Currency { get; set; }
        public static string PluralizeRubles(this int amount)
        {
            if (amount % 10 == 1 && amount % 100 != 11)
            {
                return $"{amount} рубль";
            }

            if (amount % 10 > 1 && amount % 10 < 5 && amount % 100 > 11 && amount % 100 < 15)
            {
                return $"{amount} рублей";
            }

            return $"{amount} рубля";
        }
    // класс, где есть только методы расширения, обычно пишут с припиской в конце Ext
        public static string PresentationStudent(this Student student)
        {
            return $"{student.Name}-{student.StartStudy}-{student.Age}";
        }
}

