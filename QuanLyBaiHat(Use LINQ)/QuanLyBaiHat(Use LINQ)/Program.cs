using System.Collections.Generic;
using System.Formats.Tar;
using System.IO;
using System.Linq;
using System.Text.Json;
string tenfile = "baihat.json";
List<BaiHat> dsbh = DocDuLieu(tenfile);
Console.WriteLine("Da tai len " + dsbh.Count + " bai hat");
int hieulenh = 0;
string maxoa;
string masua;
int thongtinsua;
string tentim;
do
{
    Console.WriteLine("MENU QUAN LY BAI HAT");
    Console.WriteLine("Chon chuc nang ban muon thuc hien :");
    Console.WriteLine("1:Them bai hat");
    Console.WriteLine("2:Xoa bai hat");
    Console.WriteLine("3:Sua bai hat");
    Console.WriteLine("4:Hien thi bai hat");
    Console.WriteLine("5:Sap xep bai hat");
    Console.WriteLine("6:Tim kiem bai hat theo ten");
    Console.WriteLine("7:Thoat");
    hieulenh = Convert.ToInt32(Console.ReadLine());
    while (hieulenh < 1 || hieulenh > 7)
    {
        Console.WriteLine("Vui long cho lai chuc nang :");
        Console.WriteLine("1:Them bai hat");
        Console.WriteLine("2:Xoa bai hat");
        Console.WriteLine("3:Sua bai hat");
        Console.WriteLine("4:Hien thi bai hat");
        Console.WriteLine("5:Sap xep bai hat giam dan theo ma");
        Console.WriteLine("6:Tim kiem bai hat");
        Console.WriteLine("7:Thoat");
        hieulenh = Convert.ToInt32(Console.ReadLine());
    }
    if (hieulenh == 1)
    {
        BaiHat bh = new BaiHat();
        bh.Nhap();
        dsbh.Add(bh);
        Console.WriteLine("Them thanh cong");
    }
    else if (hieulenh == 2)
    {
        Console.Write("Nhap vao ma bai hat ban muon xoa :");
        maxoa = Console.ReadLine();
        foreach (BaiHat bh in dsbh.ToList())
        {
            if (maxoa == bh.MaBaiHat)
            {
                dsbh.Remove(bh);
            }
        }
    }
    else if (hieulenh == 3)
    {
        int tiep = 1;
        Console.Write("Nhap vao ma bai hat ban muon sua :");
        masua = Console.ReadLine();
        foreach (BaiHat bh in dsbh)
        {
            while (masua == bh.MaBaiHat && tiep == 1)
            {
                Console.WriteLine("Ban muon sua thong tin gi :");
                Console.WriteLine("1:Ma Bai Hat");
                Console.WriteLine("2:Ten Bai Hat");
                Console.WriteLine("3:Ten Ca Si");
                Console.WriteLine("4:Nam Sang Tac");
                Console.WriteLine("5:The Loai");
                thongtinsua = Convert.ToInt32(Console.ReadLine());
                while (thongtinsua < 1 || thongtinsua > 5)
                {
                    Console.WriteLine("Vui long nhap lai ban muon sua thong tin gi :");
                    Console.WriteLine("1:Ma Bai Hat");
                    Console.WriteLine("2:Ten Bai Hat");
                    Console.WriteLine("3:Ten Ca Si");
                    Console.WriteLine("4:Nam Sang Tac");
                    Console.WriteLine("5:The Loai");
                    thongtinsua = Convert.ToInt32(Console.ReadLine());
                }
                if (thongtinsua == 1)
                {
                    Console.Write("Nhap vao ma bai hat moi :");
                    string mamoi = Console.ReadLine();
                    bh.MaBaiHat = mamoi;
                }
                if (thongtinsua == 2)
                {
                    Console.Write("Nhap vao ten bai hat moi :");
                    string tenbhmoi = Console.ReadLine();
                    bh.TenBaiHat = tenbhmoi;
                }
                if (thongtinsua == 3)
                {
                    Console.Write("Nhap vao ten ca si moi :");
                    string tencsmoi = Console.ReadLine();
                    bh.TenCaSi = tencsmoi;
                }
                if (thongtinsua == 4)
                {
                    Console.Write("Nhap vao nam sang tac moi :");
                    int namstmoi = Convert.ToInt32(Console.ReadLine());
                    bh.NamSangTac = namstmoi;
                }
                if (thongtinsua == 5)
                {
                    Console.Write("Nhap vao the loai moi :");
                    string tlmoi = Console.ReadLine();
                    bh.TheLoai = tlmoi;
                }
                Console.Write("Ban co muon su bai hat nay tiep khong(0:khong) :");
                tiep = Convert.ToInt32(Console.ReadLine());
                if (tiep == 0)
                {
                    break;
                }
            }
        }
    }
    else if (hieulenh == 4)
    {
        Console.WriteLine("DANH SACH BAI HAT :");
        foreach (BaiHat bh in dsbh)
        {
            bh.Xuat();
        }
    }
    else if (hieulenh == 5)
    {
        var sxgtheoma = dsbh.OrderByDescending(bh => bh.MaBaiHat).ToList();
        Console.WriteLine("DANH SACH BAI HAT SAP XEP GIAM DAN THEO MA BAI HAT");
        foreach (BaiHat bh in sxgtheoma)
        {
            bh.Xuat();
        }
    }
    else if (hieulenh == 6)
    {
        Console.Write("Nhap vao ten bai hat can tim :");
        tentim = Console.ReadLine();
        var dsten = dsbh.Where(bh => bh.TenBaiHat.ToLower().Contains(tentim.ToLower())).ToList();
        Console.WriteLine("Danh sach ten cac bai hat ban can tim :");
        foreach (BaiHat bh in dsten)
        {
            bh.Xuat();
        }
    }
    else
    {
        LuuDuLieu(dsbh, tenfile);
        Console.WriteLine("Luu thanh cong,Tam biet ban");
        return;
    }
} while (true);
void LuuDuLieu(List<BaiHat> danhSach, string tenFile)
{
    try
    {
        // 1. Cấu hình để nó viết tiếng Việt và xuống dòng đẹp đẽ
        var options = new JsonSerializerOptions { WriteIndented = true };

        // 2. Chuyển List thành chuỗi JSON (Serialize)
        string jsonString = JsonSerializer.Serialize(danhSach, options);

        // 3. Ghi chuỗi đó xuống ổ cứng
        File.WriteAllText(tenFile, jsonString);

        Console.WriteLine("-> Da luu du lieu thanh cong vao file: " + tenFile);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Loi khi luu file: " + ex.Message);
    }
}
List<BaiHat> DocDuLieu(string tenFile)
{
    // Kiểm tra xem file có tồn tại không
    if (!File.Exists(tenFile))
    {
        return new List<BaiHat>(); // Trả về list rỗng nếu chưa có file
    }

    try
    {
        // 1. Đọc toàn bộ text trong file
        string jsonString = File.ReadAllText(tenFile);

        // 2. Chuyển ngược từ chuỗi JSON thành List<Sach> (Deserialize)
        if (string.IsNullOrEmpty(jsonString)) return new List<BaiHat>();

        return JsonSerializer.Deserialize<List<BaiHat>>(jsonString);
    }
    catch
    {
        return new List<BaiHat>(); // Nếu file lỗi thì trả về list rỗng
    }
}

class BaiHat
{
    public string MaBaiHat { get; set; }
    public string TenBaiHat { get; set; }
    public string TenCaSi { get; set; }
    public int NamSangTac { get; set; }
    public string TheLoai { get; set; }

    public void Nhap()
    {
        Console.Write("Nhap vao ma bai hat :");
        MaBaiHat = Console.ReadLine();
        Console.Write("Nhap vao ten bai hat :");
        TenBaiHat = Console.ReadLine();
        Console.Write("Nhap vao ten ca si :");
        TenCaSi = Console.ReadLine();
        Console.Write("Nhap vao nam sang tac :");
        NamSangTac = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap vao the loai :");
        TheLoai = Console.ReadLine();
    }
    public void Xuat()
    {
        Console.WriteLine("[" + MaBaiHat + "] " + TenBaiHat + ",Ca si:" + TenCaSi + ",Nam Sang Tac :" + NamSangTac + ",The Loai :" + TheLoai);
    }
}
