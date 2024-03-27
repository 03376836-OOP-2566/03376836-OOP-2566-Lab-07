# Lab 7 Exercise 3

## Read-only properties

1. สร้าง console application project

```cmd
dotnet new console --name Lab07_Ex03
```

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

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab07_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="795" alt="Screenshot 2024-03-27 201725" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-07/assets/144196049/26eee14c-4131-4071-8a52-a335b5634ac8">

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="796" alt="Screenshot 2024-03-27 201746" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-07/assets/144196049/be339be1-2d72-4f4c-b925-7048c4e51cd1">

7. อธิบายสิ่งที่พบในการทดลอง
