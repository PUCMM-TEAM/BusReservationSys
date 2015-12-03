using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BRS.Core;
using BRS.Core.CallBacks;
using BRS.Core.Models;
using BRS.Core.Repositories;

namespace BRS.Data.SqlRepositories {
  /// <summary>
  /// Clase representativa de un repositorio de tarjeta de credito que hereda la funcionabilidad de IRepository.
  /// Dicho repositorio extrae la data desde una base de datos ms sql.
  /// </summary>
  public class CreditCardSqlRepository : IRepository<CreditCard> {
    /// <summary>
    /// El contexto que maneja la base datos.
    /// </summary>
    private Context _context;

    /// <summary>
    /// Crea una instancia que contiene un contexto dado
    /// </summary>
    /// <param name="context">Contexto de data</param>
    public CreditCardSqlRepository(Context context) {
      _context = context;
    }

    /// <summary>
    /// Agrega una entidad a la base de datos
    /// </summary>
    /// <param name="entity">La entidad</param>
    public void Create(CreditCard entity) {
      entity.CreatedDate = DateTime.Now;
      entity.ModifiedDate = DateTime.Now;
      _context.CreditCards.Add(entity);
      _context.SaveChanges();
    }

    /// <summary>
    /// Elimina una entidad de la base datos
    /// </summary>
    /// <param name="id">El indice de la entidad en la base datos</param>
    public void Delete(int id) {
      CreditCard creditcard = Read(id);
      creditcard.Deleted = true;
      Update(creditcard);
    }

    /// <summary>
    /// Busca en el contexto una entidad con indice "id" y lo retorna si lo encontro si no retorna null
    /// </summary>
    /// <param name="id">El indice</param>
    /// <returns>La entidad encontrada</returns>
    public CreditCard Read(int id) {
      return _context.CreditCards.FirstOrDefault(x => x.Deleted == false && x.ID == id);
    }

    public void Read(int id, IResponse<CreditCard> reponse) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Retorna todas las entidades que no en el estado de borrado desde el contexto
    /// </summary>
    /// <returns>Todas las entidades vivas</returns>
    public IEnumerable<CreditCard> ReadAll() {
      return _context.CreditCards.Where(x => x.Deleted == false);
    }

    public void ReadAll(IListResponse<CreditCard> callback) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Busca y actualizada una entidad en el contexto
    /// </summary>
    /// <param name="entity">La entidad que se va a actualizar</param>
    public void Update(CreditCard entity) {
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
