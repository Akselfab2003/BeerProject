using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProject
{
    public enum Sortby
    {
        UNIT,PERCENT,VOLUME
    }
    class SortingBeerBy : IComparer
    {
        private Sortby _Sortby;
        public SortingBeerBy(Sortby type)
        {
            _Sortby = type;
        }
        public int Compare(object x, object y)
        {
            Beer ObjXAsBeer = x as Beer;
            Beer ObjYAsBeer = y as Beer;
            if (_Sortby == Sortby.UNIT)
            {
               
                double Diffrence = ObjXAsBeer.GetUnits() - ObjYAsBeer.GetUnits();
                if (Diffrence > 0)
                {
                    return 1;
                }
                else if (Diffrence == 0)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }

          else if (_Sortby == Sortby.PERCENT)
            {
             double percentDiffrence =  ObjXAsBeer.Percent - ObjYAsBeer.Percent;
                if (percentDiffrence > 0)
                {
                    return 1;
                }
                else if (percentDiffrence == 0)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return (ObjXAsBeer.Volume - ObjYAsBeer.Volume);
            }

        }
    }
}
