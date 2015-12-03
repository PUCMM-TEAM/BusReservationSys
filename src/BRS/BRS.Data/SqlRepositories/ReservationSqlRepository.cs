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
  /// Clase representativa de un repositorio de reservaciones que hereda la funcionabilidad de IRepository.
  /// Dicho repositorio extrae la data desde una base de datos ms sql.
  /// </summary>
    public class ReservationSqlRepository : IRepository<Reservation>
    {
      /// <summary>
      /// El contexto que maneja la base datos.
      /// </summary>
        private Context _context;

        /// <summary>
        /// Crea una instancia que contiene un contexto dado
        /// </summary>
        /// <param name="context">Contexto de data</param>
        public ReservationSqlRepository(Context context)
        {
            _context = context;
        }

      /// <summary>
      /// Agrega una entidad al contexto
      /// </summary>
      /// <param name="entity">la entidad</param>
        public void Create(Reservation entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Reservations.Add(entity);
            _context.SaveChanges();
        }

      /// <summary>
      /// Elimina una entidad del contexto
      /// </summary>
      /// <param name="id">el indice de la entidad</param>
        public void Delete(int id)
        {
            Reservation reservation = Read(id);
            reservation.Deleted = true;
            Update(reservation);
        }

      /// <summary>
      /// Devuelve una entidad del contexto
      /// </summary>
      /// <param name="id">El indice de la entidad</param>
      /// <returns> La entidad encontrada o nulo</returns>
        public Reservation Read(int id)
        {
            return _context.Reservations.FirstOrDefault(x => x.Deleted == false && x.ID == id);
        }

        public void Read(int id, IResponse<Reservation> reponse)
        {
            throw new NotImplementedException();
        }

      /// <summary>
      /// Retorna todas las entidades vidas del contexto
      /// </summary>
      /// <returns>Las entidades encontradas</returns>
        public IEnumerable<Reservation> ReadAll()
        {
            return _context.Reservations.Where(x => x.Deleted == false);
        }

        public void ReadAll(IListResponse<Reservation> callback)
        {
            throw new NotImplementedException();
        }

      /// <summary>
      /// Actualizada una entidad en el contexto.
      /// </summary>
      /// <param name="entity">la entidad con los cambios</param>
        public void Update(Reservation entity)
        {
            Reservation reservation = Read(entity.ID);
            reservation.Trip = entity.Trip;
            reservation.Customer = entity.Customer;
            reservation.NumPassenger = entity.NumPassenger;
            reservation.CreditCard = entity.CreditCard;
            reservation.ReservationDate = entity.ReservationDate;
            entity.ModifiedDate = DateTime.Now;

            _context.Entry(reservation).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
