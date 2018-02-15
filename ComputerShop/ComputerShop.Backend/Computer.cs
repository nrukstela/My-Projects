using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Backend
{
    public class Computer
    {
        public CPU Cpu { get; set; }
        public RAM RAM { get; set; }
        public List<IODevice> IODevices { get; set; }
        public Screen Screen { get; set; }
        public GraphicCard GraphicCard { get; set; }

        //New
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Id { get; set; }

    }
}
