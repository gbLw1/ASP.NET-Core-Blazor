using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DigitalCursos.Models.Models;

public class Curso
{
    //private int cargaHoraria;
    //private DateTime inicio;

    public int CursoId { get; set; }

    [Required(ErrorMessage = "Informe o nome do curso")]
    public string? CursoNome { get; set; }

    [Required(ErrorMessage = "Informe uma descrição para o curso")]
    public string? Descricao { get; set; }

    [Required(ErrorMessage = "Informe a carga horária do curso")]
    //public string CargaHoraria { get => cargaHoraria.ToString(); set => cargaHoraria = int.Parse(value); }
    public int CargaHoraria { get; set; }

    //public string Inicio { get => inicio.ToString(); set => inicio = DateTime.Parse(value); }
    public DateTime Inicio { get; set; }

    public decimal Preco { get; set; }

    public byte[]? Logo { get; set; }

    public Collection<Aluno>? Alunos { get; set; }
}
