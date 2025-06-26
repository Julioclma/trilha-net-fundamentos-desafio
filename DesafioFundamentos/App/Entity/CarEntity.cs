using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.App.Entity
{
    public class CarEntity(string Name)
    {
        private string Name { get; } = Name;
    }
}