## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-07/assets/144196505/b3f05ecb-e1ac-41ca-a0e3-f48b944c9890)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-07/assets/144196505/fa9395c2-efe5-47c0-a6f7-d4a0ee33c958)

## อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมนี้เป็นการจำกัดค่าของ property MyValue ให้อยู่ระหว่าง 0 ถึง 100 โดยอาศัยประโยชน์การคำนวณของ get/set
```
public int MyValue
    {
        set
        {   
            if(value > 100)                // กำหนดค่า set ของ value 
                StoredPercentValue = 100;  //ถ้าเกิน 100 ขึ้นไป จะมีค่า = 100
                else
                StoredPercentValue = value; // ถ้าไม่เกิน 100 เช่น 50 ก็จะมีค่า 50 ไม่แปลงเปลี่ยนใดๆ
        }
        get                // ใช้ get ดึงค่าข้อมูลจาก set
        {
            return StoredPercentValue; // return ค่าที่ได้จากการตรวจสอบเงื่อนไขใน set
        }
    }
```
