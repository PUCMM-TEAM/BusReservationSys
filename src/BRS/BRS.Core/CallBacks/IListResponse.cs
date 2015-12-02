using System.Collections.Generic;
using BRS.Core.Models;

namespace BRS.Core.CallBacks {
  public interface IListResponse<T> where T : Entity {
    void Success(List<T> response);
    void Failure(string error);
  }
}
