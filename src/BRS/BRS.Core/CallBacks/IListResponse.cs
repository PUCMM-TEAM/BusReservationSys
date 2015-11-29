using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRS.Core.Models;

namespace BRS.Core.CallBacks {
  public interface IListResponse<T> where T : Entity {
    void Success(List<T> response);
    void Failure(string error);
  }
}
