using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMVC_EF_NparaN.Models
{
    public class EstudantesCursos //Classe Junção -> Ter 1 estudante -> 1 curso 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EstudantesCursosId { get; set; }
        public int CursoId { get; set; }
        public Curso? Curso { get; set; }

        public int EstudanteID { get; set; }
        public Estudante? Estudante { get; set; }
    }
}
