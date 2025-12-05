Console.Write("Nhap vao so luong mon hoc :");
int n = Convert.ToInt32(Console.ReadLine());
double[] a = new double[n];
for (int i = 0; i < n; i++) 
{
    Console.Write("Nhap vao phan tu thu " + (i + 1) + " trong mang :");
    a[i] = Convert.ToDouble(Console.ReadLine());
}
double dtb=0;
for (int i = 0; i < n; i++) 
{
    dtb =dtb+a[i]/n;
}
string xeploai;
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
for (int i = 0; i < n; i++) 
{
    Console.WriteLine("Diem thu " + (i + 1) + " ma ban da nhap vao la :" + a[i]);
}
Console.WriteLine("Vay trung binh diem cua ban la :" + dtb);
Console.WriteLine("Vay xep loai cua ban la :" + xeploai);

