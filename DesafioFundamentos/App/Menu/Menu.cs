using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DesafioFundamentos.App.Controller;
using DesafioFundamentos.App.Entity;

namespace DesafioFundamentos.App.Menu
{
    public class Menu
    {
        public bool Program = true;
        public ParkEntity ParkEntity;
        private ParkController ParkController;

        public Menu(ParkController parkController)
        {
            ParkController = parkController;
        }
        /// <summary>
        /// Inicializa Aplicação
        /// </summary>
        public void Application()
        {
            System.Console.WriteLine("Aplicação rodando...");
            this.SetPark();

            while (this.Program)
            {
                this.Options();
            }

        }
        private void Options()
        {
            System.Console.WriteLine("1 - Cadastrar Veículo\n2 - Remover Veículo\n3 - Listar Veículos\n4 - Ver informações do Estacionamento\n5 - Encerrar");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    System.Console.WriteLine("Insira a placa do veículo");
                    this.ParkController.Add(Console.ReadLine());
                    break;
                case "1":
                    System.Console.WriteLine("Insira a placa do veículo");
                    this.ParkController.Add(Console.ReadLine());
                    break;
                case "3":
                    Console.Clear();
                    System.Console.WriteLine(this.ParkController.All());
                    break;
                case "4":
                    Console.WriteLine(this.ParkEntity.Info());
                    break;
                case "5":
                    this.Program = false;
                    Console.Clear();
                    Console.WriteLine("Programa Encerrado com sucesso!");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida, insira novamente!");
                    break;
            }

        }
        private void SetPark()
        {
            string parkName;
            double initialValue;
            double valuePerHour;

            Console.WriteLine("Defina qual será o nome do estacionamento");
            parkName = Console.ReadLine();
            Console.WriteLine("Defina qual será o preço inicial");
            initialValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Agora insira o valor por hora");
            valuePerHour = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Estacionamento cadastrado com sucesso");

            this.ParkEntity = new ParkEntity(parkName, initialValue, valuePerHour);
        }
    }
}