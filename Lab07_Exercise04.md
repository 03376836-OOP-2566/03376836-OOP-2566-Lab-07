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


ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/d976b2a1-a6bb-4bed-b9cd-28f147d50eef)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/e1d6269b-5ea3-4b17-9689-29bccc38e4c8)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/9c63216c-72f6-44e8-8eb5-2a1f2578bd4e)

7. อธิบายสิ่งที่พบในการทดลอง


จากการทดลอง เรามีคลาส MyClass ซึ่งมีเมธอด MyValue ที่เป็น setter ซึ่งกำหนดค่าที่รับเข้ามาให้กับฟิลด์ StoredValue แต่ไม่มี getter ที่ช่วยในการเข้าถึงค่า StoredValue ดังนั้นไม่สามารถเรียกใช้ค่าของ MyValue ได้หลังจากกำหนดค่า ดังนั้นจะไม่มีการแสดงผลของค่า MyValue ที่ถูกกำหนดไว้ในขั้นตอนที่ต้องการแสดงผลลัพธ์ ดังนั้นผลลัพธ์ที่ได้จะไม่แสดงค่าของ MyValue ที่ถูกกำหนดไว้ในขั้นตอนก่อนหน้านี้ เมื่อทำการแก้ไขโค้ดของโปรแกรม การทดลองนี้ เราสร้างคลาสชื่อ MyClass ซึ่งมีคุณสมบัติ MyValue ที่เป็นตัวแปรชนิด int ซึ่งเราสามารถกำหนดค่าได้โดยใช้เมทอด setter ซึ่งกำหนดค่าให้กับฟิลด์ StoredValue ภายในคลาส MyClass และสามารถเข้าถึงค่านั้นได้ผ่านเมทอด getter ที่คืนค่าของ StoredValue ออกมา ในการทดลอง เราสร้างอ็อบเจกต์จากคลาส MyClass และกำหนดค่าให้กับ MyValue ด้วยค่า 50 และแสดงผลลัพธ์ของ MyValue ที่ได้หลังจากการกำหนดค่านั้นด้วยคำสั่ง Console.WriteLine ที่ใช้แสดงค่าของ MyValue ออกมาทางหน้าจอ โดยแสดงผลดังภาพ ด้านบน
