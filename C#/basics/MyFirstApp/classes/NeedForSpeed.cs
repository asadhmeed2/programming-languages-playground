
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

        this.battery -= this.batteryDrain;
        this.distance += this.speed;
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50,4);
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
        while(car.DistanceDriven() < this.distance && !car.BatteryDrained())
        {
        car.Drive();
        }

        return car.DistanceDriven() >= this.distance;
    }
}
