using System;

public class Refrigerante : IAcompanhamento{

  public string GetDescricao(){
    return "Refrigerante";
  }

  public double GetPreco(){
    return 6.50;
  }
}