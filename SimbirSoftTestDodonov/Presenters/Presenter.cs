using System;
using System.Collections.Generic;
using System.Text;
using SimbirSoftTestDodonov.Views;
using SimbirSoftTestDodonov.Models;

namespace SimbirSoftTestDodonov.Presenters
{
    class Presenter
    {
        private IView _view;
        private IModel _model;

        public Presenter(IView view, IModel model)
        {
            _view = view;
            _model = model;
            _view.Address += Start;

        }
        public void Start(string address)
        {
            try
            {
                Dictionary<string, int> dic = _model.Statistics(address);
                ICollection<string> keys = dic.Keys;
                foreach (string k in keys)
                {
                    _view.Print(k, dic[k]);
                }
            }
            catch(Exception)
            {
                _view.Error("Выскочило исключение! Что-то пошло не так!");
            }
        }

        public void WaitString()
        {
            _view.ReadAddress();
        }
    }
}
