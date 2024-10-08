using System;
using System.Collections.Generic;

private class Bank{
  private string Name {get; set;}
  private int Code {get; set;}

  private List<Branch> Filiais;
  private List<Client> Clientes;

  public Bank(string Nome, int Cod){
    Name = Nome;
    Code = Cod;
    Filiais = new List<Branch>;
    Clientes = new List<Client>;
  }
  
  private void addBranch(Branch filial){
    Filiais.Add(filial);
  }
  
  private void removeBranch(Branch filial){
    Filiais.Remove(filial);
  }
  
  private Branch[] getBranches(){
    return Filiais.ToArray();
  }
  
  private Branch getBranch(int code){
    Filiais.Find(x => x.Code == code);
  }
  
  private void addClient(Client cliente){
    Clientes.Add(cliente);
  }

  private Client getClient(string cpf){
    Clientes.Find(x => x.CPF == cpf);
  }

}