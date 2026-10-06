using System;
using numbers;

Numbers object1 = new Numbers(15);

object1.Add(60);
object1.Add(20);
object1.Add(30);
object1.Add(40);
object1.Add(50);

Console.WriteLine("Max değer: " + object1.FindMax());
Console.WriteLine("Min değer: " + object1.FindMin());
Console.WriteLine("0. Indexteki değer: " + object1.GetValue(0));

// 1. Ödev: Verilen sayının indexini bulan method testi
int arananSayi = 30;
Console.WriteLine($"{arananSayi} sayısının indexi: " + object1.FindIndex(arananSayi));

// 2. Ödev: Remove methodu testi ve 0'dan aşağı düşmemesini sağlama
Console.WriteLine("\nRemove() metodu çağrılıyor (Son elemanı silecek)...");
object1.Remove(); 
Console.WriteLine("Şu anki eleman sayısı (Counter): " + object1._counter);

Console.WriteLine("\nDizideki tüm elemanları ve fazlasını silmeye çalışıyoruz...");
object1.Remove(); // 40 silindi
object1.Remove(); // 30 silindi
object1.Remove(); // 20 silindi
object1.Remove(); // 60 silindi
Console.WriteLine("Şu anki eleman sayısı (Counter): " + object1._counter);

Console.WriteLine("\nBir kez daha Remove() çağrılıyor (0'ın altına düşmemesi gerekiyor)...");
object1.Remove(); // Hata fırlatmak yerine uyarı vermeli ve counter'ı 0'da bırakmalı
Console.WriteLine("Test sonu eleman sayısı (Counter): " + object1._counter);