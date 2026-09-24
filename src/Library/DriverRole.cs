//------------------------------------------------------------------------------
// <copyright file="DriverRole.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Define los tipos de rol del conductor.
    /// </summary>
    public enum DriverRole
    {
        /// <summary>
        /// El conductor lleva a un solo pasajero por viaje.
        /// </summary>
        Standard,

        /// <summary>
        /// El conductor acepta viajes compartidos con varios pasajeros.
        /// </summary>
        Pool,
    }
}
