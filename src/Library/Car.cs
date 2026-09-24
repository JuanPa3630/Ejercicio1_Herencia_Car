//------------------------------------------------------------------------------
// <copyright file="Car.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Representa un vehículo utilizado por un conductor.
    /// </summary>
    public class Car
    {
        private string brand;
        private string model;
        private string plate;
        private int capacity;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Car"/>.
        /// </summary>
        /// <param name="brand">Marca del vehículo.</param>
        /// <param name="model">Modelo del vehículo.</param>
        /// <param name="plate">Patente del vehículo.</param>
        /// <param name="capacity">Capacidad máxima de pasajeros del vehículo.</param>
        public Car(string brand, string model, string plate, int capacity)
        {
            this.brand = brand;
            this.model = model;
            this.plate = plate;
            this.capacity = capacity;
        }

        /// <summary>
        /// Obtiene la marca del vehículo.
        /// </summary>
        public string Brand
        {
            get
            {
                return this.brand;
            }
        }

        /// <summary>
        /// Obtiene el modelo del vehículo.
        /// </summary>
        public string Model
        {
            get
            {
                return this.model;
            }
        }

        /// <summary>
        /// Obtiene la patente del vehículo.
        /// </summary>
        public string Plate
        {
            get
            {
                return this.plate;
            }
        }

        /// <summary>
        /// Obtiene la capacidad máxima de pasajeros del vehículo.
        /// </summary>
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
        }
    }
}
