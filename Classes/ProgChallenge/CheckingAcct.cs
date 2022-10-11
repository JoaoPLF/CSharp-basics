class CheckingAcct : Account {
  private const decimal OVERDRAW_CHARGE = 35.0m;
  public CheckingAcct(string firstName, string lastName, decimal balance) : base(firstName, lastName, balance) {}

  public override void Withdraw(decimal value) {
    if (value > Balance) {
      value += OVERDRAW_CHARGE;
    }

    base.Withdraw(value);
  }
}