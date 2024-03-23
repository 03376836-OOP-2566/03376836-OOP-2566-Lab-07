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

<img width="611" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-07/assets/144195963/bdc4ef4a-4149-4aab-ab8c-28892a2a131d">

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="458" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-07/assets/144195963/457c56cc-4640-410a-bce1-af8e2236e84f">

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล My value = 50
