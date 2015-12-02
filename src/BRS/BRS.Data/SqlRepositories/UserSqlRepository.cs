using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BRS.Core;
using BRS.Core.CallBacks;
using BRS.Core.Models;
using BRS.Core.Repositories;

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
            return _context.Users.First(x => x.Deleted == false && x.ID == id);
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
                    return roles.First(x => x.Name.Contains("Admin"));
                case Erole.Operator:
                    return roles.First(x => x.Name.Contains("Opera"));
                case Erole.Customer:
                    return roles.First(x => x.Name.Contains("Cust"));
                default:
                    return roles.First(x => x.Name.Contains("Gues"));
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
