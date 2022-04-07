
using Inheritance;

LuasPersegiPanjang luas = new();
Keliling keliling= new();

luas.Nilai(4, 5);
keliling.Nilai(4, 5);

Console.WriteLine("Luas = " + luas.area());
Console.WriteLine("Keliling = " + keliling.Area());

Console.ReadKey();
