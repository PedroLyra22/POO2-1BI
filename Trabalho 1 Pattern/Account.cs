using System;

private abstract class Account : IAccount{
  private int Acc_number {get; set;}
  private float Balance {get; set;}
  private Date Opening_Date {get; set;}

  private Branch Filial;
  private Client Cliente;

  public Account(int n_conta, float balanço, Date data_abertura, Branch filial, Client cliente){
    Acc_number = n_conta;
    Balance = balanço;
    Opening_Date = data_abertura;
    Filial = filial;
    Cliente = cliente;
  }
  
  private void debitAmount(float amount){
    Balance -= amount;
  }
  
  private void creditAmount(float amount){
    Balance += amount;
  }
  
  private float getBalance(){
    return Balance;
  }
  
  private void transfer(Account conta, float amount){
    if (amount < 0){
      throw new Exception("Valor inválido");
    } if (amount > this.Balance){
      throw new Exception("Saldo insuficiente");
    }
      debitAmount(amount);
      conta.creditAmount(amount);     
  } 

  private void pix(Account conta, float amount){
    Throws new Exception("Pix não autorizada!");
  }

}
