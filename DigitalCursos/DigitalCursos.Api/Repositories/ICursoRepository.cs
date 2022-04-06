using DigitalCursos.Models.Models;

namespace DigitalCursos.Api.Repositories;

public interface ICursoRepository
{
    Task<IEnumerable<Curso>> GetCursos();
    Task<Curso> GetCurso(int id);
    Task<Curso> GetAlunosCurso(int id);
    Task<Curso> AddCurso(Curso curso);
    Task<Curso> UpdateCurso(Curso curso);
    Task<Curso> DeleteCurso(int id);
}

