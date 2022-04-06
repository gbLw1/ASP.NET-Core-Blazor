using DigitalCursos.Api.Data;
using DigitalCursos.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace DigitalCursos.Api.Repositories;

public class CursoRepository : ICursoRepository
{
    private readonly AppDbContext _Context;

    public CursoRepository(AppDbContext context)
        => _Context = context;

    public async Task<IEnumerable<Curso>> GetCursos()
        => await _Context.Cursos.AsNoTracking().ToListAsync();

    public async Task<Curso> GetCurso(int id)
        => await _Context.Cursos.AsNoTracking().FirstOrDefaultAsync(c => c.CursoId.Equals(id));

    public async Task<Curso> GetAlunosCurso(int id)
        => await _Context.Cursos.AsNoTracking().Include(p => p.Alunos).FirstOrDefaultAsync(c => c.CursoId.Equals(id));

    public async Task<Curso> AddCurso(Curso curso)
    {
        var result = await _Context.Cursos.AddAsync(curso);

        await _Context.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<Curso> UpdateCurso(Curso curso)
    {
        var result = _Context.Cursos.FirstOrDefault(a => a.CursoId.Equals(curso.CursoId));

        if (result == null)
            return null;

        result.CursoNome = curso.CursoNome;
        result.Descricao = curso.Descricao;
        result.CargaHoraria = curso.CargaHoraria;
        result.Inicio = curso.Inicio;
        result.Preco = curso.Preco;
        result.Logo = curso.Logo;
        result.Alunos = curso.Alunos;

        await _Context.SaveChangesAsync();
        return result;
    }

    public async Task<Curso> DeleteCurso(int id)
    {
        var curso = _Context.Cursos.FirstOrDefault(c => c.CursoId.Equals(id));

        if (curso == null)
            return null;

        _Context.Cursos.Remove(curso);
        await _Context.SaveChangesAsync();
        return curso;
    }
}

