using System;

class SavingsAcct : Account {
  private decimal _interestRate;
  private int _withdrawCount = 0;
  private const decimal WITHDRAW_CHARGE = 2.0m;
  private const int WITHDRAW_LIMIT = 3;
  
  public SavingsAcct(string firstName, string lastName, decimal interestRate, decimal balance) : base(firstName, lastName, balance) {
    _interestRate = interestRate;
  }

  public void ApplyInterest() {
    Balance += (Balance * _interestRate);
  }

  public override void Withdraw(decimal value) {
    if (value > Balance) {
      Console.WriteLine("Attempt to overdraw savings - denied");
    }
    else {
      base.Withdraw(value);
      _withdrawCount++;

      if (_withdrawCount > WITHDRAW_LIMIT) {
        Console.WriteLine("More than 3 withdraws - extra charge");
        base.Withdraw(WITHDRAW_CHARGE);
      }
    }
  }
}