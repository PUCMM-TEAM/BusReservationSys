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
  public class CustomerRepository : IRepository<Customer>{
    private List<Customer> _customers;

    public CustomerRepository(){
      _customers = new List<Customer>();
    }

    public void Create(Customer entity){
      _customers.Add(entity);
    }

    public void Read(int id, IResponse<Customer> reponse){
      throw new NotImplementedException();
    }

    public Customer Read(int id){
      return _customers.Find(x => x.ID == id);
    }

    public void Update(Customer entity){
      throw new NotImplementedException();
    }

    public void Delete(int id){
      _customers.Remove(Read(id));
    }

    public void ReadAll(IListResponse<Customer> callback){
      throw new NotImplementedException();
    }

    public IEnumerable<Customer> ReadAll(){
      return _customers;
    }
  }
}
