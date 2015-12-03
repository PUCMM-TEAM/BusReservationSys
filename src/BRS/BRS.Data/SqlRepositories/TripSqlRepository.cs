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
    public class TripSqlRepository : IRepository<Trip>
    {
      /// <summary>
      /// El contexto que maneja la base datos.
      /// </summary>
        private Context _context;

        /// <summary>
        /// Crea una instancia que contiene un contexto dado
        /// </summary>
        /// <param name="context">Contexto de data</param>
        public TripSqlRepository(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// Agregar una entidad al contexto
        /// </summary>
        /// <param name="entity">la entidad</param>
        public void Create(Trip entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Trips.Add(entity);
            _context.SaveChanges();
        }

      /// <summary>
      /// Elimina una entidad del contexto
      /// </summary>
      /// <param name="id">el indice del contexto</param>
        public void Delete(int id)
        {
            Trip trip = Read(id);
            trip.Deleted = true;
            Update(trip);
        }

      /// <summary>
      /// Busca y retorna una entidad del contexto
      /// </summary>
      /// <param name="id">el indice de la entidad</param>
      /// <returns>la entidad</returns>
        public Trip Read(int id)
        {
            return _context.Trips.FirstOrDefault(x => x.Deleted == false && x.ID == id);
        }

        public void Read(int id, IResponse<Trip> reponse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trip> ReadAll()
        {
            return _context.Trips.Where(x => x.Deleted == false);
        }

        public void ReadAll(IListResponse<Trip> callback)
        {
            throw new NotImplementedException();
        }

      /// <summary>
      /// Busca y actualizada una entidad en el contexto
      /// </summary>
      /// <param name="entity">la entidad</param>
        public void Update(Trip entity)
        {
            Trip trip = Read(entity.ID);
            trip.Route = entity.Route;
            trip.DateAvailable = entity.DateAvailable;
            trip.DepartureTime = entity.DepartureTime;
            trip.ArrivalTime = entity.ArrivalTime;
            trip.Vehicle = entity.Vehicle;
            trip.Price = entity.Price;
            entity.ModifiedDate = DateTime.Now;

            _context.Entry(trip).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
