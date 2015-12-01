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
    public class UserSqlRepository : IRepository<User>
    {
        private Context _context;

        public UserSqlRepository()
        {
            _context = new Context();
        }

        public void Create(User entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;

            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            User user = Read(id);
            user.Deleted = true;
            Update(user);
        }

        public User Read(int id)
        {
            return _context.Users.Where(x => x.Deleted == false && x.ID == id).First();
        }

        public void Read(int id, IResponse<User> reponse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> ReadAll()
        {
            return _context.Users.Where(x => x.Deleted == false);
        }

        public void ReadAll(IListResponse<User> callback)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            User user = Read(entity.ID);
            user.Username = entity.Username;
            user.Email = entity.Email;
            user.Password = entity.Password;
            entity.ModifiedDate = DateTime.Now;

            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Role GetRoleInstance(Erole erole) {
            var roles = _context.Roles;
            switch (erole)
            {
                case Erole.Administrator:
                    return roles.Where(x => x.Name.Contains("Admin")).First();
                case Erole.Operator:
                    return roles.Where(x => x.Name.Contains("Opera")).First();
                case Erole.Customer:
                    return roles.Where(x => x.Name.Contains("Cust")).First();
                default:
                    return roles.Where(x => x.Name.Contains("Gues")).First();
            }
        }
    }



    public enum Erole
    {
        Administrator,
        Operator,
        Customer,
        Guest
    }
}
