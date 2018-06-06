using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerPete
{
    class CruiseShip : Travel
    {
        public CruiseShip()
        {
            //default constructor
        }

        public CruiseShip(int num)
        {
            this.Value = num;
        }

        public string GetCruiseShip()
        {
            switch (CustAge())
            {
                case 1:
                    ReturnValue = "Disney";
                    return ReturnValue;
                case 2:
                    ReturnValue = "Viking";
                    return ReturnValue;
                case 3:
                    ReturnValue = "Queen Mary";
                    return ReturnValue;
                case 4:
                    ReturnValue = "Titanic";
                    return ReturnValue;
                case 5:
                    ReturnValue = "Love Boat";
                    return ReturnValue;
                default:
                    ReturnValue = "Go Home";
                    return ReturnValue;
            }
        }
    }

}
