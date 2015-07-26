#region

using System;

#endregion

namespace PP_Entity
{
    /// <summary>
    ///     Docenten kunnen opdrachten opgeven waaraan groepen van één of meerdere gebruikers moeten werken.
    /// </summary>
    public class Opdracht
    {
        public Opdracht(int id, string beschrijving, DateTimeOffset beginDatum, DateTimeOffset eindDatum, Vak vak)
        {
            Id = id;
            Beschrijving = beschrijving;
            Begindatum = beginDatum;
            Einddatum = eindDatum;
            Vak = vak;
        }

        /// <summary>
        ///     Deze unieke identifier wordt gebruikt in de database.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Dit is een omschrijving van de opdracht die de studenten moeten maken.
        /// </summary>
        public string Beschrijving { get; set; }

        /// <summary>
        ///     Dit is het moment waarop deze opdracht begint.
        /// </summary>
        public DateTimeOffset Begindatum { get; set; }

        /// <summary>
        ///     Dit is het moment waarop deze opdracht eindigt.
        /// </summary>
        public DateTimeOffset Einddatum { get; set; }

        /// <summary>
        ///     Elke opdracht heeft met één vak te maken.
        /// </summary>
        public Vak Vak { get; set; }

        public override string ToString()
        {
            return Beschrijving + "(" + Vak + ")";
        }
    }
}