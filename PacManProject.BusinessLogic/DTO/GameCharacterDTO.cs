using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManProject.BusinessLogic.DTO
{
    class GameCharacterDTO
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Speed { get; set; }
        public bool IsWeak { get; set; }

        public enum Type { PacMan, RedGhost, GreenGhost, BlueGhost, YellowGhost }
    }
}
