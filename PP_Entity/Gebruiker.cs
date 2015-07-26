#region

using System;
using System.Collections.Generic;

#endregion

namespace PP_Entity
{
    /// <summary>
    ///     De gebruiker maakt gebruik van het systeem.
    /// </summary>
    public class Gebruiker
    {
        public Gebruiker()
        {
            _rollen = new List<Rol>();
        }

        public Gebruiker(String voornaam, String achternaam, String email, String wachtwoord, DateTime geboortedatum,
            Taal taal)
            : this()
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Email = email;
            Wachtwoord = wachtwoord;
            _geboortedatum = geboortedatum;
            Taal = taal;
        }

        public Gebruiker(int id, String voornaam, String achternaam, String email, String wachtwoord,
            DateTime geboortedatum, Taal taal) : this()
        {
            Id = id;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Email = email;
            Wachtwoord = wachtwoord;
            _geboortedatum = geboortedatum;
            Taal = taal;
        }

        public int Id { get; set; }


        public string Voornaam { get; set; }

        public string Achternaam { get; set; }

        public string Email { get; set; }

        public string Wachtwoord { get; set; }

        /// <summary>
        ///     Dit is de geboortedatum van de gebruiker.
        /// </summary>
        private DateTime _geboortedatum;

        public DateTime Geboortedatum
        {
            get { return _geboortedatum; }
            set { _geboortedatum = value; }
        }


        private readonly List<Rol> _rollen;

        public void RolToevoegen(Rol rol)
        {
            _rollen.Add(rol);
        }

// ReSharper disable once UnusedMember.Global
        public void RolVerwijderen(Rol rol)
        {
            _rollen.Remove(rol);
        }

        public IEnumerable<Rol> Rollen
        {
            get { return _rollen; }
        }

        /// <summary>
        ///     Dit is de voorkeurstaal van de gebruiker.
        /// </summary>
        public Taal Taal { get; set; }

        /// <summary>
        ///     Dit is de gekozen Rol van de gebruiker.
        /// </summary>
        public Rol Rol { get; set; }

        public override string ToString()
        {
            return Voornaam + " " + Achternaam;
        }
    }
}

