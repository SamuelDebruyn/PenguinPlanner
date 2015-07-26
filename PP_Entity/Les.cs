#region

using System;

#endregion

namespace PP_Entity
{
    /// <summary>
    ///     Een les is een sessie onder gebruikers over een vak.
    /// </summary>
    public class Les
    {
        public Les(int id, DateTimeOffset beginDatum, DateTimeOffset eindDatum, Lokaal lokaal)
        {
            Id = id;
            Begindatum = beginDatum;
            Einddatum = eindDatum;
            Lokaal = lokaal;
        }

        /// <summary>
        ///     Deze unieke identifier wordt gebruikt in de database.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Dit is het moment waarop deze les begint.
        /// </summary>
        public DateTimeOffset Begindatum { get; set; }

        /// <summary>
        ///     Dit is het moment waarop deze les eindigt.
        /// </summary>
        public DateTimeOffset Einddatum { get; set; }

        /// <summary>
        ///     Een les wordt gegeven in één en slechts één lokaal.
        /// </summary>
        public Lokaal Lokaal { get; set; }

        public override string ToString()
        {
            return Begindatum + " - " + Einddatum;
        }
    }
}