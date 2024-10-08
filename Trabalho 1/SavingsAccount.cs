using System;

private class SavingsAccount : Account{
  private float Rate {get; set;}

  public SavingsAccount(float rendimento, int n_conta, float balanço, Date data_abertura, Branch filial, Client cliente) : base (int n_conta, float balanço, Date data_abertura, Branch filial, Client cliente){
    Rate = rendimento;
  }
}