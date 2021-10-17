using System;

namespace PacManProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new AppDBContext())
            {
                var map = new Map() { Width = 224, Height = 288 };
                context.Maps.Add(map);
                context.SaveChanges();
            }
        }
    }
}
