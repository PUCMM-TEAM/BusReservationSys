using System.Linq;
using BRS.Core.Models;
using BRS.Data;
using BRS.Data.SqlRepositories;

namespace BRS.Logical.Account {
  public class AccountManager {
    private static AccountManager _instance;
    private User _currentUser;

    private AccountManager() {
      Role role = GetRole(Erole.Guest);
      var list = RepositoryFactory.Instance().UserRepository().ReadAll().Where(x => x.Role == role);
      _currentUser = list.FirstOrDefault();
    }

    public static AccountManager Instance {
      get {
        if (_instance == null) _instance = new AccountManager();
        return _instance;
      }
    }

    public bool LoginUser(string username, string password) {
      var list = RepositoryFactory.Instance().UserRepository().ReadAll().Where(x => x.Username.ToLower().Contains(username.ToLower()) && x.Password.ToLower().Contains(password.ToLower())).ToList();

      if (list.Count == 0) return false;

      _currentUser = list.First();
      return true;
    }

    public User CurrentUser {
      get { return _currentUser; }
    }

    public Role GetRole(Erole erole){
      var roles = RepositoryFactory.Instance().RoleRepository().ReadAll();
      switch (erole) {
        case Erole.Administrator:
          return roles.First(x => x.Name.Contains("Admin"));
        case Erole.Operator:
          return roles.First(x => x.Name.Contains("Opera"));
        case Erole.Customer:
          return roles.First(x => x.Name.Contains("Cust"));
        default:
          return roles.First(x => x.Name.Contains("Gues"));
      }
    }

    public Erole UserRole {
      get {
        switch (_currentUser.Role.Name) {
          case "Administrator":
            return Erole.Administrator;
          case "Operator":
            return Erole.Operator;
          case "Customer":
            return Erole.Customer;
          default:
            return Erole.Guest;
        }
      }
    }

    public enum Erole {
      Administrator,
      Operator,
      Customer,
      Guest
    }
  }
}

