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
<img width="960" alt="7 4 1" src="https://github.com/NathaphonTan/03376836-OOP-2566-Lab-07/assets/144870609/2e58d7cd-2fa9-4785-90bf-a22887209b52">

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="960" alt="7 4 2" src="https://github.com/NathaphonTan/03376836-OOP-2566-Lab-07/assets/144870609/5ef1018f-6c50-4984-949a-70530f98414d">

7. อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล My value = 50
