int namhientai = 2025;
Console.Write("Nhap vao ten :");
string ten = Console.ReadLine();
Console.Write("Nhap vao nam sinh :");
int namsinh = Convert.ToInt32(Console.ReadLine());
int tuoi = namhientai - namsinh;
Console.Write("Nhap vao diem 1 :");
double diem1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Nhap vao diem 2 :");
double diem2 = Convert.ToDouble(Console.ReadLine());
double dtb = (diem1 + diem2) / 2;
string xeploai;
Console.WriteLine("Xin Chao " + ten);
Console.WriteLine("Hien tai ban " + tuoi + " tuoi");
Console.WriteLine("Diem Trung binh cua ban la :" + dtb);
int dodaiten = ten.Length;
if (dodaiten > 20)
{
    Console.WriteLine("Ten cua ban qua dai !");
}
else
{
    Console.WriteLine("Ten cua ban khong qua dai !");
}
if (dtb < 5)
{
    xeploai = "yeu";
}
else if (dtb >= 5 && dtb <= 8)
{
    xeploai = "kha";
}
else
{
    xeploai = "gioi";
}
Console.WriteLine("Vay xep loai cua ban la :" + xeploai);