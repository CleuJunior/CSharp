class RemoteControlCar
{
    public int Speed { get; }
    public int BatteryDrain { get; }
    private int _battery;
    private int _distance;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _battery = 100;
        _distance = 0;
        Speed = speed;
        BatteryDrain = batteryDrain;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            _distance += Speed;
            _battery -= BatteryDrain;
        }
    }

    public int DistanceDriven() => _distance;

    public bool BatteryDrained() => _battery - BatteryDrain < 0;

    public static RemoteControlCar Nitro() => new(50, 4);
}

class RaceTrack
{
    private readonly int _distance;

    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        var drives = (100 / car.BatteryDrain);
        var possibleDistance = drives * car.Speed;
        return possibleDistance >= _distance;
    }
}