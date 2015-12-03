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
  /// Clase representativa de un repositorio de usuario que hereda la funcionabilidad de IRepository.
  /// Dicho repositorio extrae la data desde una base de datos ms sql.
  /// </summary>
  public class UserSqlRepository : IRepository<User> {
    /// <summary>
    /// El contexto que maneja la base datos.
    /// </summary>
    private Context _context;
    /// <summary>
    /// Crea una instancia que contiene un contexto dado
    /// </summary>
    /// <param name="context">Contexto de data</param>
    public UserSqlRepository(Context context) {
      _context = context;
    }
    /// <summary>
    /// Agrega una entidad a la base de datos
    /// </summary>
    /// <param name="entity">La entidad</param>
    public void Create(User entity) {
      entity.CreatedDate = DateTime.Now;
      entity.ModifiedDate = DateTime.Now;

      _context.Users.Add(entity);
      _context.SaveChanges();
    }

    /// <summary>
    /// Elimina una entidad del contexto
    /// </summary>
    /// <param name="id"></param>
    public void Delete(int id) {
      User user = Read(id);
      user.Deleted = true;
      Update(user);
    }

    public User Read(int id) {
      return _context.Users.First(x => x.Deleted == false && x.ID == id);
    }

    public void Read(int id, IResponse<User> reponse) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// retorna todas las entidades que no esten borradas
    /// </summary>
    /// <returns>Las entidades</returns>
    public IEnumerable<User> ReadAll() {
      return _context.Users.Where(x => x.Deleted == false);
    }

    public void ReadAll(IListResponse<User> callback) {
      throw new NotImplementedException();
    }
    /// <summary>
    /// Actualiza una entidad en el contexto
    /// </summary>
    /// <param name="entity">La entidad</param>
    public void Update(User entity) {
      User user = Read(entity.ID);
      user.Username = entity.Username;
      user.Email = entity.Email;
      user.Password = entity.Password;
      entity.ModifiedDate = DateTime.Now;

      _context.Entry(user).State = EntityState.Modified;
      _context.SaveChanges();
    }
  }
}
