using System;

/*
 * Сопоставьте файлы или директории с их содержимым
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/proc/bus содержит список шин компьютера");
            Console.WriteLine("/proc/interrupts содержит список идентификаторов запросов прерываний в системе");
            Console.WriteLine("/proc/ioports содержит список портов ввода-вывода устройств системы");
            Console.WriteLine("/proc/dma содержит информацию об используемых в данный момент каналах прямого доступа к памяти для устройств ISA");
            Console.WriteLine("/proc/bus/pci содержит список всех подсоединенных к системе устройств PCI");
            Console.WriteLine("/proc/bus/usb/devices содержит список устройств usb, соединенных с вашей системой");
        }
    }
}
