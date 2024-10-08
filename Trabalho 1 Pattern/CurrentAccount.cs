using System;

private class CurrentAccount : Account{
  private float ServiceFee {get; set;}
  private float Limit {get; set;}

  public CurrentAccount(float taxa, float limite, int n_conta, float balanço, Date data_abertura, Branch filial, Client cliente) : base(int n_conta, float balanço, Date data_abertura, Branch filial, Client cliente){
    ServiceFee = taxa;
    Limit = limite;
  }

  private void transfer(Account conta, float amount){
    if (amount < 0){
      throw new Exception("Valor inválido");
    } if (amount > this.Balance + this.Limit){
      throw new Exception("Saldo insuficiente");
    } if (this.Filial != conta.Filial){
      throw new Exception("Transferência externa não autorizada!");
    }
    debitAmount(amount);
    conta.creditAmount(amount);     
  } 

  private void pix(Account conta, float amount){
    if (amount < 0){
      throw new Exception("Valor inválido");
    } if (amount > this.Balance + this.Limit){
      throw new Exception("Saldo insuficiente");
    }
    debitAmount(amount);
    conta.creditAmount(amount);  
}