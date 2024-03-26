# Lab 7 Exercise 2

## Properties calculation

1. สร้าง console application project

```cmd
dotnet new console --name Lab07_Ex02
```

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
MyClass mc = new MyClass();
mc.MyValue = 50;
System.Console.WriteLine($"mc.MyValue = {mc.MyValue}");
mc.MyValue = 150;
System.Console.WriteLine($"mc.MyValue = {mc.MyValue}");

class MyClass
{
    private int StoredPercentValue;
    public int MyValue
    {
        set
        {   
            if(value > 100)
                StoredPercentValue = 100;
                else
                StoredPercentValue = value;
        }
        get
        {
            return StoredPercentValue;
        }
    }
}
```

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab07_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-07/assets/144195611/a1fa2d37-ac26-47cc-872c-2c9ca17e45c8)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5 

![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-07/assets/144195611/9fe7ab93-fcfa-4d6c-b23b-ed204acb4d3c)

7. อธิบายสิ่งที่พบในการทดลอง
   - เป็นการใช้งาน properties ชื่อMyValue เพื่อเข้าถึงและกำหนดค่าให้กับตัวแปร storePercentValue โดยมีการตรวจสอบค่าให้ไม่เกิน 100ทคือset
