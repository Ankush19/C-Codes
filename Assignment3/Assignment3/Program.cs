using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaMaster am = new AreaMaster();
            CountryMaster com = new CountryMaster(1,"IND",0,"India","Anything",AreaMaster.Areatype.Country);
            StateMaster sm = new StateMaster(2, "MH", 1, "Maharashtra", "Anything", AreaMaster.Areatype.State);
            CityMaster cm = new CityMaster(3, "PUN", 2, "Pune", "Anything", AreaMaster.Areatype.City);
            cm.GetAreaMasterByCity("Pune");
            //sm.GetAreaMasterByState("Maharashtra");
            //com.GetAreaMasterByCountry("India");
            Console.ReadLine();
        }
    }
}
