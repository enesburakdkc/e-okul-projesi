<h1>Windows Form E-Okul Projesi</h1>

<hr>
Admin TC: 123456789
<br>
Admin Şifre: Admin123
<br>
Örnek Öğrenci TC: 11111111111
<br>
Örnek Öğrenci No: 1
<br>
Örnek Öğretmen TC: 99999999999
<br>
Örnek Öğretmen Şifre: 9999
<hr>

Masaüstü uygulaması olarak çalışan Windows Form projemiz MSSQL ile entegre çalışmaktadır ve bu projeyi bilgisayarınızda çalıştırabilmek için MSSQL kurulu olmalıdır.

Veri tabanına bağlı olarak çalışan projemizin çalışabilmesi için aşağıda belirttiğim yolları izlemelisiniz.

<ul>
<li>"DataBaseErisim.txt" dosyasını C klasörümüzün içine boştan bırakıyoruz. Dosya konumu "C\DataBaseErisim.txt" şeklinde olmalı.
</ul>

Bu projenin bilgisayarınızda çalışabilmesi için MSSQL'in bilgisayarınızda kurulu olması lazım. Database'yi bilgisayarınıza aktarabilmek için:

<ul>
<li>SQL Server giriş ekranında Server name ifadesinin karşısında yazan değeri olduğu gibi kopyalayıp, C klasörümüze atmış olduğumuz "DataBaseErisim.txt" dosyasını açıp, "Data Source" değerinin hemen yanındaki "DataBaseAdi" ifadesini silip yerine kopyalamış olduğumuz Server name değerini yapıştırıp, dosyayı kaydedip kapatıyoruz.</li>
<li>SQL Server'ı açıyoruz ve "Databases" klasörünün üzerine sağ tıklayıp "New Database" diyoruz.</li>
<li>"Database name" yazan alana "E-OkulProjesi" ifadesini aynı şekilde yazıyoruz ve "OK" diyoruz.</li>
<li>"MSSQL_Setup.sql" dosyamızı açıyoruz ve f5'e basıyoruz.</li>
</ul>

Bu sayede veri tabanımızı hedef bilgisayara taşımız olduk.

Son olarak klasörümüzün içerisindeki "E-Okul Projesi\E-OkulProjesiSetup\Debug\E-OkulProjesiSetup.msi" dosyamızı çalıştırıp next next diyerek kurulumu tamamlıyoruz ve masaüstümüze gelen kısayoldan projemizi çalıştırıyoruz.

Projemiz çalışmaya hazır.
