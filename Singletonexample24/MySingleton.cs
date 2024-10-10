// See https://aka.ms/new-console-template for more information
public class MySingleton
{
    private static int instanceCounter = 0;
    private int instanceNo;

    public MySingleton()
    {
        instanceCounter++;
        instanceNo = instanceCounter;
    }

    public int getInstanceNo()
    {
        return instanceNo;
    }

    public static int getInstanceCount()
    {
        return instanceCounter;
    }
}