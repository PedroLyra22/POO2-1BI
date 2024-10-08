using System;

public class Pedido{
  
  private List<IPedidoObserver> _observers = new List<IPedidoObserver>();
  private List<IAcompanhamento> _acompanhamentos = new List<IAcompanhamento>();
  public IHamburguer Hamburguer { get; private set; }
  public string Status { get; private set; }

  public Pedido(IHamburguer hamburguer){

    Hamburguer = hamburguer;
    Status = "Em produção";
    
  }

  public void AdicionarObserver(IPedidoObserver observer){

    _observers.Add(observer);
    
  }
  
  public void AdicionarAcompanhamento(IAcompanhamento acompanhamento){

    _acompanhamentos.Add(acompanhamento);
    
  }

  public void NotificarObservers(){   
    foreach (var observer in _observers){
      observer.Atualizar(this);
    }
  }

  public void FinalizarPedido(){

    Status = "Pronto para entrega";
    NotificarObservers();

    Console.WriteLine("Pedido: " + this.DescricaoCompleta());
    Console.WriteLine("Preço: " + this.CalculaPreco());
    
  }

  public string DescricaoCompleta(){
    
    string descricao = Hamburguer.GetDescricao();

    foreach (var acompanhamento in _acompanhamentos){
      descricao += ", " + acompanhamento.GetDescricao();
    }

    return descricao;
  }

  public double CalcularPreco(){

    double preco = Hamburguer.GetPreco();

    foreach (var acompanhamento in _acompanhamentos){
      preco += acompanhamento.GetPreco();
    }

    return preco;
  }
}