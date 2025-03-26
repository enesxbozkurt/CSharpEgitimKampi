🌟 C# Eğitim Kampı Projeleri
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Bu repo, sayın hocam Murat Yücedağ eğitmenliğinde gerçekleştirdiğim projeleri içeriyor. Her bir proje ile kendimi geliştirmeye devam ediyorum. Detaylar aşağıda...

📝 Proje 1: Merhaba Dünya!
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Yazılıma başlarken olmazsa olmaz kodumuzu yazdık :) Console.WriteLine() ile temel yazdırma işlemini tamamladım.

🔧 Proje 2: Değişkenler
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Farklı veri türleri (int, string, double) ile değişkenler tanımlayıp projede kullandım. Veri tipleri üzerinde işlemler yaparak değişkenleri daha da iyi kavradım.

📦 Proje 3: Diziler (Arrays)
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Dizileri kullanarak birden fazla veriyi nasıl depolayıp kontrol edebileceğimi ve bunları döngülerle nasıl işleyebileceğimi öğrendim.

⚙️ Proje 4: Karar Yapıları (If-Else)
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Karar yapıları ile programların koşullara göre nasıl ilerlediğini gördüm. If, else if ve else ile karar durumlarını karşılaştırdım.

🔄 Proje 5: Döngüler (Loops)
------------------------------------------------------------------------------------------------------------------------------------------------------------------
For, while ve foreach döngüleri ile tekrarlayan işlemleri otomatikleştirmenin yollarını işledim.

🛠️ Proje 6: Metotlar (Methods)
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Kodlarımı daha düzenli hale ve kod tekrarlarını ortadan kaldırmak için metotlar kullandım. Parametre alıp sonuç döndüren metotlar yazarak daha da ileri götürdüm.

🎓 Proje 7: Foreach Döngüsü ve Sınav Sistemi
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Bir sınav sistemi projesi oluşturarak foreach döngüsünü daha iyi kavradım. Öğrencilerin notlarını hesaplayarak geçme durumlarını belirledim.

🏆 Proje 8: Geriye Değer Döndüren Fonksiyonlar
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Kullanıcıdan aldığım verileri işleyip değer döndüren fonksiyonlar oluşturdum.

🗄️ Proje 9: Database Project (Veri Tabanı Bağlantısı)
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Veri tabanında tablolar oluşturarak veri girişlerini sağladım. Temel SQL sorgu örneklerini kullanarak verileri listelemeyi öğrendim. ADO.NET çerçevesi sayesinde C# ile veri tabanına bağlanarak konsolda kullanıcılara veri tabanındaki verileri gösterebildim.

📊 Proje 10: CRUD İşlemleri
------------------------------------------------------------------------------------------------------------------------------------------------------------------
C# ile veri tabanı bağlantısı kurarak CRUD (Create, Read, Update, Delete) işlemlerini kapsamlı bir şekilde gerçekleştirdim. Kullanıcıdan aldığım verilerle yeni kayıtlar oluşturup, mevcut verileri güncelleyerek veya silerek veri yönetimini gerçekleştirdin. Uygulama içinde temel SQL sorgularını kullanarak verilerin nasıl düzenlendiğini ve listelediğini deneyimledim.

🔍 Proje 11: N Katmanlı Mimari (Entity Layer) 
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Projelerin baştan sona bir düzen ve bir bütün içerisinde ilerlemesini sağlayacak yapıları öğrendim. N katmanlı mimari ile uygulamalarımın farklı bileşenlerini birbirinden ayırarak, daha modüler ve bakımı kolay sistemler geliştirme imkanı sunduğunu gördüm.

🗃️ Proje 12: Data Access Layer ve Context Sınıfı
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Context sınıfı oluşturuldu.
App.config dosyasına bağlantı dizgisi eklendi.
Bire-çok ilişkiler tanımlandı ve veritabanı modeli oluşturuldu.

⚙️ Proje 13: Migration ve Abstract Interface Kullanımı
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Migration işlemleri öğrenildi ve veritabanı şeması güncellemeleri yapıldı.
IGenericDal interface ile generic yapı oluşturuldu.
Her entity için ayrı bir interface tasarlandı, böylece esneklik ve sürdürülebilirlik sağlandı.

🏗️ Proje 14: Entity Framework DB First ve Model Oluşturma
------------------------------------------------------------------------------------------------------------------------------------------------------------------
DB First yaklaşımı kullanılarak mevcut bir veritabanı projeye entegre edildi ve model sınıfları oluşturuldu.
Veritabanı yapısına uygun olarak otomatik modelleme yapıldı.

🖥️ Proje 15: Entity Framework Metotları ile Uygulama
------------------------------------------------------------------------------------------------------------------------------------------------------------------
DataGridView ile veri görüntüleme işlemi yapıldı.
TextBox ile veri ekleme işlemi gerçekleştirildi.
ID ile veri çekme ve düzenleme işlemleri yapıldı.

🌍 Proje 16: Entity Framework - Location İşlemleri
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Location tablosu için bir form oluşturuldu ve aşağıdaki işlemler gerçekleştirildi:
Kayıtları listeleme
Yeni kayıt ekleme
Mevcut kayıtları silme
Kayıt güncelleme
ID'ye göre veri getirme
ID'ye göre tabloya veri listeleme

📊 Proje 17: Entity Framework ve LINQ ile İstatistik Takibi
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Entity Framework ve LINQ sorgularıyla bir Windows Form uygulaması oluşturuldu.
Veritabanından alınan dinamik istatistikler listelendi.
İstatistikler, kullanıcı dostu bir arayüzde görselleştirildi ve analiz için hazır hale getirildi.

![image](https://github.com/user-attachments/assets/da980560-302f-46ff-9492-eaa2dc15062d)

🔧 Proje 18: EntityState Komutları ve Generic Repository
------------------------------------------------------------------------------------------------------------------------------------------------------------------
DataAccessLayer içerisinde bir Repository klasörü oluşturuldu.
GenericRepository sınıfı tanımlandı ve CRUD işlemleri genelleştirildi.
Entity Framework ve LINQ sorgularıyla veritabanı işlemleri tamamlandı.

🏗️ Proje 19: Business Katmanı ve Logic Kuralları
------------------------------------------------------------------------------------------------------------------------------------------------------------------
BusinessLayer içinde iki ana klasör oluşturuldu:
Abstract: GenericService adlı genel bir arayüz tanımlandı.
Her entity için ayrı servis arayüzleri tasarlandı.
Concrete: Abstract arayüzlerinden türeyen Manager sınıfları oluşturuldu.
Manager sınıflarında Dependency Injection kullanılarak veritabanı atamaları yapıldı.
Validasyon İşlemleri: Manager sınıfları kullanılarak validasyon işlemleri uygulandı.
Business katmanı, validasyon ve iş kurallarının merkezi olarak yapılandırıldı.

🔗 Proje 20: Dependency Injection (Bağımlılık Enjeksiyonu)
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Dependency Injection (DI): Bağımlılık enjeksiyonu, sınıfın ihtiyaç duyduğu bağımlılıkları dışarıdan almasını sağlayan bir tasarım desenidir.
Avantajları: Kod Modülerliği: Daha az bağımlı ve esnek kod yapıları.
Test Edilebilirlik: Mock nesnelerle kolay entegrasyon.
Yeniden Kullanılabilirlik: Bileşenlerin farklı bağlamlarda tekrar kullanımı.
Uygulama: Constructor Metodu kullanılarak servisler ve EfCategoryDal gibi bağımlılıklar enjekte edilerek işlemler tamamlandı.
Kategori form işlemleri (veri ekleme, silme, güncelleme, listeleme) gerçekleştirildi.

🛠️ Proje 21: Entity'e Özgü Metot Yazmak
------------------------------------------------------------------------------------------------------------------------------------------------------------------
GetProductsWithCategory Metodu: Ürünlerin bağlı olduğu kategori adını listelemelerde göstermek amacıyla tasarlandı.
Çözüm: ProductWithCategoryDTO sınıfı ile ürün bilgileri ve kategori adını içeren bir yapı oluşturuldu.

⚙️ Proje 22-23: C# ile Dapper Kullanımı
------------------------------------------------------------------------------------------------------------------------------------------------------------------
ID'ye göre veri getirme, ekleme ve güncelleme işlemleri tamamlandı.
DTO Sınıfları: ResultDTO, AddDTO ve UpdateDTO sınıfları eklendi.
Asenkron İşlemler: Repository altyapısı asenkron metotlarla desteklendi.
Dapper ile İstatistik Sorguları: CRUD işlemleri tamamlandı.
3 farklı istatistik sorgusu oluşturulup görselleştirildi.

🗄️ Proje 24-25: MongoDB ile Çalışma
------------------------------------------------------------------------------------------------------------------------------------------------------------------
MongoDB Temelleri: BSON yapısı öğrenildi.
MongoDB ile CRUD işlemleri uygulandı.
MongoDB'nin ilişkisel olmayan veritabanı yönetimi üzerine uygulamalar tamamlandı.

🐘 Proje 26-27: PostgreSQL ile Çalışma
------------------------------------------------------------------------------------------------------------------------------------------------------------------
PostgreSQL: Açık kaynaklı, ölçeklenebilir ve güvenilir bir ilişkisel veritabanı sistemi kullanıldı.
PostgreSQL’de tablo ve veritabanı tasarımı yapıldı.
CRUD işlemleri gerçekleştirildi.
Tablolar arası ilişkiler kurularak formlar oluşturuldu.
Dinamik ComboBox ile çalışan-departman ilişkilendirmesi yapıldı.

📊 Proje 28-30: Finansal CRM Uygulaması
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Timer: Fatura döngüleri ve toplam bakiye görüntülendi.
Chart: Banka bakiyeleri ve faturalar görselleştirildi.
🗂️ Category: Kategorileri yönetme.
💰 Spending: Harcamalar takibi.
⚙️ Settings: Ayarlar ve yapılandırma.
🔑 Login: Giriş modülü.
🏦 Bank Transactions: Banka hareketleri.

![image](https://github.com/user-attachments/assets/b2a1c112-7a37-4861-9686-7eab4245fce7)

![image](https://github.com/user-attachments/assets/87fb3b0c-0f50-49b5-aad2-9f66855c704b)

![image](https://github.com/user-attachments/assets/d48233d4-e22e-458d-adda-bb3e0fdec899)

![image](https://github.com/user-attachments/assets/90830eb5-f5ce-4215-b94e-3ac24087b16e)





