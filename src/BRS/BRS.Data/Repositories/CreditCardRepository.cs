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
  public class CreditCardRepository : IRepository<CreditCard>{
    private List<CreditCard> _creditCards;

    public CreditCardRepository(){
      _creditCards = new List<CreditCard>();
    }

    public void Create(CreditCard entity){
      _creditCards.Add(entity);
    }

    public void Read(int id, IResponse<CreditCard> reponse){
      throw new NotImplementedException();
    }

    public CreditCard Read(int id){
      return _creditCards.Find(x => x.ID == id);
    }

    public void Update(CreditCard entity){
      CreditCard creditCard = Read(entity.ID);

      creditCard.CardHolder = entity.CardHolder;
      creditCard.CardNumber = entity.CardNumber;
      creditCard.CVC = entity.CVC;
      creditCard.ExpirationDate = entity.ExpirationDate;
    }

    public void Delete(int id){
      _creditCards.Remove(Read(id));
    }

    public void ReadAll(IListResponse<CreditCard> callback){
      throw new NotImplementedException();
    }

    public IEnumerable<CreditCard> ReadAll(){
        return _creditCards;
    }
  }
}
