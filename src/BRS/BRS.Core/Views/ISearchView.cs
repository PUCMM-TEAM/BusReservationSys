using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Core.Views {
  public interface ISearchView{
    void Show();
    void SubmitQuery();
    void FillListView();
  }
}
