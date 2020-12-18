using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNexos
{
    public class GameFileReader //class made to handle room managment
    {
        public string RoomLoader() //finds the room text file and loads it into a string
        { 
            string text = System.IO.File.ReadAllText(@"PageAssets/1A.txt");

            return text;
        }

    }
}
