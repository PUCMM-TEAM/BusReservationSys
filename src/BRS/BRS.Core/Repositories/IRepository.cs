using System.Collections.Generic;
using BRS.Core.CallBacks;
using BRS.Core.Models;

namespace BRS.Core.Repositories {
    /// <summary>
    /// Interface que representa un repositorio.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T: Entity{
      /// <summary>
      /// Crea una entidad
      /// </summary>
      /// <param name="entity">Una entidad dada</param>
      void Create(T entity);
      /// <summary>
      /// Devuelve una instancia de la entidad y una respuesta.
      /// </summary>
      /// <param name="id">id de la instancia a buscar</param>
      /// <param name="reponse">respuesta</param>
      void Read(int id, IResponse<T> reponse);
      /// <summary>
      /// Devuelve una instancia de la entidad.
      /// </summary>
      /// <param name="id">id de la instancia a buscar</param>
      /// <returns>una instancia</returns>
      T Read(int id);
      /// <summary>
      /// Modifica la instancia de una entidad.
      /// </summary>
      /// <param name="entity">Una entidad dada</param>
      void Update(T entity);
      /// <summary>
      /// Borra un instancia de una entidad.
      /// </summary>
      /// <param name="id">id de la instancia</param>
      void Delete(int id);
      /// <summary>
      /// Devuelve todas las instancias de una entidad.
      /// </summary>
      /// <param name="callback">una llamada</param>
      void ReadAll(IListResponse<T> callback);
      /// <summary>
      /// Devuelve todas las instancias de una entidad.
      /// </summary>
      /// <returns>todas las instancias</returns>
      IEnumerable<T> ReadAll();
    }
}
