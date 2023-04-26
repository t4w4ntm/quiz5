using System;

class MainClass {
  public static void Main (string[] args) {

    Console.Write("กรอกจำนวนช่องที่ต้องการ: ");
    int n = int.Parse(Console.ReadLine());
    
    string str = new String('_', n);
    Console.WriteLine("เริ่มต้น: " + str);
    
    
    Console.Write("กรอกตำแหน่งที่ต้องการเปลี่ยน: ");
    int index = int.Parse(Console.ReadLine()) - 1;
    
   
    str = str.Remove(index, 1).Insert(index, "X");
    Console.WriteLine("เปลี่ยน: " + str);
    
    
    while (true) {
      Console.Write("กรอกตำแหน่งที่ต้องการเปลี่ยน (หากต้องการจบการทำงานให้พิมพ์ค่าน้อยกว่า 1): ");
      index = int.Parse(Console.ReadLine()) - 1;
      
      if (index < 0) {
        Console.WriteLine("จบการทำงาน");
        break;
      }
      
      str = str.Remove(index, 1).Insert(index, "X");
      Console.WriteLine("หลังการเปลี่ยน: " + str);
    }
  }
}
