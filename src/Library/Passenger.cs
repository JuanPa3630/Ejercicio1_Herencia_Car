//------------------------------------------------------------------------------
// <copyright file="Passenger.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Representa a un pasajero del sistema.
    /// </summary>
    public class Passenger : Person
    {
        private float qualification;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Passenger"/>.
        /// </summary>
        /// <param name="ci">Cédula del pasajero.</param>
        /// <param name="name">Nombre del pasajero.</param>
        /// <param name="surname">Apellido del pasajero.</param>
        /// <param name="qualification">Calificación del pasajero.</param>
        public Passenger(string ci, string name, string surname, float qualification)
            : base(ci, name, surname)
        {
            this.qualification = qualification;
        }

        /// <summary>
        /// Obtiene la calificación del pasajero.
        /// </summary>
        public float Qualification
        {
            get
            {
                return this.qualification;
            }
        }
    }
}
