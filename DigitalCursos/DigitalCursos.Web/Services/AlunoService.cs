using DigitalCursos.Models.Models;

namespace DigitalCursos.Web.Services;

public class AlunoService : IAlunoService
{
    private readonly HttpClient _httpClient;

    public AlunoService(HttpClient httpClient)
        => _httpClient = httpClient;

    public async Task<IEnumerable<Aluno>> GetAlunos()
        => await _httpClient.GetFromJsonAsync<IEnumerable<Aluno>>($"api/alunos");

    public async Task<Aluno> GetAluno(int id)
        => await _httpClient.GetFromJsonAsync<Aluno>($"api/alunos/{id}");

    public async Task<Aluno> CreateAluno(Aluno aluno)
    {
        var response = await _httpClient.PostAsJsonAsync<Aluno>($"api/alunos", aluno);
        var content = await response.Content.ReadFromJsonAsync<Aluno>();
        return content;
    }

    public async Task<Aluno> UpdateAluno(Aluno aluno)
    {
        var response = await _httpClient.PutAsJsonAsync<Aluno>($"api/alunos/{aluno.AlunoId}", aluno);
        var content = await response.Content.ReadFromJsonAsync<Aluno>();
        return content;
    }
    public async Task DeleteAluno(int id)
        => await _httpClient.DeleteAsync($"api/alunos/{id}");
}

