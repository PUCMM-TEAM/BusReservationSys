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
  public class LocalGenericRepository<T> : IRepository<T> where T: Entity {

    public void Create(T entity){
      throw new NotImplementedException();
    }

    public void Read(int id, IResponse<T> reponse){
      throw new NotImplementedException();
    }

    public T Read(int id){
      throw new NotImplementedException();
    }

    public void Update(T entity){
      throw new NotImplementedException();
    }

    public void Delete(int id){
      throw new NotImplementedException();
    }

    public void ReadAll(IListResponse<T> callback){
      throw new NotImplementedException();
    }

    public IEnumerable<T> ReadAll(){
      throw new NotImplementedException();
    }
  }
}
