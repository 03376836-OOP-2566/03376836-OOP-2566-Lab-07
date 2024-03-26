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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-07/assets/144195708/389f9aa8-1913-45a0-98f0-19700ce59208)

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-07/assets/144195708/5d7b9b8f-e9ec-49b2-acc8-95accfb1d9a2)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-07/assets/144195708/cd960089-bb7d-4c54-be10-e30b15a6142d)

7. อธิบายสิ่งที่พบในการทดลอง
- My value  = 3.141592653589793
- My value  = 50
ในการเเก้ไขโปรเเกรม เพิ่ม ตัวแปร เป็น myValue ให้ myValue = math.PI และกำหนดให้ myValue get กับ set
