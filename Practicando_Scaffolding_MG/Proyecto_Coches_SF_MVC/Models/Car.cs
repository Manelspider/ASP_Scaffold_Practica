using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PruebaScaffold.Models
{
    public class Car
    {
        public int Id { get; set; }



        [Required(ErrorMessage = "El modelo es obligatorio.")]
        [MaxLength(15, ErrorMessage = "El campo del rango tiene que ser menor o igual de 15 caracteres")]
        [MinLength(3, ErrorMessage = "El campo de rango tiene que ser mayor o igual a 3 caracteres")]
        [DisplayName("Modelo")]
        public string Model { get; set; }

        [Required(ErrorMessage = "La marca es obligatoria")]
        [MaxLength(15, ErrorMessage = "El campo del rango tiene que ser menor o igual de 15 caracteres")]
        [MinLength(3, ErrorMessage = "El campo de rango tiene que ser mayor o igual a 3 caracteres")]
        [DisplayName("Marca")]

        public string Brand { get; set; }


        [DisplayName("Matrícula")]
        [Required(ErrorMessage = "La matrícula es obligatoria.")]
        [RegularExpression(@"^[A-Z0-9]{7}$", ErrorMessage = "La matrícula debe tener 7 caracteres alfanuméricos en mayúscula.")]
        public string LicensePlate { get; set; }

        [DisplayName("Numero Asientos")]
        [Required(ErrorMessage = "El numero de asientos es obligatorios")]
        [Range(1, 9, ErrorMessage = "El numero de asientos tiene que estar entre 1 y 9")]
        public string SeatNum { get; set; }

    }
}