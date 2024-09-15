﻿using Fecha_Festiva.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha_Festiva.Core.Interfaces.Repositorios
{
    public interface ISeleccionRepositorio
    {
        Task<IEnumerable<Festivos>> ObtenerTodos();

        Task<Festivos> Obtener(int Id);

        Task<IEnumerable<Festivos>> Buscar(int IndiceDato, String Dato);

        Task<Festivos> Agregar(Festivos Dato);

        Task<Festivos> Modificar(Festivos Dato);

        Task<bool> Eliminar(int Id);
    }
}