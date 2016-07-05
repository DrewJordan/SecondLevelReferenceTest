using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLevel
{
    public class FirstLevel
    {
        public SecondLevel.SecondLevel reference;

        public FirstLevel()
        {
            reference = new SecondLevel.SecondLevel();
        }
    }
}
