using NUnit.Framework;
using Ucu.Poo.RideShare;

namespace Ucu.Poo.RideShareTests
{
    public class UcuRideTests
    {
        [Test]
        public void Passenger_ShouldStoreIdentityAndQualification()
        {
            Passenger passenger = new Passenger("12345678", "Ana", "Pérez", 4.8f);

            Assert.That(passenger.CI, Is.EqualTo("12345678"));
            Assert.That(passenger.Name, Is.EqualTo("Ana"));
            Assert.That(passenger.Surname, Is.EqualTo("Pérez"));
            Assert.That(passenger.Qualification, Is.EqualTo(4.8f).Within(0.0001f));
        }

        [Test]
        public void Driver_ShouldStoreVehicleAndRole()
        {
            Car car = new Car("Toyota", "Corolla", "ABC1234", 5);
            Driver driver = new Driver("98765432", "Luis", "García", car, "Profesor de programación", DriverRole.Pool);

            Assert.That(driver.CI, Is.EqualTo("98765432"));
            Assert.That(driver.Car, Is.SameAs(car));
            Assert.That(driver.Role, Is.EqualTo(DriverRole.Pool));
            Assert.That(driver.Description, Is.EqualTo("Profesor de programación"));
        }

        [Test]
        public void UcuRide_ShouldRegisterDriversAndPassengers()
        {
            UcuRide ucuRide = new UcuRide();
            Car car = new Car("Ford", "Focus", "XYZ9876", 4);
            Driver driver = new Driver("11111111", "Martín", "López", car, "Docente", DriverRole.Standard);
            Passenger passenger = new Passenger("22222222", "Sofía", "Ramírez", 5.0f);

            ucuRide.AddDriver(driver);
            ucuRide.AddPassenger(passenger);

            Assert.That(ucuRide.Drivers.Count, Is.EqualTo(1));
            Assert.That(ucuRide.Passengers.Count, Is.EqualTo(1));
            Assert.That(ucuRide.Drivers[0], Is.SameAs(driver));
            Assert.That(ucuRide.Passengers[0], Is.SameAs(passenger));
        }

        [Test]
        public void PoolDriver_ShouldExposeCarCapacity()
        {
            Car car = new Car("Volkswagen", "Gol", "LMN4567", 3);
            Driver driver = new Driver("33333333", "Carla", "Díaz", car, "Viajes compartidos", DriverRole.Pool);

            Assert.That(driver.Role, Is.EqualTo(DriverRole.Pool));
            Assert.That(driver.Car.Capacity, Is.EqualTo(3));
        }
    }
}
