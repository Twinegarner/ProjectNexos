using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNexos
{
    public class GameMap // holds the users movments and displays the users curretn location 
    {
        int currentLocation = 0;//zero is start location
        List<int> visitedLocation; //save the past locations
        public void GameMap1(int newLocation)//
        {
            if(visitedLocation.Count == 0)
            {
                visitedLocation.Add(0);
            }
            if(visitedLocation.Contains(newLocation))//dont add to list if already visted
            {
                //dont add
            }
            else
            {
                visitedLocation.Add(newLocation);//add to list to remember locations
            }
            
        }

        public bool checkLocation()//used to check location on map
        {

            return false;
        }

    }
}
