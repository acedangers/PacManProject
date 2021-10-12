using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManProject
{
    public class Player
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string email { get; set; }

        public virtual ICollection<Entity> Entities { get; set; }
    }
}
