# Lab 7 Exercise 3

## Read-only properties

1. สร้าง console application project

```cmd
dotnet new console --name Lab07_Ex03
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/2f8d07f8-bdd4-4f91-adb0-e92a34beb8b7)

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
MyClass mc = new MyClass();
System.Console.WriteLine($"My value  = {mc.MyValue}");

mc.MyValue = 50;
System.Console.WriteLine($"My value  = {mc.MyValue}");

class MyClass
{
    private const double My_PI =  Math.PI;
    public double MyValue
    {
        get
        {
            return My_PI;
        }
    }
}
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/0e9992b3-ad36-470f-8c8e-d82c71df2684)

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab07_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/23c704bf-c6f9-4c11-8d9b-f99097283539)
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/9eaee600-7449-424b-93ce-86c9ee9ff417)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/8a3a5146-6dfe-4b72-99fc-e65addf2168a)

7. อธิบายสิ่งที่พบในการทดลอง
