using System;

class MonitorMontagem : IPedidoObserver{

  public void Atualizar(Pedido pedido){
    Console.WriteLine("Montagem informada: " + pedido.DescricaoCompleta());
  }
}