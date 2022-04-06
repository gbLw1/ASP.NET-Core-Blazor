using DigitalCursos.Models.Models;

namespace DigitalCursos.Web.Services;

public interface IAlunoService
{
    Task<IEnumerable<Aluno>> GetAlunos();
    Task<Aluno> GetAluno(int id);
    Task<Aluno> CreateAluno(Aluno aluno);
    Task<Aluno> UpdateAluno(Aluno aluno);
    Task DeleteAluno(int id);
}