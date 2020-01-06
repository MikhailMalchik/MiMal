using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    partial class Flowers : Goods
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public Flowers(string Type, string Name, int Cost, string Color, int Size)
        {
            this.Type = Type;
            this.Name = Name;
            this.Cost = Cost;
            this.Color = Color;
            this.Size = Size;
        }
        public int CompareTo(Goods obj)
        {
            if (this.Size > obj.Size)
                return 1;
            if (this.Size < obj.Size)
                return -1;
            else
                return 0;
        }
    }
}
