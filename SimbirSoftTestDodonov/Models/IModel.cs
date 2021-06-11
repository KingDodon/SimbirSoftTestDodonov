using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoftTestDodonov.Models
{
    interface IModel
    {
        Dictionary<string, int> Statistics(string address);
    }
}
