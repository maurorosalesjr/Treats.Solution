using System.Collections.Generic;

namespace Pierre.Models
{
    public class Treat
    {
        public Treat()
        {
            this.JoinEntities = new HashSet<FlavorTreat>();
        }

        public int TreatId { get; set; }
        public string TreatName { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<FlavorTreat> JoinEntities { get;}
    }
}