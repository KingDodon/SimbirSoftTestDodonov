using System;
using System.Collections.Generic;
using System.Text;
using SimbirSoftTestDodonov.Views;

namespace SimbirSoftTestDodonov.Views
{
    class View :IView
    {
        public event Action<string> Address;
        public void Error(string err)
        {
            Console.WriteLine(err);
        }
        public void ReadAddress()
        {
            Console.Write("Введите адрес сайта: ");
            Address?.Invoke(Console.ReadLine());
        }
        public void Print(string st, int num)
        {
            Console.WriteLine("{0} - {1}",st,num);
        }
    }
}
