using System.Net;

Random r = new Random();
int songaunhien = r.Next(0, 101);
int solan = 0;
int sodoan=0;
do
{
    Console.Write("Nhap vao so ban doan :");
    sodoan = Convert.ToInt32(Console.ReadLine());
    if (sodoan > songaunhien) 
    {
        Console.WriteLine("So ban doan lon hon so dung !,Vui long doan la");
    }
    else if (sodoan < songaunhien)
    {
        Console.WriteLine("So ban doan nho hon so dung !,Vui long doan lai");
    }
    solan++;
} while (sodoan != songaunhien);
Console.WriteLine("Ban da doan dung ! so ngau nhien la :" + songaunhien + " voi so lan doan la:" + solan);