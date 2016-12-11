using System;
using System.Collections.Generic;
using System.Text;

namespace Leo
{
    class Stage
    {
        //This class can't be static as multiple Stages will be possible.
        //We don't need to communicate with webservers in this class
        public Stage()
        {

        }

        public void update()
        {
            //Updates the class if the user completed something
        }

        public void finish()
        {
            //"Closing" the object ... marking it finished
        }

        public void getExtraHint()
        {
            //Asking for more hints
        }

    }
}
