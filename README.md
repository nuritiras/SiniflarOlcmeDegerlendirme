### https://github.com/nuritiras/SiniflarOlcmeDegerlendirme/blob/master/SiniflarOlcmeDegerlendirmeSorulari.pdf
#### C) Aşağıdaki cümlelerde boş bırakılan yerlere doğru sözcükleri yazınız.
<b>11.</b> Sınıf içindeki bir değişkeni dış dünyaya kapatıp sadece sınıf içinde kullanılabilir kılmak için bu özellik ………<b>private</b>………… şeklinde tanımlanmalıdır. <br>
<b>12.</b> Sınıf içindeki bir değişkeni dış dünyaya kapatıp sadece sınıf içinde ve bu sınıftan türetilen alt sınıflarda kullanılabilir kılmak için bu özellik ……………<b>protected</b>……………… şeklinde tanımlanmalıdır. <br>
<b>13.</b> Sınıf içindeki bir değişkeni her yerden erişilebilir kılmak için bu özellik …………<b>public</b>………………… şeklinde tanımlanmalıdır.<br>
#### 15. YAPICI VE YIKICI METOTLAR
Nesneler oluşturulurken otomatik olarak çalıştırılan metotlara <b>yapıcı metot (constructor)</b>, nesnelerin yok edildiği anda otomatik olarak çalıştırılan metotlara <b>yıkıcı metot (destructors) denir.</b> <br><br>
<b>Yapıcı metotlar,</b> nesnelerin ilk oluşturulduğu anda otomatik olarak çalıştırılır. Yapıcı metotlar genellikle sınıf içinde tanımlanan yerel değişkenlerin ilk değerlerini düzenlemek için kullanılır.Bir metodun yapıcı metot olabilmesi için şu şartları taşıması gerekir:<br>
• Metot adı, sınıfın adı ile aynı olmalıdır.<br>
• Geri dönüş tipi olmamalıdır (void ya da int gibi).<br>
• Nesneleri oluşturmak için new operatörü kullanıldığı anda yapıcı metotlar otomatik olarak çalıştırılır.Nesne oluşturulduktan sonra yapıcı metotlar bir daha çağrılamaz.<br><br>
Nesne hafızadan atıldığı anda otomatik olarak çalışan <b>yıkıcı metotlar,</b> tıpkı yapıcı metotlar gibi özel metotlardırve şu şartları taşımalıdır:<br>
• Metot adı, sınıfın adı ile aynı olmalıdır.<br>
• Metot adının başında ~ (Tilde) karakteri olmalıdır.<br>
• Bir sınıfın yalnızca bir tane yıkıcı metodu olabilir.<br>
• Yıkıcı metotlar aşırı yüklenemez.<br>
• Yıkıcı metotlar parametre alamaz.<br>
• Yıkıcı metotların erişim belirleyicisi olamaz.<br>
#### 17. STATİK SINIFLAR (STATIC CLASSES)
Oluşturduğumuz sınıf içerisinde sadece static metotlar ve değişkenler bulunuyorsa sınıfı static olarak tanımlayabiliriz. Statik ögeler genellikle nesnelerin durumuna göre değişmeyen verileri temsil etmede veya hesaplamaları yapmada kullanılır. Buna en güzel örnek, .NET Sınıf Kütüphanesi’ndeki Math sınıfıdır. 
