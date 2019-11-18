class ManualGearLever : IGearLeaver {

    readonly IGearBox GearBox;
    public ManualGearLever (IGearBox gearBox) {
        GearBox = gearBox;
    }

    void ShiftUp () {
        // Do whatever is needed to move to the next gear
    }
    void ShiftTo (string gearNumber) {
        // Do whatever is needed to move to the required gear
    }

}