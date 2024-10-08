using System;

public class HamburguerSimples : IHamburguer{

  public string GetDescricao(){
    return "Hamburguer Simples (Pão, Carne e Queijo)";
  }

  public double GetPreco(){
    return 10.0;
  }
}