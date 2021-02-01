using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<int, string> kitaplar = new MyDict<int, string>();
            kitaplar.Add(1, "Roman");
            kitaplar.Add(2, "Bilim-Kurgu");
            kitaplar.Add(3, "Şiir");
            kitaplar.Add(4, "Anı");
            kitaplar.Add(5, "Öykü");


}
