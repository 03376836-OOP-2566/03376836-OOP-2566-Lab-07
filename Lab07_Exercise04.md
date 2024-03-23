# Lab 7 Exercise 4

## Write-only properties

1. สร้าง console application project

```cmd
dotnet new console --name Lab07_Ex04
```

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
MyClass mc = new MyClass();
mc.MyValue = 50;
System.Console.WriteLine($"My value  = {mc.MyValue}");

class MyClass
{
    private int StoredValue;
    public int MyValue
    {
        set
        {
            StoredValue = value;
        }
    }
}
```

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab07_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
### แก้ไขแล้ว
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-07/assets/144195555/17b9c668-4692-44b9-a405-5d65e2091029)
### ไม่สามารถ Build ได้ เพราะ MyValue ที่มี set เท่านั้นและไม่มี get
5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
### แก้ไขแล้ว
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-07/assets/144195555/fe193905-015e-4642-a6cf-a1b22216a40d)
### ไม่สามารถ Run ได้ เพราะ MyValue ที่มี set เท่านั้นและไม่มี get
7. อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมจะแสดงผล My value = 50
