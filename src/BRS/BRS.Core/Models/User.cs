using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Core.Models
{
    public class User : Entity {

        public string UserName { get; set; }

        public string Password { get; set; }

        public string EMail { get; set; }

        public virtual Role Role { get; set; }

    }
}
