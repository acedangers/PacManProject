using System;

namespace PacManProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new MyDBContext())
            {
                var map = new Map() { width = 30, height = 30 };
                context.Maps.Add(map);
                context.SaveChanges();
            }
        }
    }
}
