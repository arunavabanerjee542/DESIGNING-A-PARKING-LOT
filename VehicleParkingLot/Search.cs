using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleParkingLot
{
   public  class Search
    {
        public void ShowParkingSpaceByVehicleType(Vehicle v,ParkingLot p)
        {
            int i = (int)v.vehicletype;

           
            
            foreach(var f in p.floors)
            {
                foreach(var pspot in f.parkingspot)
                {
                 
                    if(pspot.vt == v.vehicletype && (int)pspot.ps == 0)
                    {
                        Console.WriteLine(" FLOOR NO : " + f.floor_no +  " " + " SPOT NO :" + pspot.spotid );
                    }

                }


            }



         

        }

        public void ShowParkingSpacesByFloor(int floorno)
         {

         }


    }
}
