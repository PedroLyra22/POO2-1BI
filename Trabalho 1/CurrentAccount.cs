using System;

private class CurrentAccount : Account{
  private float ServiceFee {get; set;}
  private float Limit {get; set;}

  public CurrentAccount(float taxa, float limite, int n_conta, float balanço, Date data_abertura, Branch filial, Client cliente) : base(int n_conta, float balanço, Date data_abertura, Branch filial, Client cliente){
    ServiceFee = taxa;
    Limit = limite;
  }
}