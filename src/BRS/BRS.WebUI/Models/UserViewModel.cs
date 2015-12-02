

using System.Collections;
using System.Collections.Generic;
using BRS.Core.Models;

namespace BRS.WebUI.Models {
  public class UserViewModel {
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public int RoleId { get; set; }
    public int CustomerId { get; set; }
    public IEnumerable<Role> Roles { get; set; }
    public IEnumerable<Customer> Customers { get; set; }
  }
}