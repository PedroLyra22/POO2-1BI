using System;

public class ContaPoupancaCreator : IAccountFactory{
  
  public float rendimento;

  public ContaPoupanacCreator(float rendimento){
    this.rendimento = rendimento;
  }
  
  public IAccount criarConta(int n_conta, float balanço, Date data_abertura, Branch filial, Client cliente){
    return new SavingAccount(rendimento, n_conta, balanço, data_abertura, filial, cliente);
  }
}