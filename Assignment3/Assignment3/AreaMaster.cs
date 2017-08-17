using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class AreaMaster
    {
        public static List<AreaMaster> AreaCollection=new List<AreaMaster>();
        private int id,aid;
        private string name, desc,code;

        public AreaMaster()
        {

        }

        public AreaMaster(int id,string code,int aid,string name,string desc,Areatype Area)
        {
            this.id = id;
            this.name = name;
            this.code = code;
            this.desc = desc;
            this.aid = aid;
            this.Area = Area;


            AreaCollection.Add(this);
            }

        public int ID {
            get {return id; }
            set {id=value; }
        }
        public string NAME  {
            get {return name; }
            set {name=value; }
        }
        public string  CODE {
            get {return code; }
            set {code=value; }
        }
        public string DESCRIPTION {
            get {return desc; }
            set {desc=value; }
        }
        public int AREAID {
            get {return aid; }
            set {aid=value; }
        }
        public  enum Areatype { Country, State, City , District };

        public virtual Areatype Area {
            get ; 
            set; 
        }
    }

    public class CountryMaster : AreaMaster
    {
        public CountryMaster(int id, string code, int aid, string name, string desc, Areatype Area):base(id,code,aid,name,desc,Area)
        {
            
        }

        public override Areatype Area
        {
            get
            {
                return Areatype.Country;
            }

            set
            {
                base.Area = Areatype.Country;
            }
        }

        public AreaMaster GetAreaMasterByCountry(string country)
        {


            foreach (var item in AreaCollection.Where(area => area.Area == Areatype.Country))
            {
                if (string.Equals(item.NAME, country))
                {
                    Console.WriteLine(item.ID);
                    Console.WriteLine(item.NAME);
                    
                }
            }
            //    Console.WriteLine(item.ID);
            //    Console.WriteLine(item.NAME);
            //    Console.WriteLine(item.Area);


            //Console.ReadLine();



            return null;
        }

    }

    public class StateMaster : AreaMaster
    {
        public StateMaster(int id, string code, int aid, string name, string desc, Areatype Area):base(id,code,aid,name,desc,Area)
        {

        }

        public override Areatype Area
        {
            get
            {
                return base.Area;
            }

            set
            {
                base.Area = value;
            }
        }


        public AreaMaster GetAreaMasterByState(string state)
        {


            foreach (var item in AreaCollection.Where(area => area.Area == Areatype.State))
            {
                Console.WriteLine(item.ID);
                Console.WriteLine(item.NAME);
                
                    foreach (var item1 in AreaCollection)
                {
                    
                        if (item.AREAID == item1.ID)
                        {
                            Console.WriteLine(item1.NAME);

                        }
                    

                }
                    
            }
            //    Console.WriteLine(item.ID);
            //    Console.WriteLine(item.NAME);
            //    Console.WriteLine(item.Area);


            //Console.ReadLine();



            return null;
        }
    }

    public class CityMaster : AreaMaster
    {
        public CityMaster(int id, string code, int aid, string name, string desc, Areatype Area) : base(id, code, aid, name, desc, Area)
        {

        }

        public override Areatype Area
        {
            get
            {
                return base.Area;
            }

            set
            {
                base.Area = value;
            }
        }
        public AreaMaster GetAreaMasterByCity(string city)
        {


            foreach (var item in AreaCollection.Where(area => area.Area == Areatype.City))
            {
                Console.WriteLine(item.ID);
                Console.WriteLine(item.NAME);
                

                foreach (var item1 in AreaCollection)
                {

                    if (item.AREAID == item1.ID)
                    {
                        Console.WriteLine(item1.NAME);
                        foreach (var item2 in AreaCollection)
                        {

                            if (item1.AREAID == item2.ID)
                            {
                                Console.WriteLine(item2.NAME);

                            }


                        }

                    }


                }

            }
            //    Console.WriteLine(item.ID);
            //    Console.WriteLine(item.NAME);
            //    Console.WriteLine(item.Area);


            //Console.ReadLine();



            return null;
        }

    }

    public class DistrictMaster : AreaMaster
    {
        public override Areatype Area
        {
            get
            {
                return base.Area;
            }

            set
            {
                base.Area = value;
            }
        }
    }

}
