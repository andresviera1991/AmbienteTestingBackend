using System.Collections.Generic;

namespace MGP.Location.Client.DTOs.Locality
{
    public class Localidad
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
    }

    public class Parametros
    {
        public List<string> Campos { get; set; }
        public int Inicio { get; set; }
        public int Max { get; set; }
        public string Orden { get; set; }
        public List<string> Provincia { get; set; }
    }

    public class GetLocalitiesByDepartmentIdClientResult
    {
        public int Cantidad { get; set; }
        public int Inicio { get; set; }
        public List<Localidad> Localidades { get; set; }
        public Parametros Parametros { get; set; }
        public int Total { get; set; }
    }
}
