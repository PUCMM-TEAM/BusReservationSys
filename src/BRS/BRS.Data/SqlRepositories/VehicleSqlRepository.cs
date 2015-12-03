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
  /// Clase representativa de un repositorio de vehiculos que hereda la funcionabilidad de IRepository.
  /// Dicho repositorio extrae la data desde una base de datos ms sql.
  /// </summary>
     public class VehicleSqlRepository : IRepository<Vehicle>
    {
       /// <summary>
       /// El contexto que maneja la base datos.
       /// </summary>
        private Context _context;

        /// <summary>
        /// Crea una instancia que contiene un contexto dado
        /// </summary>
        /// <param name="context">Contexto de data</param>
        public VehicleSqlRepository(Context context)
        {
            _context = context;
        }

       /// <summary>
       /// Agrega una entidad al contexto
       /// </summary>
       /// <param name="entity">La nueva entidad</param>
        public void Create(Vehicle entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Vehicles.Add(entity);
            _context.SaveChanges();
        }

       /// <summary>
       /// Elimina una entidad del contexto
       /// Este le marca como borrado por tanto solo hace una eliminación virtual
       /// </summary>
       /// <param name="id">El indice de la entidad</param>
        public void Delete(int id)
        {
          Vehicle vehicle = Read(id);
          vehicle.Deleted = true;
          Update(vehicle);
        }

       /// <summary>
       /// devuelve la entidad que se desea buscar
       /// </summary>
       /// <param name="id">El indice de la entidad</param>
       /// <returns>la entidad encontrada</returns>
        public Vehicle Read(int id)
        {
            return _context.Vehicles.Find(id);
        }

        public void Read(int id, IResponse<Vehicle> reponse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> ReadAll()
        {
            return _context.Vehicles.Where(x => x.Deleted == false);
        }

        public void ReadAll(IListResponse<Vehicle> callback)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Busca y actualizada una entidad en el contexto
        /// </summary>
        /// <param name="entity">La entidad que se va a actualizar</param>
        public void Update(Vehicle entity)
        {
            Vehicle vehicle = Read(entity.ID);
            vehicle.Name = entity.Name;
            vehicle.Image = entity.Image;
            vehicle.PassengerCapacity = entity.PassengerCapacity;
            vehicle.VehicleType = entity.VehicleType;
            vehicle.Description = entity.Description;
            entity.ModifiedDate = DateTime.Now;

            _context.Entry(vehicle).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
