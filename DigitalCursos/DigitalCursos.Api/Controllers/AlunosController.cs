using DigitalCursos.Api.Repositories;
using DigitalCursos.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalCursos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlunosController : ControllerBase
{
    private readonly IAlunoRepository _alunoRepository;

    public AlunosController(IAlunoRepository alunoRepository) => _alunoRepository = alunoRepository;

    [HttpGet]
    public async Task<ActionResult> GetAlunos() => Ok(await _alunoRepository.GetAlunos());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Aluno>> GetAluno(int id)
    {
        var result = await _alunoRepository.GetAluno(id);

        if (result is null)
            return NotFound($"O aluno com id = {id} não foi encontrado.");

        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<Aluno>> CreateAluno(Aluno aluno)
    {
        if (aluno is null) return BadRequest();

        var createdAluno = await _alunoRepository.AddAluno(aluno);

        return CreatedAtAction(nameof(GetAluno),
                               new { id = createdAluno.CursoId },
                               createdAluno);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<Aluno>> UpdateAluno(int id, Aluno aluno)
    {
        if (id != aluno.AlunoId)
            return BadRequest($"O aluno com id = {id} não confere com o aluno a ser atualizado");

        var updatedAluno = _alunoRepository.GetAluno(id);

        if (updatedAluno is null)
            return NotFound($"Aluno com id = {id} não encontrado.");

        return await _alunoRepository.UpdateAluno(aluno);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<Aluno>> DeleteAluno(int id)
    {
        var deletedAluno = await _alunoRepository.GetAluno(id);

        if (deletedAluno is null)
            return NotFound($"Aluno com id = {id} não encontrado.");

        return await _alunoRepository.DeleteAluno(id);
    }
}
