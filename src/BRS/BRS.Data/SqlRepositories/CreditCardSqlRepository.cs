﻿using BRS.Core.Models;
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
    public class CreditCardSqlRepository : IRepository<CreditCard>
    {
        private Context _context;

        public CreditCardSqlRepository()
        {
            _context = new Context();
        }

        public void Create(CreditCard entity)
        {
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
            

            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
