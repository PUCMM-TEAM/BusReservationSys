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
    public class CreditCardSqlRepository : IRepository<CreditCard>
    {
        private Context _context;

        public CreditCardSqlRepository(Context context)
        {
            _context = context;
        }

        public void Create(CreditCard entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.CreditCards.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            CreditCard creditcard = Read(id);
            creditcard.Deleted = true;
            Update(creditcard);
        }

        public CreditCard Read(int id)
        {
            return _context.CreditCards.Where(x => x.Deleted == false && x.ID == id).First();
        }

        public void Read(int id, IResponse<CreditCard> reponse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CreditCard> ReadAll()
        {
            return _context.CreditCards.Where(x => x.Deleted == false);
        }

        public void ReadAll(IListResponse<CreditCard> callback)
        {
            throw new NotImplementedException();
        }

        public void Update(CreditCard entity)
        {
            CreditCard creditcard = Read(entity.ID);
            creditcard.CardHolder = entity.CardHolder;
            creditcard.CardNumber = entity.CardNumber;
            creditcard.CVC = entity.CVC;
            creditcard.ExpirationDate = entity.ExpirationDate;
            entity.ModifiedDate = DateTime.Now;

            _context.Entry(creditcard).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
