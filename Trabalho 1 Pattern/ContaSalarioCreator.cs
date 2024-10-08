using System;

public class SalaryAccountCreator : IAccountFactory{
  
  public IAccount criaConta(int n_conta, float balanço, Date data_abertura, Branch filial, Client cliente){
    return new SalaryAccount(n_conta, balanço, data_abertura, filial, cliente);
  }
  
}