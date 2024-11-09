using System.Diagnostics;

public partial class Walking : State
{
    override public void onEnter() 
    {
        Debug.Print("Entering Walking state...");
    }

    public override void onExit()
    {
        Debug.Print("Exiting Walking state..");
    }

    public override void stateProcess()
    {
        Debug.Print("Running stateProcess on Walking state...");
    }

}