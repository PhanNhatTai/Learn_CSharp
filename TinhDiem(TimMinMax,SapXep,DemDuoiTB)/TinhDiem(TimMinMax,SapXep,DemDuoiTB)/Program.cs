Console.Write("Nhap vao so luong diem :");
int n=Convert.ToInt32(Console.ReadLine());
double[] a = new double[n];
for (int i = 0; i < n; i++) 
{
    Console.Write("Nhap vao diem thu "+(i+1)+" :");
    a[i] =Convert.ToDouble(Console.ReadLine());
}
double min = a[0], max = a[0];
int demduoitb = 0;
for (int i = 0;i < n; i++)
{
    if (a[i] > max) 
    {
        max = a[i];
    }
    if (a[i] < min)
    {
        min = a[i];
    }
    if (a[i] < 5) 
    {
        demduoitb++;
    }
}
Console.WriteLine("DIEM CHUA XAP SEP");
for (int i=0;i<n;i++)
{
    Console.WriteLine("Diem thu " + (i + 1) + " la :" + a[i]);
}
double tam = 0;
for (int i = 0; i < n - 1; i++) 
{
    for (int j = i; j < n; j++) 
    {
        if (a[i] < a[j]) 
        {
            tam = a[i];
            a[i] = a[j];
            a[j] = tam;
        }
    }
}
Console.WriteLine("Vay diem lon nhat la :" + max);
Console.WriteLine("Vay diem nho nhat la :" + min);
Console.WriteLine("Vay so luong diem duoi tb la :" + demduoitb);
Console.WriteLine("DIEM DA XAP SEP");
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Diem thu " + (i + 1) + " la :" + a[i]);
}

