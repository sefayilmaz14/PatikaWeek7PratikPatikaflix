using PatikaWeek7PratikPatikaflix;

// Dizilerin tutulacağı liste tanımlaması

List<Patikaflix> patikaflixes = new List<Patikaflix>();

bool exit  = false;// Dizi ekleme işlemleri için döngü çıkış değişkeni

do
{
   Patikaflix newMovie = new Patikaflix();// Yeni nesne üretimi
    
    // Kullanıcıdan alınan verilerle propetry tanımlamaları
    Console.Write("Dizi Adını Giriniz:");
    newMovie.Title = Console.ReadLine();
    Console.Write("Yapım Yılını Giriniz:");
    newMovie.Date = Convert.ToInt32(Console.ReadLine());
    Console.Write("Dizi Türü Giriniz:");
    newMovie.Type = Console.ReadLine();
    Console.Write("Yayınlanma Yılını Giriniz:");
    newMovie.DatePublication = Convert.ToInt32(Console.ReadLine());
    Console.Write("Yönetmen Bilgisini Giriniz:");
    newMovie.Director = Console.ReadLine();
    Console.Write("Platform Bilgisi Giriniz:");
    newMovie.Platform = Console.ReadLine();
    
    // Oluşturulan nesnenin listeye eklenmesi
    patikaflixes.Add(newMovie);

    Console.WriteLine("Tekrar Bir Dizi Girişi Yapmak İstermisiniz ? e/h");
    string choice = Console.ReadLine();
    if (choice == "h")
        exit = true;
} while (!exit);

//Komedi filmleri için liste tanımlaması
List<Comedy> comedyList =patikaflixes 
    .Where(x => x.Type == "Komedi") // Yeni listenin eski listeden alacağı verilerin koşulu
    .Select(x => new Comedy(x.Title , x.Type , x.Director)) // Listeye hangi verilerin alınacağının belirlenmesi
    .ToList();
 
comedyList.OrderBy(x => x.Title) // Listenin sıralamasının yapılması ilk olarak isme göre daha sonra yönetmen isimlerine göre
    .ThenBy(x => x.Director);

Console.WriteLine("----------------Komedi Filmleri ------------------------");

foreach (Comedy c in comedyList)
{
    Console.WriteLine(c);
}