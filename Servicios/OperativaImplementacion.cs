using pruebaExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaExamen.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void registroVehiculo(List<VehiculoDto> listaAntiguaVeh)
        {
            throw new NotImplementedException();
        }

        private VehiculoDto nuevoRegistro()
        {
            VehiculoDto vehiculo = new VehiculoDto();

            Console.WriteLine("Indique la matricula del vehiculo: ");
            vehiculo.Matricula = Console.ReadLine();            
            Console.WriteLine("Que tipo de vehiculo es?(P,F,A): ");
            vehiculo.TipoVehiculo = Console.ReadLine();
            vehiculo.ZonaDestino = asignarZonaDestino(vehiculo.TipoVehiculo);
            vehiculo.FechaPaso = DateTime.Now;

            return vehiculo;

        }

        private string  asignarZonaDestino(string tipoVeh)
        {
            string destino="";
            VehiculoDto vehiculo=new VehiculoDto();

            switch (tipoVeh)
            {
                case "P":
                    destino = "Oeste";
                    break;

                case "F" or "A":
                    if (vehiculo.Mercancia == "si")
                    {
                        destino = "Este";
                        break;
                    }
                    else
                    {
                        destino = "Norte";
                        break;
                    }
                    

                

                default:
                    Console.WriteLine("opcion introducida no valida.");
                    break;
            }

            return destino;
        }
    }
}
