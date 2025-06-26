using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.App.Menu
{
    public class Menu
    {
        public bool Program = true;

        /// <summary>
        /// Inicializa Aplicação
        /// </summary>
        public void Application()
        {
            System.Console.WriteLine("Aplicação rodando...");

            while (this.Program)
            {
                Console.WriteLine("Defina qual será o nome do estacionamento");
                this.Program = false;
            }

        }
    }
}