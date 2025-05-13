
static class VehicleFactory {
    public static IVehicle? GetVehicle(string? tireCount) {
        switch (tireCount) {
            case "4":
                return new Car();
            case "3":
                return new TriWhealer();
            default:
                return null;
        }
    }
}