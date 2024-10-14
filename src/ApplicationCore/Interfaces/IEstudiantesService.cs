using ApplicationCore.Wrappers;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IEstudiantesService
    {
        Task<Response<List<Estudiante>>> GetEstudiantes();

    }
}
