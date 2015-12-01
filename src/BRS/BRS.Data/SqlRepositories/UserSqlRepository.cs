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

            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
