using Comun.DTOs;
using Core.Cnp.Abstraccion;
using Datos.Cnp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Cnp
{
    public class HechoRepositorio : IAgregarHechoProcesoVerbalAbreviado, IListarHechosVerbalAbreviado
    {
        public string AgregarHechoProcesoVerbalAbreviado(CnpHechoDTO _cnpHechosDto)
        {          
            Hecho cnpHechos = new Hecho();

            cnpHechos.Fecha = _cnpHechosDto.Fecha;
            cnpHechos.IdMunicipio = _cnpHechosDto.IdMunicipio;
            cnpHechos.IdBarrio = _cnpHechosDto.IdBarrio;
            cnpHechos.Localidad = _cnpHechosDto.Localidad;
            cnpHechos.DireccionHechos = _cnpHechosDto.DireccionHechos;
            cnpHechos.IdComportamiento = _cnpHechosDto.IdComportamiento;
            cnpHechos.Apelacion = _cnpHechosDto.Apelacion;
            cnpHechos.RelatoHechos = _cnpHechosDto.RelatoHechos;
            cnpHechos.Mop = _cnpHechosDto.Mop;
            cnpHechos.Mrs = _cnpHechosDto.Mrs;
            cnpHechos.Minc = _cnpHechosDto.Minc;
            cnpHechos.Mtpp = _cnpHechosDto.Mtpp;
            cnpHechos.Msia = _cnpHechosDto.Msia;
            cnpHechos.Mtppp = _cnpHechosDto.Mtppp;
            cnpHechos.Minicoe = _cnpHechosDto.Minicoe;
            cnpHechos.Minisoe = _cnpHechosDto.Minisoe;
            cnpHechos.CnpArt = _cnpHechosDto.CnpArt;
            cnpHechos.CnpNum = _cnpHechosDto.CnpNum;
            cnpHechos.CnpLit = _cnpHechosDto.CnpLit;
            cnpHechos.Latitud = _cnpHechosDto.Latitud;
            cnpHechos.Longitud = _cnpHechosDto.Longitud;
            cnpHechos.IdTipoLugar = _cnpHechosDto.IdTipoLugar;
            cnpHechos.Descargos = _cnpHechosDto.Descargos;
            cnpHechos.HoraHechos = _cnpHechosDto.HoraHechos;
           
            cnpHechos.AtiendeApelacion = _cnpHechosDto.AtiendeApelacion;
            cnpHechos.IdEntidadeRemiteApelac = _cnpHechosDto.IdEntidadeRemiteApelac;           
            cnpHechos.Fuente = 1;
            cnpHechos.IdTipoTransp = _cnpHechosDto.IdTipoTransp;

            cnpHechos.Vigente = true;
            cnpHechos.UsuarioCreacion = HttpContext.Current.User.Identity.Name;
            cnpHechos.MaquinaCreacion = HttpContext.Current.Request.UserHostAddress;      
            cnpHechos.FechaCreacion = DateTime.Now;
            
            using (ContextCnp db = new ContextCnp())
            {
                cnpHechos.HechoId = Guid.NewGuid().ToString();
                db.Hecho.Add(cnpHechos);
                db.SaveChanges();
                return cnpHechos.HechoId;
            }
        }

        public List<CnpHechoDTO> ListarHechosVerbalAbreviado()
        {
            using (ContextCnp db = new ContextCnp())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.AutoDetectChangesEnabled = false;

                var resultado = db.Hecho.Select(x => new CnpHechoDTO
                {
                    Fecha = x.Fecha, 
                    IdMunicipio = x.IdMunicipio,
                    IdBarrio = x.IdBarrio,
                    Localidad = x.Localidad,
                    DireccionHechos = x.DireccionHechos
            });
                return resultado.ToList();
            }



        }


    }
}
