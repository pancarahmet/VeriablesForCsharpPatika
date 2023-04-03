using System;

namespace VeriablesForCSharpPatika
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sayısal işlemler için kullanılıcak değişken tipleri

            byte b;         // 0 - 255 arasında değer alır ve 1 byte yer kaplar küçük değerler kullanılırken kullanılması avantajlıdır. sonsuz döngülerde 255 i geçtikten sonra tekrar 0 dan başlayarak 255 e kadar ilerler.
            sbyte sb;       // -128 - 127 arasında değer alır. byte ile aynı yapıdadır.
            short s;        // -32768 - 32267 arasında değer alır ve 2 byte yer kaplar.
            ushort us;      // 0 - 65365 arasında değer alır ve 2 byte yer kaplar. Baştaki u Unsigned anlamınadadır. İşaretsiz olarak bilinir.
            Int16 i16;      // short ile aynı değerleri alır ve aynı şekilde 2 byte yer kaplar
            Int32 i32;      // -2147483648 - 2147483647 arasında ki değerleri alır ve 4 byte yer kaplar.
            Int64 i64;      //  -9223372036854775808 - 9223372036854775807 arasındaki değerleri alır ve 8 byte yer kaplar.
            int i;          // int32 ile aynı değerleri alır ve 4 byte yer kaplar.
            uint ui;        // 0 - 4294967295 arasında değerler alır, int değerinin işaretsiz kısmıdır ve 4 byte yer kaplar.
            long l;         // int64 ile aynı değerleri alır ve 8 byte yer kaplar.
            ulong ul;       // 	0 - 18446744073709551615 arasında değer alır. long un işaretsiz kısmıdır ve 8 byte yer kaplar.
            float f;        //  4 byte yer kaplar ve ondalık sayılar için kullanılır. Ve işaretli değer alabilir.
            double d;       //  8 byte yer kaplar ve float gibi ondalık sayılar için kullanılır. Aralığı float dan çok daha fazladır. 
            decimal de;     //  16 byte yer kaplar ve float ve double gibi alanlarda kullanılır.

            // Yazı işlemlerinde kullanılıcak değişken tipleri

            char c;         //  Tek karakter alır. ve kullanımı ' ' tek tırnak içerisindedir. ve 2 byte yer kaplar.
            string str;     //  Cümle, paragraf gibi uzun yazılarda kullanılır. Değerleri " " çift tırnak içersinde yazarak alır ve kapladığı alan ise karakter adedi * 2 dir.

            // Onay işlemleri için kullanıcak veri tipi
            String ahmet="Recep Ahmet Pancar"
            bool isTrue;    //  2 çeşit değer alır. true yada false değerleri alır. bazen 0 ve 1 değerleride bunlar yerine kullanıbilir. 0 false yerine 1 true yerine ve 4 byte yer kaplar.

            // Tarih ve Zaman işlemleri için kullanılıcak değişken tipleri

            DateTime dt;    //  Zaman işlemleri için kullanılan bir değişkendir genellikle şimdi zamanı almamıza yardımcı olur DateTime.Now() şekilde ve 8 byte yer kaplar.

            // Tüm değişkenler yerine kullanılabilicek değişken tipleri

            object o;       // İstediğiniz değişken tipinde değer atayabilirsiniz.
            var v = "";
            var v1 = 1;
            var v2 = 'c';   // var object gibi istediğiniz değeri atayabilirsiniz Ama objeten tek farkı başlangıçta bir değer atamanız gerekir.
            var v3 = 1.1;
            var v4 = -1.1;

            //String ifalerin kullanımı

            string str1 = String.Empty;                         // bu kullanımı String ifadenin içersini boşaltmasını sağlar ve boş değer döndürür.
            str1 = "Recep Ahmet Pancar";                        // bu kullanımı String ifade ataması yaparken kullanırız.
            string ad = "Recep Ahmet";
            string AdSoyAd = ad + " Pancar";                    // bu kullanımı String ifaleri birleştirmede kullanırız.

            // Değişken Dönüşümleri

            string strToInt = "30";
            int _strToInt = int.Parse(strToInt);
            _strToInt = Convert.ToInt32(strToInt); // bu iki şekilde string ifadeyi int değerine dönüştürebilirsiniz. ve diğer sayısal değişkenlere dönüştürmek içinde bu dönüşümlerin aynısı kullanılır.

            int intToString = 30;
            string _intToString = intToString.ToString();       // bu kullanımda herhangi bir değişken tipini string ifadeye dönüştürmenizi sağlar.

            // Zaman değişken tipini kullanımı

            string dt1 = DateTime.Now.ToString("dd.MM.yyyy");   // bu kullanım Tarihi hangi formatta alacağınızı söyler parantez içersinde yazım şeklineze göre değişkenlik gösterir.
            string dt2 = DateTime.Now.ToString("HH:mm");        // bu saat formatını belirler. HH yaparsanız 24 saatlik dilim kullanır veya hh yaparsanız 12 saatlik dilimi kullanır.






        }
    }
}