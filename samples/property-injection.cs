public class Driver
{
    public IGearLever GearLever { set; }
    public IClutchPedal ClutchPedal { set; }
    public IThrottlePedal ThrottlePedal { get; set; }
    public IBreakPedal BreakPedal { get; set; }
    
}