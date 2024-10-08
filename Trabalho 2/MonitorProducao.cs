using System;

class MonitorProducao : IPedidoObserver{

  public void Atualizar(Pedido pedido){
    Console.WriteLine("Produção informada: " + pedido.DescricaoCompleta());
  }
}