using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Core.Views {
  public interface ILoginView{
    void Show();
    void Login();
    void GoBack();
  }
}
