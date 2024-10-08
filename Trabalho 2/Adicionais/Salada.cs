using System;

public class Salada extends DecoratorHamburguer{

  public Salada(IHamburguer hamburguer): base(hamburguer){}

  public override string GetDescricao(){
    return _hamburguer.GetDescricao() + ", Alface e Tomate";
  }

  public override double GetPreco(){
    return _hamburguer.GetPreco() + 2.0;
  }
}