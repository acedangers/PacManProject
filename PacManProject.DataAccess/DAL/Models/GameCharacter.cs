using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManProject
{
    public class GameCharacter
    {
        public int Id { get; set; }        
        public int Width { get; set; }        
        public int Height { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Speed { get; set; }
        public bool IsWeak { get; set; }
        
        public enum Type { PacMan, RedGhost, GreenGhost, BlueGhost, YellowGhost }
        
        public int PlayerId { get; set; }
        public int MapId { get; set; }
        public virtual Map Map { get; set; }
        public virtual Player Player { get; set; }
    }
}
