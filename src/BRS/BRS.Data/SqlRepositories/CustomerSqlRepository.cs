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
  /// Clase representativa de un repositorio de Clientes que hereda la funcionabilidad de IRepository.
  /// Dicho repositorio extrae la data desde una base de datos ms sql.
  /// </summary>
    public class CustomerSqlRepository : IRepository<Customer>
    {
      /// <summary>
      /// El contexto que maneja la base datos.
      /// </summary>
        private Context _context;

        /// <summary>
        /// Crea una instancia que contiene un contexto dado
        /// </summary>
        /// <param name="context">Contexto de data</param>
        public CustomerSqlRepository(Context context)
        {
            _context = context;
        }

      /// <summary>
      /// Agrega una entidad al contexto
      /// </summary>
      /// <param name="entity"></param>
        public void Create(Customer entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Customers.Add(entity);
            _context.SaveChanges();
        }

      /// <summary>
      /// Elimina una entidad del contexto
      /// </summary>
      /// <param name="id"> El indice</param>
        public void Delete(int id)
        {
            Customer customer = Read(id);
            customer.Deleted = true;
            Update(customer);
        }

        public Customer Read(int id)
        {
            return _context.Customers.FirstOrDefault(x => x.Deleted == false && x.ID == id);
        }

        public void Read(int id, IResponse<Customer> reponse)
        {
            throw new NotImplementedException();
        }

      /// <summary>
      /// Retorna todos las entidades que no esten borradas del contexto
      /// </summary>
      /// <returns></returns>
        public IEnumerable<Customer> ReadAll()
        {
            return _context.Customers.Where(x => x.Deleted == false);
        }

        public void ReadAll(IListResponse<Customer> callback)
        {
            throw new NotImplementedException();
        }
      /// <summary>
      /// Actualiza una entidad existente
      /// </summary>
      /// <param name="entity">la entidad que se desea actualizar</param>
        public void Update(Customer entity)
        {
            Customer customer = Read(entity.ID);
            customer.FirstName = entity.FirstName;
            customer.LastName = entity.LastName;
            customer.Birthday = entity.Birthday;
            customer.ModifiedDate = DateTime.Now;

            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
