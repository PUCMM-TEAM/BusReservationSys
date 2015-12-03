using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BRS.WebUI.Models {
  public class LoginUserViewModel {
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
  }
}