using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gurpreetDogRace
{
   abstract class move {
        public int dgMove1() {
            return 0;
        }
        public int dgMove2()
        {
            return 0;
        }
        public int dgMove3()
        {
            return 0;
        }
        public int dgMove4()
        {
            return 0;
        }

    }
   class dgMove : move
    {
        Random obj = new Random();
        //here  we are overriding the working of  the extending class of the concept of Single level inheritance 
        public int dgMove1() {
            return obj.Next(1, 12);
        }

        public int dgMove2()
        {
            return obj.Next(1, 12);
        }

        public int dgMove3()
        {
            return obj.Next(1, 12);
        }

        public int dgMove4()
        {
            return obj.Next(1, 12);
        }



    }
}
