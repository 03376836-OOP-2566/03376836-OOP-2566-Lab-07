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
#### แก้ไขแล้ว
<img width="793" alt="Screenshot 2024-03-28 205404" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-07/assets/144196049/a29c2924-330f-4b3e-8614-fa3ed70be45b">

#### ไม่สามารถ Build ได้ เพราะ MyValue ที่มี set เท่านั้นและไม่มี get
5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
#### แก้ไขแล้ว
<img width="795" alt="Screenshot 2024-03-28 205502" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-07/assets/144196049/11317672-9db4-4647-ba18-766a8b049a21">

#### ไม่สามารถ Run ได้ เพราะ MyValue ที่มี set เท่านั้นและไม่มี get
7. อธิบายสิ่งที่พบในการทดลอง
#### โปรแกรมจะแสดงผล My value = 50
