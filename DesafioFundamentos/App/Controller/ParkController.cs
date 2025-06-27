using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFundamentos.App.Entity;
using DesafioFundamentos.App.Service;

namespace DesafioFundamentos.App.Controller
{
    public class ParkController
    {
        private CarService CarService;
        private SaleService SaleService;


        public ParkController(CarService carService, SaleService saleService)
        {
            this.CarService = carService;
            this.SaleService = saleService;
        }
        public void Add(string placa)
        {
            // adiciona veiculo
            this.CarService.Add(placa);

        }

        public void Remove()
        {
            // remove veiculo
        }

        public string All()
        {
            // lista todos veiculo
            return this.CarService.All();
        }

        public void Sale(CarEntity carEntity, int hour)
        {
            // lista todos veiculo
             this.SaleService.Sale(carEntity, hour);
        }
        
    }
}