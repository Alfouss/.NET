using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetDLL.Exceptions
{
    public class FichierIntrouvableException:Exception
    {
        public FichierIntrouvableException(string message) : base(message) { 


        }
    }
}
