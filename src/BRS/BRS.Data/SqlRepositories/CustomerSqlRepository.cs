using BRS.Core.Models;
using BRS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRS.Core;
using BRS.Core.CallBacks;
using System.Data.Entity;

namespace BRS.Data.SqlRepositories
{
    public class CustomerSqlRepository : IRepository<Customer>
    {
        private Context _context;

        public CustomerSqlRepository()
        {
            _context = new Context();
        }

        public void Create(Customer entity)
        {
            _context.Customers.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Customer customer = Read(id);
            customer.Deleted = true;
            Update(customer);
        }

        public Customer Read(int id)
        {
            return _context.Customers.Where(x => x.Deleted == false && x.ID == id).First();
        }

        public void Read(int id, IResponse<Customer> reponse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> ReadAll()
        {
            return _context.Customers.Where(x => x.Deleted == false);
        }

        public void ReadAll(IListResponse<Customer> callback)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            Customer customer = Read(entity.ID);
            customer.FirstName = entity.FirstName;
            customer.LastName = entity.LastName;
            customer.Birthday = entity.Birthday;

            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
