using ListaLeitura.Enums;
using System.ComponentModel.DataAnnotations;


namespace ListaLeitura.Models
{
    public class ListaLeituraModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o autor")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Preencha o status")]
        public StatusEnum Status { get; set; }

        [Required(ErrorMessage = "Preencha o ano da leitura")]
        public int AnoLeitura { get; set; }
    }
}
