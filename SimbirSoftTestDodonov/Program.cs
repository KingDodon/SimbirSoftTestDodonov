using System;
using SimbirSoftTestDodonov.Views;
using SimbirSoftTestDodonov.Presenters;
using SimbirSoftTestDodonov.Models;

namespace SimbirSoftTestDodonov
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            View view = new View();
            Presenter presenter = new Presenter(view, model);
            presenter.WaitString();
        }
    }
}
