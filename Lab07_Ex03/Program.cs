MyClass mc = new MyClass();
System.Console.WriteLine($"My value  = {mc.MyValue}");

mc.MyValue = 50;
System.Console.WriteLine($"My value  = {mc.MyValue}");

class MyClass
{
    private  double myValue;
    public MyClass()
    {
        myValue = Math.PI;
    }
    public double MyValue
    {
        get
        {
            return myValue;
        }
        set
        {
            myValue = value;
        }
    }
}