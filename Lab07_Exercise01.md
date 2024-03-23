# Lab 7 Exercise 1

## Properties

1. สร้าง console application project

```cmd
dotnet new console --name Lab07_Ex01
```

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var c1 = new Circle();
c1.Radius = 3.0f;
c1.Info();
c1.Diameter = 8.0;
c1.Info();

class Circle
{
    private double radius;
    public double Radius 
    { 
        get{return radius;} 
        set{radius = value;} 
    }
    public double Diameter
    {
        get{return radius * 2;} 
        set{radius = value / 2.0;}
    }

    public void Info()
    {
        System.Console.WriteLine($"My circle has radius of {radius:F4} and diameter of {Diameter:F4} unit");
    }
}
```

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab07_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-07/assets/144195555/8d0077a7-aae7-4ffe-a787-7db8faffde95)
### สามารถ Build เพราะ สามารถเรียกใช้ class จาก Circle เข้าถึงได้ทั้งหมด เพราะเป็น Public
5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-07/assets/144195555/5289a601-fb41-41bf-acdd-ccbfa764e215)
### สามารถ Run ได้ปกติ เพราะ สามารถเข้าถึง class ได้
7. อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมจะแสดงผล
### My circle has radius of 3.0000 and diameter of 6.0000 unit
### My circle has radius of 4.0000 and diameter of 8.0000 unit
