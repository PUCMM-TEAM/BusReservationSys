using System;

namespace BRS.Core.Models {
  public abstract class Entity{
    public int ID { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public bool Deleted { get; set; }
  }
}
