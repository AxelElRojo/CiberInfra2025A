using Microsoft.AspNetCore.Mvc;
using web_service.Models;

namespace web_service.DataAccess
{
    public interface IDataAccessProvider
    {
        List<catalumno> GetAlumnos();
        List<catalumno> GetAlumno(int id);
        public catalumno InsertAlumno(string nombre);
    }
}
