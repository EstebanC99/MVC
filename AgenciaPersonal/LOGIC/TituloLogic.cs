using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public class TituloLogic: BaseLogic
    {

        public List<titulo> GetAll()
        {
            return AgenciaContext.titulos.ToList();
        }


        public titulo GetOne(string key)
        {
            return AgenciaContext.titulos.FirstOrDefault(t => t.cod_titulo.Equals(key));
        }
    }
}
