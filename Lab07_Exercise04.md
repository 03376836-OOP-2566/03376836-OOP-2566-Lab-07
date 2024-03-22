# Lab 7 Exercise 4

## Write-only properties

1. สร้าง console application project

```cmd
dotnet new console --name Lab07_Ex04
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/7ae7398d-4a29-4c2c-b77d-703bc2f907d0)

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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/83c9e466-d672-47c1-b6c9-c05ab9b01623)

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab07_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/26002462-88aa-41b0-abd8-5773afd612c6)
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/90527a75-c9ce-4a9e-aef6-9b2555a5d945)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/c12783e9-6280-4b5e-a920-b12329e858e4)

7. อธิบายสิ่งที่พบในการทดลอง
