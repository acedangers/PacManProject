using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManProject
{
    public class MapObject
    {
        public int Id { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        
        public enum Type { Wall, Dot, PowerDot }
        
        public int MapId { get; set; }
        public virtual Map Map { get; set; }
    }
}
