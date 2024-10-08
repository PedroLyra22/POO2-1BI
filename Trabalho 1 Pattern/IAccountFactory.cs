using System;

private interface IAccountFactory{
  private IAccount criarConta(int n_conta, float balanço, Date data_abertura, Branch filial, Client cliente);
}