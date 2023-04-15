using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }

        //ValidationTema
        [Required (ErrorMessage = "O campo {0} é obrigatório."),
        StringLength(50, MinimumLength =3,
                         ErrorMessage = "Intervalo permitido de 3 a 50 caracteres.")]
        public string Tema { get; set; }

        //ValidationQtdPessoas
        [Display(Name = "Qtd Pessoas"),
        Range(1, 120000, ErrorMessage = "{0} não pode ser menor que 1 e maior que 120.000.")]
        public int QtdPessoas { get; set; }

        //ValidationImage
        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$", 
                            ErrorMessage = "Não é uma imagem válida. (gif, jpg, jpeg, bmp ou png)")]
        public string ImagemURL { get; set; }

        //ValidationTelefone
        [Required(ErrorMessage = "O campo {0} é obrigatório."),
        Phone(ErrorMessage = "O campo {0} está com número inválido.")]
        public string Telefone { get; set; }

        //ValidationE-mail
        [Required(ErrorMessage = "O campo {0} é obrigatório."),
        Display(Name = "E-mail"),
        EmailAddress (ErrorMessage = "É necessário ser um {0} válido.")]
        public string Email { get; set; }

        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrantes { get; set; }
    }
}