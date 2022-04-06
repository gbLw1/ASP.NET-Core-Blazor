using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DigitalCursos.Models.Models;

public class Aluno
{
    public int AlunoId { get; set; }

    [Required(ErrorMessage = "Informe o nome do aluno")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "Informe o sobrenome do aluno")]
    public string? SobreNome { get; set; }

    [Required(ErrorMessage = "Informe o email do aluno")]
    [EmailAddress]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Informe a data de nascimento do aluno")]
    public DateTime Nascimento { get; set; }

    public byte[]? Foto { get; set; }

    public Genero Genero { get; set; }

    [JsonIgnore]
    public Curso? Curso { get; set; }

    public int CursoId { get; set; }
}
