List<string> Menu = new List<string>();
int hieulenh = 0;
string tenmonthem;
string tenmonxoa;
do
{
    Console.WriteLine("Chao mung ban den voi menu quan ly mon an vui long chon chuc nang :");
    Console.WriteLine("1:Them mon an");
    Console.WriteLine("2:Hien thi danh sach mon an");
    Console.WriteLine("3:Xoa mon an");
    Console.WriteLine("4:Thoat");
    hieulenh = Convert.ToInt32(Console.ReadLine());
    while (hieulenh<1 || hieulenh > 4) 
    {
        Console.WriteLine("Vui long nhap lai chuc nang ban muon lam");
        Console.WriteLine("1:Them mon an");
        Console.WriteLine("2:Hien thi danh sach mon an");
        Console.WriteLine("3:Xoa mon an");
        Console.WriteLine("4:Thoat");
        hieulenh = Convert.ToInt32(Console.ReadLine());
    }
    if (hieulenh == 1) 
    {
        Console.Write("Nhap vao ten mon an ban muon them :");
        tenmonthem=Convert.ToString(Console.ReadLine());
        Menu.Add(tenmonthem);
    }
    else if (hieulenh == 2) 
    {
        Console.WriteLine("CAC MON DA DUOC THEM VAO MENU LA :");
        foreach(string item in Menu) 
        {
            Console.WriteLine($"{item}");
        }
    }
    else if (hieulenh == 3) 
    {
        Console.Write("Nhap vao mon ban muon xoa khoi menu :");
        tenmonxoa = Console.ReadLine();
        Menu.Remove(tenmonxoa);
    }
    else
    {
        return;
    }
} while (true);