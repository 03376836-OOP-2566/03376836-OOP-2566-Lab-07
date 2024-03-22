﻿MyClass mc = new MyClass();
System.Console.WriteLine($"My value  = {mc.MyValue}");

mc.MyValue = 50;
System.Console.WriteLine($"My value  = {mc.MyValue}");

class MyClass
{
    private double myValue; // เพิ่มตัวแปรที่จะถูกใช้เก็บค่า

    public MyClass()
    {
        myValue = Math.PI; // กำหนดค่าเริ่มต้นใน constructor
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