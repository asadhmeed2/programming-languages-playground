
class RemoteControlCar
{

    private int _distance = 0;
    
    private int _battery = 100;


    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {this._distance} meters";
    }

    public string BatteryDisplay()
    {
        return $"Battery at {this._battery}%";
    }

    public void Drive()
    {
        this._distance += 20;
        this._battery -= 1;
    }
}
