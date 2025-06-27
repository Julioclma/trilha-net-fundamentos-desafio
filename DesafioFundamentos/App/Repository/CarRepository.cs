using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFundamentos.App.Entity;
using DesafioFundamentos.App.Service;

namespace DesafioFundamentos.App.Repository
{
    public class CarRepository
    {
        public List<CarEntity> Cars;

        public CarRepository()
        {
            this.Cars = new List<CarEntity>();
        }
        public void Add(CarEntity carEntity)
        {
            // adiciona veiculo
            this.Cars.Add(carEntity);
            System.Console.WriteLine($"Carro de Placa {carEntity.Placa} foi adicionado com sucesso!");
        }

        public string All()
        {
            string info = "**Carros**\n";
            foreach (CarEntity car in this.Cars)
            {
                if (car.FlagActive)
                {
                    info += $"Placa: {car.Placa}\n";
                }
            }
            return info;
        }
    }
}