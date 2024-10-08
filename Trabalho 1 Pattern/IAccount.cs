using System; 

private interface IAccount{
  
  private void debitAmount(float amount);
  private void creditAmount(float amount);
  private float getBalance();
  private void transfer(Account conta, float amount);

}