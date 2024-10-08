using System;

private class Account{
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
    }
      debitAmount(amount);
      conta.creditAmount(amount);  
  } 
}
