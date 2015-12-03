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
  /// <summary>
  /// Clase representativa de un repositorio de tarjeta de credito que hereda la funcionabilidad de IRepository.
  /// Dicho repositorio extrae la data desde una base de datos ms sql.
  /// </summary>
     public class RouteSqlRepository : IRepository<Route>
    {
       /// <summary>
       /// El contexto que maneja la base datos.
       /// </summary>
        private Context _context;

        /// <summary>
        /// Crea una instancia que contiene un contexto dado
        /// </summary>
        /// <param name="context">Contexto de data</param>
        public RouteSqlRepository(Context context)
        {
            _context = context;
        }

       /// <summary>
       /// Agrega una entidad al contexto
       /// </summary>
       /// <param name="entity"></param>
        public void Create(Route entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Routes.Add(entity);
            _context.SaveChanges();
        }

       /// <summary>
       /// Elimina una entidad de la base de datos
       /// </summary>
       /// <param name="id"></param>
        public void Delete(int id)
        {
            Route route = Read(id);
            route.Deleted = true;
            Update(route);
        }

       /// <summary>
       /// Busca y devuelve una entidad en el contexto
       /// </summary>
       /// <param name="id">El indice de la entidad que se desea buscar</param>
       /// <returns>la entidad</returns>
        public Route Read(int id)
        {
            return _context.Routes.FirstOrDefault(x => x.Deleted == false && x.ID == id);
        }

        public void Read(int id, IResponse<Route> reponse)
        {
            throw new NotImplementedException();
        }

       /// <summary>
       /// Devuelve todas las entidades que no esten borradas del contexto
       /// </summary>
       /// <returns></returns>
        public IEnumerable<Route> ReadAll()
        {
            return _context.Routes.Where(x => x.Deleted == false);
        }

        public void ReadAll(IListResponse<Route> callback)
        {
            throw new NotImplementedException();
        }

       /// <summary>
       /// Actualiza una entidad en el contexto
       /// </summary>
       /// <param name="entity">La entidad</param>
        public void Update(Route entity)
        {
            Route route = Read(entity.ID);
            route.Pickup = entity.Pickup;
            route.DropOff = entity.DropOff;
            entity.ModifiedDate = DateTime.Now;

            _context.Entry(route).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }


}
