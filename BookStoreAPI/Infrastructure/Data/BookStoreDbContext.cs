using ApplicationCore.Entities;
using ApplicationCore.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData
                (
                    new Book()
                    {
                        Id = 1,
                        BookTitle = "Kendine İyi Davran Güzel İnsan",
                        Description = "Bu yolculukta, kaygılarınla baş etmek ve kafaya takmamak için hangi yöntemleri kullanabileceğini, olumsuz düşüncelerini nasıl kontrol edebileceğini, sağlıklı ilişkilerini geliştirirken sana zarar veren zehirli insanlardan kendini nasıl koruyabileceğini, hangi alanlarda mücadele etmenin anlamlı olduğunu, hangi alanlarda hayatı ve getirdiklerini kabullenmen gerektiğini, içindeki değersizlik hissini nasıl yenebileceğini ve kendini nasıl dönüştürebileceğini keşfedeceksin.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/500x400-0/originals/0001988057001-1.jpg",
                        Author = "Beyhan Budak",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 2,
                        BookTitle = "Zamanın Kısa Tarihi",
                        Description = "Zamanın Kısa Tarihi 1988 yılındaki ilk basımından bu yana geçen yıllar içerisinde bilimsel yazın alanında bir başyapıt konumu kazandı. Kırk dile çevrildi ve dokuz milyonun üzerinde baskı yaparak dev bir uluslararası ün kazandı. Kitap o dönemde evrenin doğası hakkında öğrendiğimiz en son bilgiler göz önüne alınarak yazılmıştı, öte yandan o günden bu güne hem atom-altı dünyanın hem de büyük ölçekte evrenin gözlem teknolojilerinde olağanüstü ilerlemeler yaşandı. Bu yeni gözlemler Profesör Hawking’in kitabın ilk baskısında yaptığı kuramsal öngörülerin çoğunu doğrulayan nitelikteydi.Bu gözlemlere, evrenin başlangıcından 300.000 yıl sonrasını araştıran ve Hawking’in varlığını ileri sürdüğü uzayzaman dokusundaki kırışıklıkları tespit eden Kozmik Ardalan Kâşifi COBE uydusunun son bulguları da dahildir.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/500x400-0/originals/0000000562120-1.jpg",
                        Author = "Stephen Hawking",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 3,
                        BookTitle = "İyi Hissetmek",
                        Description = "Psikiyatri ve davranış bilimleri alanında dünya genelinde adından en çok söz ettiren bilim insanlarından Dr. David D. Burns, İyi Hissetmek adlı kitabıyla okurlarına daha mutlu bir yaşamın kapılarını aralıyor. Kaygı, suçluluk ve özgüvensizlik gibi duyguların bireyin psikolojisi üzerindeki olumsuz tesirini aşmayı amaçlayan kitap, bilimsel olarak test edilmiş tekniklerle okurlarına eşsiz bir terapi sunuyor.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0000000202710-1.jpg",
                        Author = "David Burns",
                        Genre = BookTypes.Classic
                    },


                    new Book()
                    {
                        Id = 4,
                        BookTitle = "Hayvan Çiftliği",
                        Description = "Fazla çalıştırılan ve kötü muamele gören hayvanlar bir gün toplanıp yaşadıkları çiftliği ele geçirirler. Sonunda söz sahibi olmuşlardır, çiftlikte daha adil ve eşit bir toplum oluşturmaya kararlıdırlar. Domuzların öncülüğünde bu yeni düzeni kurmak için çalışmaya başlarlar. Bu düzen ilk başta çiftliğin gelişmesini sağlasa da zamanla hayvanların öngöremediği sorunlar ortaya çıkacak ve eskisinden daha acımasız bir rejim kurulacaktır.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/500x400-0/originals/0000000105409-1.jpg",
                        Author = "George Orwell",
                        Genre = BookTypes.Classic
                    },


                    new Book()
                    {
                        Id = 5,
                        BookTitle = "Sineklerin Tanrısı",
                        Description = "Dünya klasikleri arasında gösterilen “Sineklerin Tanrısı”, William Golding’in en önemli eserleri arasında gösteriliyor. Nobel edebiyat ödülü almasıyla ise tüm dünyada büyük üne kavuşan eser, ıssız ada yaşamını bambaşka bir yönden ele alıyor. Karakter analizlerine ve davranışlara odaklanan kitap, saf ve temiz çocukların bile aslında ne kadar vahşileşebileceklerini gözler önüne seriyor. Okuyucuları, davranışlar üzerinde düşünmeye iten bu kitapla siz de hayatta kalma mücaledesine giren çocukların derinden etkileyen hikayesiyle baş başa kalacaksınız.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/500x400-0/originals/0000000107800-1.jpg",
                        Author = "William Golding",
                        Genre = BookTypes.Classic
                    },


                    new Book()
                    {
                        Id = 6,
                        BookTitle = "Olağanüstü Bir Gece",
                        Description = "Olağanüstü Bir Gece, seçkin bir burjuva olarak rahat ve tasasız varoluşunu sürdürürken giderek duyarsızlaşan bir adamın hayatındaki dönüştürücü deneyimin hikâyesidir. Sıradan bir Pazar gününü at yarışlarında geçirirken, belki de ilk kez burjuva ahlakından saparak 'suç' işler. Böylece yeniden 'hissetmeye' başladığını, kötücül ve ateşli hazları olan gerçek bir insan olduğunu fark eder. İçindeki haz dolu esrime, aynı günün akşamında onu gece âleminin son atıklarının arasına, 'hayatın en dibindeki lağımlara' sürükleyecek, varış noktası ise ruhani bir uyanış olacaktır.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0000000671636-1.jpg",
                        Author = "Stefan Zweig",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 7,
                        BookTitle = "1984",
                        Description = "Distopya olarak nitelendirilen George Orwell’ın bu şahane eseri, geçmişin aslında ne kadar da gelecekten izler taşıdığını ortaya koyuyor. 1948’de kaleme aldığı bu eser ile Orwell, günümüz modern dünyasına bir protesto bırakıyor.Her ne kadar kitabında 1984 yılını tasvir etse de kitabın derinliklerinde bugünden izler de bulabilmeniz mümkün. Bu durumda elbette ki George Orwell’ın ileri görüşlülüğü etkili.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0000000064038-1.jpg",
                        Author = "George Orwell",
                        Genre = BookTypes.Classic
                    },


                    new Book()
                    {
                        Id = 8,
                        BookTitle = "Nutuk - Gençler İçin Fotoğraflarla",
                        Description = "Ey Türk geleceğinin evladı!İşte, bu durum ve koşullar içinde bile görevin, Türk bağımsızlık ve cumhuriyetini kurtarmaktır!Muhtaç olduğun güç, damarlarındaki soylu kanda mevcuttur!",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0000000325204-1.jpg",
                        Author = "Mustafa Kemal Atatürk",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 9,
                        BookTitle = "İçimdeki Müzik",
                        Description = "İngiltere'nin saygın edebiyat ödüllerinden Coratta Scott King ödüllü yazar Sharon M. Draper'dan hüzün ve umut dolu soluksuz okunacak bir roman. Gerçek bir yaşam öyküsünden ilham alınarak kaleme alınmış. 11 yaşındaki Melody'nin hastalığının adı Spastik ikili kuadripleji yani beyin felci. Yürüyemiyor, konuşamıyor,tekerlekli sandalyeye mahkum. Hiçbir uzvuna komut veremeyen bu küçük kızın beyni ise mükemmel işliyor. ",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0000000683283-1.jpg",
                        Author = "Sharon M. Draper",
                        Genre = BookTypes.Classic
                    },


                    new Book()
                    {
                        Id = 10,
                        BookTitle = "Bir Ömür Nasıl Yaşanır?",
                        Description = "Kişisel gelişim; mesleki ve sosyal anlamda farklı konumlarda yer alan her insanın tabii olarak fikir sahibi olduğu, ancak bir o kadar da fikre ihtiyaç duyulan bir alan. Bu nedenle söz konusu alanın, modern dünyada geniş bir yer edindiğini söylemek mümkün. Hayatı hakkınca ve nitelikli yaşamaya dair tavsiye alınabilecek kişilere gelindiğinde ise Türkiye’de herkesin aklına gelecek isimlerden birini tahmin etmek zor değil.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0001796150001-1.jpg",
                        Author = "İlber Ortaylı",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 11,
                        BookTitle = "Simyacı",
                        Description = "Dünya edebiyatının fenomenleri arasında yer alan Simyacı, yayımlandığı günden bugüne pek çok hayata dokunmaya devam ediyor. Brezilyalı yazar Paulo Coelho tarafından 1988 yılında yayımlanan eser, Doğu ve Batı dünyasına aynı pencereden ışık tutuyor. Coelho’nun Mesnevi’deki bir kıssadan hareketle kaleme aldığı Simyacı, macera dolu öyküsü ve felsefi yönüyle başucu kitabınız olmaya aday!",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/500x400-0/originals/0000000064552-1.jpg",
                        Author = "Paulo Coelho",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 12,
                        BookTitle = "Tanrılar Okulu",
                        Description = "İtalyan asıllı yazar ve modern çağ filozofu Prof. Stefano D’Anna, Tanrılar Okulu kitabı ile insanın kendi yaşamına dair devrim niteliğinde bir bakış açısı ortaya koyuyor. Eserinde bireyin hayata bir edilgen değil, tüm iyi ve kötü etkenlerin faili olarak bakması gerektiğini vurgulayan yazar, hikayeleştirme tekniği ile bunu oldukça etkileyici bir şekilde aktarıyor.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0000000324077-1.jpg",
                        Author = "Stefano D’Anna",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 13,
                        BookTitle = "Otomatik Portakal",
                        Description = "Teknolojik gelişmeler öyle bir boyuta ulaşmış,markete bile gitmeden evden oturduğumuz yerden ya da yurt dışından sipariş vererek alışveriş yapmaya, bankaya gitmeden evden dünyanın öbür ucuna para göndermeye, akıllı telefonu kredi kartı gibi kullanmaya kadar dijitalleşme günlük hayatımızın hemen her alanına o kadar egemen olmuştur ki, suç işleyenler de adeta bu duruma ayak uydurarak bilinen suç işleme yöntemleri yerine bambaşka yöntemler geliştirmeye başlamışlardır. ",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0001806049001-1.jpg",
                        Author = "Anthony Burgess",
                        Genre = BookTypes.Classic
                    },


                    new Book()
                    {
                        Id = 14,
                        BookTitle = "Gurur ve Önyargı ",
                        Description = " Sadece kırk iki yıllık, gözden uzak ve sade yaşantısına karşın yazdıklarıyla 'roman tarihinin ilk büyük(ve sahici) kültü' olmayı başaran bir 19. yüzyıl romancısıdır. Sayısız TV ve sinema uyarlamalarının yanısıra tüm 'satış / okunma' anketlerinin de gösterdiği üzere, yazarın 1813'de yayınlanan ikinci romanı Gurur ve Önyargı tüm zamanların en sevilen romanlarının başında gelir. Bu da, sanırız, Austen'in, dünyanın pek çok yerinde geleneklerin kadına biçtiği 'en iyi gelecek' rolüyle kadınların aşklarını seçme hakkı arasındaki gerilimi 'mizah, zeka ve sevecenlik'le yansıtmasından kaynaklanmaktadır.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0000000202083-1.jpg",
                        Author = "Jane Austen",
                        Genre = BookTypes.Classic
                    },


                    new Book()
                    {
                        Id = 15,
                        BookTitle = "Çavdar Tarlasında Çocuklar ",
                        Description = "1951 yılında basılan kitap, Salinger’in ilk ve tek romanıdır. Çıktığı andan bu yana ilgi gören roman, ergenlik dönemindeki bir çocuğun dünyayı algılayış biçimini bize anlatırken, yetişkinlerin düzenine karşı olan isyanını da başarılı bir dil ile aktarıyor. Samimi dili ve karakterin içinde bulunduğu duyguların okuyucuya olan yansıması, onu kısa sürede dünya edebiyatı listelerinde ilk sıralara taşıyor.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0000000058117-1.jpg",
                        Author = "J.D. Salinger",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 16,
                        BookTitle = "İçimizdeki Şeytan",
                        Description = "steyip istemedeğimi doğru dürüst bilmediğim, fakat neticede aleyhime çıkarsa istemediğimi iddia ettiğim bu nevi söz ve fiillerimin daimi bir mesulünü bulmuştum: Buna içimdeki şeytan diyordum, müdafaasını üzerime almaktan korktuğum bütün hareketlerimi ona yüklüyor ve kendi suratıma tüküreceğim yerde, haksızlığa, tesadüfün cilvesine uğramış bir mazlum gibi nefsimi şefkat ve ihtimama layık görüyordum. Halbuki ne şeytanı azizim, ne şeytanı? Bu bizim gururumuzun, salaklığımızın uydurması.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/500x400-0/originals/0000000058246-1.jpg",
                        Author = "Sabahattin Ali",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 17,
                        BookTitle = "Nietzsche Ağladığında",
                        Description = "Rus asıllı yazar Irvin D. Yalom’un 1992 yılında kaleme aldığı Nietzsche Ağladığında,ünlü filozofun hayatına dair derin izler taşıyor. Filozofun yaşamından bir bölüme tanıklık etmenizi sağlayacak olan eser, dönemin önemli şahsiyetlerini de hikayesine dahil ediyor.Romanın ana temasına “ümitsizlik” fikrini yerleştiren Yalom, böylece Nietzsche’nin felsefi düşüncelerine dair ipuçlarını da okuyucu ile buluşturuyor.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0000000065453-1.jpg",
                        Author = "Irvin D. Yalom",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 18,
                        BookTitle = "Ikigai",
                        Description = "Uluslararası çok satan bir rehber olan Ikigai’yle her gününüz bir anlam kazansın. Japonlar herkesin bir ikigaisi olduğuna inanır, her sabah yataktan kalkmaları için bir sebepleri vardır. İlham verici ve rahatlatıcı bu kitap sizlere kendi ikigainizi keşfetmeniz için gerekli tüm bilgileri veriyor. Aceleci davranmamanızı, hayat gayenizi keşfetmenizi, ilişkilerinizi canlandırmanızı ve kendinizi tutkularınıza adamanızı sağlıyor.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/500x400-0/originals/0001735494001-1.jpg",
                        Author = "Hector Garcia",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 19,
                        BookTitle = "Tutunamayanlar",
                        Description = "Ülkemizin en değerli yazarlarından biri olan Oğuz Atay’ın yazıldığı dönemde büyük tartışma konusu olmuş eseri Tutunamayanlar, 1972 yılında yayımlanmıştır. Eser, bilinç-akışı tekniğiyle döneme damgasını vurarak Türk Edebiyatı’nda yeni bir çağı başlatmıştır. Pek çok eleştirmen, Tutunamayanlar’ı Türk Dili’nde yazılmış en iyi eser olarak değerlendirmektedir.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/500x400-0/originals/0000000061424-1.jpg",
                        Author = "Oğuz Atay",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 20,
                        BookTitle = "Çekiç ve Gül",
                        Description = "Sıvasız duvarlı gecekonduda, pavyonda, işkembecide, oto tamirhanesinde, dükkânda, şık bir ofiste, tekkede, Millet Bahçesi’nde, adliyede, hastanede, nezarethanede, mezarlıkta ve tabii sokaklarda, cinayetlerin ve nice cürümlerin izini sürüyor Behzat Ç.. Umutsuz, serkeş, pejmürde... Bazen de olanca dehşetine tezat, “basit, tatlı ve hüzünlü” insan hikâyelerinin içinde geziyor.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0001985496001-1.jpg",
                        Author = "Emrah Serbes",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 21,
                        BookTitle = "Güzel Dünya Neredesin?",
                        Description = "Alice ve Eileen,farklı şehirlerde yaşayan,otuzlarına yaklaşan iki arkadaş.Roman yazarı Alice,flört uygulaması sayesinde bir depo işçisi olan Felix’le tanışıp yakınlaşır.Eileen ise sona eren ilişkisinin yaralarını sarmaya çabalarken bir yandan da çocukluk arkadaşı Simon’ın çekimine kapıldığını hisseder.Alice ve Eileen ilişkiler,sanat,edebiyat ve günbegün belirsizleşen gelecekleri hakkında yazışırken hem arkadaşlıklarını hem de hayata bakışlarını sorgulamaya başlarlar.Zira aşklarına,kalp kırıklıklarına,günü yaşamaya ve muhabbetlerine tepelerinden ayrılmak bilmeyen bir bulut eşlik eder.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/500x400-0/originals/0001975703001-1.jpg",
                        Author = "Sally Rooney",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 22,
                        BookTitle = "Etkili İnsanların 7 Alışkanlığı",
                        Description = "Kurumsal danışman, aile uzmanı, eğitmen ve bir liderlik otoritesi olarak uluslararası alanda kabul görmüş bir yazar olan Stephen R. Covey, Etkili İnsanların 7 Alışkanlığı kitabı ile modern yaşamda başarının anahtarını sunuyor. 1999 yılında yayımlanan ve “iş dünyasında yirminci yüzyılın en etkili kitabı” olarak anılan eser, 38 dilde 15 milyonu aşkın baskısıyla dünya genelinde büyük ilgi görmeye devam ediyor.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/500x400-0/originals/0000000061005-1.jpg",
                        Author = "Stephen R. Covey",
                        Genre = BookTypes.Classic
                    },


                    new Book()
                    {
                        Id = 23,
                        BookTitle = "Kırmızı Pazartesi",
                        Description = "Kolombiyalı büyük yazar Gabriel García Márquez'in 1981'de yayımlanan yedinci romanı Kırmızı Pazartesi, işleneceğini herkesin bildiği, engel olmak için kimsenin bir şey yapmadığı bir namus cinayetinin öyküsü. Hem Kolombiya'da, hem de yayımlandığı dünyanın dört bir yanındaki pek çok ülkede sarsıcı etkileri olmuş bir roman. Usta yazar, çocukluğunu geçirdiği kasabada yıllar önce yaşanmış bir cinayet olayını aktarıyor.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0000000064101-1.jpg",
                        Author = "Gabriel Garcia Marouez",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 24,
                        BookTitle = "Karamazov Kardeşler",
                        Description = "Dostoyevski, yaşamının son yıllarında başyapıtı Karamazov Kardeşler'i tamamladığında,Rus yazınında 'felsefe düzeyinde roman-tragedya denen türün de temelini attığının bilincinde değildi. Dostoyevski`nin yaşam birikiminin tümünü ve sanat gücünün doruğunu içeren bu roman, gerçekte insanı insan yapan ne varsa, onlara adanmış bir destan niteliğini taşır. Yazar, hiçbir romanında 'Karamazov Kardeşler'de olduğu denli insan ruhuna inmemiş, insanoğlunu bu denli kesitler biçiminde, içgüdülerinin ve istencinin tüm görünümüyle sergilenmiştir.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0000000240594-1.jpg",
                        Author = "Dostoyevski",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 25,
                        BookTitle = "Romeo ve Juliet ",
                        Description = "Oyunları ve şiirlerinde insanlık durumlarını dile getiriş gücüyle yaklaşık 400 yıldır bütün dünya okur ve seyircilerini etkilemeyi sürdüren efsanevi yazar, Romeo ve Juliet’de birbirinden farklı pek çok toplumda benzerleriyle karşılaşılan trajik bir ilişkiyi, düşman ailelerin çocukları arasında doğan aşkı ele alır. Romeo ile Juliet’in umutsuz aşkını romantik örgüsünün yarı karanlık örtüsüyle sarmalayan eser, buna rağmen insan ilişkilerini gerçekçi bir anlayışla gözler önüne serer.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/500x400-0/originals/0000000324159-1.jpg",
                        Author = "William Shakespeare",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 26,
                        BookTitle = "Yüzyıllık Yalnızlık",
                        Description = "Nobel Ödüllü Kolombiyalı Yazar Gabriel Garcia Marquez’in Yüzyıllık Yalnızlık romanı, gerçeklik kavramına kattığı olağandışı boyutla, yayımlandığı 1967’den bugüne edebiyat dünyasındaki değerini korumaya devam ediyor. Marquez’in 1982 yılında Nobel Edebiyat Ödülü’nü almasını sağlayan roman, edebiyat dünyasına yazarın kazandırdığı “büyülü gerçekçilik” akımının en ihtişamlı örneğini oluşturuyor.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0000000064137-1.jpg",
                        Author = "Gabriel Garcia Marouez",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 27,
                        BookTitle = "Fahrenheit 451",
                        Description = "Amerikan edebiyatının öne çıkan yazarlarından Ray Bradbury`nin 1953 yılında yayımlanan eseri Fahrenheit 451,on yıllar öncesinden bugünün ve uzak geleceğin dünyasına sert eleştiriler savuruyor.Distopik bir kurgusal düzlemde ilerleyen eser,teknolojinin gelişmesiyle birlikte toplumun gerileyen sanat ve düşünce dünyasını ele alıyor.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0001750151001-1.jpg",
                        Author = "Ray Bradbury",
                        Genre = BookTypes.Classic
                    },

                    new Book()
                    {
                        Id = 28,
                        BookTitle = "Puslu Kıtalar Atlası",
                        Description = "Türk edebiyatının güçlü kalemlerinden İhsan Oktay Anar, 1995’te yayımladığı Puslu Kıtalar Atlası ile 7’den 70’e geniş bir okur kitlesine ulaşmaya devam ediyor. Eserinde fantastik ve tarihi roman özelliklerini ustalıkla bir araya getiren yazar, zengin anlatımı ile okurlarına benzersiz bir deneyim sunuyor.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0000000061857-1.jpg",
                        Author = "İhsan Oktay Anar",
                        Genre = BookTypes.Classic
                    },


                    new Book()
                    {
                        Id = 29,
                        BookTitle = "Beyaz Gemi",
                        Description = "Masalla gerçeği birleştiren bir eserdir.Geçmişi temsil eden dede ile geleceği temsil eden çocuk arasında dramatik bir ilişki kurarak insan duygu ve düşüncelerine kendine has yorumlar getirilir.Adı eserde hiç geçmeyen çocuğun saf ve temiz dünyasından, hayatın acı ve çıplak gerçeğine uzanan bir roman kurgusu meydana çıkarılır. Aytmatov’un, edebiyat âleminde geniş akisler uyandıran, uzun yıllar tartışılan, verilmek istenen mesajla yaratılan tiplerin büyük bir uyum sağladığı eserlerinden biridir.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0000000156851-1.jpg",
                        Author = "Cengiz Aytmatov",
                        Genre = BookTypes.Classic
                    },


                    new Book()
                    {
                        Id = 30,
                        BookTitle = "Lyon'da Düğün",
                        Description = "Lyon’da Düğün Fransız Devrimi sırasında yaşanan kargaşa ve zulüm günlerinde ölüme yaklaşan insanlara umut veren bir aşkın hikâyesidir. 1793’te kentte kurşuna dizilmeyi bekleyen karşı devrimcilerin toplandığı hapishane tuhaf bir nikâha sahne olur. İki Yalnız İnsan, acı çeken iki çaresiz insanı buluşturur. Birinin yüreğinden kopan çığlık diğerininkinde karşılık bulurken, farkında olmadan birbirlerinin yıllar süren yalnızlığına son verirler.",
                        Price = 25m,
                        Publisher = "D&R",
                        ImagePath = "https://i.dr.com.tr/cache/600x600-0/originals/0001775354001-1.jpg",
                        Author = "Stefan Zweig",
                        Genre = BookTypes.Classic
                    }
                );




            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
