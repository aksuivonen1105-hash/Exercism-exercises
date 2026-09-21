class RemoteControlCar
{
    private int BatteryPercentage = 100;
    private int distanceDriven = 0;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();
    
    public string DistanceDisplay() => $"Driven {distanceDriven} meters";

    public string BatteryDisplay()
    {
        if (BatteryPercentage <= 0)
        {
            return "Battery empty";
        }
        else
        {
            return $"Battery at {BatteryPercentage}%";
        }
        
    }

    public void Drive()
    {
        if (BatteryPercentage > 0)
        {
            distanceDriven += 20;
            BatteryPercentage -= 1;
        }
    }
}
