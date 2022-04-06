using DigitalCursos.Models.Models;

namespace DigitalCursos.Web.Services;

public class CursoService : ICursoService
{
    private readonly HttpClient _httpClient;

    public CursoService(HttpClient httpClient)
        => _httpClient = httpClient;

    public async Task<IEnumerable<Curso>> GetCursos()
        => await _httpClient.GetFromJsonAsync<IEnumerable<Curso>>($"api/cursos");

    public async Task<Curso> GetCurso(int id)
        => await _httpClient.GetFromJsonAsync<Curso>($"api/cursos/{id}");

    public async Task<Curso> GetAlunosCurso(int id)
        => await _httpClient.GetFromJsonAsync<Curso>($"api/cursos/{id}/alunos");

    public async Task<Curso> CreateCurso(Curso curso)
    {
        var response = await _httpClient.PostAsJsonAsync<Curso>($"api/cursos", curso);
        var content = await response.Content.ReadFromJsonAsync<Curso>();
        return content;
    }

    public async Task<Curso> UpdateCurso(Curso curso)
    {
        var response = await _httpClient.PutAsJsonAsync<Curso>($"api/cursos/{curso.CursoId}", curso);
        var content = await response.Content.ReadFromJsonAsync<Curso>();
        return content;
    }
    public async Task DeleteCurso(int id)
        => await _httpClient.DeleteAsync($"api/cursos/{id}");
}

