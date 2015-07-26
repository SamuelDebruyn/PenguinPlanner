namespace PP_Entity
{
    /// <summary>
    ///     Een lokaal is een omschrijving van een plaats.
    /// </summary>
    public class Lokaal
    {
        public Lokaal(int id, int capaciteit)
        {
            Id = id;
            Capaciteit = capaciteit;
        }

        /// <summary>
        ///     Deze unieke identifier wordt gebruikt in de database. In dit geval geeft deze identifier ook een omschrijving van
        ///     het lokaal weer.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Dit is de hoeveelheid beschikbare stoelen met tafels.
        /// </summary>
        public int Capaciteit { get; set; }

        public override string ToString()
        {
            return "Lokaal: " + Id + " - Capaciteit: " + Capaciteit;
        }
    }
}