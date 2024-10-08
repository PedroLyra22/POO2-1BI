using System;
using System.Collections.Generic;

private class Branch{
  private string Name {get; set;}
  private int Code {get; set;}
  private string City {get; set;}

  private Bank Banco;
  private List<Account> Contas;

  public Branch(string nome, int cod, string cidade, Bank banco){
    Name = nome;
    Code = cod;
    City = cidade;
    Banco = banco;
    Contas = new List<Account>;
  }

  private void addAccount(Account conta){
    Contas.Add(conta);
  }
  
  private void removeAccount(Accountm conta){
    Contas.Remove(conta);
  }
  
  private Account getAccount(int acc_Number){
    Contas.Find(x => x.Acc_number == acc_Number);
  }
  
}