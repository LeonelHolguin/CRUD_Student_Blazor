using CRUD_TEST.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_TEST.Data
{
    public class EstudianteService : IEstudianteService
    {
        private readonly EstudianteContext _context;

        public EstudianteService(EstudianteContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteEstudiante(int id)
        {
            var estudiante = await _context.Estudiantes.FindAsync(id);

            _context.Estudiantes.Remove(estudiante);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Estudiante>> GetAllEstudiante()
        {
            return await _context.Estudiantes.ToListAsync();
        }

        public async Task<Estudiante> GetEstudiante(int id)
        {
            return await _context.Estudiantes.FindAsync(id);
        }

        public async Task<bool> InsertEstudiante(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveEstudiante(Estudiante estudiante)
        {
            if(estudiante.EstudianteId > 0)
            {
                return await UpdateEstudiante(estudiante);

            } else
            {
                return await InsertEstudiante(estudiante);
            }
        }

        public async Task<bool> UpdateEstudiante(Estudiante estudiante)
        {
            _context.Entry(estudiante).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
