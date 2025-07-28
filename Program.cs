Console.WriteLine("KDV HESAPLAMA");

Console.Write("Ürün giriniz: ");
string product = Console.ReadLine();

string urun = "Çamaşır Makinesi";

if (urun == product)
{ 
    Console.WriteLine("KDV'siz: 15000TL");
    Console.WriteLine("KDV'si : "+ 15000 * 0.20 + "TL");
    Console.WriteLine("Toplam: 18000TL");
}
if (urun != product)
{
    Console.WriteLine("ürün bulunmamaktadır.");
}