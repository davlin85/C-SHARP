using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasShow
{
    public class ChristmasShow
    {
        string fileLocation = "christmas-table.txt";
        List<ChristmasShow> items = new List<ChristmasShow>();

        public ChristmasShow()
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
                    ChristmasShow newItem = new ChristmasShow();
                    items.Add(newItem);
                }
            }
        }
    }



}
