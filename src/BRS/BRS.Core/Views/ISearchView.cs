using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Core.Views {
  /// <summary>
  /// Interface del searchview.
  /// </summary>
  public interface ISearchView{
    /// <summary>
    /// Muestra el searchview.
    /// </summary>
    void Show();
    /// <summary>
    /// Manda una consulta.
    /// </summary>
    void SubmitQuery();
    /// <summary>
    /// Llena una lista.
    /// </summary>
    void FillListView();
  }
}
