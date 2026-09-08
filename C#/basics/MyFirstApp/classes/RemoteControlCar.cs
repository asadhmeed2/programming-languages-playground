
class RemoteControlCar
{

    private int _distance = 0;
    
    private int _battery = 0;


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
        throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
    }
}
