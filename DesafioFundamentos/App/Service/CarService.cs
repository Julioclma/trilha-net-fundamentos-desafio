using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFundamentos.App.Entity;
using DesafioFundamentos.App.Repository;

namespace DesafioFundamentos.App.Service
{
    public class CarService
    {
        public CarRepository CarRepository;

        public CarService(CarRepository carRepository)
        {
            CarRepository = carRepository;
        }
        public void Add(string placa)
        {
            // adiciona veiculo
            this.CarRepository.Add(new CarEntity(placa));

        }

        public void Remove()
        {
            // remove veiculo
        }

        public string All()
        {
            // remove veiculo
            return this.CarRepository.All();
        }
    }
}