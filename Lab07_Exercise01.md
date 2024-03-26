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

![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-07/assets/144195611/7e45b6ea-9617-437a-a0b6-93a473fd9bd9)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-07/assets/144195611/a0cdd369-87c7-4cdb-b2e1-e5bcc1373701)

7. อธิบายสิ่งที่พบในการทดลอง
-มีการสร้าง class circle ใช้งานสร้างวงกลม และกำหนดค่า รัศมี เส้นผ่านศูนย์กลาง
มีการสร้างค่า get สำหรับดึงค่า/set สำหรับการตั้งค่า คือการใช้งาน properties เพื่อเข้าถึงและกำหนดค่าให้กับรัศมีและเส้นผ่านศูนย์กลางของวงกลม 
