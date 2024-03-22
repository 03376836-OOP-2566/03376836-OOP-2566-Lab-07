# Lab 7 Exercise 1

## Properties

1. สร้าง console application project

```cmd
dotnet new console --name Lab07_Ex01
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/57a14468-ff3b-48c4-bb47-8b3f4d655ff4)

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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/879884a1-839a-465b-b1ba-4149b5e24396)
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/d7e33608-787d-466b-8b51-9d8414fa29d9)

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab07_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/de669c10-f692-45f6-9ceb-28958d534746)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/be8b8d2c-1eba-48fd-8604-00aef9e7c9f3)

7. อธิบายสิ่งที่พบในการทดลอง

จากการทดลอง การใช้งานคลาส Circle ในการจัดการข้อมูลเกี่ยวกับวงกลม โดยมีลักษณะดังนี้ สร้างอ็อบเจกต์ c1 จากคลาส Circle และกำหนดค่า Radius เป็น 3.0 ด้วยคำสั่ง c1.Radius = 3.0f; เมื่อเรียกใช้เมธอด Info() โดยใช้อ็อบเจกต์ c1 จะแสดงข้อมูลเกี่ยวกับวงกลมที่มีรัศมีและเส้นผ่านศูนย์กลางตามค่าที่กำหนด ต่อมากำหนดค่า Diameter เป็น 8.0 ด้วยคำสั่ง c1.Diameter = 8.0; ซึ่งจะทำให้ค่า radius ของวงกลม c1 ถูกปรับใหม่ตามค่า Diameter ที่กำหนด  เมื่อเรียกใช้เมธอด Info() อีกครั้ง จะแสดงข้อมูลเกี่ยวกับวงกลม c1 ที่ถูกปรับค่า radius และ Diameter ใหม่แล้ว เป็นการใช้งานและการคำนวณข้อมูลของวงกลมด้วยคลาส Circle ในภาษา C# โดยใช้คุณสมบัติของเมธอด get และ set เพื่อควบคุมการเข้าถึงและการกำหนดค่าของฟิลด์ในคลาส circ
