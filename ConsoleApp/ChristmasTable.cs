using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTable
{
    public class ChristmasTable
    {
        string fileLocation = "christmas-table.txt";
        List<ChristmasTable> items = new List<ChristmasTable>();

        public ChristmasTable()
        {
            LoadItems();
        }

        void LoadItems()
        {
            if (File.Exists(fileLocation))
            {
                string[] lines = File.ReadAllLines(fileLocation);
                foreach (string line in lines)
                {
                    string text = line.Substring(1).Split(' ')[1];
                    int number = int.Parse(line.Substring(1).Split(' ')[0]);
                    ChristmasTable newItem = new ChristmasTable();
                    items.Add(newItem);
                }
            }
        }
    }



}
