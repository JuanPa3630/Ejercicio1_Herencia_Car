//------------------------------------------------------------------------------
// <copyright file="UcuRide.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Ucu.Poo.Discord;

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Gestiona el registro de conductores y pasajeros del sistema.
    /// </summary>
    public class UcuRide
    {
        private List<Driver> drivers;
        private List<Passenger> passengers;
        private DiscordClient discordClient;
        private ulong channelId;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UcuRide"/> sin publicar en Discord.
        /// </summary>
        public UcuRide()
            : this(null, 0)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UcuRide"/> con la publicación en Discord.
        /// </summary>
        /// <param name="discordClient">Cliente de Discord para enviar mensajes e imágenes.</param>
        /// <param name="channelId">Identificador del canal donde se publicará.</param>
        public UcuRide(DiscordClient discordClient, ulong channelId)
        {
            this.drivers = new List<Driver>();
            this.passengers = new List<Passenger>();
            this.discordClient = discordClient;
            this.channelId = channelId;
        }

        /// <summary>
        /// Obtiene la lista de conductores registrados en el sistema.
        /// </summary>
        public List<Driver> Drivers
        {
            get
            {
                return this.drivers;
            }
        }

        /// <summary>
        /// Obtiene la lista de pasajeros registrados en el sistema.
        /// </summary>
        public List<Passenger> Passengers
        {
            get
            {
                return this.passengers;
            }
        }

        /// <summary>
        /// Agrega un conductor nuevo al sistema y publica el registro si hay un cliente configurado.
        /// </summary>
        /// <param name="driver">Conductor a registrar.</param>
        public void AddDriver(Driver driver)
        {
            this.drivers.Add(driver);
            this.PublishDriver(driver);
        }

        /// <summary>
        /// Agrega un pasajero nuevo al sistema y publica el registro si hay un cliente configurado.
        /// </summary>
        /// <param name="passenger">Pasajero a registrar.</param>
        public void AddPassenger(Passenger passenger)
        {
            this.passengers.Add(passenger);
            this.PublishPassenger(passenger);
        }

        private void PublishDriver(Driver driver)
        {
            if (this.discordClient == null || this.channelId == 0)
            {
                return;
            }

            string message = "Nuevo conductor registrado: " + driver.Name + " " + driver.Surname + " - " + driver.Role;
            this.discordClient.SendMessageAsync(this.channelId, message).GetAwaiter().GetResult();
        }

        private void PublishPassenger(Passenger passenger)
        {
            if (this.discordClient == null || this.channelId == 0)
            {
                return;
            }

            string message = "Nuevo pasajero registrado: " + passenger.Name + " " + passenger.Surname;
            this.discordClient.SendMessageAsync(this.channelId, message).GetAwaiter().GetResult();
        }
    }
}
