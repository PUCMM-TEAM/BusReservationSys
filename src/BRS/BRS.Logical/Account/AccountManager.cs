using System.Linq;
using BRS.Core.Models;
using BRS.Data;
using BRS.Data.SqlRepositories;

namespace BRS.Logical.Account {
  public class AccountManager {
    private static AccountManager _instance;
    private User _currentUser;
    private UserSqlRepository _repository;

    private AccountManager() {
      _repository = new UserSqlRepository();
      Role role = _repository.GetRoleInstance(Erole.Guest);
      _currentUser = RepositoryFactory.Instance().UserRepository().ReadAll().First(x => x.Role == role);
    }

    public static AccountManager Instance {
      get {
        if (_instance == null) _instance = new AccountManager();
        return _instance;
      }
    }

    public bool LoginUser(string username, string password) {
      User user = RepositoryFactory.Instance().UserRepository().ReadAll().First(x => x.Username.ToLower().Contains(username.ToLower()) && x.Password.ToLower().Contains(password.ToLower()));

      if (user != null) {
        _currentUser = user;
        return true;
      }

      return false;
    }

    public User CurrentUser {
      get { return _currentUser; }
    }

    public Role GetRole(Erole erole){
      
      //switch (erole) {
      //  case Erole.Administrator:
      //    return roles.First(x => x.Name.Contains("Admin"));
      //  case Erole.Operator:
      //    return roles.First(x => x.Name.Contains("Opera"));
      //  case Erole.Customer:
      //    return roles.First(x => x.Name.Contains("Cust"));
      //  default:
      //    return roles.First(x => x.Name.Contains("Gues"));
      //}
    }

    public Erole UserRole {
      get {
        var role = _currentUser.Role;
        switch (role.Name) {
          case "Administrador":
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
  }
}

