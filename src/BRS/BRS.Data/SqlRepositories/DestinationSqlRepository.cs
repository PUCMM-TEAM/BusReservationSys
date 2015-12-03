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
  /// Clase representativa de un repositorio de destinos que hereda la funcionabilidad de IRepository.
  /// Dicho repositorio extrae la data desde una base de datos ms sql.
  /// </summary>
    public class DestinationSqlRepository : IRepository<Destination>
    {
      /// <summary>
      /// El contexto que maneja la base datos.
      /// </summary>
        private Context _context;

        /// <summary>
        /// Crea una instancia que contiene un contexto dado
        /// </summary>
        /// <param name="context">Contexto de data</param>
        public DestinationSqlRepository(Context context)
        {
            _context = context;
        }

      /// <summary>
      /// Agrega una entidad al contexto
      /// </summary>
      /// <param name="entity">La entidad que se desea agregar</param>
        public void Create(Destination entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Destinations.Add(entity);
            _context.SaveChanges();
        }

      /// <summary>
      /// Elimina una entidad del contexto
      /// </summary>
      /// <param name="id">El indice del contexto</param>
        public void Delete(int id)
        {
            Destination destination = Read(id);
            destination.Deleted = true;
            Update(destination);
        }

      /// <summary>
      /// Busca y devuelve una entidad en el contexto
      /// </summary>
      /// <param name="id">El indice de la entidad</param>
      /// <returns>La entidad encontrada</returns>
        public Destination Read(int id)
        {
            return _context.Destinations.FirstOrDefault(x => x.Deleted == false && x.ID == id);
        }

        public void Read(int id, IResponse<Destination> reponse)
        {
            throw new NotImplementedException();
        }

      /// <summary>
      /// Devuelve todas las entidades del contexto que existen
      /// </summary>
      /// <returns>Retorna las entidades</returns>
        public IEnumerable<Destination> ReadAll()
        {
            return _context.Destinations.Where(x=>x.Deleted==false);
        }

        public void ReadAll(IListResponse<Destination> callback)
        {
            throw new NotImplementedException();
        }

      /// <summary>
      /// Actualiza una entidad en el contexto
      /// </summary>
      /// <param name="entity">la entidad</param>
        public void Update(Destination entity)
        {
            Destination destination = Read(entity.ID);
            destination.Name = entity.Name;
            destination.ModifiedDate = DateTime.Now;

            _context.Entry(destination).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
