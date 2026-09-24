//------------------------------------------------------------------------------
// <copyright file="Person.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Representa a una persona del sistema.
    /// </summary>
    public class Person
    {
        private string ci;
        private string name;
        private string surname;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Person"/>.
        /// </summary>
        /// <param name="ci">Cédula de la persona.</param>
        /// <param name="name">Nombre de la persona.</param>
        /// <param name="surname">Apellido de la persona.</param>
        public Person(string ci, string name, string surname)
        {
            this.ci = ci;
            this.name = name;
            this.surname = surname;
        }

        /// <summary>
        /// Obtiene la cédula de la persona.
        /// </summary>
        public string CI
        {
            get
            {
                return this.ci;
            }
        }

        /// <summary>
        /// Obtiene el nombre de la persona.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        /// <summary>
        /// Obtiene el apellido de la persona.
        /// </summary>
        public string Surname
        {
            get
            {
                return this.surname;
            }
        }
    }
}
