using System;
class Aula06{
    static void Main(){
        double ValorCompra=5.50;
        double ValorVenda;
        double lucro=0.1;
        string produto="Pastel";

        ValorVenda=ValorCompra+(ValorCompra*lucro);

          Console.WriteLine("Produto...........:{0,15}", produto);
          Console.WriteLine("Val.Compra........:{0,15:c}", ValorCompra);
          Console.WriteLine("Lucro.............:{0,15:p}", lucro);
          Console.WriteLine("Val.Venda.........:{0,15:c}", ValorVenda);


    }
}