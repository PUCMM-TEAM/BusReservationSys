using System;
using System.Collections.Generic;
using BRS.Core;
using BRS.Core.CallBacks;
using BRS.Core.Models;
using BRS.Core.Repositories;

namespace BRS.Data.Repositories {
  public class TripRepository : IRepository<Trip>{
    private List<Trip> _trips;

    public TripRepository(){
      _trips = new List<Trip>();
    }

    public void Create(Trip entity){
      _trips.Add(entity);
    }

    public void Read(int id, IResponse<Trip> reponse){
      throw new NotImplementedException();
    }

    public Trip Read(int id){
      return _trips.Find(x => x.ID == id);
    }

    public void Update(Trip entity){
      throw new NotImplementedException();
    }

    public void Delete(int id){
      throw new NotImplementedException();
    }

    public void ReadAll(IListResponse<Trip> callback){
      throw new NotImplementedException();
    }

    public IEnumerable<Trip> ReadAll(){
      return _trips;
    }
  }
}
