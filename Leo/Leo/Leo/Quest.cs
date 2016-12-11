using System;
using System.Collections.Generic;
using System.Text;

namespace Leo
{
    class Quest
    {
        public void getQuest()
        {
            //This method will be changed because we are waiting an answer
            //from the server.
        }

        public void upload()
        {
            //This method will be changed because we are waiting an answer
            //from the server.

            //gets called if the user completed something 
            //or uploaded a file or w\e we need

        }

        public void Update()
        {
            //This method gets the gps location, updates
            //the GPSLocation object and refreshing the
            //position of the map and updates Stage.

            GPSLocation.update();
            Map.update();
            Stage.update();
        }
    }
}
