# Lab 7 Exercise 3

## Read-only properties

1. สร้าง console application project

```cmd
dotnet new console --name Lab07_Ex03
```

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

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab07_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 

![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-07/assets/144195611/37d8f882-b721-44ef-b8ed-9132dd0bf44d)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-07/assets/144195611/101d3922-cf2b-47d1-93e8-b43e7ca3f9f2)


## โค้ดมีข้อผิดพลาด 
- แก้ไขความผิดพลาด
```
  MyClass mc = new MyClass();
System.Console.WriteLine($"My value  = {mc.MyValue}");
// mc.MyValue = 50;
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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-07/assets/144195611/1b73172b-e6d5-42cd-9940-3529f0307f82)


![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-07/assets/144195611/5c20dc83-2ae7-4c43-b24d-3695da9b7267)




7. อธิบายสิ่งที่พบในการทดลอง
   -เป็นการใช้งาน properties ชื่อ MyValue เพื่อส่งค่าคงที่ My_PI ที่โปรแกรมเรียกใช้ ที่ผิดพลาดพเกิดจากความผิดพลาด ในการทำงานmc.MyValue = 50; ไม่มีsetให้กำหนกค่าใหม่
