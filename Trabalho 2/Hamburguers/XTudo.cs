using System;

public class XTudo : IHamburguer{

  public string GetDescricao(){
    return "Hamburguer Completo (Pão, Carne, Queijo, Ovo, Alface e Tomate, Picles e Bacon)";
  }

  public double GetPreco(){
    return 20.0;
  }
}