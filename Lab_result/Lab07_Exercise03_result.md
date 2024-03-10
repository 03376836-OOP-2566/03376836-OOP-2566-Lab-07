## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![pic](/Pictures/pic-5.png)

- ไม่สามารถ Build ได้ เพราะ  MyValue มีเฉพาะ getter (การอ่านค่า) และไม่มี setter (การกำหนดค่า) ซึ่งทำให้ไม่สามารถกำหนดค่าให้ MyValue ได้

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![pic](/Pictures/pic-6.png)

- ไม่สารถ Run ได้ เพราะ MyValue มีเฉพาะ getter (การอ่านค่า) และไม่มี setter (การกำหนดค่า) ซึ่งทำให้ไม่สามารถกำหนดค่าให้ MyValue ได้

## อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล

- My value  = 3.141592653589793
- My value  = 50

# หลังแก้ไขโปรแกรม

![pic](/Pictures/pic-9.png)

![pic](/Pictures/pic-7.png)

![pic](/Pictures/pic-8.png)

เพิ่ม ตัวแปร เป็น myValue ให้ myValue = math.PI และกำหนดให้ myValue get กับ set