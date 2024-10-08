using System;

public class Sundae : IAcompanhamento{

  public string GetDescricao(){
    return "Sundae";
  }

  public double GetPreco(){
    return 8.0;
  }
}