List<NhanVien> dsnv = new List<NhanVien>();
int hieulenh = 0;
string maxoa;
double luongmax = 0;
do
{
    Console.WriteLine("MENU QUAN LY NHAN VIEN");
    Console.WriteLine("Vui long chon chuc nang:");
    Console.WriteLine("1:Them nhan vien");
    Console.WriteLine("2:Hien thi danh sach nhan vien");
    Console.WriteLine("3:Xoa nhan vien");
    Console.WriteLine("4:Tong luong cua tat ca nhan vien");
    Console.WriteLine("5:In nhan vien co luong cao nhat");
    Console.WriteLine("6:Thoat");
    hieulenh =Convert.ToInt32(Console.ReadLine());
    if (hieulenh<1 || hieulenh>6) 
    {
        Console.WriteLine("Vui long chon lai chuc nang dung :");
        Console.WriteLine("1:Them nhan vien");
        Console.WriteLine("2:Hien thi danh sach nhan vien");
        Console.WriteLine("3:Xoa nhan vien");
        Console.WriteLine("4:Tong luong cua tat ca nhan vien");
        Console.WriteLine("5:In nhan vien co luong cao nhat");
        Console.WriteLine("6:Thoat");
        hieulenh = Convert.ToInt32(Console.ReadLine());
    }
    if (hieulenh == 1)
    {
        NhanVien nv = new NhanVien();
        nv.Nhap();
        nv.LuongThucLanh();
        dsnv.Add(nv);
        Console.WriteLine("Them thanh cong");
    }
    else if (hieulenh == 2)
    {
        Console.WriteLine("Danh Sach Nhan Vien");
        foreach (NhanVien nv in dsnv)
        {
            nv.Xuat();
        }
    }
    else if (hieulenh == 3)
    {
        Console.Write("Nhap vao ma nhan vien ban muon xoa :");
        maxoa = Console.ReadLine();
        foreach (NhanVien nv in dsnv.ToList())
        {
            if (maxoa == nv.Manv)
            {
                dsnv.Remove(nv);
            }
        }
    }
    else if (hieulenh == 4)
    {
        double tongluong = 0;
        foreach (NhanVien nv in dsnv) 
        {
            tongluong += nv.Luong;
        }
        Console.WriteLine("Vay so tien ma cong ty phai tra cho tat ca nhan vien la :" + tongluong);
    }
    else if (hieulenh == 5) 
    {
        foreach(NhanVien nv in dsnv) 
        {
            if (luongmax < nv.Luong) 
            {
                luongmax= nv.Luong;
            }
        }
        foreach(NhanVien nv in dsnv) 
        {
            if (luongmax == nv.Luong) 
            {
                Console.WriteLine("Thong Tin Nhan Vien Co Luong Cao Nhat La :");
                nv.Xuat();
            }
        }
    }
    else
    {
        return;
    }
} while(true);

class NhanVien
{
    public string Manv { get; set; }
    public string Hoten { get; set; }
    public double LuongMotNgay { get; set; }
    public int SoNgayCong { get; set; }
    public double Luong {  get; set; }
    public void LuongThucLanh() 
    {
        int NgayDu = 0;
        if (SoNgayCong <= 26)
        {
            Luong = SoNgayCong * LuongMotNgay;      
        }
        else
        {
            NgayDu = SoNgayCong - 26;
            Luong = LuongMotNgay * 26 + LuongMotNgay * NgayDu * 2;
        }
    }
    public void Nhap() 
    {
        Console.Write("Nhap vao manv:");
        Manv = Console.ReadLine();
        Console.Write("Nhap vao ho ten:");
        Hoten = Console.ReadLine();
        Console.Write("Nhap vao luong mot ngay:");
        LuongMotNgay = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap vao so ngay cong:");
        SoNgayCong = Convert.ToInt32(Console.ReadLine());
    }
    public void Xuat() 
    {
        Console.WriteLine("Manv :" + Manv + ",Ho ten :" + Hoten + ",Luong mot ngay :" + LuongMotNgay + ",So ngay cong :" + SoNgayCong+",Luong :"+Luong);
    }
}
