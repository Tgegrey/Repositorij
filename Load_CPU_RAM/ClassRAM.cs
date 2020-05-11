using System;
using System.Collections; // Для работы с листами
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Load_CPU_RAM
{
    class ClassRAM
    {
        // Накопительный массив заполняющий память
        public static ArrayList arrayList = new ArrayList();
        
        // Положить объект "pattern" в лист.
        public static void FillMemory()
        {
            lock (arrayList)
            {
                ClassPattern @pattern = new ClassPattern();

                arrayList.Add(value: @pattern);
            }
        }
    }
}