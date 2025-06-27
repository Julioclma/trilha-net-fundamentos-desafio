using DesafioFundamentos.App.Controller;
using DesafioFundamentos.App.Menu;
using DesafioFundamentos.App.Repository;
using DesafioFundamentos.App.Service;

//inicializa programa
Menu menu =
new Menu(
    new ParkController(
        new CarService(new CarRepository()),
        new SaleService(new SaleRepository())
    )
);

menu.Application();