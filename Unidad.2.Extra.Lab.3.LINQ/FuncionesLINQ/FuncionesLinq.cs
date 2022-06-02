using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncionesLINQ
{
    public class FuncionesLinq
    {
        public IEnumerable<string> ObtenerProvinciasQueEmpiezanConDeterminadasLetras(IEnumerable<string> provincias)
        {
            var misProvincias = from p in provincias where p.StartsWith("T") || p.StartsWith("S") select p;
            return misProvincias;

        }

        public IEnumerable<int> ObtenerNumerosMayoresA20(IEnumerable<int> numeros)
        {
            List<int> ListaEnt = (List<int>)numeros;
            return (from e in ListaEnt where e > 20 select e);
        }

        public IEnumerable<int> ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminados(IEnumerable<Ciudad> ciudades, string ciudad)
        {
            var city = from c in ciudades where c.Nombre.Contains(ciudad) select c.CodigoPostal;
            return city;
        }

        public IEnumerable<Empleado> AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldo(IEnumerable<Empleado> empleados, IEnumerable<Empleado> empleadosParaAgregar, string order)
        {
            throw new NotImplementedException();
        }
    }
}
