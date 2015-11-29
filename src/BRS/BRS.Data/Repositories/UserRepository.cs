using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRS.Core;
using BRS.Core.CallBacks;
using BRS.Core.Models;
using BRS.Core.Repositories;

namespace BRS.Data.Repositories {
  public class UserRepository : IRepository<User>{
    private List<User> _users;

    public UserRepository(){
      _users = new List<User>();
    }

    public void Create(User entity){
      _users.Add(entity);
    }

    public void Read(int id, IResponse<User> reponse){
      throw new NotImplementedException();
    }

    public User Read(int id){
      return _users.Find(x => x.ID == id);
    }

    public void Update(User entity){
      throw new NotImplementedException();
    }

    public void Delete(int id){
      throw new NotImplementedException();
    }

    public void ReadAll(IListResponse<User> callback){
      throw new NotImplementedException();
    }

    public IEnumerable<User> ReadAll(){
      return _users;
    }
  }
}
