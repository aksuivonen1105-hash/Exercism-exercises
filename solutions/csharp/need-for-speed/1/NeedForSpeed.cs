class RemoteControlCar
{
        public int distanceDriven = 0;
        public int battery = 100;
        public int speed;
        public int batteryDrain;
    
        public RemoteControlCar(int speed, int batteryDrain)
        {
            this.speed = speed;
            this.batteryDrain = batteryDrain;
        }
    
    public bool BatteryDrained()
    {
        return battery < batteryDrain;    
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
       if (battery >= batteryDrain)
       {
           distanceDriven += speed;
           battery -= batteryDrain;
       }
        else
        {
            return;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }

    public bool CanFinish(int laps)
    {
    int distance = laps;
    int drives = (distance + speed - 1) / speed;

    return drives * batteryDrain <= battery;
    }
}

class RaceTrack
{
    private int laps;

    public RaceTrack(int laps)
    {
        this.laps = laps;
    }
        

    public bool TryFinishTrack(RemoteControlCar car)
    {
       return car.CanFinish(laps);
    }
    
}
