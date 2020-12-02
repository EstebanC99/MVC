using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public abstract class BaseLogic
    {
        public virtual APContext AgenciaContext { get; set; }


        public BaseLogic()
        {
            this.AgenciaContext = new APContext();
        }
    }
}
