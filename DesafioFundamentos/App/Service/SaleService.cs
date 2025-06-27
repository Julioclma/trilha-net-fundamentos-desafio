using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFundamentos.App.Entity;
using DesafioFundamentos.App.Repository;

namespace DesafioFundamentos.App.Service
{
    public class SaleService
    {
        public SaleRepository SaleRepository;
        public SaleService(SaleRepository saleRepository)
        {
            this.SaleRepository = saleRepository;
        }
        public void Sale(CarEntity carEntity, int hour)
        {
            SaleEntity saleEntity = new SaleEntity(carEntity, hour);

            this.SaleRepository.Add(saleEntity);
        }

        public string All()
        {
            // remove veiculo
            return this.SaleRepository.All();
        }

    }
}