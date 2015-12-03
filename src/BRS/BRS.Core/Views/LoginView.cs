using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Core.Views {
  /// <summary>
  /// Interface de loginview.
  /// </summary>
  public interface ILoginView{
    /// <summary>
    /// Muestra el loginview.
    /// </summary>
    void Show();
    /// <summary>
    /// Realiza el login.
    /// </summary>
    void Login();
    /// <summary>
    /// Va hacia atras.
    /// </summary>
    void GoBack();
  }
}
