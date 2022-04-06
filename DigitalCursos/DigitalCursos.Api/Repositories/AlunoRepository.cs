using DigitalCursos.Api.Data;
using DigitalCursos.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace DigitalCursos.Api.Repositories;

public class AlunoRepository : IAlunoRepository
{
    private readonly AppDbContext _Context;

    public AlunoRepository(AppDbContext context)
        => _Context = context;

    public async Task<IEnumerable<Aluno>> GetAlunos()
        => await _Context.Alunos.AsNoTracking().ToListAsync();

    public async Task<Aluno> GetAluno(int id)
        => await _Context.Alunos.AsNoTracking().FirstOrDefaultAsync(a => a.AlunoId.Equals(id));

    public async Task<Aluno> AddAluno(Aluno aluno)
    {
        var result = await _Context.Alunos.AddAsync(aluno);

        await _Context.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<Aluno> UpdateAluno(Aluno aluno)
    {
        var result = _Context.Alunos.FirstOrDefault(a => a.AlunoId.Equals(aluno.AlunoId));

        if (result == null)
            return null;

        result.Nome = aluno.Nome;
        result.SobreNome = aluno.SobreNome;
        result.Email = aluno.Email;
        result.Nascimento = aluno.Nascimento;
        result.Foto = aluno.Foto;
        result.Genero = aluno.Genero;
        result.CursoId = aluno.CursoId;

        await _Context.SaveChangesAsync();
        return result;
    }

    public async Task<Aluno> DeleteAluno(int id)
    {
        var aluno = _Context.Alunos.FirstOrDefault(a => a.AlunoId.Equals(id));

        if (aluno == null)
            return null;

        _Context.Alunos.Remove(aluno);
        await _Context.SaveChangesAsync();
        return aluno;
    }
}
