using BRS.Core.Models;
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
    public class ReservationSqlRepository : IRepository<Reservation>
    {
        private Context _context;

        public ReservationSqlRepository()
        {
            _context = new Context();
        }

        public void Create(Reservation entity)
        {
            _context.Reservations.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Reservation reservation = Read(id);
            reservation.Deleted = true;
            Update(reservation);
        }

        public Reservation Read(int id)
        {
            return _context.Reservations.Where(x => x.Deleted == false && x.ID == id).First();
        }

        public void Read(int id, IResponse<Reservation> reponse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> ReadAll()
        {
            return _context.Reservations.Where(x => x.Deleted == false);
        }

        public void ReadAll(IListResponse<Reservation> callback)
        {
            throw new NotImplementedException();
        }

        public void Update(Reservation entity)
        {
            Reservation reservation = Read(entity.ID);
            reservation.Trip = entity.Trip;
            reservation.Customer = entity.Customer;
            reservation.NumPassenger = entity.NumPassenger;
            reservation.CreditCard = entity.CreditCard;
            reservation.ReservationDate = entity.ReservationDate;

            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
