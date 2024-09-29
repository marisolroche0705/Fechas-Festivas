using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fecha_Festiva.Core.Interfaces.Repositorios;
using Fecha_Festiva.Dominio.Entidades;
using Fecha_Festiva.Core.Interfaces.Repositorios;
using Fecha_Festiva.Dominio.Entidades;
using Fecha_Festiva.Infraestructura.Persistencia.Contextos;
using Microsoft.EntityFrameworkCore;

namespace Fecha_Festiva.Infraestructura.Repositorio
{

    public class Fecha_FestivaRepositorio : ISeleccionRepositorio
    {
        private readonly Fecha_FestivaContex context;

        public Fecha_FestivaRepositorio(Fecha_FestivaContex context)
        {
            this.context = context;
        }

        Task<Festivos> ISeleccionRepositorio.Agregar(Festivos Dato)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Festivos>> ISeleccionRepositorio.Buscar(int IndiceDato, string Dato)
        {
            throw new NotImplementedException();
        }

        Task<bool> ISeleccionRepositorio.Eliminar(int Id)
        {
            throw new NotImplementedException();
        }

        Task<Festivos> ISeleccionRepositorio.Modificar(Festivos Dato)
        {
            throw new NotImplementedException();
        }

        Task<Festivos> ISeleccionRepositorio.Obtener(int Id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Festivos>> ISeleccionRepositorio.ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}