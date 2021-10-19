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
            }
        }
    }
}
