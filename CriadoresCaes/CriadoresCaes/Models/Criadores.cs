namespace CriadoresCaes.Models
{

    /// <summary>
    /// Descrição dos Criadores dos cães
    /// </summary>

    public class Criadores
    {
        public int ID { get; set; } 

        /// <summary>
        /// Nome do Criador
        /// </summary>
        public string Nome { get; set;}

        /// <summary>
        /// Nome Comercial do Criador
        /// </summary>
        public string NomeComercial { get; set;}

        /// <summary>
        /// Morada do Criador
        /// </summary>
        public string Morada { get; set;}

        /// <summary>
        /// Código Postal do Criador
        /// </summary>
        public string CodPostal { get; set;} 

        /// <summary>
        /// E-mail do Criador
        /// </summary>
        public string Email {get; set;}

        /// <summary>
        /// Telemóvel do Criador
        /// </summary>
        public string Telemovel { get; set;}


    }
}
