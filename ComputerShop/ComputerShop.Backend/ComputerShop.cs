using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Backend
{
    public class ComputerShop
    {
        public List<Computer> Warehouse { get; private set; }

        public ComputerShop()
        {
            Warehouse = new List<Computer>();
        }

        public void PutComputerToWarehouse(Computer computer) {
            Warehouse.Add(computer);
        }

        public Computer TakeComputerFromWarehouse(int index) {
            var computer = Warehouse.ElementAt(index);
            Warehouse.RemoveAt(index);
            return computer;
        }

        public void PrintWarehouseList() {
            foreach (var item in Warehouse)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Manufacturer);
                Console.WriteLine(item.Model);
                
            }
        }

        public void PopulateWarehouseWithComputer()
        {
            //Components
            CPU cpu = new CPU();
            cpu.Manufacturer = "Intel";
            cpu.Model = "i5";
            cpu.Frequency = 2.7;

            RAM ram = new RAM();
            ram.Manufacturer = "Gigabyte";
            ram.Model = "TX234";
            ram.MemorySize = 512;

            Screen screen = new Screen();
            screen.Manufacturer = "Dell";
            screen.Model = "Ae1235";
            screen.Resolution = "FULL HD";
            screen.Size = 24;

            GraphicCard card = new GraphicCard();
            card.Manufacturer = "Geforce";
            card.Model = "G516";
            card.MemorySize = 1024;
            
            IODevice device1 = new IODevice();
            device1.Type = IODeviceType.Mouse;
            device1.Manufacturer = "Logitech";
            device1.Model = "G215";

            IODevice device2 = new IODevice();
            device2.Type = IODeviceType.Keyboard;
            device2.Manufacturer = "Apple";
            device2.Model = "GH5";

            List<IODevice> devices = new List<IODevice>();
            devices.Add(device1);
            devices.Add(device2);

            //Computers
            Computer computer = new Computer();
            computer.Id = 1;
            computer.Manufacturer = "Apple";
            computer.Model = "Macbook Pro TouchBar";
            computer.Cpu = cpu;
            computer.RAM = ram;
            computer.Screen = screen;
            computer.IODevices = devices;
            computer.GraphicCard = card;

            Computer computer2 = new Computer();
            computer2.Id = 2;
            computer2.Manufacturer = "HP";
            computer2.Model = "ProBook G124";

            computer2.Cpu = cpu;
            computer2.RAM = ram;
            computer2.Screen = screen;
            computer2.IODevices = devices;
            computer2.GraphicCard = card;

            Computer computer3 = new Computer();
            computer3.Id = 3;
            computer3.Manufacturer = "Lenovo";
            computer3.Model = "T450";


            computer3.Cpu = cpu;
            computer3.RAM = ram;
            computer3.Screen = screen;
            computer3.IODevices = devices;
            computer3.GraphicCard = card;

            Warehouse.Add(computer);
            Warehouse.Add(computer2);
            Warehouse.Add(computer3);
        }

    }
}
