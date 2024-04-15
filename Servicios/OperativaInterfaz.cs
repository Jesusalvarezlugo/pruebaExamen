using pruebaExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaExamen.Servicios
{
    internal interface OperativaInterfaz
    {
        public void registroVehiculo(List<VehiculoDto>listaAntiguaVeh);
    }
}
