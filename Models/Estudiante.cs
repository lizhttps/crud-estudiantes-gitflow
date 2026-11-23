using System.ComponentModel.DataAnnotations;

namespace CrudEstudiantes.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(100)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Email no válido")]
        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La matrícula es obligatoria")]
        [StringLength(20)]
        [Display(Name = "Matrícula")]
        public string Matricula { get; set; } = string.Empty;

        [Display(Name = "Fecha de Registro")]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}