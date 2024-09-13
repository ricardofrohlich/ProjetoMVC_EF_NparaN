using Microsoft.EntityFrameworkCore;
using ProjetoMVC_EF_NparaN.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ProjetoMVC_EF_NparaN.DAL
{

    public class Contexto : DbContext
    {
        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<EstudantesCursos> EstudantesCursos { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstudantesCursos>()
                .HasKey(e => e.EstudantesCursosId);

            //chave estrangeira dentro da tabela EstudanteCursos referente ao Curso
            modelBuilder.Entity<EstudantesCursos>()
                .HasOne(ec => ec.Curso)
                .WithMany(c => c.EstudantesCursos)
                .HasForeignKey(ec => ec.CursoId);
            //chave estrangeira dentro da tabela EstudanteCursos referente ao Estudante
            modelBuilder.Entity<EstudantesCursos>()
                .HasOne(ec => ec.Estudante)
                .WithMany(e=> e.EstudantesCursos)
                .HasForeignKey(ec => ec.EstudanteID);
        }
    }
}
