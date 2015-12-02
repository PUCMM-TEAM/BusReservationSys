using BRS.Core.Models;

namespace BRS.Core {
  public interface IResponse<T> where T : Entity{
    void Success(T response);
    void Failure(string error);
  }
}
