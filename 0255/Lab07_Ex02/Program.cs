MyClass mc = new MyClass();
mc.MyValue = 50;
System.Console.WriteLine($"mc.MyValue = {mc.MyValue}");
mc.MyValue = 150;
System.Console.WriteLine($"mc.MyValue = {mc.MyValue}");

class MyClass
{
    private int StoredPercentValue;
    public int MyValue
    {
        set
        {   
            if(value > 100)
                StoredPercentValue = 100;
                else
                StoredPercentValue = value;
        }
        get
        {
            return StoredPercentValue;
        }
    }
}