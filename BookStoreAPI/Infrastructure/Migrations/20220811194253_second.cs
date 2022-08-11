using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "AuthorId", "BookTitle", "Description", "Genre", "ImagePath", "Price", "Publisher" },
                values: new object[,]
                {
                    { 1, "Beyhan Budak", null, "Kendine İyi Davran Güzel İnsan", "Bu yolculukta, kaygılarınla baş etmek ve kafaya takmamak için hangi yöntemleri kullanabileceğini, olumsuz düşüncelerini nasıl kontrol edebileceğini, sağlıklı ilişkilerini geliştirirken sana zarar veren zehirli insanlardan kendini nasıl koruyabileceğini, hangi alanlarda mücadele etmenin anlamlı olduğunu, hangi alanlarda hayatı ve getirdiklerini kabullenmen gerektiğini, içindeki değersizlik hissini nasıl yenebileceğini ve kendini nasıl dönüştürebileceğini keşfedeceksin.", 2, "https://i.dr.com.tr/cache/500x400-0/originals/0001988057001-1.jpg", 25m, "D&R" },
                    { 28, "İhsan Oktay Anar", null, "Puslu Kıtalar Atlası", "Türk edebiyatının güçlü kalemlerinden İhsan Oktay Anar, 1995’te yayımladığı Puslu Kıtalar Atlası ile 7’den 70’e geniş bir okur kitlesine ulaşmaya devam ediyor. Eserinde fantastik ve tarihi roman özelliklerini ustalıkla bir araya getiren yazar, zengin anlatımı ile okurlarına benzersiz bir deneyim sunuyor.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0000000061857-1.jpg", 25m, "D&R" },
                    { 27, "Ray Bradbury", null, "Fahrenheit 451", "Amerikan edebiyatının öne çıkan yazarlarından Ray Bradbury`nin 1953 yılında yayımlanan eseri Fahrenheit 451,on yıllar öncesinden bugünün ve uzak geleceğin dünyasına sert eleştiriler savuruyor.Distopik bir kurgusal düzlemde ilerleyen eser,teknolojinin gelişmesiyle birlikte toplumun gerileyen sanat ve düşünce dünyasını ele alıyor.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0001750151001-1.jpg", 25m, "D&R" },
                    { 26, "Gabriel Garcia Marouez", null, "Yüzyıllık Yalnızlık", "Nobel Ödüllü Kolombiyalı Yazar Gabriel Garcia Marquez’in Yüzyıllık Yalnızlık romanı, gerçeklik kavramına kattığı olağandışı boyutla, yayımlandığı 1967’den bugüne edebiyat dünyasındaki değerini korumaya devam ediyor. Marquez’in 1982 yılında Nobel Edebiyat Ödülü’nü almasını sağlayan roman, edebiyat dünyasına yazarın kazandırdığı “büyülü gerçekçilik” akımının en ihtişamlı örneğini oluşturuyor.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0000000064137-1.jpg", 25m, "D&R" },
                    { 25, "William Shakespeare", null, "Romeo ve Juliet ", "Oyunları ve şiirlerinde insanlık durumlarını dile getiriş gücüyle yaklaşık 400 yıldır bütün dünya okur ve seyircilerini etkilemeyi sürdüren efsanevi yazar, Romeo ve Juliet’de birbirinden farklı pek çok toplumda benzerleriyle karşılaşılan trajik bir ilişkiyi, düşman ailelerin çocukları arasında doğan aşkı ele alır. Romeo ile Juliet’in umutsuz aşkını romantik örgüsünün yarı karanlık örtüsüyle sarmalayan eser, buna rağmen insan ilişkilerini gerçekçi bir anlayışla gözler önüne serer.", 2, "https://i.dr.com.tr/cache/500x400-0/originals/0000000324159-1.jpg", 25m, "D&R" },
                    { 24, "Dostoyevski", null, "Karamazov Kardeşler", "Dostoyevski, yaşamının son yıllarında başyapıtı Karamazov Kardeşler'i tamamladığında,Rus yazınında 'felsefe düzeyinde roman-tragedya denen türün de temelini attığının bilincinde değildi. Dostoyevski`nin yaşam birikiminin tümünü ve sanat gücünün doruğunu içeren bu roman, gerçekte insanı insan yapan ne varsa, onlara adanmış bir destan niteliğini taşır. Yazar, hiçbir romanında 'Karamazov Kardeşler'de olduğu denli insan ruhuna inmemiş, insanoğlunu bu denli kesitler biçiminde, içgüdülerinin ve istencinin tüm görünümüyle sergilenmiştir.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0000000240594-1.jpg", 25m, "D&R" },
                    { 23, "Gabriel Garcia Marouez", null, "Kırmızı Pazartesi", "Kolombiyalı büyük yazar Gabriel García Márquez'in 1981'de yayımlanan yedinci romanı Kırmızı Pazartesi, işleneceğini herkesin bildiği, engel olmak için kimsenin bir şey yapmadığı bir namus cinayetinin öyküsü. Hem Kolombiya'da, hem de yayımlandığı dünyanın dört bir yanındaki pek çok ülkede sarsıcı etkileri olmuş bir roman. Usta yazar, çocukluğunu geçirdiği kasabada yıllar önce yaşanmış bir cinayet olayını aktarıyor.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0000000064101-1.jpg", 25m, "D&R" },
                    { 22, "Stephen R. Covey", null, "Etkili İnsanların 7 Alışkanlığı", "Kurumsal danışman, aile uzmanı, eğitmen ve bir liderlik otoritesi olarak uluslararası alanda kabul görmüş bir yazar olan Stephen R. Covey, Etkili İnsanların 7 Alışkanlığı kitabı ile modern yaşamda başarının anahtarını sunuyor. 1999 yılında yayımlanan ve “iş dünyasında yirminci yüzyılın en etkili kitabı” olarak anılan eser, 38 dilde 15 milyonu aşkın baskısıyla dünya genelinde büyük ilgi görmeye devam ediyor.", 2, "https://i.dr.com.tr/cache/500x400-0/originals/0000000061005-1.jpg", 25m, "D&R" },
                    { 21, "Sally Rooney", null, "Güzel Dünya Neredesin?", "Alice ve Eileen,farklı şehirlerde yaşayan,otuzlarına yaklaşan iki arkadaş.Roman yazarı Alice,flört uygulaması sayesinde bir depo işçisi olan Felix’le tanışıp yakınlaşır.Eileen ise sona eren ilişkisinin yaralarını sarmaya çabalarken bir yandan da çocukluk arkadaşı Simon’ın çekimine kapıldığını hisseder.Alice ve Eileen ilişkiler,sanat,edebiyat ve günbegün belirsizleşen gelecekleri hakkında yazışırken hem arkadaşlıklarını hem de hayata bakışlarını sorgulamaya başlarlar.Zira aşklarına,kalp kırıklıklarına,günü yaşamaya ve muhabbetlerine tepelerinden ayrılmak bilmeyen bir bulut eşlik eder.", 2, "https://i.dr.com.tr/cache/500x400-0/originals/0001975703001-1.jpg", 25m, "D&R" },
                    { 20, "Emrah Serbes", null, "Çekiç ve Gül", "Sıvasız duvarlı gecekonduda, pavyonda, işkembecide, oto tamirhanesinde, dükkânda, şık bir ofiste, tekkede, Millet Bahçesi’nde, adliyede, hastanede, nezarethanede, mezarlıkta ve tabii sokaklarda, cinayetlerin ve nice cürümlerin izini sürüyor Behzat Ç.. Umutsuz, serkeş, pejmürde... Bazen de olanca dehşetine tezat, “basit, tatlı ve hüzünlü” insan hikâyelerinin içinde geziyor.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0001985496001-1.jpg", 25m, "D&R" },
                    { 19, "Oğuz Atay", null, "Tutunamayanlar", "Ülkemizin en değerli yazarlarından biri olan Oğuz Atay’ın yazıldığı dönemde büyük tartışma konusu olmuş eseri Tutunamayanlar, 1972 yılında yayımlanmıştır. Eser, bilinç-akışı tekniğiyle döneme damgasını vurarak Türk Edebiyatı’nda yeni bir çağı başlatmıştır. Pek çok eleştirmen, Tutunamayanlar’ı Türk Dili’nde yazılmış en iyi eser olarak değerlendirmektedir.", 2, "https://i.dr.com.tr/cache/500x400-0/originals/0000000061424-1.jpg", 25m, "D&R" },
                    { 18, "Hector Garcia", null, "Ikigai", "Uluslararası çok satan bir rehber olan Ikigai’yle her gününüz bir anlam kazansın. Japonlar herkesin bir ikigaisi olduğuna inanır, her sabah yataktan kalkmaları için bir sebepleri vardır. İlham verici ve rahatlatıcı bu kitap sizlere kendi ikigainizi keşfetmeniz için gerekli tüm bilgileri veriyor. Aceleci davranmamanızı, hayat gayenizi keşfetmenizi, ilişkilerinizi canlandırmanızı ve kendinizi tutkularınıza adamanızı sağlıyor.", 2, "https://i.dr.com.tr/cache/500x400-0/originals/0001735494001-1.jpg", 25m, "D&R" },
                    { 17, "Irvin D. Yalom", null, "Nietzsche Ağladığında", "Rus asıllı yazar Irvin D. Yalom’un 1992 yılında kaleme aldığı Nietzsche Ağladığında,ünlü filozofun hayatına dair derin izler taşıyor. Filozofun yaşamından bir bölüme tanıklık etmenizi sağlayacak olan eser, dönemin önemli şahsiyetlerini de hikayesine dahil ediyor.Romanın ana temasına “ümitsizlik” fikrini yerleştiren Yalom, böylece Nietzsche’nin felsefi düşüncelerine dair ipuçlarını da okuyucu ile buluşturuyor.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0000000065453-1.jpg", 25m, "D&R" },
                    { 16, "Sabahattin Ali", null, "İçimizdeki Şeytan", "steyip istemedeğimi doğru dürüst bilmediğim, fakat neticede aleyhime çıkarsa istemediğimi iddia ettiğim bu nevi söz ve fiillerimin daimi bir mesulünü bulmuştum: Buna içimdeki şeytan diyordum, müdafaasını üzerime almaktan korktuğum bütün hareketlerimi ona yüklüyor ve kendi suratıma tüküreceğim yerde, haksızlığa, tesadüfün cilvesine uğramış bir mazlum gibi nefsimi şefkat ve ihtimama layık görüyordum. Halbuki ne şeytanı azizim, ne şeytanı? Bu bizim gururumuzun, salaklığımızın uydurması.", 2, "https://i.dr.com.tr/cache/500x400-0/originals/0000000058246-1.jpg", 25m, "D&R" },
                    { 15, "J.D. Salinger", null, "Çavdar Tarlasında Çocuklar ", "1951 yılında basılan kitap, Salinger’in ilk ve tek romanıdır. Çıktığı andan bu yana ilgi gören roman, ergenlik dönemindeki bir çocuğun dünyayı algılayış biçimini bize anlatırken, yetişkinlerin düzenine karşı olan isyanını da başarılı bir dil ile aktarıyor. Samimi dili ve karakterin içinde bulunduğu duyguların okuyucuya olan yansıması, onu kısa sürede dünya edebiyatı listelerinde ilk sıralara taşıyor.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0000000058117-1.jpg", 25m, "D&R" },
                    { 14, "Jane Austen", null, "Gurur ve Önyargı ", " Sadece kırk iki yıllık, gözden uzak ve sade yaşantısına karşın yazdıklarıyla 'roman tarihinin ilk büyük(ve sahici) kültü' olmayı başaran bir 19. yüzyıl romancısıdır. Sayısız TV ve sinema uyarlamalarının yanısıra tüm 'satış / okunma' anketlerinin de gösterdiği üzere, yazarın 1813'de yayınlanan ikinci romanı Gurur ve Önyargı tüm zamanların en sevilen romanlarının başında gelir. Bu da, sanırız, Austen'in, dünyanın pek çok yerinde geleneklerin kadına biçtiği 'en iyi gelecek' rolüyle kadınların aşklarını seçme hakkı arasındaki gerilimi 'mizah, zeka ve sevecenlik'le yansıtmasından kaynaklanmaktadır.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0000000202083-1.jpg", 25m, "D&R" },
                    { 13, "Anthony Burgess", null, "Otomatik Portakal", "Teknolojik gelişmeler öyle bir boyuta ulaşmış,markete bile gitmeden evden oturduğumuz yerden ya da yurt dışından sipariş vererek alışveriş yapmaya, bankaya gitmeden evden dünyanın öbür ucuna para göndermeye, akıllı telefonu kredi kartı gibi kullanmaya kadar dijitalleşme günlük hayatımızın hemen her alanına o kadar egemen olmuştur ki, suç işleyenler de adeta bu duruma ayak uydurarak bilinen suç işleme yöntemleri yerine bambaşka yöntemler geliştirmeye başlamışlardır. ", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0001806049001-1.jpg", 25m, "D&R" },
                    { 12, "Stefano D’Anna", null, "Tanrılar Okulu", "İtalyan asıllı yazar ve modern çağ filozofu Prof. Stefano D’Anna, Tanrılar Okulu kitabı ile insanın kendi yaşamına dair devrim niteliğinde bir bakış açısı ortaya koyuyor. Eserinde bireyin hayata bir edilgen değil, tüm iyi ve kötü etkenlerin faili olarak bakması gerektiğini vurgulayan yazar, hikayeleştirme tekniği ile bunu oldukça etkileyici bir şekilde aktarıyor.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0000000324077-1.jpg", 25m, "D&R" },
                    { 11, "Paulo Coelho", null, "Simyacı", "Dünya edebiyatının fenomenleri arasında yer alan Simyacı, yayımlandığı günden bugüne pek çok hayata dokunmaya devam ediyor. Brezilyalı yazar Paulo Coelho tarafından 1988 yılında yayımlanan eser, Doğu ve Batı dünyasına aynı pencereden ışık tutuyor. Coelho’nun Mesnevi’deki bir kıssadan hareketle kaleme aldığı Simyacı, macera dolu öyküsü ve felsefi yönüyle başucu kitabınız olmaya aday!", 2, "https://i.dr.com.tr/cache/500x400-0/originals/0000000064552-1.jpg", 25m, "D&R" },
                    { 10, "İlber Ortaylı", null, "Bir Ömür Nasıl Yaşanır?", "Kişisel gelişim; mesleki ve sosyal anlamda farklı konumlarda yer alan her insanın tabii olarak fikir sahibi olduğu, ancak bir o kadar da fikre ihtiyaç duyulan bir alan. Bu nedenle söz konusu alanın, modern dünyada geniş bir yer edindiğini söylemek mümkün. Hayatı hakkınca ve nitelikli yaşamaya dair tavsiye alınabilecek kişilere gelindiğinde ise Türkiye’de herkesin aklına gelecek isimlerden birini tahmin etmek zor değil.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0001796150001-1.jpg", 25m, "D&R" },
                    { 9, "Sharon M. Draper", null, "İçimdeki Müzik", "İngiltere'nin saygın edebiyat ödüllerinden Coratta Scott King ödüllü yazar Sharon M. Draper'dan hüzün ve umut dolu soluksuz okunacak bir roman. Gerçek bir yaşam öyküsünden ilham alınarak kaleme alınmış. 11 yaşındaki Melody'nin hastalığının adı Spastik ikili kuadripleji yani beyin felci. Yürüyemiyor, konuşamıyor,tekerlekli sandalyeye mahkum. Hiçbir uzvuna komut veremeyen bu küçük kızın beyni ise mükemmel işliyor. ", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0000000683283-1.jpg", 25m, "D&R" },
                    { 8, "Mustafa Kemal Atatürk", null, "Nutuk - Gençler İçin Fotoğraflarla", "Ey Türk geleceğinin evladı!İşte, bu durum ve koşullar içinde bile görevin, Türk bağımsızlık ve cumhuriyetini kurtarmaktır!Muhtaç olduğun güç, damarlarındaki soylu kanda mevcuttur!", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0000000325204-1.jpg", 25m, "D&R" },
                    { 7, "George Orwell", null, "1984", "Distopya olarak nitelendirilen George Orwell’ın bu şahane eseri, geçmişin aslında ne kadar da gelecekten izler taşıdığını ortaya koyuyor. 1948’de kaleme aldığı bu eser ile Orwell, günümüz modern dünyasına bir protesto bırakıyor.Her ne kadar kitabında 1984 yılını tasvir etse de kitabın derinliklerinde bugünden izler de bulabilmeniz mümkün. Bu durumda elbette ki George Orwell’ın ileri görüşlülüğü etkili.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0000000064038-1.jpg", 25m, "D&R" },
                    { 6, "Stefan Zweig", null, "Olağanüstü Bir Gece", "Olağanüstü Bir Gece, seçkin bir burjuva olarak rahat ve tasasız varoluşunu sürdürürken giderek duyarsızlaşan bir adamın hayatındaki dönüştürücü deneyimin hikâyesidir. Sıradan bir Pazar gününü at yarışlarında geçirirken, belki de ilk kez burjuva ahlakından saparak 'suç' işler. Böylece yeniden 'hissetmeye' başladığını, kötücül ve ateşli hazları olan gerçek bir insan olduğunu fark eder. İçindeki haz dolu esrime, aynı günün akşamında onu gece âleminin son atıklarının arasına, 'hayatın en dibindeki lağımlara' sürükleyecek, varış noktası ise ruhani bir uyanış olacaktır.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0000000671636-1.jpg", 25m, "D&R" },
                    { 5, "William Golding", null, "Sineklerin Tanrısı", "Dünya klasikleri arasında gösterilen “Sineklerin Tanrısı”, William Golding’in en önemli eserleri arasında gösteriliyor. Nobel edebiyat ödülü almasıyla ise tüm dünyada büyük üne kavuşan eser, ıssız ada yaşamını bambaşka bir yönden ele alıyor. Karakter analizlerine ve davranışlara odaklanan kitap, saf ve temiz çocukların bile aslında ne kadar vahşileşebileceklerini gözler önüne seriyor. Okuyucuları, davranışlar üzerinde düşünmeye iten bu kitapla siz de hayatta kalma mücaledesine giren çocukların derinden etkileyen hikayesiyle baş başa kalacaksınız.", 2, "https://i.dr.com.tr/cache/500x400-0/originals/0000000107800-1.jpg", 25m, "D&R" },
                    { 4, "George Orwell", null, "Hayvan Çiftliği", "Fazla çalıştırılan ve kötü muamele gören hayvanlar bir gün toplanıp yaşadıkları çiftliği ele geçirirler. Sonunda söz sahibi olmuşlardır, çiftlikte daha adil ve eşit bir toplum oluşturmaya kararlıdırlar. Domuzların öncülüğünde bu yeni düzeni kurmak için çalışmaya başlarlar. Bu düzen ilk başta çiftliğin gelişmesini sağlasa da zamanla hayvanların öngöremediği sorunlar ortaya çıkacak ve eskisinden daha acımasız bir rejim kurulacaktır.", 2, "https://i.dr.com.tr/cache/500x400-0/originals/0000000105409-1.jpg", 25m, "D&R" },
                    { 3, "David Burns", null, "İyi Hissetmek", "Psikiyatri ve davranış bilimleri alanında dünya genelinde adından en çok söz ettiren bilim insanlarından Dr. David D. Burns, İyi Hissetmek adlı kitabıyla okurlarına daha mutlu bir yaşamın kapılarını aralıyor. Kaygı, suçluluk ve özgüvensizlik gibi duyguların bireyin psikolojisi üzerindeki olumsuz tesirini aşmayı amaçlayan kitap, bilimsel olarak test edilmiş tekniklerle okurlarına eşsiz bir terapi sunuyor.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0000000202710-1.jpg", 25m, "D&R" },
                    { 2, "Stephen Hawking", null, "Zamanın Kısa Tarihi", "Zamanın Kısa Tarihi 1988 yılındaki ilk basımından bu yana geçen yıllar içerisinde bilimsel yazın alanında bir başyapıt konumu kazandı. Kırk dile çevrildi ve dokuz milyonun üzerinde baskı yaparak dev bir uluslararası ün kazandı. Kitap o dönemde evrenin doğası hakkında öğrendiğimiz en son bilgiler göz önüne alınarak yazılmıştı, öte yandan o günden bu güne hem atom-altı dünyanın hem de büyük ölçekte evrenin gözlem teknolojilerinde olağanüstü ilerlemeler yaşandı. Bu yeni gözlemler Profesör Hawking’in kitabın ilk baskısında yaptığı kuramsal öngörülerin çoğunu doğrulayan nitelikteydi.Bu gözlemlere, evrenin başlangıcından 300.000 yıl sonrasını araştıran ve Hawking’in varlığını ileri sürdüğü uzayzaman dokusundaki kırışıklıkları tespit eden Kozmik Ardalan Kâşifi COBE uydusunun son bulguları da dahildir.", 2, "https://i.dr.com.tr/cache/500x400-0/originals/0000000562120-1.jpg", 25m, "D&R" },
                    { 29, "Cengiz Aytmatov", null, "Beyaz Gemi", "Masalla gerçeği birleştiren bir eserdir.Geçmişi temsil eden dede ile geleceği temsil eden çocuk arasında dramatik bir ilişki kurarak insan duygu ve düşüncelerine kendine has yorumlar getirilir.Adı eserde hiç geçmeyen çocuğun saf ve temiz dünyasından, hayatın acı ve çıplak gerçeğine uzanan bir roman kurgusu meydana çıkarılır. Aytmatov’un, edebiyat âleminde geniş akisler uyandıran, uzun yıllar tartışılan, verilmek istenen mesajla yaratılan tiplerin büyük bir uyum sağladığı eserlerinden biridir.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0000000156851-1.jpg", 25m, "D&R" },
                    { 30, "Stefan Zweig", null, "Lyon'da Düğün", "Lyon’da Düğün Fransız Devrimi sırasında yaşanan kargaşa ve zulüm günlerinde ölüme yaklaşan insanlara umut veren bir aşkın hikâyesidir. 1793’te kentte kurşuna dizilmeyi bekleyen karşı devrimcilerin toplandığı hapishane tuhaf bir nikâha sahne olur. İki Yalnız İnsan, acı çeken iki çaresiz insanı buluşturur. Birinin yüreğinden kopan çığlık diğerininkinde karşılık bulurken, farkında olmadan birbirlerinin yıllar süren yalnızlığına son verirler.", 2, "https://i.dr.com.tr/cache/600x600-0/originals/0001775354001-1.jpg", 25m, "D&R" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
