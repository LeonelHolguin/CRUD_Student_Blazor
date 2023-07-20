using CRUD_TEST.Models;

namespace CRUD_TEST.Data
{
    public interface IEstudianteService
    {
        Task<IEnumerable<Estudiante>> GetAllEstudiante();
        Task<Estudiante> GetEstudiante(int id);
        Task<bool> InsertEstudiante(Estudiante estudiante);
        Task<bool> DeleteEstudiante(int id);
        Task<bool> UpdateEstudiante(Estudiante estudiante);
        Task<bool> SaveEstudiante(Estudiante estudiante);
    }
}
