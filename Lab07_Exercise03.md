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

![3](https://github.com/Siriratda/03376836-OOP-2566-Lab-07/assets/144195995/13f9c9b7-e128-4fa6-ba54-4b21f51ea9d5)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![3 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-07/assets/144195995/78ce4521-116b-41fd-88d1-9cc97582f169)

7. อธิบายสิ่งที่พบในการทดลอง

ไม่สามารถ Run ได้ เพราะ MyValue มีเฉพาะ getter (การอ่านค่า) และไม่มี setter (การกำหนดค่า) ซึ่งทำให้ไม่สามารถกำหนดค่าให้ MyValue ได้ แก้โดยใส่ค่าของพาย
โปรแกรมจะแสดงผล My value = 3.14159
