using System.ComponentModel.Design;
using System.Runtime;

List<SinhVien> danhsachlop = new List<SinhVien>();

int hieulenh = 0;
string MaXoa;
string MaTim;
do 
{
    Console.WriteLine("MENU QUAN LY SINH VIEN");
    Console.WriteLine("Vui long chon chuc nang :");
    Console.WriteLine("1:Them sinh vien");
    Console.WriteLine("2:Hien thi danh sach sinh vien");
    Console.WriteLine("3:Xoa sinh vien");
    Console.WriteLine("4:Tim kiem(Theo mssv)");
    Console.WriteLine("5:Thoat chuong trinh");
    // (Dùng int.TryParse để không bị crash nếu người dùng lỡ tay gõ chữ)
    bool isNumber = int.TryParse(Console.ReadLine(), out hieulenh);
    while(!isNumber||hieulenh<1 || hieulenh> 5) 
    {
        Console.WriteLine("Vui long chon lai hieu lenh:");
        Console.WriteLine("1:Them sinh vien");
        Console.WriteLine("2:Hien thi danh sach sinh vien");
        Console.WriteLine("3:Xoa sinh vien");
        Console.WriteLine("4:Tim kiem(Theo mssv)");
        Console.WriteLine("5:Thoat chuong trinh");
    }
    if (hieulenh == 1) 
    {
        SinhVien svmoi = new SinhVien();
        svmoi.Nhap() ;
        danhsachlop.Add(svmoi);
    }
    else if (hieulenh == 2) 
    {
        foreach(SinhVien sv in danhsachlop) 
        {
            sv.HientThi() ;
        }
    }
    else if (hieulenh == 3) 
    {
        int demxoa = 0;
        Console.Write("Nhap vao mssv cua sinh vien muon xoa :");
        MaXoa = Convert.ToString(Console.ReadLine());
        foreach (SinhVien sv in danhsachlop.ToList())
        {
            if (MaXoa == sv.mssv) 
            {
                danhsachlop.Remove(sv);
                demxoa++;
            }
        }
        if (demxoa == 0) 
        {
            Console.WriteLine("Khong tim thay sinh vien ban muon xoa");
        }
    }
    else if (hieulenh == 4)
    {
        int demtim = 0;
        Console.Write("Nhap vao mssv cua sinh vien ban muon tim :");
        MaTim = Convert.ToString(Console.ReadLine());
        foreach (SinhVien sv in danhsachlop)
        {
            if (MaTim == sv.mssv)
            {
                sv.HientThi();
                demtim++;
            }
        }
        if (demtim == 0) 
        {
            Console.WriteLine("Khong tim thay sinh vien ban muon tim");
        }
    }
    else
    {
        return;
    }
} while (true);  

public class SinhVien 
{
    public string hoten { get; set; }
    public string mssv { get; set; }
    public double dtb {  get; set; }
    
    public SinhVien(string hoten, string mssv,double dtb) 
    {
        this.hoten=hoten;
        this.mssv=mssv;
        this.dtb=dtb;
    }
    public SinhVien() 
    {
    }
    public void Nhap() 
    {
        Console.Write("Nhap vao ho ten:");
        hoten = Convert.ToString(Console.ReadLine());
        Console.Write("Nhap vao mssv:");
        mssv = Convert.ToString(Console.ReadLine());
        Console.Write("Nhap vao dtb:");
        dtb = Convert.ToDouble(Console.ReadLine());
    }
    public void HientThi() 
    {
        Console.WriteLine("Hoten:" + hoten + ",MSSV:" + mssv + ",DiemTrungBinh" + dtb);
    }
}
