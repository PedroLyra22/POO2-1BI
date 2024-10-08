using System;

public class Picles extends DecoratorHamburguer{

  public Picles(IHamburguer hamburguer): base(hamburguer){}

  public override string GetDescricao(){
    return _hamburguer.GetDescricao() + ", Picles";
  }

  public override double GetPreco(){
    return _hamburguer.GetPreco() + 3.0;
  }
}