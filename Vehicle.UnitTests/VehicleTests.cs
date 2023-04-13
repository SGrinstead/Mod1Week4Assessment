namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

        // This test needs some work!
        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");

            var expected = "This Blue vehicle has 2 wheels, and has driven 0 miles.";

            Assert.Equal(expected, andysBike.Sumary());
        }

        // Add more tests here!
        [Fact]
        public void DriveMethod_Adds5To_MilesDriven()
        {
            Vehicle car = new Vehicle(4, "Silver");
            car.Drive();

            Assert.Equal(5, car.MilesDriven);
        }

        [Fact]
        public void PaintMethod_Changes_Color()
        {
            Vehicle car = new Vehicle(4, "Silver");
            car.Paint("Blue");

            Assert.Equal("Blue", car.Color);
        }
    }
}