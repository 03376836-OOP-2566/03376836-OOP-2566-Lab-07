# Lab 7 Exercise 2

## Properties calculation

1. สร้าง console application project

```cmd
dotnet new console --name Lab07_Ex02
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/78ac99f0-4108-41af-ab02-3cafc4b32986)

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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/6ae401b4-58dd-48dd-bbe1-3e89ab94c8e4)

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab07_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/8190e756-ca8f-4b3e-9850-0ed16afd237c)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/02bc1b6e-b911-4440-b4c7-f732a1249954)

7. อธิบายสิ่งที่พบในการทดลอง

จากการทดลอง มีการใช้คลาส MyClass เพื่อสร้างอ็อบเจกต์ mc และกำหนดค่าให้กับพร็อพเพอร์ตี้ MyValue โดยมีลักษณะดังนี้  สร้างอ็อบเจกต์ mc จากคลาส MyClass. กำหนดค่าให้กับพร็อพเพอร์ตี้ MyValue ของอ็อบเจกต์ mc ด้วยค่า 50 โดยใช้คำสั่ง mc.MyValue = 50; พิมพ์ค่าของพร็อพเพอร์ตี้ MyValue ด้วยคำสั่ง System.Console.WriteLine($"mc.MyValue = {mc.MyValue}"); ซึ่งเป็นการแสดงผลลัพธ์ล่าสุดหลังจากกำหนดค่าใหม่ กำหนดค่าให้กับพร็อพเพอร์ตี้ MyValue ของอ็อบเจกต์ mc ด้วยค่า 150 โดยใช้คำสั่ง mc.MyValue = 150; พิมพ์ค่าของพร็อพเพอร์ตี้ MyValue อีกครั้ง ซึ่งในที่นี้ค่าจะถูกกำหนดให้เท่ากับ 100 เนื่องจากมีการตรวจสอบและปรับค่าให้ไม่เกิน 100 ในตัวเมธอด setter ของ MyValue ดังนั้นผลลัพธ์ที่ได้คือ mc.MyValue = 50
mc.MyValue = 100 ตามภาพด้านบน ในการแสดงผลลัพธ์ของข้อมูล
