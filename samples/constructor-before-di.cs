public class Driver
{
    public Driver() {
            _gearLever = new ManualGearLever();    
            _clutchPedal = new ClutchPedal();    
            _throttlePedal = new ThrottlePedal();    
            _breakPedal = new BreakPedal();    
            _revCounter - new RevCounter();
            _speedometer = new Speedometer();
    }

    readonly ManualGearLever _gearLever;
    readonly ClutchPedal _clutchPedal;
    readonly ThrottlePedal _throttlePedal;
    readonly BreakPedal _breakPedal;
    readonly RevCounter _revCounter;
    readonly Speedometer _speedometer;

    public void Accelerate(){        
        _clutchPedal.In();
        _throttlePedal.Out();
        _gearLever.ShiftUp();
        _throttlePedal.In();
        _clutchPedal.Out();

        while (!_revCounter.Warning)
        {
            _throttlePedal.In();
        }

        Accelerate();
    }

    public void Stop(){        
        _throttlePedal.Out();
        _clutchPedal.In();
        _breakPedal.In();

        while (_speedometer.Value != 0)
        {
            _breakPedal.In();
        }

        _gearLever.ShiftTo("1");

    }

}