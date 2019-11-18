public class Driver
{
    readonly _gearLever;
    readonly _clutchPedal;
    readonly _throttlePedal;
    readonly _breakPedal;

    public Driver(
            IGearLever gearLever, 
            IClutchPedal clutchPedal, 
            IThrottlePedal throttlePedal,
            IBreakPedal breakPedal
        )
    {
            _gearLever = gearLever;    
            _clutchPedal = clutchPedal;    
            _throttlePedal = throttlePedal;    
            _breakPedal = breakPedal;    
    }
    
}