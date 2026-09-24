//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Ucu.Poo.Discord;

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Punto de entrada del programa de ejemplo del sistema UCURide.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Ejecuta un ejemplo básico de registro de un conductor y un pasajero.
        /// </summary>
        public static void Main()
        {
            MainAsync().GetAwaiter().GetResult();
        }

        private static async Task MainAsync()
        {
            string botToken = Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN");
            string channelText = Environment.GetEnvironmentVariable("CHANNEL_ID");

            if (string.IsNullOrWhiteSpace(botToken) || string.IsNullOrWhiteSpace(channelText))
            {
                Console.WriteLine("Faltan las variables de entorno DISCORD_BOT_TOKEN y CHANNEL_ID.");
                return;
            }

            ulong channelId = ulong.Parse(channelText);
            DiscordClient discord = new DiscordClient();
            await discord.LoginAsync(botToken);

            Car car1 = new Car("Toyota", "Corolla", "ABC1234", 4);
            Driver driver1 = new Driver("12345678", "Ana", "Pérez", car1, "Docente y voluntaria", DriverRole.Standard);
            Passenger passenger1 = new Passenger("87654321", "Luis", "García", 4.9f);

            UcuRide rideShare = new UcuRide(discord, channelId);
            rideShare.AddDriver(driver1);
            rideShare.AddPassenger(passenger1);

            Console.WriteLine("Registro de conductores y pasajeros");
            Console.WriteLine("Conductor: " + driver1.Name + " " + driver1.Surname + " - " + driver1.Role);
            Console.WriteLine("Vehículo: " + driver1.Car.Brand + " " + driver1.Car.Model + " - " + driver1.Car.Plate);
            Console.WriteLine("Pasajero: " + passenger1.Name + " " + passenger1.Surname + " - calificaci\u00f3n: " + passenger1.Qualification);
        }
    }
}
