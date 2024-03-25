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

![2](https://github.com/Siriratda/03376836-OOP-2566-Lab-07/assets/144195995/5c8a9551-4cf5-4df3-bcf4-47febc9af7b6)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![2 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-07/assets/144195995/cd6e87cd-4726-41c7-823e-d9c0ed94cf2e)

7. อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ สามารถเข้าถึง class แบบ pubilc ได้
โปรแกรมจะแสดงผล
mc.MyValue = 50
mc.MyValue = 100
