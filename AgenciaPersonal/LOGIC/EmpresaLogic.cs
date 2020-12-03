using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public class EmpresaLogic: BaseLogic
    {

        public List<empresa> GetAll()
        {
            return AgenciaContext.empresas.ToList();
        }


        public empresa GetOne(string key)
        {
            return AgenciaContext.empresas.FirstOrDefault(p => p.cuit.Equals(key));
        }
    }
}
