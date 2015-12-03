using BRS.Core.Models;

namespace BRS.Core {
  /// <summary>
  /// Interface de la respuesta.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public interface IResponse<T> where T : Entity{
    void Success(T response);
    void Failure(string error);
  }
}
