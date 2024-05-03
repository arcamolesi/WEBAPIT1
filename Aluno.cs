using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEBAPIT1
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int id { get; set; }

        [StringLength(35)]
        public string descricao { get; set; }

        [StringLength (25)]
        public string curso { get; set; }

        public float nota1 { get; set; }
        public float nota2 { get; set; }



    }
}
