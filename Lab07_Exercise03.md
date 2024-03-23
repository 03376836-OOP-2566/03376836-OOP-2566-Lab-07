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

<img width="447" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-07/assets/144195963/a55fc0c5-c6e8-4456-b3f8-9e31db258ef1">

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="447" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-07/assets/144195963/5e3596c9-c4a2-45af-ad03-e52669a65018">


7. อธิบายสิ่งที่พบในการทดลอง
   
โปรแกรมจะแสดงผล My value = 3.14159
