## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-07/assets/144197367/f6c7dbea-3d59-45d5-9b2d-12e6ff9bab31)


- ไม่สามารถ Build ได้ เพราะ  MyValue มีเฉพาะ getter (การอ่านค่า) และไม่มี setter (การกำหนดค่า) ซึ่งทำให้ไม่สามารถกำหนดค่าให้ MyValue ได้

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-07/assets/144197367/e04b4a39-7c76-4bb7-8aed-bf7a45082168)


- ไม่สามารถ Run ได้ เพราะ MyValue มีเฉพาะ getter (การอ่านค่า) และไม่มี setter (การกำหนดค่า) ซึ่งทำให้ไม่สามารถกำหนดค่าให้ MyValue ได้

## อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล

- My value  = 3.141592653589793
- Stack overflow
- Repeat 24107 times

# หลังแก้ไขโปรแกรม

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-07/assets/144197367/01ed31bd-8067-4e64-aa4c-eaccbaf142ad)
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-07/assets/144197367/240a4e57-f0f1-459d-9920-df10f87454ad)



เพิ่ม ตัวแปร เป็น myValue ให้ myValue = math.PI และกำหนดให้ myValue get กับ set
