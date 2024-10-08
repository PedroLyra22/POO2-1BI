using System;

public class Suco : IAcompanhamento{

  public string GetDescricao(){
    return "Suco";
  }

  public double GetPreco(){
    return 5.50;
  }
}