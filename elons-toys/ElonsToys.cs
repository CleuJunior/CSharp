class RemoteControlCar
{
    private int _battery = 100;
    private int _totalDriven;
    private const int BatteryDrainValuePerTwentyMeters = 1;
    private const int MetersDriven = 20;
    private const string BatteryEmpty = "Battery empty";

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_totalDriven} meters";
    }

    public string BatteryDisplay()
    {
        return _battery == 0 ? BatteryEmpty : $"Battery at {_battery}%";
    }

    public void Drive()
    {
        if (_battery <= 0)
        {
            return;
        }

        _totalDriven += MetersDriven;
        _battery -= BatteryDrainValuePerTwentyMeters;
    }
}