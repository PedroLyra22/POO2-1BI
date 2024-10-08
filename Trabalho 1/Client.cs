using System;
using System.Collections.Generic;

public class Client{
  public string CPF {get; set;}
  public string Name {get; set;}
  public string Address {get; set;}
  public string Phone {get; set;}
  public string EMail {get; set;}

  private Bank Banco;
  private List<Account> Contas;
  
  public Client(string cpf, string nome, string endereço, string telefone, strign email){
    CPF = cpf;
    Name = nome;
    Address = endereço;
    Phone = telefone;
    EMail = email;
  }
}

