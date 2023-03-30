namespace CriadoresCaes.Models
{

    /// <summary>
    /// Descrição dos Animais
    /// </summary>

    public class Animais
    {
        public int ID { get; set; }

        /// <summary>
        /// Nome do cão
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Data de Nascimento do cão
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// Data da compra do cão
        /// </summary>
        public DateTime DataCompra {  get; set; }

        /// <summary>
        /// Sexo do cão
        /// M - Macho
        /// F - Fêmea
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// Valor de registo no LOP
        /// </summary>
        public string NumLOP { get; set; }
    }
}
