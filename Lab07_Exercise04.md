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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-07/assets/144195611/53755b77-e7fc-4f88-b873-73d8061bc332)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-07/assets/144195611/1b4eb618-695b-4769-8e42-54d40f8f2129)

## โค้ดมีข้อผิดพลาด แก้ไข
```
MyClass mc = new MyClass();
mc.MyValue = 50;
//System.Console.WriteLine($"My value  = {mc.MyValue}");

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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-07/assets/144195611/4dab3ed9-471d-4a38-9e0d-ec8207ec7313)
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-07/assets/144195611/f39de9f1-23dc-488a-87e0-2264a76a1d77)

7. อธิบายสิ่งที่พบในการทดลอง
 - เมื่อแก้ไขโค้ดและจะไม่มีการแสดงค่าของมาเนื่องจากไม่มีคำสั่งใช้ get ที่แสดงค่าออกมา WriteLine แต่โปรแกรมนี้มีการทำงาน กำหนดค่าให้กับคุณสมบัติโดยใช้set ซึ่งในการกำหนดค่าให้กับตัวแปร  StoredValue โดยไม่มี get เพื่ออ่านได้ ซึ่งเป็นปกติถ้าเราอยากจะกำหนดค่าตัวแปรที่สามารถกำหนดค่าได้แต่ไม่ได้อ่านค่าภายนอก
