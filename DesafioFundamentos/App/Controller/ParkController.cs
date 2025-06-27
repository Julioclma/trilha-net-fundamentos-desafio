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

        public void Sale(string placa, int hour)
        {
            // pesquisa veículo
            CarEntity carEntity = this.CarService.FindByPlaca(placa);
            this.SaleService.Sale(carEntity, hour);
        }

        public string Sales()
        {
            // Lista Vendas
            return this.SaleService.All();
        }



    }
}