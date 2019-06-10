# CarParkProject_LinkedListQueueStack
*Bu uygulama Data Structures (Veri Yapıları) dersi için linked list (bağlı liste), queue (kuyruk) ve stack data structers (yığın veri yapıları) kulanılarak geliştirilmiştir.*

### AÇIKLAMA
#### Gerçekleştirilen Platform
Microsoft Visual Studio Community 2017 - Version 15.6.2 - C#
#### Projenin Tanımı
3 katlı bir otoparkın her katına eklenen 15’er tane arabanın, sadece zemin kattan birer birer çıkmasına izin veren otopark projesi.
#### Veri Yapısı Kataloğu
#### Kullanılan Veri Yapıları
<ul>
  <li>Bağlı liste</li>
  <li>Dairesel kuyruk</li>
  <li>Yığın</li>
</ul>

#### Sınıflar ve Metotlar
<ul>
  <li>Araba Sınıfı: Arabanın renk özelliğini tutar.</li>
  <li>IQueue Arayüzü:</li>
  <ul>
    <li>void Insert(Araba a);</li>
    <li>Araba Remove();</li>
    <li>Araba Peek();</li>
    <li>Boolean IsEmpty();</li>
  </ul>
  <li>IStack Arayüzü:</li>
  <ul>
    <li>void Push(Araba a);</li>
    <li>Araba Pop();</li>
    <li>Araba Peek();</li>
    <li>Boolean IsEmpty();</li>
    <li>int Top { get; set; }</li>    
  </ul>
  <li>LinkedListADT Soyut Sınıfı:</li>
  <ul>
    <li>Node Head;</li>
    <li>Node Last;</li>
    <li>int Size = 0;</li>
    <li>abstract void InsertFirst(Araba a);</li>
    <li>abstract Node Delete();</li>    
  </ul>
  <li>Node Sınıfı: Düğümün özelliklerini tutar.</li>
  <li>BodrumKat Sınıfı: Bodrum kattaki arabaların tutulduğu yığın.</li>
  <ul>
    <li>void Push(Araba a) : Yığına araba ekler.</li>
    <li>Araba Pop(): Yığından araba çıkarır.</li>
    <li>Araba Peek(): Yığındaki ilk elemanı döndürür.</li>
    <li>Boolean IsEmpty(): Yığın boş mu diye kontrol eder.</li>
    <li>int Top { get; set; }: Yığının en üstündeki eleman.</li>  
    <li>string BKListele() : Yığındaki arabaları listeler.</li> 
  </ul>
   <li>ZeminKat Sınıfı: Zemin kattaki arabaların tutulduğu kuyruk.</li>
  <ul>
    <li>void Insert(Araba a): Kuyruğa araba ekler.</li>
    <li>Araba Remove(); Kuyruktan araba çıkarır.</li>
    <li>Araba Peek(); Kuyruktaki ilk elemanı döndürür.</li>
    <li>Boolean IsEmpty(): Kuyruk boş mu diye kontrol eder.</li>
    <li>string ZKListele() : Kuyruktaki arabaları listeler.</li>  
    <li>double Test() : bilgisayarın 5 saniyede ortalama kaç adet otopark problemi çözdüğünü döndürür.</li> 
  </ul>
     <li>UskKat Sınıfı: Üst kattaki arabaların tutulduğu bağlı liste.</li>
    <ul>
    <li>abstract void InsertFirst(Araba a) : Listenin başına araba ekler.</li>
    <li>abstract Node Delete(): Listeden araba çıkarır.</li>
    <li>string UKListele() : Listedeki arabaları listeler.</li>
  </ul>
