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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-07/assets/144195708/51161fe3-1661-448f-a6b1-ea204ee7a1d7)

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-07/assets/144195708/472926bd-9062-4e19-9302-0422336dc15c)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-07/assets/144195708/e47a6bc6-0756-4376-9f54-aa81fd306b65)

7. อธิบายสิ่งที่พบในการทดลอง
โปรแกรม Build และ Run ไม่ได้ เพราะ MyValue ในคลาส MyClass ไม่มี get สำหรับ property
