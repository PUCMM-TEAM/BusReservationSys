using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BRS.WebUI.Models {
  public class NewUserViewModel {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string CardHolder { get; set; }
    public string CardNumber { get; set; }
    public string CVC { get; set; }
    public int ExpirationDate { get; set; }
  }
}