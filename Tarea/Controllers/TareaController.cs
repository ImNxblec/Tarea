using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea.Data;
using Tarea.Data.ClaseEstudiante;
using Tarea.Models;
using Tarea.Models.ClaseEstudiante;
using static Azure.Core.HttpHeader;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tarea.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TareaController : ControllerBase
    {
        private readonly ClaseDbContext dbContext1;
        private readonly EstudianteDbContext dbContext2;
        private readonly CedulaDbContext dbContext3;
        private readonly DepartamentoDbContext dbContext4;

        public TareaController(ClaseDbContext dbContext1, EstudianteDbContext dbContext2, CedulaDbContext dbContext3, DepartamentoDbContext dbContext4)
        {
            this.dbContext1 = dbContext1;
            this.dbContext2 = dbContext2;
            this.dbContext3 = dbContext3;
            this.dbContext4 = dbContext4;
        }
        #region Ejemplo N:M
        [HttpGet("clases")]
        public IEnumerable<Clase> GetClases()
        {
            return dbContext1.Integrantes;
        }

        [HttpGet("estudiantes")]
        public IEnumerable<Estudiante> GetEstudiantes()
        {
            return dbContext2.Clases;
        }
        #endregion
        #region Ejemplo 1:1
        [HttpGet("cedulas")]
        public IEnumerable<Cedula> GetCedulas()
        {
            return dbContext3.Personas;
        }
        #endregion
        #region Ejemplo 1:N
        [HttpGet("departamentos")]
        public IEnumerable<Departamento> GetDepartamentos()
        {
            return dbContext4.Integrantes;
        }
        #endregion
    }
}
