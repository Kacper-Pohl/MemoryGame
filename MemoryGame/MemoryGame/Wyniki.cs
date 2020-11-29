using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace MemoryGame
{
    public class Gracz
    {
        public static List<string> ListRooms = File.ReadAllLines("SavedList.txt").ToList();
        
        public static string Imie { get; set; }

        public static int Wynik { get; set; }


    }
    
}