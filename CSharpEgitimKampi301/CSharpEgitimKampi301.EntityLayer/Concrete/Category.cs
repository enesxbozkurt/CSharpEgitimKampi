using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    internal class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

    }
}

/*
 EntityLayer --> Projeye ait varlıklar tanımlanır.
 DataAccessLayer -- Veri tabanı işlemleri yapılır.
 BusinessLayer --> Temel işlevler ve iş kuralları tanımlanır.
 Presentation/UI(User Interface)Layer --> Kullanıcıya gösterilir.
 */

/*
 Tablo --> Sql tarafında QUERY bazlı işlenir
 Class --> C# class oluşturulur ve bu class sql tarafında Table olarak algılanır
 Propery --> Classların içerisindeki property'ler tablodaki sütunlara karşılık gelecek
 */

/*
 ACCESS MODİFİERS
 Public --> Herkese açık
 Private --> Sadece bulunduğu class'a özel
 Internal --> Sadece bulunduğu katmandan(Sadece Entity'den) erişim sağlanılabilir
 Protected --> Sınıfın miras aldığı yerlerden erişim sağlanabilir
 */


/*
 SOLID(Single Responsibility)
 Bir method, sınıf vb. bileşenin bağlı bulunduğu alanda sadece tek bir işlem yapabilmesidir.(Toplama methodu ise sadece toplama işlemi yapmalı)
*/

/*
 Field --> int x;
 Property --public int y {get; set;}
 Variable --> void test() {int z;}
 */
