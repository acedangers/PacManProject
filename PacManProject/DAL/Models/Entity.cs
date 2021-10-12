using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManProject
{
    public class Entity
    {
        public int Id { get; set; }        
        public int width { get; set; }        
        public int height { get; set; }
        public int positionX { get; set; }
        public int positionY { get; set; }
        public bool isWeak { get; set; }
        public string type { get; set; } // maybe enum?
        
        public int playerId { get; set; }
        public int mapId { get; set; }
        public virtual Map Map { get; set; }
        public virtual Player Player { get; set; }
    }
}
