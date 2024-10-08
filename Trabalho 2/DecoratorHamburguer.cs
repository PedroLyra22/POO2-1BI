using System;

public abstract class DecoratorHamburguer : IHamburguer{
  
  protected IHamburguer _hamburguer;

  public DecoratorHamburguer(IHamburguer hamburguer){
    _hamburguer = hamburguer;
  }

  public virtual string GetDescricao(){
    return _hamburguer.GetDescricao();
  }

  public virtual double GetPreco(){
    return _hamburguer.GetPreco();
  }
}