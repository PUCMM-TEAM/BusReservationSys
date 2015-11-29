

using System.Collections.Generic;
using BRS.Core;
using BRS.Core.CallBacks;
using BRS.Core.Models;
using BRS.Core.Repositories;

namespace BRS.Data.Repositories {
  public class DestinationRepository : IRepository<Destination>{
    private List<Destination> _destinations;

    public DestinationRepository(){
      _destinations = new List<Destination>();

      Create(new Destination {ID = 1, Name = "Santo Domingo"});
      Create(new Destination { ID = 2, Name = "Santiago" });
    }

    public void Create(Destination entity){
      _destinations.Add(entity);
    }

    public void Read(int id, IResponse<Destination> reponse){
      throw new System.NotImplementedException();
    }

    public Destination Read(int id){
      return _destinations.Find(x => x.ID == id);
    }

    public void Update(Destination entity){
      throw new System.NotImplementedException();
    }

    public void Delete(int id){
      _destinations.Remove(Read(id));
    }

    public IEnumerable<Destination> ReadAll(){
      return _destinations;
    }

    public void ReadAll(IListResponse<Destination> callback){
      throw new System.NotImplementedException();
    }
  }
}
