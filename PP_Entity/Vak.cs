namespace PP_Entity
{
    /// <summary>
    ///     Een vak is niet hetzelfde als een les. Een vak is een leerplan dat gegeven wordt.
    /// </summary>
    public class Vak
    {
        public Vak(int id, string naam, string beschrijving, byte studiepunten)
        {
            Id = id;
            Naam = naam;
            Beschrijving = beschrijving;
            Studiepunten = studiepunten;
        }

        /// <summary>
        ///     Dit is de naam van het vak.
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        ///     Dit is een beschrijving van het vak.
        /// </summary>
        public string Beschrijving { get; set; }

        /// <summary>
        ///     Elk vak heeft een aantal studiepunten gaande van 1 tot 60.
        /// </summary>
        public byte Studiepunten { get; set; }

        /// <summary>
        ///     Deze unieke identifier wordt gebruikt in de database.
        /// </summary>
        public int Id { get; set; }

        public override string ToString()
        {
            return Naam;
        }
    }
}