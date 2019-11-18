public class Driver
{
    readonly _gearLever;
    readonly _clutchPedal;
    readonly throttlePeddle;
    readonly _breakPedal;

    public Driver(
            IGearLever gearLever, 
            IClutchPedal clutchPedal, 
            IThrottlePedal throttlePeddle,
            IBreakPedal breakPedal
        )
    {
            _gearLever = gearLever;    
            _clutchPedal = clutchPedal;    
            _throttlePeddle = throttlePeddle;    
            _breakPedal = breakPedal;    
    }
    
}