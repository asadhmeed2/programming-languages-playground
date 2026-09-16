
class RemoteControlCar
{
    private int speed;
    private int batteryDrain;

    private int distance = 0;
    private int battery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => this.battery < this.batteryDrain;

    public int DistanceDriven() => this.distance;

    public void Drive()
    {
        if(this.battery < this.batteryDrain){
            return;
        }

        this.distance += this.speed;
    }

    public static RemoteControlCar Nitro()
    {
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Nitro() method");
    }
}

class RaceTrack
{
    private int distance = 0;
    
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        throw new NotImplementedException("Please implement the RaceTrack.TryFinishTrack() method");
    }
}
