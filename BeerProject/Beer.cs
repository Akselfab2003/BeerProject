using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProject
{
    public enum BeerType
    {
        LAGER,PILSNER,MÜNCHENER,WIENERDORTMUNDER,BOCK,DOBBELBOCK,PORTER,MIX
    }
    class Beer : IComparable
    {
        private string _brewery;
        private string _beerName;
        private BeerType _beerType;
        private int _volume;
        private double _percent;

        public Beer()
        {

        }
        public Beer(string brewery,string beerName,BeerType beerType,int volume,double percent)
        {
            _brewery = brewery;
            _beerName = beerName;
            _beerType = beerType;
            _volume = volume;
            _percent = percent;
        }
        

        public string Brewery
        {
            get { return _brewery; }
            set { _brewery = value; }
        }

        public string BeerName
        {
            get { return _beerName; }
            set { _beerName = value; }
        }

        public BeerType BeerType
        {
            get { return _beerType; }
            set { _beerType = value; }
        }
        public int Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }
        public double Percent
        {
            get { return _percent; }
            set { _percent = value; }
        }



        public double GetUnits()
        {
            return ((Volume * Percent) / 150);
        }

        public override string ToString()
        {
            return string.Format("Brewery: {0,-10}, Beername: {1,10}, Beertype: {2,10}, Volume: {3,10}, Percent: {4,10}, GetUnits: {5,5}",Brewery,BeerName,BeerType,Volume,Percent,GetUnits());
        }

        public Beer Mix(Beer beer2)
        {
            Beer NewCombinedBeer = new Beer();
            NewCombinedBeer.Percent = (Volume * Percent + beer2.Volume * beer2.Percent) / (Volume + beer2.Volume);
            NewCombinedBeer.Brewery = Brewery + " + " + beer2.Brewery;
            NewCombinedBeer.BeerName = BeerName + " + " + beer2.BeerName;
            NewCombinedBeer.Volume = Volume + beer2.Volume;
            NewCombinedBeer.BeerType = BeerType.MIX;
            return NewCombinedBeer;
        }
        public void add(Beer beer2)
        {
            
            Percent = (Volume * Percent + beer2.Volume * beer2.Percent) / (Volume + beer2.Volume);
            Brewery = Brewery + " + " + beer2.Brewery;
            BeerName = BeerName + " + " + beer2.BeerName;
            Volume = Volume + beer2.Volume;
            BeerType = BeerType.MIX;
            
        }
        public static Beer Mix(Beer beer1,Beer beer2)
        {
            Beer NewCombinedBeer = new Beer();
            NewCombinedBeer.Percent = (beer1.Volume * beer1.Percent + beer2.Volume * beer2.Percent) / (beer1.Volume + beer2.Volume);
            NewCombinedBeer.Brewery = beer1.Brewery + " + " + beer2.Brewery;
            NewCombinedBeer.BeerName = beer1.BeerName + " + " + beer2.BeerName;
            NewCombinedBeer.Volume = beer1.Volume + beer2.Volume;
            NewCombinedBeer.BeerType = BeerType.MIX;
            return NewCombinedBeer;
        }

        public int CompareTo(object obj)
        {
            Beer ObjAsBeer = obj as Beer;
            double Diffrence = GetUnits() - ObjAsBeer.GetUnits();
            if(Diffrence > 0)
            {
                return 1;
            }
            else if(Diffrence == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
