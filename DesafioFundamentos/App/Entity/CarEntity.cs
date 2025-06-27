using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.App.Entity
{
    public class CarEntity(string Placa)
    {
        public string Placa { get; } = Placa;
        public bool FlagActive { get; } = true;
    }
}