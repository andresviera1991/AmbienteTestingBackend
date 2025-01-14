using System.Collections.Generic;

namespace MGP.Location.Client.DTOs.Department
{
    public class Departamento
    {
        public string Categoria { get; set; }
        public double CentroideLat { get; set; }
        public double CentroideLon { get; set; }
        public string Fuente { get; set; }
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string NombreCompleto { get; set; }
        public string ProvinciaId { get; set; }
        public double ProvinciaInterseccion { get; set; }
        public string ProvinciaNombre { get; set; }
    }

    public class Parametros
    {
        public bool Aplanar { get; set; }
        public List<string> Campos { get; set; }
        public bool Exacto { get; set; }
        public Interseccion Interseccion { get; set; }
        public int Max { get; set; }
        public string Orden { get; set; }
    }

    public class Interseccion
    {
        public List<string> Provincias { get; set; }
    }

    public class GetDepartmentByProvinceIdClientResult
    {
        public int Cantidad { get; set; }
        public List<Departamento> Departamentos { get; set; }
        public int Inicio { get; set; }
        public Parametros Parametros { get; set; }
        public int Total { get; set; }
    }
}
