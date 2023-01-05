#### https://github.com/nuritiras/SiniflarOlcmeDegerlendirme/blob/master/SiniflarOlcmeDegerlendirmeSorulari.pdf
#### C) Aşağıdaki cümlelerde boş bırakılan yerlere doğru sözcükleri yazınız.
<b>11.</b> Sınıf içindeki bir değişkeni dış dünyaya kapatıp sadece sınıf içinde kullanılabilir kılmak için bu özellik ………<b>private</b>………… şeklinde tanımlanmalıdır. <br><br>
<b>12.</b> Sınıf içindeki bir değişkeni dış dünyaya kapatıp sadece sınıf içinde ve bu sınıftan türetilen alt sınıflarda kullanılabilir kılmak için bu özellik ……………<b>protected</b>……………… şeklinde tanımlanmalıdır. <br><br>
<b>13.</b> Sınıf içindeki bir değişkeni her yerden erişilebilir kılmak için bu özellik …………<b>public</b>………………… şeklinde tanımlanmalıdır.<br>
#### 14. Ekran Çıktısı
8
#### 15. YAPICI VE YIKICI METOTLAR
Nesneler oluşturulurken otomatik olarak çalıştırılan metotlara <b>yapıcı metot (constructor)</b>, nesnelerin yok edildiği anda otomatik olarak çalıştırılan metotlara <b>yıkıcı metot (destructors) denir.</b> <br><br>
<b>Yapıcı metotlar,</b> nesnelerin ilk oluşturulduğu anda otomatik olarak çalıştırılır. Yapıcı metotlar genellikle sınıf içinde tanımlanan yerel değişkenlerin ilk değerlerini düzenlemek için kullanılır. Bir metodun yapıcı metot olabilmesi için şu şartları taşıması gerekir:<br>
• Metot adı, sınıfın adı ile aynı olmalıdır.<br>
• Geri dönüş tipi olmamalıdır (void ya da int gibi).<br>
• Nesneleri oluşturmak için new operatörü kullanıldığı anda yapıcı metotlar otomatik olarak çalıştırılır. Nesne oluşturulduktan sonra yapıcı metotlar bir daha çağrılamaz.<br><br>
Nesne hafızadan atıldığı anda otomatik olarak çalışan <b>yıkıcı metotlar,</b> tıpkı yapıcı metotlar gibi özel metotlardır ve şu şartları taşımalıdır:<br>
• Metot adı, sınıfın adı ile aynı olmalıdır.<br>
• Metot adının başında ~ (Tilde) karakteri olmalıdır.<br>
• Bir sınıfın yalnızca bir tane yıkıcı metodu olabilir.<br>
• Yıkıcı metotlar aşırı yüklenemez.<br>
• Yıkıcı metotlar parametre alamaz.<br>
• Yıkıcı metotların erişim belirleyicisi olamaz.<br>
#### 16. Ekran Çıktısı
0 & 125
#### 17. Statik sınıflar hangi durumlarda kullanılır?
Oluşturduğumuz sınıf içerisinde sadece static metotlar ve değişkenler bulunuyorsa sınıfı static olarak tanımlayabiliriz. Statik ögeler genellikle nesnelerin durumuna göre değişmeyen verileri temsil etmede veya hesaplamaları yapmada kullanılır. Buna en güzel örnek, .NET Sınıf Kütüphanesi’ndeki Math sınıfıdır. 
#### 18. Statik yapıcı metotlar ne zaman çalıştırılır?
Statik yapıcı metot mutlaka ilk nesne tanımlandığında çalıştırılır.
#### 19. Arayüzler ile Soyut sınıf arasındaki benzerlikler ve farklılıklar
• Bir sınıf birden fazla arayüzden türetilebilir. Bir sınıf sadece tek bir soyut sınıftan türetilebilir. <br>
• Sadece boş (gövdesi olmayan) metotlar tanımlanabilir. Hem normal metot hem de boş metotlar tanımlanabilir. <br>
• Çoklu kalıtım özelliği sağlar. Çoklu kalıtım özelliği sağlamaz.<br>
• Tüm ögeler public olarak kabul edilir. Ögeler public olmak zorunda değildir.<br>
• Yapıcı metot içeremez. Yapıcı metot içerebilir.<br>
• Statik ögeler barındıramaz. Statik ögeler barındırabilir.<br>
