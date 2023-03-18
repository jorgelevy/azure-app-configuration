using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfig3
{
    public class Settings
    {
        public int KeyOne { get; set; }
        public bool KeyTwo { get; set; }
        public Keythree KeyThree { get; set; }
        public Setting Setting { get; set; }
    }

    public class Keythree
    {
        public string Message { get; set; }
    }

    public class Setting
    {
        public string Message { get; set; }
    }

}
