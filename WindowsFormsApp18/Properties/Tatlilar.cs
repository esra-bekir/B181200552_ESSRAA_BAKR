using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp18.Properties
{
    public class tatlılar : Yemekler
    {
        public string şekeroranı { get; set; }
        public string yapılış_tarihi { get; set; }
        public string vitamenA { get; set; }

        public string getvitamenA()
        {
            return vitamenA + " IU";
        }
        public string   getyapılış_tarihi()
        {
            return yapılış_tarihi +DateTime.Today.ToString() ;
        }

        public string getşekeroranı()
        {
            return şekeroranı + " gr";
        }
    }
}
