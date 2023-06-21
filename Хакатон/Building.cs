using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Resources;

namespace Хакатон
{
    internal class Building
    {
        public string Name { get; set; }
        public string Adres { get; set; }
        public int BuidYear { get; set; }
        public string State { get; set;}
        public int Floors { get; set; }
        public int Flats { get; set; }
        public string Material { get; set; }
        public int CudNum { get; set; }
        public int Square { get; set; }
        public int PepleCount { get; set;}
    }
}
