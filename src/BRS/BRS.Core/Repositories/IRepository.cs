using System.Collections.Generic;
using BRS.Core.CallBacks;
using BRS.Core.Models;

namespace BRS.Core.Repositories {
    public interface IRepository<T> where T: Entity{
      void Create(T entity);
      void Read(int id, IResponse<T> reponse);
      T Read(int id);
      void Update(T entity);
      void Delete(int id);
      void ReadAll(IListResponse<T> callback);
      IEnumerable<T> ReadAll();
    }
}
