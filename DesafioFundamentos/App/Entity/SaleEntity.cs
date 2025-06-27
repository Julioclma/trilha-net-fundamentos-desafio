using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.App.Entity
{
    public class SaleEntity
    {

        public CarEntity CarEntity { get; }
        public int Hour { get; }
        public SaleEntity(CarEntity carEntity, int hour)
        {
            CarEntity = carEntity;
            Hour = hour;
        }
        public double Total()
        {
            return 0;
            // this.Hour * 
        }
    }
}