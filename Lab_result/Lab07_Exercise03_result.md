## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-07/assets/144196505/3b7fbbb9-5103-470b-974f-ddfab46e05a5)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-07/assets/144196505/00d68cb0-cce1-4878-baa3-ce8e9be5665d)

## อธิบายสิ่งที่พบในการทดลอง
### บรรทัด mc.MyValue = 50; ไม่สามารถทำได้เนื่องจากเป็น readonly ไม่สามารถกำหนดค่าได้

## หลังแก้ไขโคด
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
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-07/assets/144196505/bf53ff1a-4b1a-498b-9bb8-5d5c8d6864d4)
