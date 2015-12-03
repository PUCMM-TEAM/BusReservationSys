using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Core.Views {
  /// <summary>
  /// Interface del Homeview.
  /// </summary>
  public interface IHomeView{
    /// <summary>
    /// Muestra un homeview.
    /// </summary>
    void Show();
    /// <summary>
    /// Llena una lista de ofertas.
    /// </summary>
    void FillOfferListView();
  }
}
