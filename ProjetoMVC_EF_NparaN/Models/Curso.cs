namespace ProjetoMVC_EF_NparaN.Models
{
    public class Curso
    {
        public int CursoID {  get; set; }
        public string NomeCurso { get; set; }
        public ICollection<EstudantesCursos>? EstudantesCursos { get; set; }
    }
}
