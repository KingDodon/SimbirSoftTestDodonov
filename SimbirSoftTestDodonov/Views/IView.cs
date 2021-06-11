using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoftTestDodonov.Views
{
    interface IView
    {
        event Action<string> Address;
        void Error(string err);
        void ReadAddress();
        void Print(string st, int num);
    }
}
