using Microsoft.AspNetCore.Mvc;
using web_service.DataAccess;
using web_service.Models;
namespace web_service.Controllers
{
    [Route("api/[controller]")]
    public class catalumnoController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public catalumnoController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet]
        public IEnumerable<catalumno> Get()
        {
            return _dataAccessProvider.GetAlumnos();
        }
        [HttpGet("{id}", Name = nameof(GetById))]
        public IEnumerable<catalumno> GetById(int id)
        {
            return _dataAccessProvider.GetAlumno(id);
        }
        [HttpPost]
        public ActionResult<catalumno> PostAlumno([FromBody] catalumno alumno)
        {
            if (alumno == null || string.IsNullOrWhiteSpace(alumno.Nombre))
                return BadRequest("Nombre es requerido.");
            var created = _dataAccessProvider.InsertAlumno(alumno.Nombre);
            return CreatedAtAction(nameof(GetById), new { id = created.ID }, created);
        }
    }
}