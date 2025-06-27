using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFundamentos.App.Entity;

namespace DesafioFundamentos.App.Repository
{
    public class SaleRepository
    {
        public List<SaleEntity> saleEntities;

        public SaleRepository()
        {
            this.saleEntities = new List<SaleEntity>();
        }
        public void Add(SaleEntity saleEntity)
        {
            System.Console.WriteLine("Venda cadastrada com sucesso!");
            this.saleEntities.Add(saleEntity);
        }
    }
}