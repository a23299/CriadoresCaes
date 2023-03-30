namespace CriadoresCaes.Models
{

    /// <summary>
    /// Descrição das Fotografias associadas ao cães
    /// </summary>

    public class Fotografias
    {
        public int ID { get; set; }

        /// <summary>
        /// Nome do ficheiro com a Fotografia do cão
        /// </summary>
        public string NomeFicheiro { get; set; }

        /// <summary>
        /// Data em que a Fotografia foi tirada
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// Local onde a Fotografia foi tirada
        /// </summary>
        public string Local { get; set; }
    }
}
