# Lab 7 Exercise 3

## Read-only properties

1. สร้าง console application project

```cmd
dotnet new console --name Lab07_Ex03
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/2f8d07f8-bdd4-4f91-adb0-e92a34beb8b7)

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
MyClass mc = new MyClass();
System.Console.WriteLine($"My value  = {mc.MyValue}");

mc.MyValue = 50;
System.Console.WriteLine($"My value  = {mc.MyValue}");

class MyClass
{
    private const double My_PI =  Math.PI;
    public double MyValue
    {
        get
        {
            return My_PI;
        }
    }
}
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/0e9992b3-ad36-470f-8c8e-d82c71df2684)

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab07_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/23c704bf-c6f9-4c11-8d9b-f99097283539)
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/9eaee600-7449-424b-93ce-86c9ee9ff417)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-07/assets/144197034/8a3a5146-6dfe-4b72-99fc-e65addf2168a)

7. อธิบายสิ่งที่พบในการทดลอง

การทดลองนี้เราสร้างคลาส MyClass ซึ่งมีคุณสมบัติ MyValue เพื่อเก็บค่า π (พาย) ที่เป็นค่าคงที่ ซึ่งมีการกำหนดค่าให้ MyValue เท่ากับค่า π (พาย) และไม่อนุญาตให้เปลี่ยนแปลงค่าที่เก็บไว้ใน MyValue จากค่าคงที่ π (พาย) แม้ว่าจะมีการกำหนดค่าใหม่ก็ตาม ดังนั้นค่าที่ได้จากการเรียกใช้ MyValue จะเป็นค่า π (พาย) ที่เป็นค่าคงที่ทั้งหมด โดยเราจะเห็นว่า มีคลาส MyClass ที่มีเมทอด MyValue เป็น getter ซึ่งคืนค่าคงที่ My_PI (ค่า π) โดยเมื่อเรียกใช้ MyValue จะได้ผลลัพธ์เป็นค่า π (พาย) ตลอดเวลา และไม่สามารถกำหนดค่าใหม่ให้กับ MyValue ได้ ดังนั้นผลลัพธ์ที่ได้จากการเรียกใช้ MyValue ในทั้งสองรอบคือค่า π (พาย) อย่างถาวร

เมื่อมีการสร้าง  π เราจะเห็นว่าโค้ดนี้ น่ามีบางอย่างที่ผิดพลาดที่ไม่สามารถแสดงผลของค่า π ในคำสั้งได้ แต่โดยสรุปถ้าทำการแสดงผลออกมาจะออกมาเป็นค่า π เนื่องจากทำการแก้ไขโค้ดแล้วแต่ดูเหมือนว่าไม่สามารถ Run ได้เลย จึงขออธิบายเพื่อความเข้าใจ 







