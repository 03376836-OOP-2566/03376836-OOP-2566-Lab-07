# Lab 7 Exercise 2

## Properties calculation

1. สร้าง console application project

```cmd
dotnet new console --name Lab07_Ex02
```

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
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
```

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab07_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-07/assets/144195555/f3f55ad7-c223-44a4-b636-f6fa25671097)
### สามารถ Build ได้ เพราะ กำหนด ให้ mc เป็น new MyClass จึงสามารถเข้าถึงค่าต่างๆได้ตามที่กำหนด
5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-07/assets/144195555/fd51bb42-5e54-46ed-97ee-24410c39cec1)
### สามารถ Run ได้ เพราะ สามารถเข้าถึง class แบบ pubilc ได้
7. อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมจะแสดงผล
### mc.MyValue = 50
### mc.MyValue = 100
