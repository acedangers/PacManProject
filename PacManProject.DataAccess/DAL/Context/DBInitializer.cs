using PacManProject.DataAccess.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManProject.DataAccess.DAL.Context
{
    class DBInitializer
    {
        public static void Initialize(AppDBContext context)
        {
            if (!context.Maps.Any())
            {
                new Map
                {
                    Width = 224,
                    Height = 288,
                };
                new GameCharacter
                {
                    Width = 8,
                    Height = 8,
                    PositionX = 0,
                    PositionY = 0,
                    Speed = 10,
                    IsWeak = false,
                };
            }
        }
    }
}
