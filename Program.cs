using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tool> tools = new List<Tool>();
            tools.Add(new Drill("Bosch Drill", 2));
            tools.Add(new Drill("Makita Drill", 3));
            tools.Add(new Hammer("Heavy Hammer", 1));
            tools.Add(new Wrench("Adjustable Wrench", 1));
            tools.Add(new Saw("Wood Saw", 2));
            tools.Add(new Screwdriver("Phillips Screwdriver", 1));
            tools.Add(new PipeCutter("Metal Pipe Cutter", 3));
            tools.Add(new NailGun("Nail gun", 1));
            tools.Add(new WireStripper("WireStripper", 5));

            foreach (Tool tool in tools)
            {
                tool.Describe();
                tool.Use();
            }
        }
    }
}
