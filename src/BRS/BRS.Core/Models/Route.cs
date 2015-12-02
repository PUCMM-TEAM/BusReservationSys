namespace BRS.Core.Models
{
    public class Route : Entity{
        public virtual Destination Pickup { get; set; }
        public virtual Destination DropOff { get; set; }

        public string RouteName { get { return Pickup.Name + " - " + DropOff.Name; } }
    }
}
