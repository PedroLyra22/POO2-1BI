using System;

public class Bacon extends DecoratorHamburguer{
  
  public Bacon(IHamburguer hamburguer): base(hamburguer){}

  public override string GetDescricao(){
    return _hamburguer.GetDescricao() + ", Bacon";
  }

  public override double GetPreco(){
    return _hamburguer.GetPreco() + 4.0;
  }
}