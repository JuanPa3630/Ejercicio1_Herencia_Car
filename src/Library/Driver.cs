//------------------------------------------------------------------------------
// <copyright file="Driver.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Representa a un conductor del sistema.
    /// </summary>
    public class Driver : Person
    {
        private Car car;
        private string description;
        private DriverRole role;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Driver"/>.
        /// </summary>
        /// <param name="ci">Cédula del conductor.</param>
        /// <param name="name">Nombre del conductor.</param>
        /// <param name="surname">Apellido del conductor.</param>
        /// <param name="car">Vehículo asociado al conductor.</param>
        /// <param name="description">Descripción o bio del conductor.</param>
        /// <param name="role">Rol que cumple el conductor dentro del sistema.</param>
        public Driver(string ci, string name, string surname, Car car, string description, DriverRole role)
            : base(ci, name, surname)
        {
            this.car = car;
            this.description = description;
            this.role = role;
        }

        /// <summary>
        /// Obtiene el vehículo asociado al conductor.
        /// </summary>
        public Car Car
        {
            get
            {
                return this.car;
            }
        }

        /// <summary>
        /// Obtiene la descripción o bio del conductor.
        /// </summary>
        public string Description
        {
            get
            {
                return this.description;
            }
        }

        /// <summary>
        /// Obtiene el rol del conductor.
        /// </summary>
        public DriverRole Role
        {
            get
            {
                return this.role;
            }
        }
    }
}
