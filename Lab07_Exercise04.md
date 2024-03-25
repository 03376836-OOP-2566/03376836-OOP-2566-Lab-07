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

![4](https://github.com/Siriratda/03376836-OOP-2566-Lab-07/assets/144195995/2ecc7706-4c91-4655-a531-ce7c97074a04)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![4 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-07/assets/144195995/96971e84-ccef-4c79-8ad4-f904fb230891)

7. อธิบายสิ่งที่พบในการทดลอง

ไม่สามารถ Run ได้ เพราะ MyValue ที่มี set เท่านั้นและไม่มี get
โปรแกรมจะแสดงผล My value = 50
