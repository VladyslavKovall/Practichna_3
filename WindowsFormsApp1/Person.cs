using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class CountryMedal
    {
        string CountryName;
        int SportCount;
        int MedalCount;

        public CountryMedal(string countryname)
        {
            this.CountryName = countryname;
        }
        public CountryMedal(string countryname, int sportcount)
        {
            this.CountryName = countryname;
            this.SportCount = sportcount;
        }
        public CountryMedal(string countryname, int sportcount, int medalcount)
        {
            this.CountryName = countryname;
            this.SportCount = sportcount;
            this.MedalCount = medalcount;
        }
        public string GetInformation()
        {
            string information;
            information = "Ім`я Країни: " + this.CountryName + "; Кількість спортсменів: " + this.SportCount.ToString() + "; Кількість медалей: " + this.MedalCount;
            return information;
        }
    }
}
