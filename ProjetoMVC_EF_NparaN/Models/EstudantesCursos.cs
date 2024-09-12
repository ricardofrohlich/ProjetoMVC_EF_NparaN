namespace ProjetoMVC_EF_NparaN.Models
{
    public class EstudantesCursos //Classe Junção -> Ter 1 estudante -> 1 curso 
    {
        public int CursoId { get; set; }
        public Curso? Curso { get; set; }

        public int EstudanteID { get; set; }
        public Estudante? Estudante { get; set; }
    }
}
