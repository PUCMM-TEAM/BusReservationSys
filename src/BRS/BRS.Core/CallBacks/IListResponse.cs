using System.Collections.Generic;
using BRS.Core.Models;

namespace BRS.Core.CallBacks {
  /// <summary>
  /// Interface de una lista respuestas.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public interface IListResponse<T> where T : Entity {
    void Success(List<T> response);
    void Failure(string error);
  }
}
