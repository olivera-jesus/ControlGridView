using System;
using System.Collections.Generic;
using System.Text;

namespace ControlGridView
{ 
    internal class PersonaDataObjects
    {
      private List<Persona> listadepersonas = new List<Persona>();

        public PersonaDataObjects()
        {
            Persona p1 = new Persona { Nombre = "Javier", Email = "javier@gmail.com", Genero = "Hombre", Telefono = "2228889993",ImagenGenero="Imagen/Hombre.png" };
            Persona p2 = new Persona { Nombre = "Rebeca", Email = "rebeca@gmail.com", Genero = "Mujer", Telefono = "2226655447", ImagenGenero="Imagen/Mujer.png" };
            listadepersonas.Add(p1);
            listadepersonas.Add(p2);

        }
        public List<Persona> Listar()
        {
            return listadepersonas;
        }
    }
}
