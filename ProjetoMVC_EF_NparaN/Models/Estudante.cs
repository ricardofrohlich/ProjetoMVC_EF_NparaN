namespace ProjetoMVC_EF_NparaN.Models
{
    public class Estudante
    {
        public int EstudanteId { get; set; }
        public string Nome { get; set; }
        public ICollection<EstudantesCursos>? EstudantesCursos { get; set; }
    }
}
