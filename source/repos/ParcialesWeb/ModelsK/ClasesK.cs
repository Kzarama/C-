using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsK
{
    public partial class EstudianteK
    {
        public EstudianteK()
        {
            this.ParcialK = new HashSet<ParcialK>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite el nombre del EstudianteK"), MaxLength(50)]
        public string Nombre { get; set; }
        [Required, Display(Name = "Correo Electrónico"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public virtual ICollection<ParcialK> ParcialK { get; set; }
    }

    public partial class MateriaK
    {
        public MateriaK()
        {
            this.CursoK = new HashSet<CursoK>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe digitar el nombre de la MateriaK"), MaxLength(50)]
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public virtual ICollection<CursoK> CursoK { get; set; }
    }

    public partial class CursoK
    {
        public CursoK()
        {
            this.ParcialK = new HashSet<ParcialK>();
        }
        public int Id { get; set; }
        public int Grupo { get; set; }
        [Display(Name = "Año y semestre (ej. 162)")]
        public int AñoSem { get; set; }
        [Required(ErrorMessage = "Debe digitar el nombre del Profesor"), MaxLength(50)]
        public string Profesor { get; set; }
        [Display(Name = "MateriaK")]
        public int MateriaKId { get; set; }
        public virtual MateriaK MateriaK { get; set; }
        public virtual ICollection<ParcialK> ParcialK { get; set; }
    }

    public partial class ParcialK
    {
        public int Id { get; set; }
        public int Número { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime Fecha { get; set; }
        [Range(0.0, 5.0)]
        public double Nota { get; set; }
        public double Porcentaje { get; set; }
        [Display(Name = "EstudianteK")]
        public int EstudianteKId { get; set; }
        [Display(Name = "CursoK")]
        public int CursoKId { get; set; }
        public virtual EstudianteK EstudianteK { get; set; }
        public virtual CursoK CursoK { get; set; }
    }
}
