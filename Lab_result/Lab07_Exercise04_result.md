## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-07/assets/144196505/b7aab8fb-70c5-4010-af76-15b3896632c4)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-07/assets/144196505/c30dbea4-4b66-435e-b381-5bc5c14d07a5)

## อธิบายสิ่งที่พบในการทดลอง
### บรรทัด System.Console.WriteLine($"My value  = {mc.MyValue}"); ไม่สามารถทำได้เนื่องจากเป็น Write-only properties 

## หลังแก้ไขโค้ด 
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
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-07/assets/144196505/6a0df58a-0310-4265-9cf1-506249c2f0c7)
### เนื่องจากไม่มี get ทำให้โปรแกรมไม่สามารถอ่านค่าได้
