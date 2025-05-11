using Microsoft.AspNetCore.Mvc;
using web_service.Models;
namespace web_service.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;
        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }
        public List<catalumno> GetAlumnos()
        {
            return _context.catalumno.ToList();
        }
        public List<catalumno> GetAlumno(int id) {
            return _context.catalumno.Where<catalumno>(a => a.ID == id).ToList();
        }
        public catalumno InsertAlumno(string nombre)
        {
            catalumno alumno = new() { Nombre = nombre};
            _context.catalumno.Add(alumno);
            _context.SaveChanges();
            return alumno;
        }
    }
}