class Account {
  private string _firstName;
  private string _lastName;
  public decimal Balance {
    get; set;
  }

  public Account(string firstName, string lastName, decimal balance = 0.00m) {
    _firstName = firstName;
    _lastName = lastName;
    Balance = balance;
  }

  public virtual void Deposit(decimal value) {
    Balance += value;
  }

  public virtual void Withdraw(decimal value) {
    Balance -= value;
  }

  public string AccountOwner {
    get => $"{_firstName} {_lastName}";
  }
}