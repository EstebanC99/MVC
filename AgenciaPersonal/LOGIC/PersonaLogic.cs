using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public class PersonaLogic: BaseLogic
    {



        public List<persona> GetAll()
        {
            return AgenciaContext.personas.ToList();
        }


        public persona GetOne(string key)
        {
            return AgenciaContext.personas.FirstOrDefault(p => p.dni.Equals(key));
        }

        public void AddPerson(persona newEntity)
        {
            AgenciaContext.personas.Add(newEntity);
            AgenciaContext.SaveChanges();
        }

    }
}
