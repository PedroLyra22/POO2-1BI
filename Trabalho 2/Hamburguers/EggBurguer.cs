using System;

public class EggBurguer : IHamburguer{

  public string GetDescricao(){
    return "Eggburguer (Pão, Carne, Queijo e Ovo)";
  }

  public double GetPreco(){
    return 12.0;
  }
}