public class Driver
{
    readonly IGearLever _gearLever;
    readonly IClutchPedal _clutchPedal;
    readonly IThrottlePedal _throttlePedal;
    readonly IBreakPedal _breakPedal;
    readonly IRevCounter _revCounter;
    readonly ISpeedometer _speedometer;

    public Driver(
            IGearLever gearLever, 
            IClutchPedal clutchPedal, 
            IThrottlePedal throttlePedal,
            IBreakPedal breakPedal,
            IRevCounter revCounter,
            ISpeedometer speedometer
        )
    {
            _gearLever = gearLever;    
            _clutchPedal = clutchPedal;    
            _throttlePedal = throttlePedal;    
            _breakPedal = breakPedal;    
            _revCounter - revCounter
            _speedometer = speedometer;
    }

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

        _gearLever.Reset();

    }

}