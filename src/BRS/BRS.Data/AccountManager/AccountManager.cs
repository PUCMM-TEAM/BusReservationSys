using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRS.Core.Models;

namespace BRS.Data.AccountManager {
  public class AccountManager{
    private static AccountManager _instance;
    private User currentUser;

    private AccountManager(){
      
    }

    public static AccountManager Instance {
      get{
        if(_instance == null) _instance = new AccountManager();
        return _instance;
      }
    }

    public void LoginUser(string username, string password){
      
    }
  }
}
