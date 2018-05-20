using Comun.DTOs;
using Core.Cnp.Abstraccion;
using Datos.Cnp;
using Newtonsoft.Json;
using Servicio;
using Servicio.Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Cnp
{
    public class Multa : IConsultarCobroCoactivo
    {
        //public async Task<string> ConsultarCobroCoactivo()
        //{

        //    //IRetornarEntidad entidad = new Entidad();
        //    //string result = await entidad.RetornarEntidad();
        //    //List<MedidaNoPagadaDTO> datos = JsonConvert.DeserializeObject<List<MedidaNoPagadaDTO>>(result);

        //    //foreach (var item in datos)
        //    //{
        //    //    CobroCoactivo cobro = new CobroCoactivo();
        //    //    cobro.IdHecho = (int)item.CodHecho;
        //    //    cobro.CodDepartamento = item.CodDepartamento;
        //    //    cobro.Departamento = item.Departamento;
        //    //    cobro.CodMunicipio = item.CodMunicipio;
        //    //    cobro.Municipio = item.Municipio;
        //    //    cobro.FechaComparendo = item.FechaComparendo;
        //    //    cobro.NombreRazonSocial = item.NombreRazonSocial;
        //    //    cobro.Identificacion = item.Identificacion;
        //    //    cobro.Nit = item.Nit;
        //    //    cobro.Direccion = item.Direccion;
        //    //    cobro.Telefono = item.Telefono;
        //    //    cobro.Correo = item.Correo;
        //    //    cobro.LugarConducta = item.LugarConducta;
        //    //    cobro.DetalleConducta = item.DetalleConducta;
        //    //    cobro.ArticuloInfringido = item.ArticuloInfringido;
        //    //    cobro.Estado = item.Estado;
        //    //    cobro.CodCategoriaMulta = (int)item.CodCategoriaMulta;
        //    //    cobro.CategoriaMulta = item.CategoriaMulta;

        //    //    using (ContextCnp db = new ContextCnp())
        //    //    {
        //    //        db.CobroCoactivo.Add(cobro);
        //    //        if (db.SaveChanges() > 0)
        //    //        {
        //    //            return "Se agrego correctamente la auditoria";
        //    //        }
        //    //        return "Error al guardar los cobros coativos en base de datos local"; ;
        //    //    }              
        //    //}

        //    //return "Problemas al sincronizar con servicio web";


        //}
    }
}
