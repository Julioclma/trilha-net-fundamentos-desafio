using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.App.Entity
{
    public class ParkEntity
    {
        private string Name { get; }
        private double InitialValue { get; }
        private double PricePerHour { get; }
        public ParkEntity(string name, double value, double pricePerHour)
        {
            Name = name;
            InitialValue = value;
            PricePerHour = pricePerHour;
        }
        public string Info()
        {
            return $" **Estacionamento Informação**\nEstacionamento: {Name}\nValor inicial: {InitialValue}\nValor por hora: {PricePerHour}";
        }
    }
}