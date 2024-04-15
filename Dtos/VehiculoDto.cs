using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaExamen.Dtos
{
    internal class VehiculoDto
    {
        //Atributos
        long VehiculoId;
        string tipoVehiculo = "aaaaa";
        string zonaDestino = "aaaaa";
        string mercancia = "aaaaa";
        string matricula = "aaaaa";
        DateTime fechaPasoSur;
        DateTime fechaPasoPif;
        DateTime fechaPasoNorte;



        //Getters y Setters
        public long VehiculoId1 { get => VehiculoId; set => VehiculoId = value; }
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
        public string ZonaDestino { get => zonaDestino; set => zonaDestino = value; }
        public string Mercancia { get => mercancia; set => mercancia = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime FechaPaso { get => fechaPaso;set => fechaPaso = value; }

        //Constructores

        public VehiculoDto()
        {

        }

        public VehiculoDto(long vehiculoId, string tipoVehiculo, string zonaDestino, string mercancia, string matricula, DateTime fechaPaso)
        {
            VehiculoId = vehiculoId;
            this.tipoVehiculo = tipoVehiculo;
            this.zonaDestino = zonaDestino;
            this.mercancia = mercancia;
            this.matricula = matricula;
            this.fechaPaso = fechaPaso;
        }

        

        override
            public string ToString()
        {
            string texto = "ID: "+this.VehiculoId+"\n tipo vehiculo: "+this.tipoVehiculo+"\nzona destino: "+this.zonaDestino
                +"\n mercancia: "+this.mercancia+"\n fecha paso: "+this.fechaPaso;

            return texto;
        }
    }
}
