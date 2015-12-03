using System.Linq;
using BRS.Core.Models;
using BRS.Data;
using BRS.Data.SqlRepositories;

namespace BRS.Logical.Account 
{
  /// <summary>
  /// Clase representativa de la sección del usuario
  /// Esta clase es un singleton
  /// </summary>
  public class UserSessionManager {
    /// <summary>
    /// La instancia del singleton
    /// </summary>
    private static UserSessionManager _instance;
    /// <summary>
    /// El usuario que esta autenticado en el sistema
    /// </summary>
    private User _currentUser;

    /// <summary>
    /// Crea una instancia y y asigna por defecto el usuario visitante
    /// </summary>
    private UserSessionManager() {
      Role role = GetRole(Erole.Guest);
      var list = RepositoryFactory.Instance().UserRepository().ReadAll().Where(x => x.Role == role);
      _currentUser = list.FirstOrDefault();
    }

    /// <summary>
    /// Propiedad estatica de devulve la instancia 
    /// </summary>
    public static UserSessionManager Instance {
      get {
        if (_instance == null) _instance = new UserSessionManager();
        return _instance;
      }
    }

    /// <summary>
    /// Atentica el usuario
    /// </summary>
    /// <param name="username">El nombre de usuario</param>
    /// <param name="password">La contraseña</param>
    /// <returns></returns>
    public bool LoginUser(string username, string password) {
      var list = RepositoryFactory.Instance().UserRepository().ReadAll().Where(x => x.Username.ToLower().Contains(username.ToLower()) && x.Password.ToLower().Contains(password.ToLower())).ToList();

      if (list.Count == 0) return false;

      _currentUser = list.First();
      return true;
    }

    /// <summary>
    /// Propiedad que devuelve el usuario actual.
    /// </summary>
    public User CurrentUser {
      get { return _currentUser; }
    }

    /// <summary>
    /// Metodo para obtener la instancia de un role
    /// </summary>
    /// <param name="erole">La enumeración del role</param>
    /// <returns>La instancia del role</returns>
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

    /// <summary>
    /// Retorna una enumeración del usuario actual
    /// </summary>
    public Erole UserRole {
      get {
        var role = _currentUser.Role;
        switch (role.Name) {
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

