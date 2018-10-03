using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Basket
    {
        public int Id { get; set; }
        public int[] tovars;
        public int[] Tovars { get { return tovars; } set { tovars = new int[10]; } }
    }
}
