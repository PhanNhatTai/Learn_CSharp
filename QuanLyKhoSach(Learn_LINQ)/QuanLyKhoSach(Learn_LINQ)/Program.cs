using System.Linq;
using System.Collections.Generic;
List <Sach> dss = new List <Sach> ();
int hieulenh = 0;
string maxoa;
string loctl;
string tentk;
do
{
    Console.WriteLine("MENU QUAN LY SACH");
    Console.WriteLine("Vui long chon chuc nang :");
    Console.WriteLine("1:Them sach");
    Console.WriteLine("2:Hien thi danh sach sach");
    Console.WriteLine("3:Xoa sach theo ma sach");
    Console.WriteLine("4:In sach co gia thap nhat");
    Console.WriteLine("5:Loc theo the loai");
    Console.WriteLine("6:Sap xep theo gia (giam dan)");
    Console.WriteLine("7:Tim kiem theo ten");
    Console.WriteLine("8:Thong ke");
    Console.WriteLine("9:Thoat");
    hieulenh=Convert.ToInt32 (Console.ReadLine());
    while (hieulenh <1 || hieulenh > 9) 
    {
        Console.WriteLine("Vui long chon lai chuc nang :");
        Console.WriteLine("1:Them sach");
        Console.WriteLine("2:Hien thi danh sach sach");
        Console.WriteLine("3:Xoa sach theo ma sach");
        Console.WriteLine("4:In sach co gia thap nhat");
        Console.WriteLine("5:Loc theo the loai");
        Console.WriteLine("6:Sap xep theo gia (giam dan)");
        Console.WriteLine("7:Tim kiem theo ten");
        Console.WriteLine("8:Thong ke");
        Console.WriteLine("9:Thoat");
        hieulenh = Convert.ToInt32(Console.ReadLine());
    }
    if (hieulenh == 1) 
    {
        Sach s = new Sach();
        s.Nhap();
        dss.Add(s);
        Console.WriteLine("Them thanh cong");
    }
    else if (hieulenh == 2) 
    {
        Console.WriteLine("Danh sach quan ly sach");
        foreach(Sach s in dss) 
        {
            s.Xuat();
        }
    }
    else if (hieulenh == 3) 
    {
        int demxoa = 0;
        Console.WriteLine("Nhap vao ma sach ban muon xoa :");
        maxoa=Console.ReadLine();
        foreach(Sach s in dss.ToList() )
        {
            if (maxoa == s.MaSach) 
            {
                dss.Remove(s);
                demxoa++;
                Console.WriteLine("Xoa thanh cong");
            }
        }
        if (demxoa == 0) 
        {
            Console.WriteLine("Khong tim thay doi tuong ban muon xoa");
        }
    }
    else if (hieulenh == 4) 
    {
        var smin = dss.OrderBy(s => s.Gia).FirstOrDefault();
        Console.WriteLine("THONG TIN CUA SACH CO GIA THAP NHAT LA :");
        if (smin != null)
        {
            smin.Xuat();
        }
    }
    else if (hieulenh == 5) 
    {
        Console.Write("Nhap vao the loai ban muon loc :");
        loctl = Console.ReadLine();
        var dstl=dss.Where(s=>s.TheLoai==loctl).ToList();
        Console.WriteLine("Dach sach cac sach thuoc the loai "+loctl);
        foreach(Sach s in dstl) 
        {
            s.Xuat();
        }
    }
    else if (hieulenh == 6) 
    {
        var dsgiam = dss.OrderByDescending(s => s.Gia);
        Console.WriteLine("Danh sach xep sap giam dan");
        foreach(Sach s in dsgiam) 
        {
            s.Xuat();
        }
    }
    else if (hieulenh == 7) 
    {
        Console.Write("Nhap vao ten ban muon tim kiem :");
        tentk = Console.ReadLine();
        var sachct=dss.Where(s=>s.TenSach.ToLower().Contains(tentk.ToLower())).ToList();
        Console.WriteLine("Cac sach can tim la :");
        foreach (Sach s in sachct) 
        {
            s.Xuat();
        }
    }
    else if (hieulenh == 8) 
    {
        double tonggia = 0;
        tonggia = dss.Sum(s => s.Gia);
        Console.WriteLine("Vay tong gia cua cac loai sach la :"+tonggia);
    }
    else
    {
        return;
    }
} while (true);

class Sach 
{
    public string MaSach {  get; set; }
    public string TenSach { get; set; }
    public double Gia {  get; set; }
    public string TheLoai {  get; set; }
    
    public void Nhap() 
    {
        Console.Write("Nhap vao ma sach :");
        MaSach = Console.ReadLine();
        Console.Write("Nhap vao ten sach :");
        TenSach = Console.ReadLine();
        Console.Write("Nhap vao gia :");
        Gia = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap vao the loai :");
        TheLoai = Console.ReadLine();
    }
    public void Xuat() 
    {
        Console.WriteLine("[" + MaSach + "] " + TenSach + " :" + Gia + ",The Loai:" + TheLoai);
    }
}
