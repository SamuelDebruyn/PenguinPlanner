namespace PP_Entity
{
    /// <summary>
    ///     Een Rol omschrijft welke rechten een gebruiker in het systeem heeft.
    /// </summary>
    public enum Rol
    {
        /// <summary>
        ///     Een beheerder heeft alle rechten in het systeem.
        /// </summary>
        Beheerder,

        /// <summary>
        ///     Een docent kan alle informatie over een vak aanpassen.
        /// </summary>
        Docent,

        /// <summary>
        ///     Een student leest voornamelijk informatie en slechts enkele persoonlijke voorkeuren aanpassen.
        /// </summary>
        Student,
    }
}