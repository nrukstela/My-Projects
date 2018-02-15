using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Backend
{
    public class IODevice
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public IODeviceType Type { get; set; }
    }

    public enum IODeviceType {
        Mouse, Printer, Keyboard
    }
}
