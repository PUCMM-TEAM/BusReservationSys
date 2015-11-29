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
  public class VehicleRepository : IRepository<Vehicle>{
    private List<Entity> _vehicles;

    public VehicleRepository(){
      _vehicles = new List<Entity>();

      _vehicles.Add(new Vehicle{ID = 1, Name = "OMSA", PassengerCapacity = 40, Description = "La melma bus", VehicleType = "Public Bus"});
      _vehicles.Add(new Vehicle { ID = 2, Name = "Boladora", PassengerCapacity = 10, Description = "La melma bus", VehicleType = "Public Bus" });
    }

    public void Create(Vehicle entity){
      _vehicles.Add(entity);
    }

    public void Read(int id, IResponse<Vehicle> reponse){
      throw new NotImplementedException();
    }

    public Vehicle Read(int id){
      throw new NotImplementedException();
    }

    public void Update(Vehicle entity){
      throw new NotImplementedException();
    }

    public void Delete(int id){
      throw new NotImplementedException();
    }

    public void ReadAll(IListResponse<Vehicle> callback){
      throw new NotImplementedException();
    }

    public IEnumerable<Vehicle> ReadAll(){
      throw new NotImplementedException();
    }
  }
}
