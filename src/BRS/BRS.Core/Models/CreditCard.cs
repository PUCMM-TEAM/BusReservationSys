namespace BRS.Core.Models {
  public class CreditCard : Entity {
    public string CardHolder { get; set; }
    public string CardNumber { get; set; }
    public string CVC { get; set; }
    public int ExpirationDate { get; set; }
  }
}
