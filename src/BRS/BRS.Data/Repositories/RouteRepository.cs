using System;
using System.Collections.Generic;
using BRS.Core;
using BRS.Core.CallBacks;
using BRS.Core.Models;
using BRS.Core.Repositories;

namespace BRS.Data.Repositories {
  public class RouteRepository : IRepository<Route>{

    private List<Route> _routes;

    public RouteRepository(){
      _routes = new List<Route>();

      IRepository<Destination> repo = new DestinationRepository();
      _routes.Add(new Route{ID = 1, Pickup = repo.Read(1), DropOff = repo.Read(2)});
      _routes.Add(new Route { ID = 2, Pickup = repo.Read(2), DropOff = repo.Read(1) });
    }

    public Route Read(int id){
      return _routes.Find(x => x.ID == id);
    }

    public void Read(int id, IResponse<Route> reponse){
      throw new NotImplementedException();
    }

    public void Create(Route entity){
      throw new NotImplementedException();
    }

    public void Delete(int id){
      throw new NotImplementedException();
    }

    public void Update(Route entity){
      throw new NotImplementedException();
    }

    public IEnumerable<Route> ReadAll(){
      throw new NotImplementedException();
    }

    public void ReadAll(IListResponse<Route> callback){
      throw new NotImplementedException();
    }
  }
}
