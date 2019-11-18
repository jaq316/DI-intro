public class Driver
{
    public IGearLever _gearLever { get; set; }
    public IClutchPedal _clutchPedal { get; set; }
    public IThrottlePedal _throttlePedal { get; set; }
    public IBreakPedal BreakPedal { get; set; }
    public IRevCounter _revCounter { get; set; }
    public ISpeedometer _speedometer { get; set; }


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