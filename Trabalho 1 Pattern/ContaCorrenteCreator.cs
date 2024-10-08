using System;

public class ContaCorrenteCreator : IAccountFactory{

  public float taxa;
  public float limite;

  public ContaCorrenteCreator(float taxa, float limite){
    this.taxa = taxa;
    this.limite = limite;
  }
  
  public IAccount criarConta(int n_conta, float balanço, Date data_abertura, Branch filial, Client cliente){
    return new CurrentAccount(taxa, limite, n_conta, balanço, data_abertura, filial, cliente);
  }
}