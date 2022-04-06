using DigitalCursos.Api.Repositories;
using DigitalCursos.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalCursos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CursosController : ControllerBase
{
    private readonly ICursoRepository _cursoRepository;

    public CursosController(ICursoRepository cursoRepository) => _cursoRepository = cursoRepository;

    [HttpGet]
    public async Task<ActionResult> GetCursos() => Ok(await _cursoRepository.GetCursos());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Curso>> GetCurso(int id)
    {
        var result = await _cursoRepository.GetCurso(id);

        if (result is null)
            return NotFound($"O curso com id = {id} não foi encontrado.");

        return Ok(result);
    }

    [HttpGet("{id:int}/alunos")]
    public async Task<ActionResult<Curso>> GetAlunosCurso(int id)
    {
        var result = await _cursoRepository.GetAlunosCurso(id);

        if (result is null)
            return NotFound($"O curso com id = {id} não foi encontrado.");

        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<Curso>> CreateCurso(Curso curso)
    {
        if (curso is null) return BadRequest();

        var createdCurso = await _cursoRepository.AddCurso(curso);

        return CreatedAtAction(nameof(GetCurso),
                               new { id = createdCurso.CursoId },
                               createdCurso);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<Curso>> UpdateCurso(int id, Curso curso)
    {
        if (id != curso.CursoId)
            return BadRequest($"O curso com id = {id} não confere com o curso a ser atualizado");

        var updatedCurso = _cursoRepository.GetCurso(id);

        if (updatedCurso is null)
            return NotFound($"Curso com id = {id} não encontrado.");

        return await _cursoRepository.UpdateCurso(curso);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<Curso>> DeleteCurso(int id)
    {
        var deletedCurso = await _cursoRepository.GetCurso(id);

        if (deletedCurso is null)
            return NotFound($"Curso com id = {id} não encontrado.");

        return await _cursoRepository.DeleteCurso(id);
    }
}
