using System;

private class SavingsAccount : Account{
  
  private float Rate {get; set;}

  public SavingsAccount(float rendimento, int n_conta, float balanço, Date data_abertura, Branch filial, Client cliente) : base (int n_conta, float balanço, Date data_abertura, Branch filial, Client cliente){
    Rate = rendimento;
  }

  public int saquesMes = 0;

  public void saque(float amount){
    this.debitAmount(amount);
    saquesMes++;

    if(saquesMes > 3){
      this.debitAmount(1);
    }
  }

  public void render(){
    this.creditAmount(this.Balance * Rate);
  }

  private void transfer(Account conta, float amount){
    if (amount < 0){
      throw new Exception("Valor inválido");
    } if (amount > this.Balance){
      throw new Exception("Saldo insuficiente");
    } if (this.Cliente != conta.Cliente){
      throw new Exception("Transferência para outros clientes não autorizada!");
    }
    debitAmount(amount);
    conta.creditAmount(amount);     
  } 
  
}