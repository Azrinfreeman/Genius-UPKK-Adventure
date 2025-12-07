using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Watermelon
{
    public class QuestionClasses : MonoBehaviour
    {
        public static QuestionClasses instance;

        void Awake()
        {
            instance = this;
        }

        [System.Serializable]
        public class Question
        {
            public string question;
            public List<string> answerButton;
            public int AnswerOnButton;

            public Question(string question, List<string> answerButton, int AnswerOnButton)
            {
                this.question = question;
                this.answerButton = answerButton;
                this.AnswerOnButton = AnswerOnButton;
            }
        }

        [System.Serializable]
        public class Levels
        {
            public List<Question> questions = new List<Question>();
        }

        public int level;
        public List<Levels> levels;

        public void SetLevel(int levelNum)
        {
            level = levelNum;
        }

        // Start is called before the first frame update
        void Start()
        {
            levels.AddRange(
                new List<Levels>
                {
                    //Akidah Tahap
                    //level 1 AKIDAH 1
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Apakah maksud Rukun Iman?",
                                new List<string>
                                {
                                    "Tiang agama",
                                    "Perkara yang wajib dipercayai",
                                    "Rukun solat",
                                },
                                1
                            ),
                            new Question(
                                "Berapa bilangan Rukun Iman?",
                                new List<string> { "Tiga", "Lima", "Enam" },
                                2
                            ),
                            new Question(
                                "Rukun Iman pertama ialah beriman kepada",
                                new List<string> { "Malaikat", "Allah", "Rasul" },
                                1
                            ),
                            new Question(
                                "Beriman kepada Allah bermaksud kita percaya bahawa Allah itu",
                                new List<string> { "Ada dan Maha Berkuasa", "Manusia", "Banyak" },
                                0
                            ),
                            new Question(
                                "Rukun Iman kedua ialah beriman kepada",
                                new List<string> { "Kitab", "Malaikat", "Rasul" },
                                1
                            ),
                            new Question(
                                "Beriman kepada malaikat bermaksud percaya bahawa malaikat",
                                new List<string>
                                {
                                    "tidak wujud",
                                    "makhluk Allah yang taat",
                                    "boleh makan dan minum",
                                },
                                1
                            ),
                            new Question(
                                "Rukun Iman ketiga ialah beriman kepada",
                                new List<string> { "Kitab", "Rasul", "Hari Akhirat" },
                                0
                            ),
                            new Question(
                                "Beriman kepada kitab bermaksud percaya kepada",
                                new List<string>
                                {
                                    "Buku sekolah",
                                    "Kitab yang diturunkan Allah",
                                    "Taurat sahaja",
                                },
                                1
                            ),
                            new Question(
                                "Rukun Iman keempat ialah beriman kepada",
                                new List<string> { "Rasul", "Syurga", "Hari Akhirat" },
                                0
                            ),
                            new Question(
                                "Rukun Iman kelima ialah beriman kepada",
                                new List<string> { "Qada' dan Qadar", "Hari Akhirat", "Syurga" },
                                1
                            ),
                            new Question(
                                "Rukun Iman keenam ialah beriman kepada",
                                new List<string> { "Qada' dan Qadar", "Syaitan", "Iman" },
                                0
                            ),
                            new Question(
                                "Dalil beriman kepada Allah terdapat dalam",
                                new List<string> { "Hadis", "Al-Quran", "Kisah Nabi" },
                                1
                            ),
                            new Question(
                                "Allah mencipta di dunia ini.",
                                new List<string>
                                {
                                    "manusia dan alam",
                                    "haiwan sahaja",
                                    "benda jahat",
                                },
                                0
                            ),
                            new Question(
                                "Tanda orang beriman kepada Allah ialah dia",
                                new List<string>
                                {
                                    "rajin beribadah",
                                    "malas solat",
                                    "suka menipu",
                                },
                                0
                            ),
                            new Question(
                                "Kita mesti yakin bahawa Allah ialah Tuhan yang",
                                new List<string> { "ramai", "satu", "dua" },
                                1
                            ),
                            new Question(
                                "Orang yang beriman kepada Allah tidak akan",
                                new List<string> { "menipu", "berzikir", "bersyukur" },
                                0
                            ),
                            new Question(
                                "Iman bermaksud percaya dengan",
                                new List<string>
                                {
                                    "lidah dan hati",
                                    "mata dan telinga",
                                    "tangan dan kaki",
                                },
                                0
                            ),
                            new Question(
                                "Allah bersifat Maha",
                                new List<string> { "Lupa", "Kuasa", "Lemah" },
                                1
                            ),
                            new Question(
                                "Kalimah Syahadah mengandungi dua",
                                new List<string> { "kalimat", "bahagian", "doa" },
                                1
                            ),
                            new Question(
                                "Bahagian pertama Syahadah ialah pengakuan kepada",
                                new List<string> { "Rasul", "Allah", "Malaikat" },
                                1
                            ),
                            new Question(
                                "Bahagian kedua Syahadah ialah pengakuan kepada",
                                new List<string>
                                {
                                    "Muhammad sebagai Rasul",
                                    "Allah sebagai Tuhan",
                                    "Malaikat",
                                },
                                0
                            ),
                            new Question(
                                "Syahadah mengajar kita supaya",
                                new List<string>
                                {
                                    "percaya kepada Allah dan Rasul",
                                    "malas solat",
                                    "tidak berzakat",
                                },
                                0
                            ),
                            new Question(
                                "Orang Islam wajib membaca kalimah Syahadah ketika",
                                new List<string> { "bermain", "masuk Islam", "tidur" },
                                1
                            ),
                            new Question(
                                "Islam bermaksud",
                                new List<string>
                                {
                                    "keamanan dan patuh kepada Allah",
                                    "kekayaan",
                                    "kuasa",
                                },
                                0
                            ),
                            new Question(
                                "Iman bermaksud",
                                new List<string>
                                {
                                    "percaya dan yakin kepada Allah",
                                    "menyerah diri kepada syaitan",
                                    "malas belajar",
                                },
                                0
                            ),
                            new Question(
                                "Islam dan Iman mesti ada bersama untuk menjadi",
                                new List<string>
                                {
                                    "umat yang sempurna",
                                    "orang kaya",
                                    "pemain bola",
                                },
                                0
                            ),
                            new Question(
                                "Hubungan Islam dan Iman seperti",
                                new List<string>
                                {
                                    "pokok dan buah",
                                    "air dan api",
                                    "langit dan laut",
                                },
                                0
                            ),
                            new Question(
                                "Asma' al-Husna bermaksud nama-nama",
                                new List<string> { "rasul", "baik Allah", "malaikat" },
                                1
                            ),
                            new Question(
                                "Bilangan Asma' al-Husna ialah",
                                new List<string> { "33", "77", "99" },
                                2
                            ),
                            new Question(
                                "Antara contoh Asma' al-Husna ialah",
                                new List<string> { "Ar-Rahman", "Zulkarnain", "Fir'aun" },
                                0
                            ),
                            new Question(
                                "Ar-Rahman bermaksud",
                                new List<string> { "Maha Pemurah", "Maha Kaya", "Maha Kuat" },
                                0
                            ),
                            new Question(
                                "Asma' al-Husna mengajar kita supaya",
                                new List<string>
                                {
                                    "meniru sifat baik Allah",
                                    "berlawan",
                                    "menipu",
                                },
                                0
                            ),
                            new Question(
                                "Allah bersifat As-Sami' bermaksud Allah Maha",
                                new List<string> { "Melihat", "Mendengar", "Mengetahui" },
                                1
                            ),
                            new Question(
                                "Allah bersifat Al-Basir bermaksud Allah Maha",
                                new List<string> { "Melihat", "Pemurah", "Berkuasa" },
                                0
                            ),
                            new Question(
                                "Tauhid bermaksud mengesakan",
                                new List<string> { "Rasul", "Allah", "Malaikat" },
                                1
                            ),
                            new Question(
                                "Tauhid terbahagi kepada bahagian.",
                                new List<string> { "dua", "tiga", "empat" },
                                1
                            ),
                            new Question(
                                "Tauhid Rububiyyah bermaksud mengesakan Allah sebagai",
                                new List<string>
                                {
                                    "Tuhan yang mencipta dan mentadbir",
                                    "Rasul",
                                    "manusia",
                                },
                                0
                            ),
                            new Question(
                                "Tauhid Uluhiyyah bermaksud hanya menyembah",
                                new List<string> { "Rasul", "Allah", "Malaikat" },
                                1
                            ),
                            new Question(
                                "Tauhid Asmaa wa Sifat bermaksud beriman dengan",
                                new List<string>
                                {
                                    "nama dan sifat Allah",
                                    "nama nabi",
                                    "kitab Allah",
                                },
                                0
                            ),
                            new Question(
                                "Dalil tauhid boleh didapati dalam",
                                new List<string> { "Al-Quran", "buku cerita", "surat khabar" },
                                0
                            ),
                            new Question(
                                "Orang yang bertauhid tidak akan selain Allah.",
                                new List<string> { "menyembah", "menyebut", "menyayangi" },
                                0
                            ),
                            new Question(
                                "Orang yang tidak bertauhid akan menjadi",
                                new List<string> { "beriman", "musyrik", "alim" },
                                1
                            ),
                            new Question(
                                "Kita mesti mempelajari tauhid supaya",
                                new List<string> { "kenal Allah", "menjadi kaya", "dipuji orang" },
                                0
                            ),
                            new Question(
                                "Allah sahaja yang layak disembah kerana Dia",
                                new List<string>
                                {
                                    "maha kuat dan berkuasa",
                                    "manusia",
                                    "malaikat",
                                },
                                0
                            ),
                            new Question(
                                "Dalil iman kepada Allah terdapat dalam surah",
                                new List<string> { "Al-Ikhlas", "Al-Fatihah", "Al-Kawthar" },
                                1
                            ),
                            new Question(
                                "Islam dan Iman membawa kita ke jalan",
                                new List<string> { "neraka", "kebaikan", "kemalasan" },
                                1
                            ),
                            new Question(
                                "Iman dalam hati akan membuat seseorang menjadi",
                                new List<string> { "penyayang dan jujur", "pemarah", "pendendam" },
                                0
                            ),
                            new Question(
                                "Asma' al-Husna menunjukkan sifat Allah yang",
                                new List<string> { "buruk", "mulia", "jahat" },
                                1
                            ),
                            new Question(
                                "Kita hendaklah berdoa menggunakan",
                                new List<string> { "Asma' al-Husna", "nama sendiri", "nama orang" },
                                0
                            ),
                            new Question(
                                "Orang Islam mesti percaya kepada semua",
                                new List<string> { "rukun iman", "rukun negara", "rukun hidup" },
                                0
                            ),
                            new Question(
                                "Beriman kepada Allah menjadikan kita",
                                new List<string>
                                {
                                    "taat dan bersyukur",
                                    "malas dan sombong",
                                    "lalai",
                                },
                                0
                            ),
                        }, //tahap 4
                    },
                    //level 2 IBADAH 1
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Sirah bermaksud cerita tentang kehidupan.",
                                new List<string> { "Nabi dan Rasul", "Malaikat", "Sahabat" },
                                0
                            ),
                            new Question(
                                "Sirah mengajar kita tentang Nabi Muhammad.",
                                new List<string> { "kesihatan", "kehidupan", "pekerjaan" },
                                1
                            ),
                            new Question(
                                "Sumber utama sirah ialah...",
                                new List<string>
                                {
                                    "al-Quran dan Hadis",
                                    "buku cerita",
                                    "surat khabar",
                                },
                                0
                            ),
                            new Question(
                                "Kita belajar sirah supaya dapat meniru Nabi Muhammad.",
                                new List<string>
                                {
                                    "meniru akhlak",
                                    "berlawan dengan",
                                    "melupakannya",
                                },
                                0
                            ),
                            new Question(
                                "Sirah membantu kita menjadi...",
                                new List<string> { "malas", "sombong", "baik" },
                                2
                            ),
                            new Question(
                                "Orang yang tidak belajar sirah akan sukar mengenal...",
                                new List<string> { "haiwan", "Nabi Muhammad", "tumbuhan" },
                                1
                            ),
                            new Question(
                                "Sirah ialah satu cara untuk kita mengetahui sejarah...",
                                new List<string> { "Islam", "negara", "dunia" },
                                0
                            ),
                            new Question(
                                "Sirah menceritakan perjuangan...",
                                new List<string> { "sahabat Nabi", "malaikat", "musuh" },
                                0
                            ),
                            new Question(
                                "Kita hendaklah membaca sirah dengan rasa...",
                                new List<string> { "marah", "bosan", "cinta kepada Nabi" },
                                2
                            ),
                            new Question(
                                "Pengajaran sirah membantu kita menjadi umat yang...",
                                new List<string> { "lemah", "kuat dan beriman", "lupa diri" },
                                1
                            ),
                            new Question(
                                "Bapa Nabi Muhammad bernama...",
                                new List<string> { "Abu Talib", "Abdullah", "Abdul Muttalib" },
                                1
                            ),
                            new Question(
                                "Ibu Nabi Muhammad bernama...",
                                new List<string> { "Fatimah", "Aminah", "Khadijah" },
                                1
                            ),
                            new Question(
                                "Datuk Nabi Muhammad bernama...",
                                new List<string> { "Abu Talib", "Abdul Muttalib", "Hamzah" },
                                1
                            ),
                            new Question(
                                "Nama penuh Nabi Muhammad ialah Muhammad bin...",
                                new List<string> { "Abu Talib", "Abdullah", "Abu Bakar" },
                                1
                            ),
                            new Question(
                                "Nabi Muhammad berasal daripada bangsa...",
                                new List<string> { "Quraisy", "Rom", "Parsi" },
                                0
                            ),
                            new Question(
                                "Nabi Muhammad keturunan Nabi...",
                                new List<string> { "Isa", "Ibrahim", "Musa" },
                                1
                            ),
                            new Question(
                                "Nabi Muhammad digelar Al-Amin kerana...",
                                new List<string>
                                {
                                    "suka bergurau",
                                    "bersikap jujur dan amanah",
                                    "kuat makan",
                                },
                                1
                            ),
                            new Question(
                                "Ibu Nabi Muhammad wafat ketika Baginda masih...",
                                new List<string> { "bayi", "remaja", "dewasa" },
                                0
                            ),
                            new Question(
                                "Selepas ibu dan bapa wafat, Nabi dijaga oleh...",
                                new List<string> { "sahabat", "datuk", "jiran" },
                                1
                            ),
                            new Question(
                                "Selepas datuk wafat, Nabi dijaga oleh...",
                                new List<string> { "Abu Talib", "Umar", "Bilal" },
                                0
                            ),
                            new Question(
                                "Nabi Muhammad ialah... terakhir.",
                                new List<string> { "rasul", "malaikat", "sahabat" },
                                0
                            ),
                            new Question(
                                "Nabi Muhammad diutuskan kepada...",
                                new List<string>
                                {
                                    "kaum Arab sahaja",
                                    "semua manusia",
                                    "orang Quraisy sahaja",
                                },
                                1
                            ),
                            new Question(
                                "Tentera bergajah datang untuk... Kaabah.",
                                new List<string> { "membina", "memusnahkan", "membersihkan" },
                                1
                            ),
                            new Question(
                                "Pemimpin tentera bergajah ialah...",
                                new List<string> { "Abrahah", "Abu Jahal", "Hamzah" },
                                0
                            ),
                            new Question(
                                "Allah menghantar burung... untuk melawan tentera bergajah.",
                                new List<string> { "merpati", "ababil", "gagak" },
                                1
                            ),
                            new Question(
                                "Burung-burung itu membawa...",
                                new List<string> { "batu", "makanan", "surat" },
                                0
                            ),
                            new Question(
                                "Peristiwa tentera bergajah berlaku pada tahun...",
                                new List<string> { "tahun gajah", "tahun unta", "tahun harimau" },
                                0
                            ),
                            new Question(
                                "Bapa Nabi Muhammad meninggal dunia di...",
                                new List<string> { "Makkah", "Madinah", "Syam" },
                                2
                            ),
                            new Question(
                                "Bapa Nabi wafat sebelum Nabi...",
                                new List<string> { "lahir", "berkahwin", "berhijrah" },
                                0
                            ),
                            new Question(
                                "Ibu Nabi bernama Aminah binti...",
                                new List<string> { "Wahab", "Umar", "Ali" },
                                0
                            ),
                            new Question(
                                "Datuk Nabi ialah seorang yang...",
                                new List<string> { "pemarah", "penyayang dan mulia", "sombong" },
                                1
                            ),
                            new Question(
                                "Peristiwa tentera bergajah menunjukkan Allah itu...",
                                new List<string> { "lemah", "Maha Kuasa", "lupa" },
                                1
                            ),
                            new Question(
                                "Allah melindungi Kaabah daripada...",
                                new List<string> { "manusia", "tentera bergajah", "burung" },
                                1
                            ),
                            new Question(
                                "Peristiwa itu berlaku sebelum Nabi Muhammad...",
                                new List<string> { "lahir", "berkahwin", "berhijrah" },
                                0
                            ),
                            new Question(
                                "Nabi Muhammad lahir di...",
                                new List<string> { "Makkah", "Madinah", "Taif" },
                                0
                            ),
                            new Question(
                                "Masa kelahiran Nabi ialah pada waktu...",
                                new List<string> { "pagi", "siang", "malam" },
                                2
                            ),
                            new Question(
                                "Nabi lahir pada hari...",
                                new List<string> { "Isnin", "Jumaat", "Sabtu" },
                                0
                            ),
                            new Question(
                                "Tahun kelahiran Nabi dikenali sebagai...",
                                new List<string> { "tahun unta", "tahun gajah", "tahun hijrah" },
                                1
                            ),
                            new Question(
                                "Kelahiran Nabi membawa rahmat kepada...",
                                new List<string>
                                {
                                    "umat Islam sahaja",
                                    "seluruh alam",
                                    "bangsa Arab sahaja",
                                },
                                1
                            ),
                            new Question(
                                "Nama Nabi diberikan oleh...",
                                new List<string> { "ibunya", "datuknya", "sahabat" },
                                1
                            ),
                            new Question(
                                "Nabi Muhammad disusukan oleh...",
                                new List<string> { "Halimah As-Sa'diyah", "Aminah", "Fatimah" },
                                0
                            ),
                            new Question(
                                "Kelahiran Nabi disambut dengan penuh...",
                                new List<string> { "gembira", "sedih", "marah" },
                                0
                            ),
                            new Question(
                                "Nabi Muhammad lahir dalam keadaan...",
                                new List<string> { "bersih dan suci", "sakit", "menangis kuat" },
                                0
                            ),
                            new Question(
                                "Datuk Nabi sangat... apabila Nabi lahir.",
                                new List<string> { "sedih", "gembira", "takut" },
                                1
                            ),
                            new Question(
                                "Kelahiran Nabi Muhammad menunjukkan kasih sayang... kepada manusia.",
                                new List<string> { "malaikat", "Allah", "ibu" },
                                1
                            ),
                            new Question(
                                "Nabi lahir untuk membawa... kepada manusia.",
                                new List<string> { "kesesatan", "kebenaran", "kesusahan" },
                                1
                            ),
                            new Question(
                                "Umat Islam patut bersyukur atas... Nabi Muhammad.",
                                new List<string> { "kematian", "kelahiran", "hijrah" },
                                1
                            ),
                            new Question(
                                "Nabi ialah contoh... bagi seluruh manusia.",
                                new List<string> { "buruk", "terbaik", "biasa" },
                                1
                            ),
                            new Question(
                                "Kelahiran Nabi berlaku selepas peristiwa...",
                                new List<string> { "Isra' Mikraj", "tentera bergajah", "hijrah" },
                                1
                            ),
                            new Question(
                                "Kita mesti mencintai Nabi dengan cara...",
                                new List<string>
                                {
                                    "meniru akhlaknya",
                                    "melupakannya",
                                    "membencinya",
                                },
                                0
                            ),

                            ///tahapo 2
                        },
                    },
                    //level 3 Sirah Tahap 1
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Sirah bermaksud cerita tentang kehidupan",
                                new List<string> { "Nabi dan Rasul", "Malaikat", "Sahabat" },
                                0
                            ),
                            new Question(
                                "Sirah mengajar kita tentang Nabi Muhammad",
                                new List<string> { "kesihatan", "kehidupan", "pekerjaan" },
                                1
                            ),
                            new Question(
                                "Sumber utama sirah ialah",
                                new List<string>
                                {
                                    "al-Quran dan Hadis",
                                    "buku cerita",
                                    "surat khabar",
                                },
                                0
                            ),
                            new Question(
                                "Kita belajar sirah supaya dapat Nabi Muhammad",
                                new List<string>
                                {
                                    "meniru akhlak",
                                    "berlawan dengan",
                                    "melupakannya",
                                },
                                0
                            ),
                            new Question(
                                "Sirah membantu kita menjadi",
                                new List<string> { "malas", "sombong", "baik" },
                                2
                            ),
                            new Question(
                                "Orang yang tidak belajar sirah akan sukar mengenal",
                                new List<string> { "haiwan", "Nabi Muhammad", "tumbuhan" },
                                1
                            ),
                            new Question(
                                "Sirah ialah satu cara untuk kita mengetahui sejarah",
                                new List<string> { "Islam", "negara", "dunia" },
                                0
                            ),
                            new Question(
                                "Sirah menceritakan perjuangan",
                                new List<string> { "sahabat Nabi", "malaikat", "musuh" },
                                0
                            ),
                            new Question(
                                "Kita hendaklah membaca sirah dengan rasa",
                                new List<string> { "marah", "bosan", "cinta kepada Nabi" },
                                2
                            ),
                            new Question(
                                "Pengajaran sirah membantu kita menjadi umat yang",
                                new List<string> { "lemah", "kuat dan beriman", "lupa diri" },
                                1
                            ),
                            new Question(
                                "Bapa Nabi Muhammad bernama",
                                new List<string> { "Abu Talib", "Abdullah", "Abdul Muttalib" },
                                1
                            ),
                            new Question(
                                "Ibu Nabi Muhammad bernama",
                                new List<string> { "Fatimah", "Aminah", "Khadijah" },
                                1
                            ),
                            new Question(
                                "Datuk Nabi Muhammad bernama",
                                new List<string> { "Abu Talib", "Abdul Muttalib", "Hamzah" },
                                1
                            ),
                            new Question(
                                "Nama penuh Nabi Muhammad ialah Muhammad bin",
                                new List<string> { "Abu Talib", "Abdullah", "Abu Bakar" },
                                1
                            ),
                            new Question(
                                "Nabi Muhammad berasal daripada bangsa",
                                new List<string> { "Quraisy", "Rom", "Parsi" },
                                0
                            ),
                            new Question(
                                "Nabi Muhammad keturunan Nabi",
                                new List<string> { "Isa", "Ibrahim", "Musa" },
                                1
                            ),
                            new Question(
                                "Nabi Muhammad digelar Al-Amin kerana",
                                new List<string>
                                {
                                    "suka bergurau",
                                    "bersikap jujur dan amanah",
                                    "kuat makan",
                                },
                                1
                            ),
                            new Question(
                                "Ibu Nabi Muhammad wafat ketika Baginda masih",
                                new List<string> { "bayi", "remaja", "dewasa" },
                                0
                            ),
                            new Question(
                                "Selepas ibu dan bapa wafat, Nabi dijaga oleh",
                                new List<string> { "sahabat", "datuk", "jiran" },
                                1
                            ),
                            new Question(
                                "Selepas datuk wafat, Nabi dijaga oleh",
                                new List<string> { "Abu Talib", "Umar", "Bilal" },
                                0
                            ),
                            new Question(
                                "Nabi Muhammad ialah terakhir.",
                                new List<string> { "rasul", "malaikat", "sahabat" },
                                0
                            ),
                            new Question(
                                "Nabi Muhammad diutuskan kepada",
                                new List<string>
                                {
                                    "kaum Arab sahaja",
                                    "semua manusia",
                                    "orang Quraisy sahaja",
                                },
                                1
                            ),
                            new Question(
                                "Tentera bergajah datang untuk Kaabah.",
                                new List<string> { "membina", "memusnahkan", "membersihkan" },
                                1
                            ),
                            new Question(
                                "Pemimpin tentera bergajah ialah",
                                new List<string> { "Abrahah", "Abu Jahal", "Hamzah" },
                                0
                            ),
                            new Question(
                                "Allah menghantar burung untuk melawan tentera bergajah.",
                                new List<string> { "merpati", "ababil", "gagak" },
                                1
                            ),
                            new Question(
                                "Burung-burung itu membawa",
                                new List<string> { "batu", "makanan", "surat" },
                                0
                            ),
                            new Question(
                                "Peristiwa tentera bergajah berlaku pada tahun",
                                new List<string> { "tahun gajah", "tahun unta", "tahun harimau" },
                                0
                            ),
                            new Question(
                                "Bapa Nabi Muhammad meninggal dunia di",
                                new List<string> { "Makkah", "Madinah", "Syam" },
                                2
                            ),
                            new Question(
                                "Bapa Nabi wafat sebelum Nabi",
                                new List<string> { "lahir", "berkahwin", "berhijrah" },
                                0
                            ),
                            new Question(
                                "Ibu Nabi bernama Aminah binti",
                                new List<string> { "Wahab", "Umar", "Ali" },
                                0
                            ),
                            new Question(
                                "Datuk Nabi ialah seorang yang",
                                new List<string> { "pemarah", "penyayang dan mulia", "sombong" },
                                1
                            ),
                            new Question(
                                "Peristiwa tentera bergajah menunjukkan Allah itu",
                                new List<string> { "lemah", "Maha Kuasa", "lupa" },
                                1
                            ),
                            new Question(
                                "Allah melindungi Kaabah daripada",
                                new List<string> { "manusia", "tentera bergajah", "burung" },
                                1
                            ),
                            new Question(
                                "Peristiwa itu berlaku sebelum Nabi Muhammad",
                                new List<string> { "lahir", "berkahwin", "berhijrah" },
                                0
                            ),
                            new Question(
                                "Nabi Muhammad lahir di",
                                new List<string> { "Makkah", "Madinah", "Taif" },
                                0
                            ),
                            new Question(
                                "Masa kelahiran Nabi ialah pada waktu",
                                new List<string> { "pagi", "siang", "malam" },
                                2
                            ),
                            new Question(
                                "Nabi lahir pada hari",
                                new List<string> { "Isnin", "Jumaat", "Sabtu" },
                                0
                            ),
                            new Question(
                                "Tahun kelahiran Nabi dikenali sebagai",
                                new List<string> { "tahun unta", "tahun gajah", "tahun hijrah" },
                                1
                            ),
                            new Question(
                                "Kelahiran Nabi membawa rahmat kepada",
                                new List<string>
                                {
                                    "umat Islam sahaja",
                                    "seluruh alam",
                                    "bangsa Arab sahaja",
                                },
                                1
                            ),
                            new Question(
                                "Nama Nabi diberikan oleh",
                                new List<string> { "ibunya", "datuknya", "sahabat" },
                                1
                            ),
                            new Question(
                                "Nabi Muhammad disusukan oleh",
                                new List<string> { "Halimah As-Sa'diyah", "Aminah", "Fatimah" },
                                0
                            ),
                            new Question(
                                "Kelahiran Nabi disambut dengan penuh",
                                new List<string> { "gembira", "sedih", "marah" },
                                0
                            ),
                            new Question(
                                "Nabi Muhammad lahir dalam keadaan",
                                new List<string> { "bersih dan suci", "sakit", "menangis kuat" },
                                0
                            ),
                            new Question(
                                "Datuk Nabi sangat apabila Nabi lahir.",
                                new List<string> { "sedih", "gembira", "takut" },
                                1
                            ),
                            new Question(
                                "Kelahiran Nabi Muhammad menunjukkan kasih sayang kepada manusia.",
                                new List<string> { "malaikat", "Allah", "ibu" },
                                1
                            ),
                            new Question(
                                "Nabi lahir untuk membawa kepada manusia.",
                                new List<string> { "kesesatan", "kebenaran", "kesusahan" },
                                1
                            ),
                            new Question(
                                "Umat Islam patut bersyukur atas Nabi Muhammad",
                                new List<string> { "kematian", "kelahiran", "hijrah" },
                                1
                            ),
                            new Question(
                                "Nabi ialah contoh bagi seluruh manusia.",
                                new List<string> { "buruk", "terbaik", "biasa" },
                                1
                            ),
                            new Question(
                                "Kelahiran Nabi berlaku selepas peristiwa",
                                new List<string> { "Isra' Mikraj", "tentera bergajah", "hijrah" },
                                1
                            ),
                            new Question(
                                "Kita mesti mencintai Nabi dengan cara",
                                new List<string>
                                {
                                    "meniru akhlaknya",
                                    "melupakannya",
                                    "membencinya",
                                },
                                0
                            ),

                            ///tahapo 2
                        },
                    },
                    //level adab tahap 1
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Apakah maksud adab dengan Allah?",
                                new List<string>
                                {
                                    "Perbuatan yang sopan terhadap Allah",
                                    "Berbuat jahat kepada Allah",
                                    "Melupakan Allah",
                                },
                                0
                            ),
                            new Question(
                                "Hukum beradab dengan Allah ialah",
                                new List<string> { "Wajib", "Sunat", "Makruh" },
                                0
                            ),
                            new Question(
                                "Kita hendaklah sentiasa kepada Allah.",
                                new List<string> { "Taat", "Melawan", "Bermalas-malasan" },
                                0
                            ),
                            new Question(
                                "Contoh adab dengan Allah ialah",
                                new List<string> { "Menunaikan solat", "Bergaduh", "Menipu" },
                                0
                            ),
                            new Question(
                                "Apabila kita berdoa, kita hendaklah",
                                new List<string>
                                {
                                    "Rendah diri dan bersopan",
                                    "Marah-marah",
                                    "Bercakap kuat",
                                },
                                0
                            ),
                            new Question(
                                "Hikmah beradab dengan Allah ialah Allah akan",
                                new List<string>
                                {
                                    "Menyayangi kita",
                                    "Memarahi kita",
                                    "Menjauhkan kita",
                                },
                                0
                            ),
                            new Question(
                                "Kita menunjukkan adab kepada Allah dengan",
                                new List<string>
                                {
                                    "Bersyukur atas nikmat-Nya",
                                    "Mengabaikan perintah-Nya",
                                    "Melanggar hukum",
                                },
                                0
                            ),
                            new Question(
                                "Kita hendaklah kepada ajaran Islam.",
                                new List<string> { "Mengikut", "Menolak", "Menentang" },
                                0
                            ),
                            new Question(
                                "Akibat tidak beradab dengan Allah ialah",
                                new List<string>
                                {
                                    "Dibenci dan berdosa",
                                    "Disayangi semua orang",
                                    "Dapat pahala",
                                },
                                0
                            ),
                            new Question(
                                "Orang yang beradab dengan Allah akan mendapat",
                                new List<string>
                                {
                                    "Pahala dan keberkatan",
                                    "Kesedihan",
                                    "Hukuman",
                                },
                                0
                            ),
                            new Question(
                                "Adab dengan ibu bapa bermaksud",
                                new List<string>
                                {
                                    "Hormati dan taati ibu bapa",
                                    "Melawan ibu bapa",
                                    "Abaikan mereka",
                                },
                                0
                            ),
                            new Question(
                                "Hukum beradab dengan ibu bapa ialah",
                                new List<string> { "Wajib", "Harus", "Sunat" },
                                0
                            ),
                            new Question(
                                "Kita hendaklah mendengar nasihat",
                                new List<string> { "Ibu bapa", "Kawan", "Orang asing" },
                                0
                            ),
                            new Question(
                                "Contoh adab dengan ibu bapa ialah",
                                new List<string>
                                {
                                    "Membantu dan menghormati mereka",
                                    "Meninggikan suara",
                                    "Meninggalkan rumah",
                                },
                                0
                            ),
                            new Question(
                                "Kita tidak boleh kepada ibu bapa.",
                                new List<string>
                                {
                                    "Meninggikan suara",
                                    "Menyapu rumah",
                                    "Membantu mereka",
                                },
                                0
                            ),
                            new Question(
                                "Hikmah beradab dengan ibu bapa ialah",
                                new List<string>
                                {
                                    "Dikasihi Allah dan ibu bapa",
                                    "Dihukum",
                                    "Dibenci",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beradab dengan ibu bapa ialah",
                                new List<string>
                                {
                                    "Berdosa dan dibenci",
                                    "Dikasihi orang",
                                    "Dapat pahala",
                                },
                                0
                            ),
                            new Question(
                                "Kita hendaklah bercakap dengan ibu bapa dengan suara yang",
                                new List<string> { "Lembut dan sopan", "Kuat", "Kasar" },
                                0
                            ),
                            new Question(
                                "Ibu bapa perlu dihormati kerana mereka",
                                new List<string> { "Berjasa kepada kita", "Orang jauh", "Guru" },
                                0
                            ),
                            new Question(
                                "Kita boleh berdoa kepada Allah supaya ibu bapa kita.",
                                new List<string> { "Mengasihi", "Menghukum", "Menegur" },
                                0
                            ),
                            new Question(
                                "Keluarga ialah",
                                new List<string>
                                {
                                    "Orang yang tinggal bersama kita",
                                    "Orang asing",
                                    "Kawan sekolah",
                                },
                                0
                            ),
                            new Question(
                                "Ahli keluarga terdiri daripada",
                                new List<string>
                                {
                                    "Ibu bapa dan adik-beradik",
                                    "Orang jauh",
                                    "Guru",
                                },
                                0
                            ),
                            new Question(
                                "Kita hendaklah menghormati",
                                new List<string>
                                {
                                    "Ahli keluarga",
                                    "Orang tidak dikenali",
                                    "Haiwan",
                                },
                                0
                            ),
                            new Question(
                                "Mahram ialah",
                                new List<string>
                                {
                                    "Orang yang haram dikahwini",
                                    "Orang luar",
                                    "Kawan",
                                },
                                0
                            ),
                            new Question(
                                "Bukan mahram ialah",
                                new List<string>
                                {
                                    "Orang yang boleh dikahwini",
                                    "Orang sebilik",
                                    "Adik kandung",
                                },
                                0
                            ),
                            new Question(
                                "Kita hendaklah bergaul dengan keluarga secara",
                                new List<string> { "Sopan dan hormat", "Kasar", "Bising" },
                                0
                            ),
                            new Question(
                                "Kita mesti menolong ahli keluarga yang",
                                new List<string> { "Sakit", "Malas", "Jahat" },
                                0
                            ),
                            new Question(
                                "Kita hendaklah apabila bercakap dengan keluarga.",
                                new List<string>
                                {
                                    "Menggunakan kata yang baik",
                                    "Meninggikan suara",
                                    "Ketawa kuat",
                                },
                                0
                            ),
                            new Question(
                                "Ahli keluarga mesti hidup dalam keadaan",
                                new List<string>
                                {
                                    "Harmoni dan kasih sayang",
                                    "Bergaduh",
                                    "Berjauhan",
                                },
                                0
                            ),
                            new Question(
                                "Kepentingan beradab dengan keluarga ialah dapat hidup",
                                new List<string> { "Bahagia dan disayangi", "Sedih", "Bosan" },
                                0
                            ),
                            new Question(
                                "Kita mesti mengamalkan adab supaya",
                                new List<string> { "Dikasihi Allah", "Dihukum", "Dibenci guru" },
                                0
                            ),
                            new Question(
                                "Akibat tidak beradab dengan keluarga ialah",
                                new List<string>
                                {
                                    "Hidup tidak bahagia",
                                    "Dikasihi semua orang",
                                    "Dapat ganjaran",
                                },
                                0
                            ),
                            new Question(
                                "Kita hendaklah menghormati semua ahli keluarga",
                                new List<string>
                                {
                                    "Tanpa mengira umur",
                                    "Yang kaya sahaja",
                                    "Yang muda sahaja",
                                },
                                0
                            ),
                            new Question(
                                "Keluarga yang bahagia hidup dengan penuh",
                                new List<string>
                                {
                                    "Kasih sayang dan tolong-menolong",
                                    "Kemarahan",
                                    "Permusuhan",
                                },
                                0
                            ),
                            new Question(
                                "Cara mewujudkan keluarga bahagia ialah dengan",
                                new List<string>
                                {
                                    "Bertolak ansur dan saling membantu",
                                    "Bergaduh",
                                    "Menyalahkan",
                                },
                                0
                            ),
                            new Question(
                                "Adab bercakap dengan keluarga ialah dengan suara yang",
                                new List<string> { "Lembut dan sopan", "Kuat dan marah", "Kasar" },
                                0
                            ),
                            new Question(
                                "Kita hendaklah menziarahi",
                                new List<string>
                                {
                                    "Saudara-mara",
                                    "Orang jahat",
                                    "Orang tidak dikenali",
                                },
                                0
                            ),
                            new Question(
                                "Kita mesti bersyukur kepada Allah atas",
                                new List<string> { "Nikmat keluarga", "Kesedihan", "Kemarahan" },
                                0
                            ),
                            new Question(
                                "Kita hendaklah sentiasa ibu bapa dan keluarga.",
                                new List<string>
                                {
                                    "Mendoakan mereka",
                                    "Memarahi mereka",
                                    "Menengking mereka",
                                },
                                0
                            ),
                            new Question(
                                "Kita mesti taat kepada perintah",
                                new List<string> { "Allah dan ibu bapa", "Kawan", "Guru" },
                                0
                            ),
                            new Question(
                                "Allah suka kepada anak yang kepada ibu bapa.",
                                new List<string> { "Patuh dan taat", "Derhaka", "Marah" },
                                0
                            ),
                            new Question(
                                "Adab berdoa kepada Allah ialah dengan",
                                new List<string>
                                {
                                    "Rendah diri dan sopan",
                                    "Ketawa",
                                    "Menangis kuat",
                                },
                                0
                            ),
                            new Question(
                                "Kita mesti beriman dan kepada Allah.",
                                new List<string> { "Bersyukur", "Melawan", "Marah" },
                                0
                            ),
                            new Question(
                                "Contoh tidak beradab dengan Allah ialah",
                                new List<string> { "Meninggalkan solat", "Berzikir", "Berdoa" },
                                0
                            ),
                            new Question(
                                "Kita hendaklah kepada ajaran Islam.",
                                new List<string> { "Taat", "Menolak", "Melawan" },
                                0
                            ),
                            new Question(
                                "Allah akan sayang kepada orang yang",
                                new List<string> { "Beradab dan patuh", "Derhaka", "Lalai" },
                                0
                            ),
                            new Question(
                                "Adab ialah",
                                new List<string>
                                {
                                    "Perangai yang baik dan sopan",
                                    "Sikap jahat",
                                    "Keras hati",
                                },
                                0
                            ),
                            new Question(
                                "Anak yang baik akan sentiasa ibu bapa.",
                                new List<string> { "Menghormati", "Menengking", "Melawan" },
                                0
                            ),
                            new Question(
                                "Hikmah beradab dengan keluarga ialah",
                                new List<string>
                                {
                                    "Disayangi Allah dan manusia",
                                    "Dibenci orang",
                                    "Dihukum",
                                },
                                0
                            ),
                            new Question(
                                "Allah suka orang yang",
                                new List<string> { "Beradab dan sopan", "Pemarah", "Derhaka" },
                                0
                            ),

                            ///tahapo 2
                        },
                    },
                    //level AKIDAH TAHAP 2
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Malaikat ialah makhluk Allah yang dicipta daripada ...",
                                new List<string> { "Air", "Cahaya", "Tanah" },
                                1
                            ),
                            new Question(
                                "Malaikat bersifat ...",
                                new List<string>
                                {
                                    "Tidak pernah ingkar",
                                    "Pemarah",
                                    "Tidur waktu malam",
                                },
                                0
                            ),
                            new Question(
                                "Malaikat tidak mempunyai ...",
                                new List<string> { "Sayap", "Jantina", "Tugas" },
                                1
                            ),
                            new Question(
                                "Tugas Malaikat Mikail ialah memberi ...",
                                new List<string> { "Rezeki", "Wahyu", "Ilmu" },
                                0
                            ),
                            new Question(
                                "Malaikat yang menjaga syurga ialah ...",
                                new List<string> { "Malik", "Ridwan", "Atid" },
                                1
                            ),
                            new Question(
                                "Malaikat mencatat amalan manusia supaya ...",
                                new List<string>
                                {
                                    "Manusia boleh meniru",
                                    "Dijadikan rekod amalan",
                                    "Malaikat bosan",
                                },
                                1
                            ),
                            new Question(
                                "Malaikat tidak makan dan minum kerana ...",
                                new List<string>
                                {
                                    "Mereka malas",
                                    "Mereka daripada cahaya",
                                    "Mereka lapar sentiasa",
                                },
                                1
                            ),
                            new Question(
                                "Malaikat Atid mencatat ...",
                                new List<string> { "Perbuatan jahat", "Perbuatan baik", "Rezeki" },
                                0
                            ),
                            new Question(
                                "Malaikat yang meniup sangkakala pada hari kiamat ialah ...",
                                new List<string> { "Izrail", "Israfil", "Mikail" },
                                1
                            ),
                            new Question(
                                "Mengapa manusia perlu berbuat baik?",
                                new List<string>
                                {
                                    "Kerana ditonton malaikat",
                                    "Kerana takutkan manusia",
                                    "Kerana ingin sombong",
                                },
                                0
                            ),
                            new Question(
                                "Beriman kepada malaikat menambahkan ...",
                                new List<string>
                                {
                                    "Iman dan ketaatan",
                                    "Malas beribadah",
                                    "Sifat marah",
                                },
                                0
                            ),
                            new Question(
                                "Siapakah ketua segala malaikat?",
                                new List<string> { "Mikail", "Jibril", "Malik" },
                                1
                            ),
                            new Question(
                                "Rasul ialah manusia yang ...",
                                new List<string>
                                {
                                    "Lahir di istana",
                                    "Diutus oleh Allah",
                                    "Sangat kaya",
                                },
                                1
                            ),
                            new Question(
                                "Rasul dipilih oleh ...",
                                new List<string> { "Malaikat", "Manusia", "Allah" },
                                2
                            ),
                            new Question(
                                "Salah satu sifat wajib rasul ialah ...",
                                new List<string> { "Berbohong", "Amanah", "Pemalas" },
                                1
                            ),
                            new Question(
                                "Contoh nabi dan rasul yang wajib diketahui ialah ...",
                                new List<string> { "Abu Lahab", "Nabi Nuh", "Qarun" },
                                1
                            ),
                            new Question(
                                "Rasul membawa ajaran ...",
                                new List<string> { "Sihir", "Kebaikan", "Tengkarah" },
                                1
                            ),
                            new Question(
                                "Mengapa manusia perlu mengikuti ajaran rasul?",
                                new List<string>
                                {
                                    "Supaya hidup mengikut petunjuk Allah",
                                    "Untuk meraih populariti",
                                    "Untuk jadi kaya",
                                },
                                0
                            ),
                            new Question(
                                "Ajaran rasul mengajar manusia supaya ...",
                                new List<string>
                                {
                                    "Menyembah Allah",
                                    "Menyembah matahari",
                                    "Menghina orang lain",
                                },
                                0
                            ),
                            new Question(
                                "Rasul mengajak manusia ke arah ...",
                                new List<string> { "Kejahatan", "Kebaikan", "Perbalahan" },
                                1
                            ),
                            new Question(
                                "Sifat wajib Allah ialah sifat yang ...",
                                new List<string>
                                {
                                    "Mustahil",
                                    "Pasti ada pada Allah",
                                    "Milik malaikat",
                                },
                                1
                            ),
                            new Question(
                                "Sifat Qiyamuhu Binafsih bermaksud ...",
                                new List<string>
                                {
                                    "Allah berdiri sendiri, tidak bergantung kepada sesiapa",
                                    "Allah perlukan makhluk",
                                    "Allah lemah",
                                },
                                0
                            ),
                            new Question(
                                "Allah Maha Mengetahui disebut ...",
                                new List<string> { "Ilmu", "Qudrat", "Hayat" },
                                0
                            ),
                            new Question(
                                "Allah Maha Berkuasa disebut ...",
                                new List<string> { "Iradat", "Qudrat", "Basar" },
                                1
                            ),
                            new Question(
                                "Allah Maha Hidup disebut ...",
                                new List<string> { "Hayat", "Sama'", "Basar" },
                                0
                            ),
                            new Question(
                                "Allah tidak sama dengan makhluk disebut sifat ...",
                                new List<string> { "Baqa'", "Mukhalafatu lil hawadith", "Qidam" },
                                1
                            ),
                            new Question(
                                "Allah bercakap tanpa suara disebut ...",
                                new List<string> { "Ilmu", "Kalam", "Basar" },
                                1
                            ),
                            new Question(
                                "Allah mendengar segala-galanya ialah sifat ...",
                                new List<string> { "Sama'", "Basar", "Qiyam" },
                                0
                            ),
                            new Question(
                                "Allah melihat semua perkara ialah sifat ...",
                                new List<string> { "Qudrat", "Ilmu", "Basar" },
                                2
                            ),
                            new Question(
                                "Sifat Salbiah ialah sifat yang ...",
                                new List<string>
                                {
                                    "Menolak kekurangan",
                                    "Menambah kekurangan",
                                    "Milik makhluk",
                                },
                                0
                            ),
                            new Question(
                                "Contoh penghayatan sifat Allah ialah ...",
                                new List<string> { "Menjadi amanah", "Menipu", "Bermalas-malasan" },
                                0
                            ),
                            new Question(
                                "Allah memiliki sifat sempurna kerana ...",
                                new List<string>
                                {
                                    "Allah Maha Berkuasa",
                                    "Allah seperti makhluk",
                                    "Allah perlukan bantuan",
                                },
                                0
                            ),
                            new Question(
                                "Sifat Ma'nawiyyah ialah ...",
                                new List<string>
                                {
                                    "Sifat yang melengkapkan sifat Ma'ani",
                                    "Sifat bebas tugas",
                                    "Sifat makhluk",
                                },
                                0
                            ),
                            new Question(
                                "Wujud bermaksud Allah ...",
                                new List<string>
                                {
                                    "Tidak wujud",
                                    "Wujud tanpa pencipta",
                                    "Wujud seperti manusia",
                                },
                                1
                            ),
                            new Question(
                                "Manusia percaya kepada Wujud Allah kerana ...",
                                new List<string>
                                {
                                    "Alam ini ada Pencipta",
                                    "Alam terjadi sendiri",
                                    "Alam tidak wujud",
                                },
                                0
                            ),
                            new Question(
                                "Qidam bermaksud Allah ...",
                                new List<string>
                                {
                                    "Ada permulaan",
                                    "Tidak bermula",
                                    "Baru diciptakan",
                                },
                                1
                            ),
                            new Question(
                                "Alam yang teratur membuktikan Allah ...",
                                new List<string> { "Lemah", "Qidam dan berkuasa", "Tiada" },
                                1
                            ),
                            new Question(
                                "Baqa' bermaksud Allah ...",
                                new List<string> { "Kekal", "Akan mati", "Tua" },
                                0
                            ),
                            new Question(
                                "Beriman bahawa Allah kekal menjadikan kita ...",
                                new List<string>
                                {
                                    "Gelisah",
                                    "Yakin dan tenang",
                                    "Malas beribadah",
                                },
                                1
                            ),
                            new Question(
                                "Contoh memahami Baqa' ialah ...",
                                new List<string>
                                {
                                    "Yakin Allah sentiasa ada",
                                    "Yakin Allah semakin tua",
                                    "Yakin Allah memerlukan makhluk",
                                },
                                0
                            ),
                            new Question(
                                "Tumbuhan penting kerana ...",
                                new List<string>
                                {
                                    "Menghasilkan makanan",
                                    "Menyebabkan kebuluran",
                                    "Menjadi racun",
                                },
                                0
                            ),
                            new Question(
                                "Daun berfungsi untuk ...",
                                new List<string>
                                {
                                    "Menangkap cahaya matahari",
                                    "Mengeluarkan api",
                                    "Menghasilkan batu",
                                },
                                0
                            ),
                            new Question(
                                "Hikmah tumbuhan kepada manusia ialah ...",
                                new List<string>
                                {
                                    "Menjadi tempat tidur",
                                    "Menyediakan oksigen",
                                    "Menghalang hujan",
                                },
                                1
                            ),
                            new Question(
                                "Allah mencipta tumbuhan supaya manusia ...",
                                new List<string> { "Membazir", "Bersyukur", "Menyombong" },
                                1
                            ),
                            new Question(
                                "Buah-buahan mengandungi ...",
                                new List<string> { "Vitamin", "Batu", "Besi" },
                                0
                            ),
                            new Question(
                                "Ulul Azmi ialah rasul yang ...",
                                new List<string> { "Putus asa", "Sangat tabah", "Lemah" },
                                1
                            ),
                            new Question(
                                "Bilangan rasul Ulul Azmi ialah ...",
                                new List<string> { "5", "7", "10" },
                                0
                            ),
                            new Question(
                                "Nabi Isa a.s. ialah salah seorang ...",
                                new List<string> { "Ulul Azmi", "Sahabat", "Malaikat" },
                                0
                            ),
                            new Question(
                                "Nabi Ibrahim digelar Ulul Azmi kerana ...",
                                new List<string>
                                {
                                    "Suka marah",
                                    "Sabar dan kuat menghadapi ujian",
                                    "Tidak berdakwah",
                                },
                                1
                            ),
                            new Question(
                                "Contoh meneladani Ulul Azmi ialah ...",
                                new List<string>
                                {
                                    "Mudah putus asa",
                                    "Sabar menghadapi cabaran",
                                    "Suka bertengkar",
                                },
                                1
                            ),
                        },
                    },
                    //level IBADAH TAHAP 2
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Apakah maksud wuduk?",
                                new List<string>
                                {
                                    "Menyucikan diri dengan debu",
                                    "Menyucikan anggota tertentu dengan air",
                                    "Menghilangkan najis",
                                },
                                1
                            ),
                            new Question(
                                "Tayamum dilakukan apabila ...",
                                new List<string>
                                {
                                    "Malas berwuduk",
                                    "Tiada air atau mudarat guna air",
                                    "Air jauh",
                                },
                                1
                            ),
                            new Question(
                                "Anggota wuduk berikut adalah betul kecuali ...",
                                new List<string> { "Muka", "Kepala", "Perut" },
                                2
                            ),
                            new Question(
                                "Anggota tayamum ialah ..",
                                new List<string>
                                {
                                    "Muka dan tangan",
                                    "Kepala dan kaki",
                                    "Tangan dan kaki",
                                },
                                0
                            ),
                            new Question(
                                "Perkara yang membatalkan wuduk ialah ...",
                                new List<string>
                                {
                                    "Berjalan",
                                    "Keluar sesuatu daripada qubul/dubur",
                                    "Minum air",
                                },
                                1
                            ),
                            new Question(
                                "Perkara yang membatalkan tayamum ialah ...",
                                new List<string> { "Duduk", "Mendapat air", "Bernafas" },
                                1
                            ),
                            new Question(
                                "Najis berat disucikan dengan ...",
                                new List<string>
                                {
                                    "Air sahaja",
                                    "Tujuh basuhan termasuk tanah",
                                    "Lap tiga kali",
                                },
                                1
                            ),
                            new Question(
                                "Najis ringan ialah ...",
                                new List<string>
                                {
                                    "Darah",
                                    "Arak",
                                    "Air kencing bayi lelaki belum makan makanan pejal",
                                },
                                2
                            ),
                            new Question(
                                "Najis pertengahan disucikan dengan ...",
                                new List<string>
                                {
                                    "Basuh hingga hilang bau dan warna",
                                    "Lap tiga kali",
                                    "Basuh tujuh kali",
                                },
                                0
                            ),
                            new Question(
                                "Istinjak bermaksud ...",
                                new List<string>
                                {
                                    "Membersih hadas besar",
                                    "Membersih qubul dan dubur",
                                    "Mandi wajib",
                                },
                                1
                            ),
                            new Question(
                                "Hukum istinjak ialah ..",
                                new List<string> { "Sunat", "Harus", "Wajib" },
                                2
                            ),
                            new Question(
                                "Alat kesat berikut boleh digunakan untuk istinjak kecuali ...",
                                new List<string> { "Batu suci", "Tisu", "Kain bernajis" },
                                2
                            ),
                            new Question(
                                "Minimum lap bagi istinjak alat kesat adalah ...",
                                new List<string> { "1 kali", "3 kali", "7 kali" },
                                1
                            ),
                            new Question(
                                "Najis ringan disucikan dengan ...",
                                new List<string>
                                {
                                    "Basuh tujuh kali",
                                    "Percikan air",
                                    "Lap tiga kali",
                                },
                                1
                            ),
                            new Question(
                                "Hikmah berwuduk ialah.",
                                new List<string>
                                {
                                    "Menghilangkan ngantuk",
                                    "Menyucikan jiwa",
                                    "Melambatkan solat",
                                },
                                1
                            ),
                            new Question(
                                "Azan bermaksud ...",
                                new List<string>
                                {
                                    "Panggilan solat",
                                    "Peringatan makan",
                                    "Seruan tidur",
                                },
                                0
                            ),
                            new Question(
                                "Iqamah bermaksud",
                                new List<string>
                                {
                                    "Seruan mendirikan solat",
                                    "Panggilan makan",
                                    "Seruan berzikir",
                                },
                                0
                            ),
                            new Question(
                                "Hikmah azan ialah ...",
                                new List<string>
                                {
                                    "Menyeru manusia main",
                                    "Menyampaikan syiar Islam",
                                    "Menghalang ibadah",
                                },
                                1
                            ),
                            new Question(
                                "Wuduk tidak sah jika ...",
                                new List<string> { "Tidak tertib", "Banyak bercakap", "Duduk" },
                                0
                            ),
                            new Question(
                                "Tayamum dilakukan menggunakan ...",
                                new List<string> { "Air", "Debu suci", "Rumput" },
                                1
                            ),
                            new Question(
                                "Rukun wuduk pertama ialah",
                                new List<string> { "Membasuh kaki", "Membasuh tangan", "Niat" },
                                2
                            ),
                            new Question(
                                "Rukun tayamum pertama ialah",
                                new List<string> { "Menepuk debu", "Niat", "Mencuci muka" },
                                1
                            ),
                            new Question(
                                "Najis berat contohnya ...",
                                new List<string> { "Ayam", "Ikan", "Anjing" },
                                2
                            ),
                            new Question(
                                "Cara menyucikan najis pertengahan ialah ...",
                                new List<string>
                                {
                                    "Basuh hingga hilang sifat najis",
                                    "Lap tiga kali",
                                    "Tanah + air",
                                },
                                0
                            ),
                            new Question(
                                "Air mustakmal ialah",
                                new List<string>
                                {
                                    "Air mutlak",
                                    "Air digunakan pada anggota wuduk",
                                    "Air hujan",
                                },
                                1
                            ),
                            new Question(
                                "Air mutlak boleh digunakan untuk ...",
                                new List<string> { "Minum sahaja", "Bersuci", "Memasak sahaja" },
                                1
                            ),
                            new Question(
                                "Istinjak tidak sah jika menggunakan ...",
                                new List<string> { "Tisu", "Batu suci", "Benda tajam" },
                                2
                            ),
                            new Question(
                                "Hikmah istinjak ialah ...",
                                new List<string>
                                {
                                    "Membazir air",
                                    "Mengelakkan bau tidak enak",
                                    "Melambatkan mandi",
                                },
                                1
                            ),
                            new Question(
                                "Azan disyariatkan untuk ...",
                                new List<string>
                                {
                                    "Mengajak makan",
                                    "Memberitahu masuk waktu solat",
                                    "Menanda perayaan",
                                },
                                1
                            ),
                            new Question(
                                "Lafaz azan bermula dengan ...",
                                new List<string> { "Allahu Akbar", "Alhamdulillah", "Subhanallah" },
                                0
                            ),
                            new Question(
                                "Berwuduk dapat.",
                                new List<string>
                                {
                                    "Menenangkan hati",
                                    "Menghilangkan peluh",
                                    "Mewarnakan kulit",
                                },
                                0
                            ),
                            new Question(
                                "Tayamum tidak sah tanpa ..",
                                new List<string> { "Niat", "Debu", "Lapik" },
                                0
                            ),
                            new Question(
                                "Najis mukhafafah ialah ...",
                                new List<string>
                                {
                                    "Air kencing bayi lelaki",
                                    "Najis manusia dewasa",
                                    "Air liur anjing",
                                },
                                0
                            ),
                            new Question(
                                "Tanah digunakan untuk menyucikan ...",
                                new List<string>
                                {
                                    "Najis ringan",
                                    "Najis berat",
                                    "Najis pertengahan",
                                },
                                1
                            ),
                            new Question(
                                "Rukun wuduk yang wajib adalah.",
                                new List<string>
                                {
                                    "Titik air",
                                    "Membasuh muka",
                                    "Mengeringkan anggota",
                                },
                                1
                            ),
                            new Question(
                                "Rukun tayamum ialah ..",
                                new List<string>
                                {
                                    "Mandi",
                                    "Menyapu muka dan tangan",
                                    "Menyiram air",
                                },
                                1
                            ),
                            new Question(
                                "Contoh najis pertengahan ialah ...",
                                new List<string> { "Air kencing", "Air mutlak", "Debu suci" },
                                0
                            ),
                            new Question(
                                "Air mutanajjis ialah",
                                new List<string>
                                {
                                    "Air dicampur sabun",
                                    "Air terkena najis",
                                    "Air masak",
                                },
                                1
                            ),
                            new Question(
                                "Istinjak wajib apabila",
                                new List<string>
                                {
                                    "Selepas makan",
                                    "Keluar najis kecil atau besar",
                                    "Selepas solat",
                                },
                                1
                            ),
                            new Question(
                                "Azan dan iqamah menunjukkan ...",
                                new List<string>
                                {
                                    "Syiar Islam",
                                    "Permainan tradisi",
                                    "Upacara adat",
                                },
                                0
                            ),
                            new Question(
                                "Hikmah tayamum ialah.",
                                new List<string>
                                {
                                    "Menjimatkan masa",
                                    "Memudahkan ibadah dalam kesukaran",
                                    "Mengelakkan wuduk",
                                },
                                1
                            ),
                            new Question(
                                "Air mutlak termasuk",
                                new List<string> { "Air sungai", "Minyak", "Teh" },
                                0
                            ),
                            new Question(
                                "Menyapu kepala adalah ...",
                                new List<string> { "Sunat wuduk", "Rukun wuduk", "Makruh wuduk" },
                                1
                            ),
                            new Question(
                                "Tayamum dilakukan pada",
                                new List<string> { "Pakaian", "Muka dan tangan", "Kaki dan perut" },
                                1
                            ),
                            new Question(
                                "Najis mughallazah ialah",
                                new List<string> { "Darah", "Kencing bayi", "Babi" },
                                2
                            ),
                            new Question(
                                "Air kencing bayi perempuan disucikan dengan ...",
                                new List<string> { "Basuhan biasa", "Percikan", "Tujuh basuhan" },
                                0
                            ),
                            new Question(
                                "Iqamah dilafazkan ...",
                                new List<string>
                                {
                                    "Sekali sehari",
                                    "Sebelum solat fardu",
                                    "Selepas tidur",
                                },
                                1
                            ),
                            new Question(
                                "Azan dikumandangkan oleh ...",
                                new List<string> { "Imam", "Bilal", "Khatib" },
                                1
                            ),
                            new Question(
                                "Hikmah najis disucikan ialah ...",
                                new List<string>
                                {
                                    "Mengelakkan penyakit",
                                    "Menghilangkan pahala",
                                    "Menambah beban",
                                },
                                0
                            ),
                            new Question(
                                "Tayamum bermula dengan ...",
                                new List<string>
                                {
                                    "Menyapu tangan",
                                    "Niat",
                                    "Menepuk debu dua kali",
                                },
                                1
                            ),
                        },
                    },
                    //level SIRAH TAHAP 2
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Siapakah ibu susuan Nabi Muhammad?",
                                new List<string> { "Halimatus Sa'diyah", "Aminah", "Fatimah" },
                                0
                            ),
                            new Question(
                                "Nabi Muhammad disusukan di perkampungan?",
                                new List<string> { "Bani Sa'ad", "Bani Tamim", "Bani Abbas" },
                                0
                            ),
                            new Question(
                                "Siapakah ibu kandung Nabi Muhammad?",
                                new List<string> { "Halimah", "Aminah", "Khadijah" },
                                1
                            ),
                            new Question(
                                "Apakah tujuan Nabi Muhammad dibawa menziarahi pusara ayahanda?",
                                new List<string>
                                {
                                    "Melawat keluarga",
                                    "Mengukuhkan silaturahim",
                                    "Mengenang ayahandanya",
                                },
                                2
                            ),
                            new Question(
                                "Di manakah terletaknya pusara ayahanda Nabi?",
                                new List<string> { "Madinah", "Mekah", "Taif" },
                                0
                            ),
                            new Question(
                                "Siapakah yang wafat ketika Nabi berusia 6 tahun?",
                                new List<string> { "Aminah", "Abdul Muttalib", "Abu Talib" },
                                0
                            ),
                            new Question(
                                "Selepas kewafatan ibu, Nabi dijaga oleh?",
                                new List<string> { "Datuknya", "Pakciknya", "Jirannya" },
                                0
                            ),
                            new Question(
                                "Nama datuk Nabi Muhammad ialah?",
                                new List<string> { "Abdullah", "Abdul Muttalib", "Abu Talib" },
                                1
                            ),
                            new Question(
                                "Abu Talib ialah?",
                                new List<string>
                                {
                                    "Bapa saudara Nabi",
                                    "Guru Nabi",
                                    "Sahabat Nabi",
                                },
                                0
                            ),
                            new Question(
                                "Abu Talib menjaga Nabi dengan penuh?",
                                new List<string> { "Marah", "Kasih sayang", "Paksaan" },
                                1
                            ),
                            new Question(
                                "Gelaran Nabi Muhammad sebelum menjadi Rasul ialah?",
                                new List<string> { "Al-Amin", "Al-Mukhtar", "Al-Hakim" },
                                0
                            ),
                            new Question(
                                "Gelaran Al-Amin bermaksud?",
                                new List<string> { "Bijaksana", "Terpuji", "Dipercayai" },
                                2
                            ),
                            new Question(
                                "Mengapa Nabi digelar Al-Amin?",
                                new List<string>
                                {
                                    "Suka bergurau",
                                    "Sentiasa bercakap benar",
                                    "Suka bermain",
                                },
                                1
                            ),
                            new Question(
                                "Peristiwa mengangkat Hajarul Aswad berlaku ketika umur Nabi?",
                                new List<string> { "15 tahun", "25 tahun", "35 tahun" },
                                2
                            ),
                            new Question(
                                "Siapakah yang mencadangkan penyelesaian pertikaian Hajarul Aswad?",
                                new List<string> { "Nabi Muhammad", "Abu Talib", "Abdul Muttalib" },
                                0
                            ),
                            new Question(
                                "Mengangkat Hajarul Aswad menunjukkan Nabi seorang yang?",
                                new List<string> { "Penakut", "Adil", "Lalai" },
                                1
                            ),
                            new Question(
                                "Pekerjaan Nabi semasa kecil ialah?",
                                new List<string> { "Petani", "Pengembala kambing", "Nelayan" },
                                1
                            ),
                            new Question(
                                "Mengembala kambing mengajar Nabi sifat?",
                                new List<string> { "Sabar", "Marah", "Lalai" },
                                0
                            ),
                            new Question(
                                "Nabi berniaga ke Syam bersama?",
                                new List<string> { "Abu Talib", "Abdul Muttalib", "Abu Bakar" },
                                0
                            ),
                            new Question(
                                "Berniaga ke Syam mengajar Nabi untuk?",
                                new List<string> { "Bermain", "Menipu", "Berdikari" },
                                2
                            ),
                            new Question(
                                "Sifat wajib Rasul yang bermaksud benar ialah?",
                                new List<string> { "Amanah", "Fatanah", "Siddiq" },
                                2
                            ),
                            new Question(
                                "Sifat amanah bermaksud?",
                                new List<string> { "Boleh dipercayai", "Cerdik", "Menyampaikan" },
                                0
                            ),
                            new Question(
                                "Sifat tabligh bermaksud?",
                                new List<string> { "Menyampaikan", "Menyembunyikan", "Menghukum" },
                                0
                            ),
                            new Question(
                                "Sifat fatanah bermaksud?",
                                new List<string> { "Bijaksana", "Pemarah", "Lalai" },
                                0
                            ),
                            new Question(
                                "Siapakah contoh terbaik sifat Siddiq?",
                                new List<string> { "Nabi Muhammad", "Abu Lahab", "Abu Jahal" },
                                0
                            ),
                            new Question(
                                "Mengapa Rasul wajib bersifat benar?",
                                new List<string>
                                {
                                    "Untuk keseronokan",
                                    "Untuk disanjung manusia",
                                    "Supaya umat percaya ajaran baginda",
                                },
                                2
                            ),
                            new Question(
                                "Rasulullah sentiasa amanah kerana?",
                                new List<string>
                                {
                                    "Mahu kekayaan",
                                    "Taat kepada Allah",
                                    "Mahu pujian",
                                },
                                1
                            ),
                            new Question(
                                "Tabligh menunjukkan Rasulullah sentiasa?",
                                new List<string>
                                {
                                    "Menyampaikan wahyu",
                                    "Diam",
                                    "Menyembunyikan ajaran",
                                },
                                0
                            ),
                            new Question(
                                "Fatanah diperlukan supaya Rasul dapat?",
                                new List<string> { "Bermain", "Menyelesaikan masalah", "Menipu" },
                                1
                            ),
                            new Question(
                                "Contoh sifat amanah Nabi ialah?",
                                new List<string>
                                {
                                    "Menjaga barang orang Mekah",
                                    "Menipu dalam berniaga",
                                    "Bermalas-malasan",
                                },
                                0
                            ),
                            new Question(
                                "Siapakah yang menjaga Nabi selepas datuknya wafat?",
                                new List<string> { "Abu Talib", "Abu Bakar", "Umar" },
                                0
                            ),
                            new Question(
                                "Kisah mengangkat Hajarul Aswad berlaku di?",
                                new List<string> { "Kaabah", "Bukit Safa", "Gua Hira'" },
                                0
                            ),
                            new Question(
                                "Mengapa suku-suku Quraisy bergaduh ketika membina Kaabah?",
                                new List<string>
                                {
                                    "Tidak cukup batu",
                                    "Mahu meletakkan Hajarul Aswad",
                                    "Tidak suka Kaabah",
                                },
                                1
                            ),
                            new Question(
                                "Penyelesaian Nabi menunjukkan sifat?",
                                new List<string> { "Adil", "Marah", "Lalai" },
                                0
                            ),
                            new Question(
                                "Mengapa Nabi dihantar ke kampung Bani Sa'ad?",
                                new List<string>
                                {
                                    "Udara segar dan baik untuk membesar",
                                    "Banyak permainan",
                                    "Ramai pedagang",
                                },
                                0
                            ),
                            new Question(
                                "Siapakah abang susuan Nabi?",
                                new List<string> { "Ali", "Hamzah", "Abu Talib" },
                                1
                            ),
                            new Question(
                                "Aminah wafat di?",
                                new List<string> { "Abwa'", "Madinah", "Mekah" },
                                0
                            ),
                            new Question(
                                "Abdul Muttalib ialah?",
                                new List<string> { "Datuk Nabi", "Anak Nabi", "Menantu Nabi" },
                                0
                            ),
                            new Question(
                                "Sifat Siddiq dapat dilihat apabila Nabi sentiasa?",
                                new List<string>
                                {
                                    "Berbohong",
                                    "Bercakap benar",
                                    "Menyembunyikan kebenaran",
                                },
                                1
                            ),
                            new Question(
                                "Amanah dapat dilihat ketika Nabi?",
                                new List<string>
                                {
                                    "Menjaga barang orang",
                                    "Memecahkan barang",
                                    "Menghilangkan barang",
                                },
                                0
                            ),
                            new Question(
                                "Tabligh dapat dilihat ketika Nabi?",
                                new List<string>
                                {
                                    "Menyampaikan wahyu",
                                    "Berdiam diri",
                                    "Tidak mengajar",
                                },
                                0
                            ),
                            new Question(
                                "Fatanah dapat dilihat ketika Nabi?",
                                new List<string>
                                {
                                    "Menyelesaikan pertikaian",
                                    "Bermain sahaja",
                                    "Mengata orang",
                                },
                                0
                            ),
                            new Question(
                                "Berniaga di Syam menunjukkan Nabi seorang yang?",
                                new List<string> { "Penipu", "Rajin", "Malas" },
                                1
                            ),
                            new Question(
                                "Pekerjaan mengembala kambing menjadikan Nabi lebih?",
                                new List<string> { "Lalai", "Bertanggungjawab", "Pemarah" },
                                1
                            ),
                            new Question(
                                "Gelaran Al-Amin diberi oleh?",
                                new List<string> { "Putera Rome", "Orang Quraisy", "Orang Yahudi" },
                                1
                            ),
                            new Question(
                                "Mengapa sifat wajib Rasul penting?",
                                new List<string>
                                {
                                    "Untuk memikat manusia",
                                    "Untuk menjadikan dakwah diterima",
                                    "Untuk hiburan",
                                },
                                1
                            ),
                            new Question(
                                "Sifat Siddiq lawannya ialah?",
                                new List<string> { "Bohong", "Amanah", "Rajin" },
                                0
                            ),
                            new Question(
                                "Sifat Amanah lawannya ialah?",
                                new List<string> { "Curang", "Bijaksana", "Berani" },
                                0
                            ),
                            new Question(
                                "Sifat Tabligh lawannya ialah?",
                                new List<string> { "Menyampaikan", "Menyembunyikan", "Menjual" },
                                1
                            ),
                            new Question(
                                "Sifat Fatanah lawannya ialah?",
                                new List<string> { "Cerdik", "Bodoh", "Jujur" },
                                1
                            ),
                        },
                    },
                    //level ADAB TAHAP 2
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Maksud adab dengan Rasulullah ialah ...",
                                new List<string>
                                {
                                    "Mengikut perintah guru",
                                    "Menghormati dan memuliakan Baginda",
                                    "Mengikuti rakan-rakan",
                                },
                                1
                            ),
                            new Question(
                                "Hukum beradab dengan Rasulullah ialah ...",
                                new List<string> { "Harus", "Makruh", "Wajib" },
                                2
                            ),
                            new Question(
                                "Antara berikut, yang manakah termasuk adab dengan Rasulullah?",
                                new List<string>
                                {
                                    "Menghina sunnah",
                                    "Mengikuti ajaran baginda",
                                    "Melupakan sejarah Nabi",
                                },
                                1
                            ),
                            new Question(
                                "Akhlak Rasulullah ketika bersahabat ialah ...",
                                new List<string>
                                {
                                    "Suka bermusuh",
                                    "Menyakiti sahabat",
                                    "Berbuat baik kepada sahabat",
                                },
                                2
                            ),
                            new Question(
                                "Akhlak Rasulullah ketika bercakap ialah ...",
                                new List<string>
                                {
                                    "Menjerit",
                                    "Berkata benar dan lemah lembut",
                                    "Berbohong",
                                },
                                1
                            ),
                            new Question(
                                "Antara berikut, yang manakah akhlak Nabi ketika bersukan?",
                                new List<string>
                                {
                                    "Menyusahkan orang lain",
                                    "Menipu untuk menang",
                                    "Bersukan dengan adil",
                                },
                                2
                            ),
                            new Question(
                                "Akhlak Rasulullah ketika berpakaian ialah ...",
                                new List<string>
                                {
                                    "Sombong",
                                    "Memilih pakaian yang bersih",
                                    "Meniru pakaian dilarang",
                                },
                                1
                            ),
                            new Question(
                                "Menghormati Rasulullah mendatangkan ...",
                                new List<string> { "Dosa", "Hikmah dan keberkatan", "Kemarahan" },
                                1
                            ),
                            new Question(
                                "Kisah Sabit bin Qois memberi pengajaran supaya ...",
                                new List<string>
                                {
                                    "Bersuara kuat",
                                    "Merendahkan suara",
                                    "Tidak bercakap dengan Nabi",
                                },
                                1
                            ),
                            new Question(
                                "Mengikut adab Rasulullah membawa kepada ...",
                                new List<string>
                                {
                                    "Hidup lebih teratur",
                                    "Hidup bermasalah",
                                    "Hidup kelam kabut",
                                },
                                0
                            ),
                            // Fasal 2 - Adab Tidur
                            new Question(
                                "Adab sebelum tidur ialah ...",
                                new List<string>
                                {
                                    "Berlari",
                                    "Membaca doa",
                                    "Menonton TV hingga lewat malam",
                                },
                                1
                            ),
                            new Question(
                                "Adab selepas bangun tidur ialah ...",
                                new List<string>
                                {
                                    "Terus makan",
                                    "Membaca doa bangun tidur",
                                    "Tidur semula",
                                },
                                1
                            ),
                            new Question(
                                "Mengamalkan adab tidur dapat ...",
                                new List<string>
                                {
                                    "Membawa keberkatan",
                                    "Menyusahkan",
                                    "Menjadikan tidur tidak lena",
                                },
                                0
                            ),
                            new Question(
                                "Tidak mengamalkan adab tidur boleh menyebabkan ...",
                                new List<string>
                                {
                                    "Badan segar",
                                    "Mudah lalai",
                                    "Lebih berdisiplin",
                                },
                                1
                            ),
                            new Question(
                                "Sunat berwuduk sebelum tidur supaya ...",
                                new List<string>
                                {
                                    "Cepat lapar",
                                    "Disukai kawan",
                                    "Mendapat perlindungan Allah",
                                },
                                2
                            ),
                            new Question(
                                "Menyusun tempat tidur menunjukkan sikap ...",
                                new List<string> { "Malas", "Rajin dan berdisiplin", "Sombong" },
                                1
                            ),
                            new Question(
                                "Doa sebelum tidur ialah ...",
                                new List<string>
                                {
                                    "Bismillah",
                                    "Alhamdulillah",
                                    "Bismika Allahumma amutu wa ahya",
                                },
                                2
                            ),
                            // Fasal 3 - Adab Menunaikan Hajat
                            new Question(
                                "Adab masuk tandas ialah ...",
                                new List<string>
                                {
                                    "Masuk dengan kaki kanan",
                                    "Masuk sambil berbual",
                                    "Masuk dengan kaki kiri",
                                },
                                2
                            ),
                            new Question(
                                "Doa masuk tandas dibaca supaya ...",
                                new List<string>
                                {
                                    "Mendapat kebersihan",
                                    "Dijauhkan daripada gangguan syaitan",
                                    "Menghilangkan mengantuk",
                                },
                                1
                            ),
                            new Question(
                                "Adab keluar tandas ialah ...",
                                new List<string>
                                {
                                    "Melangkah dengan kaki kanan",
                                    "Tidak membaca doa",
                                    "Mengotorkan tandas",
                                },
                                0
                            ),
                            new Question(
                                "Adab mandi termasuk ...",
                                new List<string>
                                {
                                    "Membazir air",
                                    "Menyiram seluruh badan",
                                    "Bermain air",
                                },
                                1
                            ),
                            new Question(
                                "Qada hajat bermaksud ...",
                                new List<string> { "Mandi", "Buang air kecil/air besar", "Tidur" },
                                1
                            ),
                            new Question(
                                "Ketika qada hajat, kita tidak boleh ...",
                                new List<string>
                                {
                                    "Menghadap kiblat",
                                    "Diam",
                                    "Membersihkan diri",
                                },
                                0
                            ),
                            new Question(
                                "Mengamalkan adab tandas memberi ...",
                                new List<string>
                                {
                                    "Kemudaratan",
                                    "Kebaikan dan kesihatan",
                                    "Masalah",
                                },
                                1
                            ),
                            new Question(
                                "Tidak menjaga adab tandas boleh menyebabkan ...",
                                new List<string> { "Tandas bersih", "Penyakit", "Badan sihat" },
                                1
                            ),
                            // Fasal 4 - Adab Berpakaian
                            new Question(
                                "Aurat bermaksud ...",
                                new List<string>
                                {
                                    "Tempat bermain",
                                    "Anggota yang wajib ditutup",
                                    "Tempat belajar",
                                },
                                1
                            ),
                            new Question(
                                "Aurat lelaki antara ...",
                                new List<string>
                                {
                                    "Pusat hingga lutut",
                                    "Kepala hingga kaki",
                                    "Tangan hingga dada",
                                },
                                0
                            ),
                            new Question(
                                "Salah satu ciri pakaian menutup aurat ialah ...",
                                new List<string>
                                {
                                    "Nipis",
                                    "Ketat",
                                    "Tidak menampakkan bentuk tubuh",
                                },
                                2
                            ),
                            new Question(
                                "Adab memakai pakaian ialah ...",
                                new List<string>
                                {
                                    "Memakai dari kiri",
                                    "Memakai dari kanan",
                                    "Memakai pakaian koyak",
                                },
                                1
                            ),
                            new Question(
                                "Mengamalkan adab berpakaian menunjukkan kita ...",
                                new List<string>
                                {
                                    "Sombong",
                                    "Tidak peduli",
                                    "Menjaga maruah diri",
                                },
                                2
                            ),
                            new Question(
                                "Tidak menjaga adab berpakaian boleh menyebabkan ...",
                                new List<string> { "Dipandang buruk", "Dipuji", "Disukai ramai" },
                                0
                            ),
                            // Fasal 5 - Adab Makan dan Minum
                            new Question(
                                "Adab sebelum makan ialah ...",
                                new List<string> { "Membasuh tangan", "Bermain", "Tidur" },
                                0
                            ),
                            new Question(
                                "Adab semasa makan ialah ...",
                                new List<string>
                                {
                                    "Menyelitkan tangan kiri",
                                    "Makan dengan tangan kanan",
                                    "Mengunyah kuat",
                                },
                                1
                            ),
                            new Question(
                                "Selepas makan kita digalakkan ...",
                                new List<string>
                                {
                                    "Membasuh pinggan",
                                    "Menjerit",
                                    "Membuang makanan",
                                },
                                0
                            ),
                            new Question(
                                "Adab minum ialah ...",
                                new List<string>
                                {
                                    "Minum sambil berdiri",
                                    "Minum dengan tangan kanan",
                                    "Minum sambil bercakap",
                                },
                                1
                            ),
                            new Question(
                                "Kelebihan mengamalkan adab makan ialah ...",
                                new List<string>
                                {
                                    "Makanan menjadi busuk",
                                    "Mendapat pahala",
                                    "Tidak kenyang",
                                },
                                1
                            ),
                            new Question(
                                "Akibat tidak beradab ketika makan ialah ...",
                                new List<string> { "Disukai guru", "Tercekik", "Lebih sopan" },
                                1
                            ),
                            new Question(
                                "Membaca doa sebelum makan menunjukkan sifat ...",
                                new List<string> { "Syukur", "Sombong", "Malas" },
                                0
                            ),
                            // Fasal 6 - Adab Masuk dan Keluar Rumah
                            new Question(
                                "Adab masuk rumah ialah ...",
                                new List<string> { "Menjerit", "Memberi salam", "Menendang pintu" },
                                1
                            ),
                            new Question(
                                "Adab keluar rumah ialah ...",
                                new List<string>
                                {
                                    "Membaca doa keluar rumah",
                                    "Menyanyi",
                                    "Membuang sampah",
                                },
                                0
                            ),
                            new Question(
                                "Mengamalkan adab masuk rumah membawa ...",
                                new List<string> { "Masalah", "Keselamatan", "Kemarahan" },
                                1
                            ),
                            new Question(
                                "Tidak mengamalkan adab keluar rumah boleh mengakibatkan ...",
                                new List<string>
                                {
                                    "Dilindungi Allah",
                                    "Hilang keselamatan",
                                    "Mendapat pahala",
                                },
                                1
                            ),
                            new Question(
                                "Salah satu adab dalam rumah ialah ...",
                                new List<string>
                                {
                                    "Menyusahkan ahli keluarga",
                                    "Menghormati ibu bapa",
                                    "Memijak barang",
                                },
                                1
                            ),
                            // Fasal 7 - Adab Menaiki Kenderaan
                            new Question(
                                "Adab menaiki kenderaan ialah ...",
                                new List<string>
                                {
                                    "Tolak-menolak",
                                    "Beratur dengan sopan",
                                    "Menjerit",
                                },
                                1
                            ),
                            new Question(
                                "Doa menaiki kenderaan dibaca untuk ...",
                                new List<string>
                                {
                                    "Mendapat hiburan",
                                    "Keselamatan dalam perjalanan",
                                    "Membuang masa",
                                },
                                1
                            ),
                            new Question(
                                "Adab menggunakan kenderaan awam ialah ...",
                                new List<string>
                                {
                                    "Mengganggu penumpang",
                                    "Duduk sopan",
                                    "Menyanyi kuat",
                                },
                                1
                            ),
                            new Question(
                                "Kelebihan mengamalkan adab kenderaan ialah ...",
                                new List<string>
                                {
                                    "Perjalanan selamat",
                                    "Kenderaan rosak",
                                    "Penumpang marah",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beradab di dalam kenderaan ...",
                                new List<string>
                                {
                                    "Disukai semua orang",
                                    "Membahayakan diri dan orang lain",
                                    "Selamat sentiasa",
                                },
                                1
                            ),
                            new Question(
                                "Menjaga kebersihan kenderaan awam ialah ...",
                                new List<string>
                                {
                                    "Adab yang baik",
                                    "Tidak penting",
                                    "Melambatkan perjalanan",
                                },
                                0
                            ),
                            new Question(
                                "Duduk dengan sopan ketika menaiki kenderaan menunjukkan ...",
                                new List<string> { "Akhlak mulia", "Sikap buruk", "Sifat marah" },
                                0
                            ),
                        },
                    },
                    //LEVEL AKIDAH TAHAP 3
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Apakah tujuan Allah menurunkan kitab-kitab-Nya?",
                                new List<string>
                                {
                                    "Untuk petunjuk manusia",
                                    "Untuk hiasan rumah",
                                    "Untuk dijual",
                                },
                                0
                            ),
                            new Question(
                                "Kitab Zabur diturunkan kepada Nabi?",
                                new List<string> { "Nabi Yunus", "Nabi Daud", "Nabi Adam" },
                                1
                            ),
                            new Question(
                                "Kitab Injil merupakan kitab bagi umat?",
                                new List<string> { "Nabi Musa", "Nabi Isa", "Nabi Hud" },
                                1
                            ),
                            new Question(
                                "Apakah kitab pertama sebelum Al-Quran?",
                                new List<string> { "Zabur", "Taurat", "Injil" },
                                1
                            ),
                            new Question(
                                "Mengapa Al-Quran disebut mukjizat terbesar?",
                                new List<string>
                                {
                                    "Bahasanya indah",
                                    "Tidak berubah",
                                    "Mengandungi kisah moden",
                                },
                                1
                            ),
                            new Question(
                                "Apakah amalan terbaik terhadap Al-Quran?",
                                new List<string>
                                {
                                    "Tidak menyentuhnya",
                                    "Membacanya selalu",
                                    "Menyimpannya di almari",
                                },
                                1
                            ),
                            new Question(
                                "Siapakah yang ditugaskan menyampaikan Al-Quran kepada manusia?",
                                new List<string> { "Nabi Muhammad", "Nabi Isa", "Nabi Ibrahim" },
                                0
                            ),
                            new Question(
                                "Apakah bukti seseorang mencintai Al-Quran?",
                                new List<string>
                                {
                                    "Mengamalkan ajarannya",
                                    "Meletaknya tinggi",
                                    "Mewarnakannya",
                                },
                                0
                            ),
                            new Question(
                                "Apakah maksud kitab samawi?",
                                new List<string>
                                {
                                    "Kitab buatan manusia",
                                    "Kitab dari langit",
                                    "Kitab sekolah",
                                },
                                1
                            ),
                            new Question(
                                "Mengapa manusia perlu beriman kepada kitab?",
                                new List<string>
                                {
                                    "Untuk panduan hidup",
                                    "Untuk koleksi",
                                    "Untuk pertandingan",
                                },
                                0
                            ),
                            new Question(
                                "Apakah peristiwa hari kiamat?",
                                new List<string>
                                {
                                    "Hancurnya alam",
                                    "Hari kelahiran",
                                    "Perpindahan rumah",
                                },
                                0
                            ),
                            new Question(
                                "Salah satu tanda kecil kiamat ialah?",
                                new List<string>
                                {
                                    "Bangunan tinggi",
                                    "Kemunculan Dajjal",
                                    "Turunnya Nabi Isa",
                                },
                                0
                            ),
                            new Question(
                                "Apakah tanda besar kiamat?",
                                new List<string>
                                {
                                    "Ramai menuntut ilmu",
                                    "Matahari terbit di barat",
                                    "Haiwan makin banyak",
                                },
                                1
                            ),
                            new Question(
                                "Mengapa manusia dibangkitkan?",
                                new List<string>
                                {
                                    "Untuk bermain",
                                    "Untuk diadili",
                                    "Untuk bersiar-siar",
                                },
                                1
                            ),
                            new Question(
                                "Orang beriman percaya hari kiamat kerana?",
                                new List<string>
                                {
                                    "Setiap makhluk pasti mati",
                                    "Alam kekal selamanya",
                                    "Manusia hidup dua kali",
                                },
                                0
                            ),
                            new Question(
                                "Kesan beriman kepada kiamat?",
                                new List<string>
                                {
                                    "Suka bermalas",
                                    "Rajin berbuat baik",
                                    "Tidak kisah dosa",
                                },
                                1
                            ),
                            new Question(
                                "Siapakah yang mengetahui tarikh kiamat?",
                                new List<string> { "Malaikat", "Nabi", "Allah" },
                                2
                            ),
                            new Question(
                                "Apa yang berlaku setelah kiamat?",
                                new List<string> { "Akhirat", "Manusia ghaib", "Tiada kehidupan" },
                                0
                            ),
                            new Question(
                                "Apakah contoh tanda kecil kiamat?",
                                new List<string>
                                {
                                    "Ramai orang berbohong",
                                    "Bulan terbelah",
                                    "Dajjal muncul",
                                },
                                0
                            ),
                            new Question(
                                "Mengapa tanda kiamat diberitahu kepada manusia?",
                                new List<string>
                                {
                                    "Supaya takut",
                                    "Supaya sedar dan bertaubat",
                                    "Supaya melarikan diri",
                                },
                                1
                            ),
                            new Question(
                                "Mukhalafatu bermaksud Allah?",
                                new List<string>
                                {
                                    "Berbeza dari makhluk",
                                    "Sama seperti manusia",
                                    "Menyerupai malaikat",
                                },
                                0
                            ),
                            new Question(
                                "Dalil sifat ini banyak disebut dalam surah?",
                                new List<string> { "Al-Ikhlas", "Al-Falaq", "An-Nas" },
                                0
                            ),
                            new Question(
                                "Allah tidak sama dengan makhluk kerana?",
                                new List<string>
                                {
                                    "Allah sempurna",
                                    "Makhluk kuat",
                                    "Makhluk berkuasa",
                                },
                                0
                            ),
                            new Question(
                                "Makhluk memerlukan udara tetapi Allah?",
                                new List<string>
                                {
                                    "Perlu udara",
                                    "Tidak berhajat apa pun",
                                    "Perlu tenaga",
                                },
                                1
                            ),
                            new Question(
                                "Sifat ini membuktikan Allah?",
                                new List<string>
                                {
                                    "Terikat ruang",
                                    "Bergantung pada makhluk",
                                    "Sempurna tanpa kekurangan",
                                },
                                2
                            ),
                            new Question(
                                "Kesan beriman kepada sifat ini?",
                                new List<string>
                                {
                                    "Yakin kebesaran Allah",
                                    "Takut manusia",
                                    "Menjadi sombong",
                                },
                                0
                            ),
                            new Question(
                                "Mengapa manusia tidak boleh menyerupakan Allah dengan makhluk?",
                                new List<string>
                                {
                                    "Allah Maha Suci",
                                    "Makhluk sempurna",
                                    "Manusia tahu segalanya",
                                },
                                0
                            ),
                            new Question(
                                "Perbezaan antara Allah dan makhluk ialah?",
                                new List<string>
                                {
                                    "Allah tidak berubah",
                                    "Makhluk tidak mati",
                                    "Makhluk tidak lemah",
                                },
                                0
                            ),
                            new Question(
                                "Sifat ini menegaskan Allah?",
                                new List<string>
                                {
                                    "Menyerupai makhluk",
                                    "Tidak menyerupai makhluk",
                                    "Memerlukan tempat",
                                },
                                1
                            ),
                            new Question(
                                "Apakah bukti akal tentang sifat ini?",
                                new List<string>
                                {
                                    "Makhluk lemah",
                                    "Pencipta mesti berbeza dari ciptaan",
                                    "Makhluk kekal",
                                },
                                1
                            ),
                            new Question(
                                "Qiyamuhu Binafsihi bermaksud Allah?",
                                new List<string>
                                {
                                    "Memerlukan bantuan",
                                    "Bergantung kepada makhluk",
                                    "Berdiri sendiri",
                                },
                                2
                            ),
                            new Question(
                                "Makhluk memerlukan makanan tetapi Allah?",
                                new List<string>
                                {
                                    "Memerlukan lebih banyak",
                                    "Tidak berhajat apa pun",
                                    "Memerlukan bantuan",
                                },
                                1
                            ),
                            new Question(
                                "Dalil sifat ini terdapat dalam surah?",
                                new List<string> { "Al-Ikhlas", "Al-Kafirun", "Al-Fil" },
                                0
                            ),
                            new Question(
                                "Allah bersifat Qiyamuhu Binafsihi kerana?",
                                new List<string> { "Maha Kaya", "Maha Lapar", "Maha Penat" },
                                0
                            ),
                            new Question(
                                "Kesan memahami sifat ini?",
                                new List<string>
                                {
                                    "Suka berbohong",
                                    "Tambah yakin beribadah",
                                    "Menjadi malas",
                                },
                                1
                            ),
                            new Question(
                                "Allah tidak berhajat kepada?",
                                new List<string> { "Makhluk", "Kuasa", "Diri-Nya" },
                                0
                            ),
                            new Question(
                                "Sifat ini menunjukkan Allah?",
                                new List<string>
                                {
                                    "Bergantung kepada langit",
                                    "Bergantung kepada waktu",
                                    "Tidak bergantung kepada sesiapa",
                                },
                                2
                            ),
                            new Question(
                                "Makhluk berdiri dengan bantuan Allah, Allah berdiri?",
                                new List<string>
                                {
                                    "Dengan bantuan makhluk",
                                    "Dengan sendiri",
                                    "Dengan matahari",
                                },
                                1
                            ),
                            new Question(
                                "Dengan memahami sifat ini, manusia akan?",
                                new List<string> { "Berputus asa", "Sombong", "Bersyukur" },
                                2
                            ),
                            new Question(
                                "Allah tidak berubah kerana?",
                                new List<string>
                                {
                                    "Maha Sempurna",
                                    "Memerlukan makan",
                                    "Memerlukan rehat",
                                },
                                0
                            ),
                            new Question(
                                "Haiwan diciptakan Allah untuk?",
                                new List<string>
                                {
                                    "Buktikan kekuasaan-Nya",
                                    "Permainan",
                                    "Hiasan",
                                },
                                0
                            ),
                            new Question(
                                "Surah An-Naml menceritakan tentang?",
                                new List<string> { "Semut", "Harimau", "Kuda" },
                                0
                            ),
                            new Question(
                                "Haiwan membantu manusia dengan?",
                                new List<string>
                                {
                                    "Memberi makanan",
                                    "Mengajar menari",
                                    "Memberi pakaian moden",
                                },
                                0
                            ),
                            new Question(
                                "Lebah disebut dalam Al-Quran kerana?",
                                new List<string>
                                {
                                    "Menghasilkan madu",
                                    "Merbahaya",
                                    "Sukar ditangkap",
                                },
                                0
                            ),
                            new Question(
                                "Kehidupan haiwan menunjukkan?",
                                new List<string>
                                {
                                    "Kebetulan",
                                    "Keindahan ciptaan Allah",
                                    "Tiada tujuan",
                                },
                                1
                            ),
                            new Question(
                                "Manusia perlu menjaga haiwan kerana?",
                                new List<string>
                                {
                                    "Haiwan milik manusia",
                                    "Haiwan tidak bernilai",
                                    "Sebahagian amanah Allah",
                                },
                                2
                            ),
                            new Question(
                                "Contoh haiwan dalam Al-Quran?",
                                new List<string> { "Gajah", "Kucing", "Panda" },
                                0
                            ),
                            new Question(
                                "Mengapa haiwan dianggap tanda kebesaran Allah?",
                                new List<string>
                                {
                                    "Sukar dibunuh",
                                    "Tidak boleh bergerak",
                                    "Dicipta dengan keunikan",
                                },
                                2
                            ),
                            new Question(
                                "Peranan unta dalam Al-Quran?",
                                new List<string>
                                {
                                    "Sebagai hiasan",
                                    "Sebagai pengangkutan zaman nabi",
                                    "Sebagai senjata",
                                },
                                1
                            ),
                            new Question(
                                "Berfikir tentang haiwan membawa manusia kepada?",
                                new List<string>
                                {
                                    "Lalai",
                                    "Kenal kebesaran Allah",
                                    "Tidak percaya Allah",
                                },
                                1
                            ),
                        },
                    },
                    //LEVEL IBADAH TAHAP 3
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Apakah maksud hadas kecil?",
                                new List<string>
                                {
                                    "Keadaan yang membatalkan wuduk",
                                    "Keadaan wajib mandi",
                                    "Keadaan suci daripada najis",
                                },
                                0
                            ),
                            new Question(
                                "Hadas besar berlaku kerana.",
                                new List<string>
                                {
                                    "Makan dan minum",
                                    "Bersentuhan dengan najis",
                                    "Berjimak atau keluar mani",
                                },
                                2
                            ),
                            new Question(
                                "Contoh perkara yang membatalkan wuduk ialah ..",
                                new List<string>
                                {
                                    "Tidur nyenyak",
                                    "Mandi wajib",
                                    "Berniat solat",
                                },
                                0
                            ),
                            new Question(
                                "Perkara yang mewajibkan mandi wajib ialah.",
                                new List<string> { "Keluar mani", "Kentut", "Minum air" },
                                0
                            ),
                            new Question(
                                "Apakah rukun mandi wajib yang betul?",
                                new List<string>
                                {
                                    "Membaca doa mandi",
                                    "Berniat dan meratakan air ke seluruh tubuh",
                                    "Membasuh kaki tiga kali",
                                },
                                1
                            ),
                            new Question(
                                "Apakah hikmah mandi wajib?",
                                new List<string>
                                {
                                    "Menghilangkan mengantuk",
                                    "Menyucikan diri daripada hadas besar",
                                    "Menjadi lebih kuat",
                                },
                                1
                            ),
                            new Question(
                                "Hadas besar menyebabkan seseorang",
                                new List<string>
                                {
                                    "Tidak boleh solat",
                                    "Tidak boleh bercakap",
                                    "Tidak boleh makan",
                                },
                                0
                            ),
                            new Question(
                                "Cara bersuci daripada hadas kecil ialah ...",
                                new List<string> { "Mandi wajib", "Berwuduk", "Membaca doa" },
                                1
                            ),
                            new Question(
                                "Salah satu sebab berhadas besar ialah ...",
                                new List<string>
                                {
                                    "Keluar darah luka",
                                    "Haidh bagi perempuan",
                                    "Tidur sekejap",
                                },
                                1
                            ),
                            new Question(
                                "Apakah perkara yang dilarang ketika berhadas kecil?",
                                new List<string> { "Solat", "Makan", "Tidur" },
                                0
                            ),
                            new Question(
                                "Perkara yang dilarang ketika berhadas besar ialah ...",
                                new List<string>
                                {
                                    "Bersukan",
                                    "Menonton TV",
                                    "Menyentuh dan membaca al-Quran",
                                },
                                2
                            ),
                            new Question(
                                "Salah satu sunnah mandi wajib ialah ...",
                                new List<string>
                                {
                                    "Membasuh kaki tiga kali",
                                    "Mendahulukan anggota kanan",
                                    "Menghadap kiblat",
                                },
                                1
                            ),
                            new Question(
                                "Apakah maksud hadas besar?",
                                new List<string>
                                {
                                    "Keadaan yang membatalkan puasa",
                                    "Keadaan yang memerlukan mandi wajib",
                                    "Keadaan tidak boleh makan",
                                },
                                1
                            ),
                            new Question(
                                "Apakah tujuan wuduk?",
                                new List<string>
                                {
                                    "Menyucikan diri daripada najis",
                                    "Menyucikan diri daripada hadas kecil",
                                    "Menghilangkan penat",
                                },
                                1
                            ),
                            new Question(
                                "Haidh menyebabkan seseorang.",
                                new List<string> { "Wajib mandi", "Harus berwuduk", "Terus solat" },
                                0
                            ),
                            new Question(
                                "Apakah perbezaan hadas kecil dan besar?",
                                new List<string>
                                {
                                    "Cara bersuci berbeza",
                                    "Tiada perbezaan",
                                    "Kedua-duanya tidak memerlukan niat",
                                },
                                0
                            ),
                            new Question(
                                "Apakah hikmah bersuci?",
                                new List<string>
                                {
                                    "Mendapat pahala dan hidup bersih",
                                    "Menjadi lebih tinggi",
                                    "Menjadi kaya",
                                },
                                0
                            ),
                            new Question(
                                "Antara sebab hadas kecil ialah.",
                                new List<string>
                                {
                                    "Muntah sedikit",
                                    "Buang angin",
                                    "Berlari jauh",
                                },
                                1
                            ),
                            new Question(
                                "Apakah maksud baligh?",
                                new List<string>
                                {
                                    "Cukup umur 18 tahun",
                                    "Sampainya seseorang pada tanda-tanda dewasa",
                                    "Masuk sekolah menengah",
                                },
                                1
                            ),
                            new Question(
                                "Batas aurat lelaki ialah",
                                new List<string>
                                {
                                    "Pusat hingga lutut",
                                    "Lutut hingga tumit",
                                    "Bahagian kepala sahaja",
                                },
                                0
                            ),
                            new Question(
                                "Batas aurat perempuan ialah ...",
                                new List<string>
                                {
                                    "Seluruh tubuh kecuali muka dan tangan",
                                    "Pusat hingga lutut",
                                    "Kepala sahaja",
                                },
                                0
                            ),
                            new Question(
                                "Antara tanda baligh ialah ..",
                                new List<string>
                                {
                                    "Pandai membaca",
                                    "Mimpi basah",
                                    "Boleh menaiki bas",
                                },
                                1
                            ),
                            new Question(
                                "Apakah tuntutan syarak kepada orang baligh?",
                                new List<string>
                                {
                                    "Belajar muzik",
                                    "Menjaga solat dan ibadah",
                                    "Menjadi ketua kelas",
                                },
                                1
                            ),
                            new Question(
                                "Hikmah menutup aurat ialah ...",
                                new List<string>
                                {
                                    "Menjadi lebih cantik",
                                    "Menjaga maruah dan kehormatan",
                                    "Supaya tidak panas",
                                },
                                1
                            ),
                            new Question(
                                "Apakah maksud aurat?",
                                new List<string>
                                {
                                    "Bahagian tubuh yang wajib ditutup",
                                    "Nama pakaian",
                                    "Bahagian rambut",
                                },
                                0
                            ),
                            new Question(
                                "Perempuan wajib menutup aurat apabila",
                                new List<string>
                                {
                                    "Masuk tadika",
                                    "Sudah baligh",
                                    "Berumur 3 tahun",
                                },
                                1
                            ),
                            new Question(
                                "Antara kesan tidak menutup aurat ialah ...",
                                new List<string>
                                {
                                    "Dipandang baik",
                                    "Menjaga maruah",
                                    "Mendapat dosa",
                                },
                                2
                            ),
                            new Question(
                                "Aurat lelaki ketika solat ialah.",
                                new List<string>
                                {
                                    "Pusat hingga lutut",
                                    "Bahagian dada",
                                    "Bahagian muka",
                                },
                                0
                            ),
                            new Question(
                                "Baligh bagi perempuan berkait dengan ...",
                                new List<string>
                                {
                                    "Suara berubah",
                                    "Haid pertama",
                                    "Kuku panjang",
                                },
                                1
                            ),
                            new Question(
                                "Menutup aurat adalah ...",
                                new List<string>
                                {
                                    "Syarat sah solat",
                                    "Perkara harus",
                                    "Tuntutan syarak",
                                },
                                2
                            ),
                            new Question(
                                "Apakah maksud solat?",
                                new List<string>
                                {
                                    "Doa dan bacaan tertentu",
                                    "Pergerakan badan sahaja",
                                    "Perkara yang membatalkan puasa",
                                },
                                0
                            ),
                            new Question(
                                "Bilangan solat fardu sehari semalam ialah ...",
                                new List<string> { "3", "5", "7" },
                                1
                            ),
                            new Question(
                                "Waktu solat Subuh ialah ...",
                                new List<string>
                                {
                                    "Selepas asar",
                                    "Sebelum syuruk",
                                    "Selepas isyak",
                                },
                                1
                            ),
                            new Question(
                                "Rukun solat ialah.",
                                new List<string>
                                {
                                    "Berdiri tegak",
                                    "Makan sebelum solat",
                                    "Bercakap",
                                },
                                0
                            ),
                            new Question(
                                "Antara perkara yang membatalkan solat ialah ...",
                                new List<string>
                                {
                                    "Berselawat",
                                    "Ketawa kuat",
                                    "Membaca al-Fatihah",
                                },
                                1
                            ),
                            new Question(
                                "Salah satu syarat sah solat ialah",
                                new List<string>
                                {
                                    "Menghadap kiblat",
                                    "Minum air dahulu",
                                    "Tidur",
                                },
                                0
                            ),
                            new Question(
                                "Antara sunat dalam solat ialah",
                                new List<string> { "Takbiratul ihram", "Doa qunut", "Niat" },
                                1
                            ),
                            new Question(
                                "Wuduk adalah.",
                                new List<string>
                                {
                                    "Syarat sah solat",
                                    "Perkara sunat",
                                    "Rukun solat",
                                },
                                0
                            ),
                            new Question(
                                "Solat dilakukan ..",
                                new List<string>
                                {
                                    "Untuk menghormati guru",
                                    "Sebagai ibadah kepada Allah",
                                    "Untuk menjadi tinggi",
                                },
                                1
                            ),
                            new Question(
                                "Dalam solat, rukun qauli ialah",
                                new List<string> { "Pergerakan", "Bacaan", "Niat" },
                                1
                            ),
                            new Question(
                                "Contoh rukun solat ialah",
                                new List<string>
                                {
                                    "Memakai telekung cantik",
                                    "Membaca al-Fatihah",
                                    "Mengikat rambut",
                                },
                                1
                            ),
                            new Question(
                                "Syarat wajib solat ialah",
                                new List<string>
                                {
                                    "Cukup umur baligh",
                                    "Boleh membaca doa",
                                    "Tahu membaca buku",
                                },
                                0
                            ),
                            new Question(
                                "Hikmah solat ialah",
                                new List<string>
                                {
                                    "Menguatkan badan",
                                    "Mendekatkan diri kepada Allah",
                                    "Menjadi kaya",
                                },
                                1
                            ),
                            new Question(
                                "Dalam solat, kita membaca al-Fatihah ketika ...",
                                new List<string> { "Rukuk", "Berdiri", "Sujud" },
                                1
                            ),
                            new Question(
                                "Solat Maghrib mempunyai ...",
                                new List<string> { "Empat rakaat", "Tiga rakaat", "Dua rakaat" },
                                1
                            ),
                            new Question(
                                "Solat Asar dilakukan pada ...",
                                new List<string>
                                {
                                    "Waktu tengah malam",
                                    "Waktu petang",
                                    "Waktu pagi",
                                },
                                1
                            ),
                            new Question(
                                "Antara perkara membatalkan solat ialah ...",
                                new List<string> { "Berzikir dalam hati", "Berhadas", "Fokus" },
                                1
                            ),
                            new Question(
                                "Niat solat dilakukan ...",
                                new List<string>
                                {
                                    "Dalam hati",
                                    "Dilafaz dengan kuat",
                                    "Tidak perlu",
                                },
                                0
                            ),
                            new Question(
                                "Solat Isyak mempunyai ...",
                                new List<string> { "Empat rakaat", "Tiga rakaat", "Dua rakaat" },
                                0
                            ),
                            new Question(
                                "Tertib ialah ...",
                                new List<string>
                                {
                                    "Mendahulukan rukun dengan turutan yang betul",
                                    "Melompat ketika solat",
                                    "Membaca doa waktu solat",
                                },
                                0
                            ),
                        },
                    },
                    // LEVEL SIRAH TAHAP 3
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Nabi Muhammad SAW berketurunan:",
                                new List<string> { "Arab Quraisy", "Parsi", "Rom" },
                                0
                            ),
                            new Question(
                                "Datuk Nabi yang menjaga Baginda selepas ibu wafat ialah:",
                                new List<string> { "Abdul Muttalib", "Abu Talib", "Hamzah" },
                                0
                            ),
                            new Question(
                                "Nabi Muhammad SAW lahir di:",
                                new List<string> { "Mekah", "Madinah", "Thaif" },
                                0
                            ),
                            new Question(
                                "Ibu susu Nabi Muhammad SAW ialah:",
                                new List<string> { "Halimatus Saadiah", "Aminah", "Zainab" },
                                0
                            ),
                            new Question(
                                "Bilangan anak lelaki Nabi ialah:",
                                new List<string> { "2 orang", "4 orang", "6 orang" },
                                0
                            ),
                            new Question(
                                "Bilangan anak perempuan Nabi ialah:",
                                new List<string> { "4 orang", "2 orang", "3 orang" },
                                0
                            ),
                            new Question(
                                "Suami kepada Fatimah ialah:",
                                new List<string> { "Ali bin Abi Talib", "Uthman", "Abu Bakar" },
                                0
                            ),
                            new Question(
                                "Anak Nabi yang meninggal pada usia kecil ialah:",
                                new List<string> { "Qasim", "Zainab", "Ruqayyah" },
                                0
                            ),
                            new Question(
                                "Nama ibu kepada Khadijah ialah:",
                                new List<string>
                                {
                                    "Fatimah binti Za'idah",
                                    "Aminah binti Wahab",
                                    "Zainab binti Jahsy",
                                },
                                0
                            ),
                            new Question(
                                "Rumah tangga yang bahagia dapat membentuk:",
                                new List<string>
                                {
                                    "Akhlak mulia",
                                    "Masalah sosial",
                                    "Pertelingkahan",
                                },
                                0
                            ),
                            new Question(
                                "Anak Khadijah dengan Nabi ialah:",
                                new List<string> { "Fatimah", "Aisyah", "Hafsa" },
                                0
                            ),
                            new Question(
                                "Saidina Ali ialah:",
                                new List<string>
                                {
                                    "Menantu Nabi",
                                    "Bapa saudara Nabi",
                                    "Guru Nabi",
                                },
                                0
                            ),
                            new Question(
                                "Susur galur keluarga penting untuk:",
                                new List<string>
                                {
                                    "Mengenali asal-usul",
                                    "Menimbulkan kebencian",
                                    "Merendahkan kaum lain",
                                },
                                0
                            ),
                            new Question(
                                "Anak perempuan Nabi yang berhijrah ke Habsyah ialah:",
                                new List<string> { "Ruqayyah", "Zainab", "Ummu Kultsum" },
                                0
                            ),
                            new Question(
                                "Institusi keluarga berperanan membentuk:",
                                new List<string>
                                {
                                    "Generasi berkualiti",
                                    "Generasi liar",
                                    "Generasi malas",
                                },
                                0
                            ),
                            new Question(
                                "Nabi dijaga oleh Abu Talib selepas:",
                                new List<string>
                                {
                                    "Datuk Baginda wafat",
                                    "Baginda berkahwin",
                                    "Baginda berhijrah",
                                },
                                0
                            ),
                            new Question(
                                "Wahyu pertama disampaikan oleh Malaikat:",
                                new List<string> { "Jibril", "Mikail", "Israfil" },
                                0
                            ),
                            new Question(
                                "Peristiwa kerasulan berlaku di:",
                                new List<string> { "Gua Hira'", "Bukit Uhud", "Padang Arafah" },
                                0
                            ),
                            new Question(
                                "Nabi menerima wahyu pada waktu:",
                                new List<string> { "Malam", "Siang", "Subuh" },
                                0
                            ),
                            new Question(
                                "Perintah pertama dalam Islam ialah:",
                                new List<string> { "Iqra'", "Sujud", "Berzikir" },
                                0
                            ),
                            new Question(
                                "Selepas menerima wahyu, Nabi pulang kepada:",
                                new List<string> { "Khadijah", "Abu Bakar", "Ali" },
                                0
                            ),
                            new Question(
                                "Khadijah menenangkan Nabi dengan:",
                                new List<string>
                                {
                                    "Memberi sokongan",
                                    "Mengejek Baginda",
                                    "Berlari ke rumah jiran",
                                },
                                0
                            ),
                            new Question(
                                "Nabi berdakwah secara senyap selama:",
                                new List<string> { "3 tahun", "1 tahun", "10 tahun" },
                                0
                            ),
                            new Question(
                                "Orang pertama memeluk Islam dari golongan wanita ialah:",
                                new List<string> { "Khadijah", "Aisyah", "Fatimah" },
                                0
                            ),
                            new Question(
                                "Orang pertama memeluk Islam dari kanak-kanak ialah:",
                                new List<string>
                                {
                                    "Ali bin Abi Talib",
                                    "Zaid bin Harithah",
                                    "Hasan",
                                },
                                0
                            ),
                            new Question(
                                "Surah Al-'Alaq mengajar kita supaya:",
                                new List<string>
                                {
                                    "Membaca dan menuntut ilmu",
                                    "Tidur awal",
                                    "Berdagang",
                                },
                                0
                            ),
                            new Question(
                                "Wahyu turun melalui:",
                                new List<string> { "Malaikat", "Mimpi biasa", "Orang soleh" },
                                0
                            ),
                            new Question(
                                "Nabi sangat suka berkhalwat kerana:",
                                new List<string>
                                {
                                    "Berfikir tentang ciptaan Allah",
                                    "Mengasing diri dari masyarakat",
                                    "Mengumpul harta",
                                },
                                0
                            ),
                            new Question(
                                "Ketika menerima wahyu, Nabi berasa:",
                                new List<string> { "Gementar", "Gembira", "Marah" },
                                0
                            ),
                            new Question(
                                "Dakwah awal tertumpu kepada:",
                                new List<string>
                                {
                                    "Ahli keluarga",
                                    "Ketua Quraisy",
                                    "Kaum Yahudi",
                                },
                                0
                            ),
                            new Question(
                                "Kebaikan membaca ialah:",
                                new List<string>
                                {
                                    "Menambah pengetahuan",
                                    "Membazir masa",
                                    "Menyusahkan",
                                },
                                0
                            ),
                            new Question(
                                "Zaid bin Harithah ialah:",
                                new List<string> { "Pembantu Nabi", "Musuh Nabi", "Ketua Quraisy" },
                                0
                            ),
                            new Question(
                                "Khadijah memberi sokongan kepada Nabi dalam bentuk:",
                                new List<string> { "Harta dan semangat", "Senjata", "Tentera" },
                                0
                            ),
                            new Question(
                                "Gelaran Khadijah ialah:",
                                new List<string>
                                {
                                    "Ibu orang beriman",
                                    "Puteri Quraisy",
                                    "Wanita Badar",
                                },
                                0
                            ),
                            new Question(
                                "Sifat Khadijah yang utama ialah:",
                                new List<string> { "Pemurah", "Bakhil", "Garang" },
                                0
                            ),
                            new Question(
                                "Peranan Khadijah sebagai isteri ialah:",
                                new List<string>
                                {
                                    "Menenangkan Nabi",
                                    "Mengawal dakwah",
                                    "Menghalang syiar",
                                },
                                0
                            ),
                            new Question(
                                "Khadijah sentiasa menjadi:",
                                new List<string>
                                {
                                    "Penyokong utama Nabi",
                                    "Pengkritik Nabi",
                                    "Penentang dakwah",
                                },
                                0
                            ),
                            new Question(
                                "Khadijah membantu Nabi ketika Baginda:",
                                new List<string> { "Menerima wahyu", "Berperang", "Berhijrah" },
                                0
                            ),
                            new Question(
                                "Khadijah menunjukkan kasih sayang dengan:",
                                new List<string>
                                {
                                    "Mengorbankan harta",
                                    "Menolak Nabi",
                                    "Marah kepada Nabi",
                                },
                                0
                            ),
                            new Question(
                                "Khadijah menjadi pembantu Nabi dengan:",
                                new List<string>
                                {
                                    "Mengurus keperluan rumah",
                                    "Menyuruh Nabi bekerja lebih",
                                    "Meninggalkan rumah",
                                },
                                0
                            ),
                            new Question(
                                "Tahun wafat Khadijah dikenali sebagai:",
                                new List<string>
                                {
                                    "Tahun Kesedihan",
                                    "Tahun Gajah",
                                    "Tahun Hijrah",
                                },
                                0
                            ),
                            new Question(
                                "Nabi menghargai Khadijah kerana:",
                                new List<string>
                                {
                                    "Jasanya besar",
                                    "Rumahnya besar",
                                    "Harta banyak",
                                },
                                0
                            ),
                        },
                    },
                    // LEVEL ADAB TAHAP 3
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Orang dewasa bermaksud ..",
                                new List<string>
                                {
                                    "Kanak-kanak kecil",
                                    "Individu yang sudah matang",
                                    "Bayi",
                                },
                                1
                            ),
                            new Question(
                                "Orang tua merujuk kepada ...",
                                new List<string> { "Warga emas", "Remaja", "Pelajar sekolah" },
                                0
                            ),
                            new Question(
                                "Salah satu dalil berbuat baik kepada ibu bapa ialah ...",
                                new List<string> { "Suruhan jiran", "Al-Quran", "Buku cerita" },
                                1
                            ),
                            new Question(
                                "Antara adab dengan orang tua ialah ...",
                                new List<string>
                                {
                                    "Menjerit kepada mereka",
                                    "Menghormati percakapan mereka",
                                    "Mengabaikan arahan",
                                },
                                1
                            ),
                            new Question(
                                "Faedah beradab dengan orang tua ialah ...",
                                new List<string>
                                {
                                    "Disayangi Allah",
                                    "Dibenci semua orang",
                                    "Hidup kesunyian",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beradab dengan orang dewasa ialah ...",
                                new List<string> { "Ramai kawan", "Mendapat dosa", "Dipuji guru" },
                                1
                            ),
                            new Question(
                                "Tanggungjawab anak kepada ibu bapa ialah ...",
                                new List<string>
                                {
                                    "Menjawab dengan kasar",
                                    "Menolong mereka",
                                    "Menyuruh mereka bekerja",
                                },
                                1
                            ),
                            new Question(
                                "Contoh orang dewasa ialah ...",
                                new List<string>
                                {
                                    "Murid Tahun 1",
                                    "Penjaga sekolah",
                                    "Bayi baru lahir",
                                },
                                1
                            ),
                            new Question(
                                "Apabila ibu bapa bercakap, anak perlu ...",
                                new List<string>
                                {
                                    "Mengabaikan",
                                    "Mendengar dengan baik",
                                    "Berlari keluar",
                                },
                                1
                            ),
                            new Question(
                                "Menghormati orang tua membawa kepada",
                                new List<string>
                                {
                                    "Hubungan keluarga yang baik",
                                    "Perselisihan faham",
                                    "Kesedihan",
                                },
                                0
                            ),
                            new Question(
                                "Jiran bermaksud ..",
                                new List<string>
                                {
                                    "Orang yang tinggal jauh",
                                    "Orang yang tinggal berdekatan",
                                    "Orang dalam sekolah",
                                },
                                1
                            ),
                            new Question(
                                "Dalil adab berjiran mengajar kita supaya ...",
                                new List<string>
                                {
                                    "Bermusuhan",
                                    "Saling membantu",
                                    "Menyakiti jiran",
                                },
                                1
                            ),
                            new Question(
                                "Adab dengan jiran Islam dan bukan Islam termasuk ...",
                                new List<string>
                                {
                                    "Mengutuk",
                                    "Mengganggu waktu rehat",
                                    "Bertegur sapa",
                                },
                                2
                            ),
                            new Question(
                                "Faedah beradab dengan jiran ialah ...",
                                new List<string>
                                {
                                    "Dihormati masyarakat",
                                    "Rumah menjadi kotor",
                                    "Tidak dikenali sesiapa",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beradab dengan jiran ialah ...",
                                new List<string>
                                {
                                    "Hidup aman",
                                    "Berlaku pergaduhan",
                                    "Jiran semakin rapat",
                                },
                                1
                            ),
                            new Question(
                                "Salah satu hak jiran ialah",
                                new List<string>
                                {
                                    "Dicerca",
                                    "Tidak dilayan",
                                    "Dibantu ketika susah",
                                },
                                2
                            ),
                            new Question(
                                "Jiran bukan Islam perlu ...",
                                new List<string> { "Dipandang rendah", "Dihormati", "Dihina" },
                                1
                            ),
                            new Question(
                                "Perbuatan menghidupkan muzik kuat hingga mengganggu jiran ialah ...",
                                new List<string> { "Baik", "Buruk", "Sunat" },
                                1
                            ),
                            new Question(
                                "Memberi salam kepada jiran adalah amalan ...",
                                new List<string>
                                {
                                    "Tidak digalakkan",
                                    "Harus dielakkan",
                                    "Beradab",
                                },
                                2
                            ),
                            new Question(
                                "Jika jiran ditimpa musibah, kita perlu ...",
                                new List<string>
                                {
                                    "Melarikan diri",
                                    "Menunjukkan simpati",
                                    "Mengejek",
                                },
                                1
                            ),
                            new Question(
                                "Tetamu ialah ...",
                                new List<string>
                                {
                                    "Orang yang datang berkunjung",
                                    "Binatang peliharaan",
                                    "Barang rumah",
                                },
                                0
                            ),
                            new Question(
                                "Dalil adab melayan tetamu mengajar supaya ...",
                                new List<string>
                                {
                                    "Kedekut",
                                    "Menghina tetamu",
                                    "Muliakan tetamu",
                                },
                                2
                            ),
                            new Question(
                                "Adab melayan tetamu termasuk",
                                new List<string>
                                {
                                    "Menyambut dengan senyuman",
                                    "Menutup pintu muka tetamu",
                                    "Membiarkan tetamu berdiri lama",
                                },
                                0
                            ),
                            new Question(
                                "Faedah melayan tetamu ialah ..",
                                new List<string>
                                {
                                    "Dipandang baik",
                                    "Dipandang sombong",
                                    "Dipulaukan",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beradab dengan tetamu ialah ...",
                                new List<string>
                                {
                                    "Tetamu berasa gembira",
                                    "Rumah disukai semua",
                                    "Hubungan renggang",
                                },
                                2
                            ),
                            new Question(
                                "Adab sebagai tetamu ialah.",
                                new List<string>
                                {
                                    "Mengotorkan rumah tuan",
                                    "Menghormati masa tuan rumah",
                                    "Memarahi tuan rumah",
                                },
                                1
                            ),
                            new Question(
                                "Batas pergaulan dengan tetamu perlu dijaga supaya ...",
                                new List<string>
                                {
                                    "Tidak menimbulkan fitnah",
                                    "Melakukan perkara haram",
                                    "Mengganggu jiran",
                                },
                                0
                            ),
                            new Question(
                                "Tetamu yang baik tidak ...",
                                new List<string>
                                {
                                    "Mengambil barang tanpa izin",
                                    "Mengucap terima kasih",
                                    "Menghormati ruang tuan rumah",
                                },
                                0
                            ),
                            new Question(
                                "Tuan rumah perlu ...",
                                new List<string>
                                {
                                    "Membiarkan tetamu menunggu",
                                    "Menyambut tetamu",
                                    "Berpura-pura tiada di rumah",
                                },
                                1
                            ),
                            new Question(
                                "Melayan tetamu dengan baik adalah ...",
                                new List<string>
                                {
                                    "Adab yang dituntut",
                                    "Tidak penting",
                                    "Dilarang",
                                },
                                0
                            ),
                            new Question(
                                "OKU bermaksud ..",
                                new List<string>
                                {
                                    "Orang yang kuat",
                                    "Orang yang sempurna",
                                    "Orang yang mempunyai kekurangan tertentu",
                                },
                                2
                            ),
                            new Question(
                                "Kategori OKU termasuk ...",
                                new List<string>
                                {
                                    "Pendengaran",
                                    "Kesihatan normal",
                                    "Kecergasan penuh",
                                },
                                0
                            ),
                            new Question(
                                "Adab dengan OKU ialah ...",
                                new List<string>
                                {
                                    "Mengaibkan mereka",
                                    "Menghulurkan bantuan",
                                    "Mentertawakan kekurangan",
                                },
                                1
                            ),
                            new Question(
                                "Faedah beradab dengan OKU ialah ...",
                                new List<string>
                                {
                                    "Mendapat pahala",
                                    "Mendapat musuh",
                                    "Dibenci Allah",
                                },
                                0
                            ),
                            new Question(
                                "Tidak menghormati OKU menyebabkan ..",
                                new List<string>
                                {
                                    "Hubungan baik",
                                    "Perbalahan",
                                    "Kasih sayang bertambah",
                                },
                                1
                            ),
                            new Question(
                                "Al-Quran ialah.",
                                new List<string> { "Kalimah Allah", "Buku cerita", "Nota sekolah" },
                                0
                            ),
                            new Question(
                                "Adab dengan Al-Quran termasuk ...",
                                new List<string>
                                {
                                    "Letak di lantai",
                                    "Menjaga kebersihan diri",
                                    "Membuka halaman secara kasar",
                                },
                                1
                            ),
                            new Question(
                                "Faedah beradab dengan Al-Quran ialah ...",
                                new List<string>
                                {
                                    "Dijauhi rahmat",
                                    "Mendapat hidayah",
                                    "Hati menjadi gelap",
                                },
                                1
                            ),
                            new Question(
                                "Akibat tidak beradab dengan Al-Quran ialah ...",
                                new List<string>
                                {
                                    "Mendapat pahala",
                                    "Menjadi lebih baik",
                                    "Mendapat dosa",
                                },
                                2
                            ),
                            new Question(
                                "Menghormati kitab dan buku bermaksud ...",
                                new List<string>
                                {
                                    "Merosakkan buku",
                                    "Menjaga dengan rapi",
                                    "Membuang sesuka hati",
                                },
                                1
                            ),
                            new Question(
                                "Guru bermaksud ...",
                                new List<string>
                                {
                                    "Orang yang mengajar",
                                    "Kawan sebaya",
                                    "Jiran sebelah rumah",
                                },
                                0
                            ),
                            new Question(
                                "Adab dengan guru termasuk ...",
                                new List<string>
                                {
                                    "Mengucap salam",
                                    "Menjerit ketika guru mengajar",
                                    "Tidak menyiapkan kerja",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beradab dengan guru ialah ...",
                                new List<string>
                                {
                                    "Mendapat keberkatan",
                                    "Sukar mendapat ilmu",
                                    "Menjadi murid cemerlang",
                                },
                                1
                            ),
                            new Question(
                                "Mendengar arahan guru adalah ...",
                                new List<string> { "Tidak penting", "Satu adab", "Dilarang" },
                                1
                            ),
                            new Question(
                                "Guru yang dihormati akan ...",
                                new List<string>
                                {
                                    "Tidak suka mengajar",
                                    "Lebih mudah memberi ilmu",
                                    "Membenci murid",
                                },
                                1
                            ),
                            new Question(
                                "Adab ketika belajar ialah ...",
                                new List<string>
                                {
                                    "Suka bising",
                                    "Memulakan dengan doa",
                                    "Mengganggu kawan",
                                },
                                1
                            ),
                            new Question(
                                "Perkara yang perlu dihindari ketika belajar ialah ...",
                                new List<string>
                                {
                                    "Menumpukan perhatian",
                                    "Makan sambil belajar",
                                    "Mengulang kaji",
                                },
                                1
                            ),
                            new Question(
                                "Faedah beradab ketika belajar ialah ...",
                                new List<string>
                                {
                                    "Mudah memahami pelajaran",
                                    "Semakin malas",
                                    "Tidak berjaya",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beradab ketika belajar ialah ...",
                                new List<string>
                                {
                                    "Lemah dalam pelajaran",
                                    "Menjadi cemerlang",
                                    "Mendapat banyak pahala",
                                },
                                0
                            ),
                            new Question(
                                "Kepentingan menjaga kebersihan sekolah ialah ...",
                                new List<string>
                                {
                                    "Mewujudkan persekitaran sihat",
                                    "Menyebabkan penyakit",
                                    "Menimbulkan bau busuk",
                                },
                                0
                            ),
                        },
                    },
                    // level Akidah Tahap 4
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Apakah maksud qada' dan qadar?",
                                new List<string>
                                {
                                    "Perintah manusia",
                                    "Ketentuan Allah sejak azali",
                                    "Pilihan hamba",
                                    "Keputusan imam",
                                },
                                1
                            ),
                            new Question(
                                "Beriman dengan qada' dan qadar hukumnya?",
                                new List<string> { "Sunat", "Harus", "Wajib", "Makruh" },
                                2
                            ),
                            new Question(
                                "Salah satu ciri orang yang beriman dengan qada' dan qadar ialah?",
                                new List<string>
                                {
                                    "Cepat marah",
                                    "Redha dan sabar",
                                    "Putus asa",
                                    "Takbur",
                                },
                                1
                            ),
                            new Question(
                                "Orang yang tidak percaya kepada qada' dan qadar termasuk dalam golongan?",
                                new List<string> { "Mukmin", "Kafir", "Soleh", "Musafir" },
                                1
                            ),
                            new Question(
                                "Percaya kepada qada' dan qadar termasuk dalam rukun?",
                                new List<string> { "Islam", "Iman", "Ihsan", "Syariat" },
                                1
                            ),
                            new Question(
                                "Qada' ialah?",
                                new List<string>
                                {
                                    "Ketentuan Allah sejak azali",
                                    "Ketentuan setelah berlaku",
                                    "Usaha manusia",
                                    "Keputusan hakim",
                                },
                                0
                            ),
                            new Question(
                                "Qadar ialah?",
                                new List<string>
                                {
                                    "Takdir yang berlaku kepada makhluk",
                                    "Pilihan manusia",
                                    "Keputusan imam",
                                    "Sifat manusia",
                                },
                                0
                            ),
                            new Question(
                                "Orang beriman dengan qada' dan qadar akan sentiasa?",
                                new List<string>
                                {
                                    "Sabar dan redha",
                                    "Gelisah",
                                    "Marah",
                                    "Putus asa",
                                },
                                0
                            ),
                            new Question(
                                "Apabila mendapat nikmat, orang beriman dengan qada' dan qadar akan?",
                                new List<string> { "Kufur", "Bersyukur", "Marah", "Putus asa" },
                                1
                            ),
                            new Question(
                                "Apabila ditimpa musibah, orang beriman dengan qada' dan qadar akan?",
                                new List<string> { "Sabar", "Menangis", "Putus asa", "Mengeluh" },
                                0
                            ),
                            new Question(
                                "Qada' dan qadar menunjukkan Allah Maha?",
                                new List<string> { "Mengetahui", "Lemah", "Lupa", "Sakit" },
                                0
                            ),
                            new Question(
                                "Percaya qada' dan qadar menjadikan hati?",
                                new List<string> { "Tenang", "Gelisah", "Takut", "Malas" },
                                0
                            ),
                            new Question(
                                "Apakah maksud sifat Wahdaniyah?",
                                new List<string>
                                {
                                    "Allah Maha Esa",
                                    "Allah Maha Pemurah",
                                    "Allah Maha Kuasa",
                                    "Allah Maha Bijaksana",
                                },
                                0
                            ),
                            new Question(
                                "Dalil naqli sifat Wahdaniyah terdapat dalam surah?",
                                new List<string>
                                {
                                    "Al-Ikhlas",
                                    "Al-Fatihah",
                                    "Al-Baqarah",
                                    "An-Nas",
                                },
                                0
                            ),
                            new Question(
                                "Dalil aqli sifat Wahdaniyah ialah?",
                                new List<string>
                                {
                                    "Alam ini menunjukkan adanya Tuhan yang satu",
                                    "Semua orang berkata begitu",
                                    "Manusia menulis buku",
                                    "Semua benda sama",
                                },
                                0
                            ),
                            new Question(
                                "Sifat yang berlawanan dengan Wahdaniyah ialah?",
                                new List<string>
                                {
                                    "Berbilang-bilang",
                                    "Esa",
                                    "Maha Kuasa",
                                    "Maha Pemurah",
                                },
                                0
                            ),
                            new Question(
                                "Orang yang tidak percaya kepada sifat Wahdaniyah ialah?",
                                new List<string> { "Kafir", "Mukmin", "Soleh", "Sabar" },
                                0
                            ),
                            new Question(
                                "Apabila beriman dengan sifat Wahdaniyah, kita akan?",
                                new List<string>
                                {
                                    "Menyembah Allah sahaja",
                                    "Menyembah banyak tuhan",
                                    "Tidak menyembah Allah",
                                    "Menjadi sombong",
                                },
                                0
                            ),
                            new Question(
                                "Allah Maha Esa bermaksud Allah tiada?",
                                new List<string> { "Sekutu", "Kuasa", "Ilmu", "Kekayaan" },
                                0
                            ),
                            new Question(
                                "Manusia yang percaya kepada banyak tuhan dipanggil?",
                                new List<string> { "Musyrik", "Mukmin", "Soleh", "Sabar" },
                                0
                            ),
                            new Question(
                                "Sifat Wahdaniyah menunjukkan Allah itu?",
                                new List<string> { "Esa dan tunggal", "Banyak", "Dua", "Tiga" },
                                0
                            ),
                            new Question(
                                "Dalil naqli Wahdaniyah bermaksud?",
                                new List<string>
                                {
                                    "Dalil daripada al-Quran dan hadis",
                                    "Dalil daripada akal",
                                    "Dalil daripada manusia",
                                    "Dalil daripada sejarah",
                                },
                                0
                            ),
                            new Question(
                                "Dalil agli Wahdaniyah bermaksud?",
                                new List<string>
                                {
                                    "Dalil daripada akal fikiran",
                                    "Dalil daripada al-Quran",
                                    "Dalil daripada hadis",
                                    "Dalil daripada kitab Injil",
                                },
                                0
                            ),
                            new Question(
                                "Hikmah beriman dengan sifat Wahdaniyah ialah?",
                                new List<string>
                                {
                                    "Menjadi lebih taat kepada Allah",
                                    "Menjadi sombong",
                                    "Menjadi lalai",
                                    "Menjadi malas",
                                },
                                0
                            ),
                            new Question(
                                "Apakah maksud sifat Qudrat?",
                                new List<string>
                                {
                                    "Allah Maha Berkuasa",
                                    "Allah Maha Kaya",
                                    "Allah Maha Bijaksana",
                                    "Allah Maha Pengasih",
                                },
                                0
                            ),
                            new Question(
                                "Dalil naqli sifat Qudrat terdapat dalam ayat?",
                                new List<string>
                                {
                                    "Allah berkuasa atas tiap-tiap sesuatu",
                                    "Allah Maha Esa",
                                    "Allah Maha Penyayang",
                                    "Allah Maha Mengetahui",
                                },
                                0
                            ),
                            new Question(
                                "Dalil agli sifat Qudrat ialah?",
                                new List<string>
                                {
                                    "Alam yang sempurna menunjukkan adanya kuasa Allah",
                                    "Semua orang kata begitu",
                                    "Semua benda sama",
                                    "Tiada bukti",
                                },
                                0
                            ),
                            new Question(
                                "Sifat yang berlawanan dengan Qudrat ialah?",
                                new List<string> { "Lemah", "Berkuasa", "Kuat", "Sabar" },
                                0
                            ),
                            new Question(
                                "Orang yang beriman dengan sifat Qudrat percaya bahawa Allah?",
                                new List<string>
                                {
                                    "Maha Berkuasa",
                                    "Lemah",
                                    "Tidak tahu",
                                    "Tidak mampu",
                                },
                                0
                            ),
                            new Question(
                                "Beriman dengan sifat Qudrat menjadikan kita?",
                                new List<string>
                                {
                                    "Yakin kepada Allah",
                                    "Putus asa",
                                    "Lemah iman",
                                    "Takbur",
                                },
                                0
                            ),
                            new Question(
                                "Contoh sifat Qudrat Allah ialah?",
                                new List<string>
                                {
                                    "Mencipta alam",
                                    "Makan dan minum",
                                    "Tidur",
                                    "Berjalan",
                                },
                                0
                            ),
                            new Question(
                                "Allah tidak mungkin bersifat?",
                                new List<string>
                                {
                                    "Lemah",
                                    "Berkuasa",
                                    "Maha Mengetahui",
                                    "Maha Bijaksana",
                                },
                                0
                            ),
                            new Question(
                                "Dalil naqli sifat Qudrat ialah ayat al-Quran yang menyebut?",
                                new List<string>
                                {
                                    "Allah berkuasa atas tiap-tiap sesuatu",
                                    "Allah Maha Pemurah",
                                    "Allah Maha Esa",
                                    "Allah Maha Penyabar",
                                },
                                0
                            ),
                            new Question(
                                "Dalil agli sifat Qudrat ialah akal yang melihat?",
                                new List<string>
                                {
                                    "Alam ciptaan Allah",
                                    "Buku manusia",
                                    "Gambar",
                                    "Rumah",
                                },
                                0
                            ),
                            new Question(
                                "Hikmah beriman dengan sifat Qudrat ialah?",
                                new List<string>
                                {
                                    "Menjadi lebih yakin dan taat kepada Allah",
                                    "Menjadi malas",
                                    "Menjadi lalai",
                                    "Menjadi sombong",
                                },
                                0
                            ),
                            new Question(
                                "Allah berkuasa mencipta?",
                                new List<string>
                                {
                                    "Alam semesta",
                                    "Telefon",
                                    "Kereta",
                                    "Komputer",
                                },
                                0
                            ),
                            new Question(
                                "Manusia diciptakan oleh?",
                                new List<string> { "Malaikat", "Jin", "Allah", "Nabi" },
                                2
                            ),
                            new Question(
                                "Proses kejadian manusia bermula dengan?",
                                new List<string> { "Air mani", "Tanah", "Tulang", "Darah" },
                                0
                            ),
                            new Question(
                                "Al-Quran menyebut kejadian manusia bermula daripada?",
                                new List<string> { "Tanah", "Kayu", "Batu", "Besi" },
                                0
                            ),
                            new Question(
                                "Janin berada dalam rahim ibu selama?",
                                new List<string> { "9 bulan", "5 bulan", "3 bulan", "7 bulan" },
                                0
                            ),
                            new Question(
                                "Proses kejadian manusia dalam al-Quran disebut dalam surah?",
                                new List<string>
                                {
                                    "Al-Mukminun",
                                    "Al-Fatihah",
                                    "Al-Ikhlas",
                                    "An-Nas",
                                },
                                0
                            ),
                            new Question(
                                "Proses kejadian manusia bermula dengan nutfah, kemudian?",
                                new List<string> { "Alaqah", "Mudghah", "Tulang", "Daging" },
                                0
                            ),
                            new Question(
                                "Selepas alaqah, kejadian manusia menjadi?",
                                new List<string> { "Mudghah", "Nutfah", "Tanah", "Air" },
                                0
                            ),
                            new Question(
                                "Selepas mudghah, Allah menjadikan?",
                                new List<string> { "Tulang", "Darah", "Air", "Rambut" },
                                0
                            ),
                            new Question(
                                "Selepas tulang, Allah menutupinya dengan?",
                                new List<string> { "Daging", "Kulit", "Air", "Rambut" },
                                0
                            ),
                            new Question(
                                "Proses kejadian manusia membuktikan bahawa Allah?",
                                new List<string> { "Maha Pencipta", "Lemah", "Sakit", "Lalai" },
                                0
                            ),
                            new Question(
                                "Manusia melalui berapa fasa kehidupan?",
                                new List<string> { "Lima", "Dua", "Tiga", "Empat" },
                                0
                            ),
                            new Question(
                                "Fasa pertama kehidupan manusia ialah?",
                                new List<string>
                                {
                                    "Dalam kandungan",
                                    "Kanak-kanak",
                                    "Dewasa",
                                    "Tua",
                                },
                                0
                            ),
                            new Question(
                                "Fasa terakhir kehidupan manusia ialah?",
                                new List<string> { "Mati", "Kanak-kanak", "Remaja", "Tua" },
                                0
                            ),
                            new Question(
                                "Penciptaan manusia membuktikan kewujudan?",
                                new List<string> { "Allah", "Malaikat", "Syaitan", "Nabi" },
                                0
                            ),
                        },
                    },
                    // level Ibadah Tahap 4
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Apakah maksud solat berjemaah?",
                                new List<string>
                                {
                                    "Solat seorang diri",
                                    "Solat yang dilakukan bersama imam dan makmum",
                                    "Solat ketika sakit",
                                    "Solat ketika musafir",
                                },
                                1
                            ),
                            new Question(
                                "Apakah kelebihan solat berjemaah berbanding solat seorang?",
                                new List<string>
                                {
                                    "Sama sahaja",
                                    "10 darjat",
                                    "27 darjat",
                                    "100 darjat",
                                },
                                2
                            ),
                            new Question(
                                "Siapakah yang memimpin solat berjemaah?",
                                new List<string> { "Muazzin", "Imam", "Makmum", "Bilal" },
                                1
                            ),
                            new Question(
                                "Makmum hendaklah mengikut imam dengan?",
                                new List<string>
                                {
                                    "Mendahului imam",
                                    "Mengikut pergerakan imam",
                                    "Lambat dari imam",
                                    "Tidak ikut langsung",
                                },
                                1
                            ),
                            new Question(
                                "Saf solat berjemaah mestilah?",
                                new List<string>
                                {
                                    "Lurus dan rapat",
                                    "Bengkok",
                                    "Jauh-jauh",
                                    "Berselerak",
                                },
                                0
                            ),
                            new Question(
                                "Solat Jumaat dilakukan pada hari?",
                                new List<string> { "Isnin", "Jumaat", "Sabtu", "Ahad" },
                                1
                            ),
                            new Question(
                                "Bilangan rakaat solat Jumaat ialah?",
                                new List<string>
                                {
                                    "Dua rakaat",
                                    "Tiga rakaat",
                                    "Empat rakaat",
                                    "Lima rakaat",
                                },
                                0
                            ),
                            new Question(
                                "Solat Jumaat menggantikan solat?",
                                new List<string> { "Subuh", "Zohor", "Asar", "Maghrib" },
                                1
                            ),
                            new Question(
                                "Khutbah Jumaat dilakukan sebanyak?",
                                new List<string>
                                {
                                    "Sekali",
                                    "Dua kali",
                                    "Tiga kali",
                                    "Empat kali",
                                },
                                1
                            ),
                            new Question(
                                "Siapakah yang wajib menunaikan solat Jumaat?",
                                new List<string>
                                {
                                    "Semua orang Islam",
                                    "Lelaki Islam yang cukup syarat",
                                    "Perempuan",
                                    "Kanak-kanak",
                                },
                                1
                            ),
                            new Question(
                                "Apakah maksud solat jamak?",
                                new List<string>
                                {
                                    "Menghimpunkan dua solat fardu dalam satu waktu",
                                    "Meringankan solat",
                                    "Mengganti solat",
                                    "Menambah solat",
                                },
                                0
                            ),
                            new Question(
                                "Apakah maksud solat qasar?",
                                new List<string>
                                {
                                    "Menghimpunkan dua solat",
                                    "Memendekkan solat fardu empat rakaat kepada dua rakaat",
                                    "Mengganti solat",
                                    "Menambah rakaat solat",
                                },
                                1
                            ),
                            new Question(
                                "Solat jamak terbahagi kepada berapa jenis?",
                                new List<string> { "Satu", "Dua", "Tiga", "Empat" },
                                1
                            ),
                            new Question(
                                "Solat Zohor dan Asar boleh dijamak pada waktu?",
                                new List<string> { "Pagi", "Malam", "Zohor atau Asar", "Subuh" },
                                2
                            ),
                            new Question(
                                "Syarat utama solat jamak dan qasar ialah?",
                                new List<string> { "Bermusafir", "Sakit", "Malas", "Sibuk" },
                                0
                            ),
                            new Question(
                                "Orang sakit yang tidak mampu berdiri boleh solat dengan?",
                                new List<string>
                                {
                                    "Duduk",
                                    "Berbaring",
                                    "Isyarat mata",
                                    "Semua di atas",
                                },
                                3
                            ),
                            new Question(
                                "Orang sakit yang tidak mampu berwuduk boleh?",
                                new List<string> { "Tidak solat", "Bertayammum", "Mandi", "Tidur" },
                                1
                            ),
                            new Question(
                                "Apabila tidak mampu rukuk dan sujud, orang sakit boleh?",
                                new List<string>
                                {
                                    "Ganti solat",
                                    "Isyarat dengan kepala",
                                    "Tidak solat",
                                    "Tidur",
                                },
                                1
                            ),
                            new Question(
                                "Apabila tidak mampu bergerak langsung, orang sakit boleh?",
                                new List<string>
                                {
                                    "Tinggalkan solat",
                                    "Solat dengan hati",
                                    "Solat dengan tangan",
                                    "Tidur",
                                },
                                1
                            ),
                            new Question(
                                "Islam mengajar kita supaya?",
                                new List<string>
                                {
                                    "Tidak solat ketika sakit",
                                    "Tetap solat mengikut kemampuan",
                                    "Meninggalkan solat",
                                    "Melengah-lengahkan solat",
                                },
                                1
                            ),
                            new Question(
                                "Apakah maksud solat dalam kenderaan?",
                                new List<string>
                                {
                                    "Solat ketika berada di masjid",
                                    "Solat ketika menaiki kenderaan",
                                    "Solat sambil berjalan",
                                    "Solat sambil berlari",
                                },
                                1
                            ),
                            new Question(
                                "Solat dalam kenderaan biasanya dilakukan ketika?",
                                new List<string>
                                {
                                    "Bermusafir jauh",
                                    "Berjalan kaki",
                                    "Tidur",
                                    "Bermain",
                                },
                                0
                            ),
                            new Question(
                                "Arah kiblat bagi solat dalam kenderaan ialah?",
                                new List<string>
                                {
                                    "Tidak penting",
                                    "Mengikut kemampuan",
                                    "Ke mana-mana",
                                    "Menghadap utara",
                                },
                                1
                            ),
                            new Question(
                                "Solat sunat boleh dilakukan dalam kenderaan dengan?",
                                new List<string>
                                {
                                    "Isyarat kepala",
                                    "Berdiri tegak",
                                    "Duduk atas tanah",
                                    "Sujud betul-betul",
                                },
                                0
                            ),
                            new Question(
                                "Solat fardu dalam kenderaan hanya boleh dilakukan jika?",
                                new List<string>
                                {
                                    "Sangat darurat",
                                    "Malas turun",
                                    "Tidak mahu berhenti",
                                    "Hendak cepat sampai",
                                },
                                0
                            ),
                            new Question(
                                "Orang yang mendapat pahala 27 darjat dalam solat ialah?",
                                new List<string>
                                {
                                    "Orang solat berjemaah",
                                    "Orang solat seorang",
                                    "Orang tidur",
                                    "Orang makan",
                                },
                                0
                            ),
                            new Question(
                                "Apakah hukum solat berjemaah bagi lelaki?",
                                new List<string> { "Sunat muakkad", "Wajib", "Harus", "Makruh" },
                                0
                            ),
                            new Question(
                                "Orang perempuan hukumnya solat Jumaat?",
                                new List<string> { "Wajib", "Tidak wajib", "Sunat", "Makruh" },
                                1
                            ),
                            new Question(
                                "Solat jamak taqdim bermaksud?",
                                new List<string>
                                {
                                    "Menghimpunkan solat di waktu yang pertama",
                                    "Menghimpunkan solat di waktu kedua",
                                    "Memendekkan solat",
                                    "Menambah solat",
                                },
                                0
                            ),
                            new Question(
                                "Solat jamak takhir bermaksud?",
                                new List<string>
                                {
                                    "Menghimpunkan solat di waktu yang kedua",
                                    "Menghimpunkan solat di waktu pertama",
                                    "Memendekkan solat",
                                    "Menambah solat",
                                },
                                0
                            ),
                            new Question(
                                "Solat qasar dilakukan pada solat?",
                                new List<string>
                                {
                                    "Empat rakaat",
                                    "Tiga rakaat",
                                    "Dua rakaat",
                                    "Semua solat",
                                },
                                0
                            ),
                            new Question(
                                "Orang sakit yang tidak boleh bertayammum boleh?",
                                new List<string>
                                {
                                    "Solat dengan isyarat",
                                    "Tidak solat",
                                    "Tunda solat",
                                    "Tidak perlu solat",
                                },
                                0
                            ),
                            new Question(
                                "Apakah syarat sah solat Jumaat?",
                                new List<string>
                                {
                                    "Didirikan di tempat bermukim",
                                    "Didirikan di padang pasir",
                                    "Dilakukan seorang diri",
                                    "Dilakukan di rumah",
                                },
                                0
                            ),
                            new Question(
                                "Bilangan minimum jemaah untuk solat Jumaat ialah?",
                                new List<string> { "40 orang", "10 orang", "2 orang", "100 orang" },
                                0
                            ),
                            new Question(
                                "Apabila bermusafir, solat Asar boleh diqasar kepada?",
                                new List<string>
                                {
                                    "Dua rakaat",
                                    "Empat rakaat",
                                    "Tiga rakaat",
                                    "Satu rakaat",
                                },
                                0
                            ),
                            new Question(
                                "Apabila bermusafir, solat Zohor boleh dijamak dengan?",
                                new List<string> { "Asar", "Maghrib", "Subuh", "Isyak" },
                                0
                            ),
                            new Question(
                                "Orang sakit yang tidak mampu mengangkat tangan untuk takbir boleh?",
                                new List<string>
                                {
                                    "Isyarat dengan jari",
                                    "Tidak solat",
                                    "Menunda solat",
                                    "Menghadap ke lain",
                                },
                                0
                            ),
                            new Question(
                                "Solat dalam kapal terbang dilakukan dengan cara?",
                                new List<string>
                                {
                                    "Duduk dan isyarat kepala",
                                    "Tidur",
                                    "Tidak solat",
                                    "Berdiri penuh",
                                },
                                0
                            ),
                            new Question(
                                "Apakah hikmah solat berjemaah?",
                                new List<string>
                                {
                                    "Menguatkan ukhuwah",
                                    "Membazir masa",
                                    "Melemahkan iman",
                                    "Menjadi malas",
                                },
                                0
                            ),
                            new Question(
                                "Solat Jumaat diwajibkan kepada lelaki yang?",
                                new List<string>
                                {
                                    "Bermukim",
                                    "Musafir",
                                    "Kanak-kanak",
                                    "Orang sakit",
                                },
                                0
                            ),
                            new Question(
                                "Solat jamak biasanya dilakukan ketika?",
                                new List<string> { "Bermusafir", "Bermain", "Bekerja", "Tidur" },
                                0
                            ),
                            new Question(
                                "Solat qasar tidak boleh dilakukan bagi solat?",
                                new List<string> { "Subuh dan Maghrib", "Zohor", "Asar", "Isyak" },
                                0
                            ),
                            new Question(
                                "Solat orang sakit menunjukkan bahawa Islam itu?",
                                new List<string> { "Mudah", "Susah", "Berat", "Tidak adil" },
                                0
                            ),
                            new Question(
                                "Solat dalam kenderaan lebih utama dilakukan jika?",
                                new List<string>
                                {
                                    "Solat sunat",
                                    "Solat Jumaat",
                                    "Solat fardu",
                                    "Solat berjemaah",
                                },
                                0
                            ),
                            new Question(
                                "Apabila tidak mampu rukuk, orang sakit boleh ganti dengan?",
                                new List<string>
                                {
                                    "Menundukkan kepala sedikit",
                                    "Berdiri tegak",
                                    "Duduk sahaja",
                                    "Tidur",
                                },
                                0
                            ),
                            new Question(
                                "Apakah hukum solat Jumaat bagi lelaki yang musafir?",
                                new List<string> { "Gugur kewajipan", "Wajib", "Sunat", "Makruh" },
                                0
                            ),
                            new Question(
                                "Apakah solat yang boleh dijamak dengan solat Isyak?",
                                new List<string> { "Maghrib", "Zohor", "Asar", "Subuh" },
                                0
                            ),
                            new Question(
                                "Solat qasar dilakukan apabila perjalanan melebihi?",
                                new List<string>
                                {
                                    "Dua marhalah",
                                    "Satu marhalah",
                                    "Tiga marhalah",
                                    "Empat marhalah",
                                },
                                0
                            ),
                            new Question(
                                "Apabila sakit, jika tidak mampu berdiri maka solat dengan?",
                                new List<string>
                                {
                                    "Duduk",
                                    "Baring",
                                    "Tidur",
                                    "Tidak perlu solat",
                                },
                                0
                            ),
                            new Question(
                                "Apabila sakit dan tidak mampu duduk, maka solat dengan?",
                                new List<string>
                                {
                                    "Berbaring mengiring",
                                    "Tidur",
                                    "Tidak solat",
                                    "Menghadap ke lain",
                                },
                                0
                            ),
                        },
                    },
                    // level Sirah Tahap 4
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Siapakah malaikat yang menyampaikan wahyu pertama kepada Nabi Muhammad SAW?",
                                new List<string> { "Mikail", "Israfil", "Jibril", "Izrail" },
                                2
                            ),
                            new Question(
                                "Wahyu pertama diturunkan di?",
                                new List<string>
                                {
                                    "Gua Hira",
                                    "Gua Tsur",
                                    "Masjidil Haram",
                                    "Kaabah",
                                },
                                0
                            ),
                            new Question(
                                "Surah pertama yang diturunkan ialah?",
                                new List<string>
                                {
                                    "Al-Fatihah",
                                    "Al-Ikhlas",
                                    "Al-'Alaq ayat 1-5",
                                    "Al-Baqarah",
                                },
                                2
                            ),
                            new Question(
                                "Nabi Muhammad SAW mula berdakwah secara rahsia selama?",
                                new List<string> { "3 tahun", "5 tahun", "10 tahun", "13 tahun" },
                                0
                            ),
                            new Question(
                                "Siapakah sahabat pertama yang memeluk Islam?",
                                new List<string>
                                {
                                    "Abu Bakar",
                                    "Ali bin Abi Talib",
                                    "Khadijah",
                                    "Zaid bin Harithah",
                                },
                                2
                            ),
                            new Question(
                                "Mengapakah Rasulullah SAW memulakan dakwah secara rahsia?",
                                new List<string>
                                {
                                    "Kerana takut",
                                    "Kerana belum cukup ilmu",
                                    "Supaya Islam lebih kuat dahulu",
                                    "Kerana diperintah bapa saudara",
                                },
                                2
                            ),
                            new Question(
                                "Orang Quraisy menentang dakwah Rasulullah SAW kerana?",
                                new List<string>
                                {
                                    "Islam mengajar menyembah Allah Yang Esa",
                                    "Islam menyuruh minum arak",
                                    "Islam mengajar berhala disembah",
                                    "Islam membenarkan judi",
                                },
                                0
                            ),
                            new Question(
                                "Siapakah antara berikut yang menyokong Rasulullah SAW dalam dakwah?",
                                new List<string>
                                {
                                    "Abu Jahal",
                                    "Abu Lahab",
                                    "Abu Talib",
                                    "Utbah bin Rabi'ah",
                                },
                                2
                            ),
                            new Question(
                                "Apakah strategi Rasulullah SAW menghadapi tentangan Quraisy?",
                                new List<string>
                                {
                                    "Bersabar dan berdoa",
                                    "Memarahi mereka",
                                    "Menyembah berhala",
                                    "Berpaling dari dakwah",
                                },
                                0
                            ),
                            new Question(
                                "Akhlak Rasulullah SAW ketika berdakwah ialah?",
                                new List<string>
                                {
                                    "Sabar dan lemah lembut",
                                    "Marah-marah",
                                    "Menjerit",
                                    "Memaksa",
                                },
                                0
                            ),
                            new Question(
                                "Siapakah yang digelar As-Siddiq kerana membenarkan dakwah Rasulullah SAW?",
                                new List<string> { "Umar", "Uthman", "Abu Bakar", "Ali" },
                                2
                            ),
                            new Question(
                                "Siapakah pemuda pertama yang memeluk Islam?",
                                new List<string>
                                {
                                    "Ali bin Abi Talib",
                                    "Umar bin Khattab",
                                    "Zubair bin Awwam",
                                    "Talhah",
                                },
                                0
                            ),
                            new Question(
                                "Siapakah hamba pertama yang memeluk Islam?",
                                new List<string>
                                {
                                    "Bilal bin Rabah",
                                    "Zaid bin Harithah",
                                    "Salman al-Farisi",
                                    "Ammar bin Yasir",
                                },
                                0
                            ),
                            new Question(
                                "Apakah faedah dakwah secara rahsia?",
                                new List<string>
                                {
                                    "Islam dapat bertapak dengan selamat",
                                    "Islam hilang",
                                    "Islam ditolak",
                                    "Islam tidak berkembang",
                                },
                                0
                            ),
                            new Question(
                                "Golongan Quraisy menentang Islam kerana?",
                                new List<string>
                                {
                                    "Takut kehilangan pengaruh",
                                    "Islam membenarkan berhala",
                                    "Islam membenarkan arak",
                                    "Islam menyuruh berjudi",
                                },
                                0
                            ),
                            new Question(
                                "Apakah maksud dakwah secara terbuka?",
                                new List<string>
                                {
                                    "Menyampaikan Islam kepada umum",
                                    "Menyembunyikan Islam",
                                    "Mengajar hanya keluarga",
                                    "Tidak berdakwah",
                                },
                                0
                            ),
                            new Question(
                                "Antara yang menentang Rasulullah SAW ialah?",
                                new List<string> { "Abu Lahab", "Bilal", "Ali", "Abu Bakar" },
                                0
                            ),
                            new Question(
                                "Apakah sifat Rasulullah SAW ketika menyampaikan dakwah?",
                                new List<string> { "Lemah lembut", "Sombong", "Garang", "Marah" },
                                0
                            ),
                            new Question(
                                "Siapakah isteri pertama Rasulullah SAW yang sentiasa menyokong baginda?",
                                new List<string> { "Aisyah", "Hafsah", "Khadijah", "Ummu Salamah" },
                                2
                            ),
                            new Question(
                                "Apakah pengajaran dari dakwah secara rahsia?",
                                new List<string>
                                {
                                    "Kita perlu berhikmah dalam berdakwah",
                                    "Kita tidak perlu berdakwah",
                                    "Kita boleh menghina orang lain",
                                    "Kita boleh tinggalkan Islam",
                                },
                                0
                            ),
                            new Question(
                                "Siapakah sahabat yang terkenal dengan sifat dermawan dan berdakwah?",
                                new List<string> { "Abu Bakar", "Umar", "Uthman", "Ali" },
                                0
                            ),
                            new Question(
                                "Siapakah sahabat yang terkenal berani dan tegas dalam Islam?",
                                new List<string> { "Abu Bakar", "Umar", "Uthman", "Talhah" },
                                1
                            ),
                            new Question(
                                "Apakah peristiwa yang berlaku di Thaif?",
                                new List<string>
                                {
                                    "Rasulullah SAW diusir dan dicederakan",
                                    "Rasulullah SAW disambut baik",
                                    "Rasulullah SAW dilantik pemimpin",
                                    "Rasulullah SAW berkahwin",
                                },
                                0
                            ),
                            new Question(
                                "Rasulullah SAW berdoa di Thaif walaupun?",
                                new List<string>
                                {
                                    "Disakiti",
                                    "Dihormati",
                                    "Disanjung",
                                    "Disambut baik",
                                },
                                0
                            ),
                            new Question(
                                "Apakah pengajaran dari peristiwa Thaif?",
                                new List<string>
                                {
                                    "Bersabar dalam berdakwah",
                                    "Putus asa",
                                    "Tidak perlu berdakwah",
                                    "Berhenti berdakwah",
                                },
                                0
                            ),
                            new Question(
                                "Rasulullah SAW menyampaikan dakwah kepada kabilah ketika?",
                                new List<string>
                                {
                                    "Musim haji",
                                    "Bulan Ramadan",
                                    "Hari raya",
                                    "Bulan Syaaban",
                                },
                                0
                            ),
                            new Question(
                                "Kabilah manakah yang akhirnya menerima Islam?",
                                new List<string>
                                {
                                    "Aus dan Khazraj",
                                    "Quraisy",
                                    "Thaif",
                                    "Bani Umayyah",
                                },
                                0
                            ),
                            new Question(
                                "Apakah perjanjian Aqabah?",
                                new List<string>
                                {
                                    "Perjanjian taat setia kepada Rasulullah SAW",
                                    "Perjanjian dengan Quraisy",
                                    "Perjanjian dengan Thaif",
                                    "Perjanjian damai",
                                },
                                0
                            ),
                            new Question(
                                "Apakah strategi Abu Bakar dalam menyebarkan Islam?",
                                new List<string>
                                {
                                    "Mengajak sahabat-sahabat terdekat",
                                    "Menggunakan kekerasan",
                                    "Membuat perjanjian dengan Quraisy",
                                    "Menyembunyikan Islam",
                                },
                                0
                            ),
                            new Question(
                                "Siapakah sahabat yang memerdekakan Bilal?",
                                new List<string> { "Abu Bakar", "Umar", "Uthman", "Ali" },
                                0
                            ),
                            new Question(
                                "Apakah yang dilakukan Quraisy kepada Rasulullah SAW dan sahabat?",
                                new List<string>
                                {
                                    "Memulaukan mereka",
                                    "Memberi hadiah",
                                    "Menghormati",
                                    "Membantu",
                                },
                                0
                            ),
                            new Question(
                                "Pemulauan Rasulullah SAW berlaku selama?",
                                new List<string> { "3 years", "5 years", "7 years", "10 years" },
                                0
                            ),
                            new Question(
                                "Di manakah Rasulullah SAW dan sahabat dipulaukan?",
                                new List<string>
                                {
                                    "Syi'b Abi Talib",
                                    "Gua Hira",
                                    "Kaabah",
                                    "Madinah",
                                },
                                0
                            ),
                            new Question(
                                "Apakah akibat daripada pemulauan Quraisy?",
                                new List<string>
                                {
                                    "Umat Islam hidup susah dan lapar",
                                    "Islam semakin kuat",
                                    "Islam disambut baik",
                                    "Quraisy masuk Islam",
                                },
                                0
                            ),
                            new Question(
                                "Apakah pengajaran daripada pemulauan Rasulullah SAW?",
                                new List<string>
                                {
                                    "Bersabar dalam menghadapi cabaran",
                                    "Berhenti berdakwah",
                                    "Menyembah berhala",
                                    "Meninggalkan Islam",
                                },
                                0
                            ),
                            new Question(
                                "Apakah maksud mukjizat?",
                                new List<string>
                                {
                                    "Perkara luar biasa yang Allah kurniakan kepada nabi",
                                    "Perkara pelik",
                                    "Sihir",
                                    "Permainan",
                                },
                                0
                            ),
                            new Question(
                                "Mukjizat terbesar Nabi Muhammad SAW ialah?",
                                new List<string>
                                {
                                    "Al-Quran",
                                    "Membelah laut",
                                    "Tongkat bertukar ular",
                                    "Menyembuhkan buta",
                                },
                                0
                            ),
                            new Question(
                                "Apakah tujuan mukjizat?",
                                new List<string>
                                {
                                    "Membuktikan kerasulan nabi",
                                    "Untuk bermain",
                                    "Untuk menunjuk-nunjuk",
                                    "Untuk sihir",
                                },
                                0
                            ),
                            new Question(
                                "Al-Quran membuktikan kebenaran Nabi Muhammad SAW kerana?",
                                new List<string>
                                {
                                    "Tiada siapa dapat menirunya",
                                    "Ditulis oleh manusia",
                                    "Sama seperti kitab lain",
                                    "Boleh dipinda",
                                },
                                0
                            ),
                            new Question(
                                "Apakah mukjizat yang berlaku ketika orang Quraisy meminta tanda?",
                                new List<string>
                                {
                                    "Bulan terbelah",
                                    "Laut terbelah",
                                    "Tongkat menjadi ular",
                                    "Api menjadi sejuk",
                                },
                                0
                            ),
                            new Question(
                                "Air keluar dari celah jari Rasulullah SAW ketika?",
                                new List<string>
                                {
                                    "Para sahabat kehausan",
                                    "Sahabat lapar",
                                    "Sahabat takut",
                                    "Sahabat sakit",
                                },
                                0
                            ),
                            new Question(
                                "Makanan bertambah dengan izin Allah ketika?",
                                new List<string>
                                {
                                    "Perang",
                                    "Jamuan kecil",
                                    "Kenduri",
                                    "Musim panas",
                                },
                                1
                            ),
                            new Question(
                                "Apakah peristiwa besar yang berlaku sebelum solat lima waktu difardukan?",
                                new List<string>
                                {
                                    "Israk Mikraj",
                                    "Hijrah",
                                    "Perang Badar",
                                    "Haji Wada'",
                                },
                                0
                            ),
                            new Question(
                                "Solat lima waktu difardukan semasa peristiwa?",
                                new List<string>
                                {
                                    "Israk Mikraj",
                                    "Hijrah",
                                    "Perang Uhud",
                                    "Pembinaan Kaabah",
                                },
                                0
                            ),
                            new Question(
                                "Apakah hikmah mukjizat Rasulullah SAW?",
                                new List<string>
                                {
                                    "Menguatkan iman umat Islam",
                                    "Untuk bermain",
                                    "Untuk menunjuk-nunjuk",
                                    "Untuk menakutkan",
                                },
                                0
                            ),
                            new Question(
                                "Mukjizat berlaku dengan izin?",
                                new List<string> { "Allah", "Manusia", "Malaikat", "Nabi" },
                                0
                            ),
                            new Question(
                                "Apakah yang membezakan mukjizat dan sihir?",
                                new List<string>
                                {
                                    "Mukjizat dari Allah, sihir dari jin",
                                    "Mukjizat dari manusia",
                                    "Mukjizat sama seperti sihir",
                                    "Kedua-duanya sama",
                                },
                                0
                            ),
                            new Question(
                                "Al-Quran menjadi mukjizat kerana?",
                                new List<string>
                                {
                                    "Bahasa dan isinya indah dan benar",
                                    "Sama seperti buku biasa",
                                    "Ditulis sahabat",
                                    "Boleh dipinda",
                                },
                                0
                            ),
                            new Question(
                                "Apakah pengajaran daripada mukjizat Nabi Muhammad SAW?",
                                new List<string>
                                {
                                    "Meyakini kerasulan baginda",
                                    "Tidak beriman",
                                    "Menjadi sombong",
                                    "Lalai",
                                },
                                0
                            ),
                            new Question(
                                "Apakah mukjizat yang masih kekal hingga hari ini?",
                                new List<string>
                                {
                                    "Al-Quran",
                                    "Bulan terbelah",
                                    "Air keluar dari jari",
                                    "Makanan bertambah",
                                },
                                0
                            ),
                        },
                    },
                    new Levels //Level Adab Tahap 4
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Apakah maksud ziarah?",
                                new List<string>
                                {
                                    "Pergi melancong",
                                    "Mengunjungi seseorang dengan tujuan baik",
                                    "Membeli barang",
                                    "Pergi bersukan",
                                },
                                1
                            ),
                            new Question(
                                "Antara adab menziarahi rakan sebaya ialah?",
                                new List<string>
                                {
                                    "Memberi salam",
                                    "Membuat bising",
                                    "Mengambil barang tanpa izin",
                                    "Bergaduh",
                                },
                                0
                            ),
                            new Question(
                                "Apabila hendak pulang dari rumah rakan, kita perlu?",
                                new List<string>
                                {
                                    "Diam sahaja",
                                    "Membanting pintu",
                                    "Mengucapkan terima kasih",
                                    "Membawa barangnya",
                                },
                                2
                            ),
                            new Question(
                                "Perbuatan yang dilarang ketika menziarahi rakan sebaya ialah?",
                                new List<string>
                                {
                                    "Memberi salam",
                                    "Meminta izin masuk",
                                    "Merosakkan barang rakan",
                                    "Berbual sopan",
                                },
                                2
                            ),
                            new Question(
                                "Kelebihan menziarahi rakan dengan adab yang baik ialah?",
                                new List<string>
                                {
                                    "Mendapat kasih sayang",
                                    "Dibenci orang",
                                    "Dimarahi jiran",
                                    "Hilang kawan",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beradab ketika menziarahi rakan ialah?",
                                new List<string>
                                {
                                    "Dipuji",
                                    "Dihormati",
                                    "Dipandang serong",
                                    "Disayangi",
                                },
                                2
                            ),
                            new Question(
                                "Apabila rakan memberi makanan, kita perlu?",
                                new List<string>
                                {
                                    "Tolak dengan kasar",
                                    "Ambil dengan sopan",
                                    "Hina makanan",
                                    "Buang makanan",
                                },
                                1
                            ),
                            new Question(
                                "Menghormati rakan sebaya ketika ziarah akan?",
                                new List<string>
                                {
                                    "Menguatkan persahabatan",
                                    "Melemahkan hubungan",
                                    "Menimbulkan pergaduhan",
                                    "Membuat kebencian",
                                },
                                0
                            ),
                            new Question(
                                "Jika rakan tiada di rumah, kita perlu?",
                                new List<string>
                                {
                                    "Pecahkan pintu",
                                    "Pulang dengan sopan",
                                    "Jerit panggil",
                                    "Panjat pagar",
                                },
                                1
                            ),
                            new Question(
                                "Akibat suka membuat bising ketika menziarahi rakan ialah?",
                                new List<string>
                                {
                                    "Rakan suka",
                                    "Rakan gembira",
                                    "Rakan marah",
                                    "Rakan hormat",
                                },
                                2
                            ),
                            new Question(
                                "Apabila menziarahi orang dewasa, kita perlu memanggil mereka dengan?",
                                new List<string>
                                {
                                    "Nama sahaja",
                                    "Panggilan hormat",
                                    "Sindiran",
                                    "Gelaran kasar",
                                },
                                1
                            ),
                            new Question(
                                "Larangan ketika menziarahi orang dewasa ialah?",
                                new List<string>
                                {
                                    "Duduk sopan",
                                    "Memotong percakapan",
                                    "Mendengar nasihat",
                                    "Memberi salam",
                                },
                                1
                            ),
                            new Question(
                                "Kelebihan beradab dengan orang dewasa ialah?",
                                new List<string>
                                {
                                    "Dibenci",
                                    "Dikasihi dan dihormati",
                                    "Dimarahi",
                                    "Dipulau",
                                },
                                1
                            ),
                            new Question(
                                "Akibat tidak beradab dengan orang dewasa ialah?",
                                new List<string>
                                {
                                    "Disayangi",
                                    "Dihormati",
                                    "Dipandang rendah",
                                    "Dikasihi",
                                },
                                2
                            ),
                            new Question(
                                "Apabila berbicara dengan orang dewasa kita hendaklah?",
                                new List<string>
                                {
                                    "Menengking",
                                    "Sopan dan lemah lembut",
                                    "Menghina",
                                    "Memotong cakap",
                                },
                                1
                            ),
                            new Question(
                                "Menghormati orang dewasa termasuk akhlak?",
                                new List<string> { "Buruk", "Mulia", "Jahat", "Tidak penting" },
                                1
                            ),
                            new Question(
                                "Berdoa untuk kebaikan orang dewasa adalah tanda?",
                                new List<string>
                                {
                                    "Benci",
                                    "Hormat dan kasih sayang",
                                    "Dendam",
                                    "Lalai",
                                },
                                1
                            ),
                            new Question(
                                "Mengangkat suara di hadapan orang dewasa adalah?",
                                new List<string>
                                {
                                    "Adab buruk",
                                    "Adab mulia",
                                    "Amalan baik",
                                    "Amalan sunat",
                                },
                                0
                            ),
                            new Question(
                                "Contoh saudara mara ialah?",
                                new List<string>
                                {
                                    "Sahabat sekolah",
                                    "Sepupu",
                                    "Jiran sebelah",
                                    "Guru",
                                },
                                1
                            ),
                            new Question(
                                "Larangan ketika menziarahi saudara mara ialah?",
                                new List<string>
                                {
                                    "Membantu mereka",
                                    "Membuat bising",
                                    "Mendoakan mereka",
                                    "Memberi salam",
                                },
                                1
                            ),
                            new Question(
                                "Kelebihan menziarahi saudara mara dengan adab baik ialah?",
                                new List<string>
                                {
                                    "Mendapat kasih sayang",
                                    "Dipulau",
                                    "Dibenci",
                                    "Dijauhi",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beradab dengan saudara mara ialah?",
                                new List<string>
                                {
                                    "Silaturahim terputus",
                                    "Silaturahim bertambah erat",
                                    "Hubungan bertambah kasih",
                                    "Hubungan dihormati",
                                },
                                0
                            ),
                            new Question(
                                "Apabila berbual dengan saudara mara kita hendaklah?",
                                new List<string> { "Kasar", "Menghina", "Sopan", "Membentak" },
                                2
                            ),
                            new Question(
                                "Mengunjungi saudara mara pada hari raya adalah?",
                                new List<string>
                                {
                                    "Amalan baik",
                                    "Amalan buruk",
                                    "Tidak penting",
                                    "Sia-sia",
                                },
                                0
                            ),
                            new Question(
                                "Menghormati saudara mara yang lebih tua adalah?",
                                new List<string>
                                {
                                    "Adab mulia",
                                    "Adab buruk",
                                    "Tidak perlu",
                                    "Tidak penting",
                                },
                                0
                            ),
                            new Question(
                                "Doa kepada orang sakit ialah?",
                                new List<string>
                                {
                                    "Semoga cepat mati",
                                    "Semoga Allah menyembuhkanmu",
                                    "Semoga semakin sakit",
                                    "Semoga susah",
                                },
                                1
                            ),
                            new Question(
                                "Larangan ketika menziarahi orang sakit ialah?",
                                new List<string>
                                {
                                    "Memberi kata semangat",
                                    "Membuat bising",
                                    "Membaca doa",
                                    "Senyum",
                                },
                                1
                            ),
                            new Question(
                                "Adab menziarahi orang sakit di hospital ialah?",
                                new List<string>
                                {
                                    "Duduk sopan",
                                    "Melompat-lompat",
                                    "Ketawa kuat",
                                    "Membuat bising",
                                },
                                0
                            ),
                            new Question(
                                "Larangan ketika menziarahi orang sakit di hospital ialah?",
                                new List<string>
                                {
                                    "Menjaga kebersihan",
                                    "Membawa makanan tidak sesuai",
                                    "Menjaga adab",
                                    "Berdoa",
                                },
                                1
                            ),
                            new Question(
                                "Contoh buah tangan yang tidak sesuai untuk orang sakit ialah?",
                                new List<string>
                                {
                                    "Buah-buahan segar",
                                    "Air bergas",
                                    "Jus buah",
                                    "Buku doa",
                                },
                                1
                            ),
                            new Question(
                                "Kelebihan beradab ketika menziarahi orang sakit ialah?",
                                new List<string>
                                {
                                    "Membina kasih sayang",
                                    "Membuat orang sakit benci",
                                    "Menambah permusuhan",
                                    "Membuat marah",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beradab ketika menziarahi orang sakit ialah?",
                                new List<string>
                                {
                                    "Membuat orang sakit terganggu",
                                    "Orang sakit gembira",
                                    "Orang sakit tenang",
                                    "Orang sakit pulih",
                                },
                                0
                            ),
                            new Question(
                                "Membantu orang sakit adalah akhlak?",
                                new List<string> { "Buruk", "Mulia", "Jahat", "Tidak penting" },
                                1
                            ),
                            new Question(
                                "Mendoakan kesembuhan orang sakit adalah tanda?",
                                new List<string> { "Kasih sayang", "Benci", "Dendam", "Sombong" },
                                0
                            ),
                            new Question(
                                "Mengucapkan salam kepada orang sakit adalah?",
                                new List<string>
                                {
                                    "Adab mulia",
                                    "Adab buruk",
                                    "Tidak penting",
                                    "Sia-sia",
                                },
                                0
                            ),
                            new Question(
                                "Apabila menziarahi kematian kita hendaklah?",
                                new List<string>
                                {
                                    "Diam dan tenang",
                                    "Ketawa",
                                    "Membuat bising",
                                    "Bermain",
                                },
                                0
                            ),
                            new Question(
                                "Mengucapkan takziah kepada keluarga si mati adalah?",
                                new List<string>
                                {
                                    "Adab mulia",
                                    "Adab buruk",
                                    "Tidak perlu",
                                    "Tidak penting",
                                },
                                0
                            ),
                            new Question(
                                "Doa kepada si mati ialah?",
                                new List<string>
                                {
                                    "Ya Allah, ampunilah dia",
                                    "Ya Allah, seksalah dia",
                                    "Ya Allah, hinakan dia",
                                    "Ya Allah, jauhilah dia",
                                },
                                0
                            ),
                            new Question(
                                "Menangisi kematian dengan berlebihan hukumnya?",
                                new List<string> { "Haram", "Wajib", "Sunat", "Harus" },
                                0
                            ),
                            new Question(
                                "Mengiringi jenazah hingga ke kubur adalah?",
                                new List<string>
                                {
                                    "Amalan mulia",
                                    "Amalan buruk",
                                    "Tidak penting",
                                    "Sia-sia",
                                },
                                0
                            ),
                            new Question(
                                "Apabila menziarahi kubur kita hendaklah?",
                                new List<string> { "Membaca doa", "Menjerit", "Bermain", "Ketawa" },
                                0
                            ),
                            new Question(
                                "Mengucapkan salam kepada ahli kubur adalah?",
                                new List<string>
                                {
                                    "Adab mulia",
                                    "Adab buruk",
                                    "Tidak perlu",
                                    "Tidak penting",
                                },
                                0
                            ),
                            new Question(
                                "Doa ketika menziarahi kubur ialah?",
                                new List<string>
                                {
                                    "Ya Allah, ampunkan penghuni kubur ini",
                                    "Ya Allah, seksalah penghuni kubur ini",
                                    "Ya Allah, hinakan penghuni kubur ini",
                                    "Ya Allah, jauhilah penghuni kubur ini",
                                },
                                0
                            ),
                            new Question(
                                "Menghormati kawasan kubur adalah?",
                                new List<string>
                                {
                                    "Adab mulia",
                                    "Adab buruk",
                                    "Tidak penting",
                                    "Tidak perlu",
                                },
                                0
                            ),
                            new Question(
                                "Bermain-main di kawasan kubur adalah?",
                                new List<string>
                                {
                                    "Adab buruk",
                                    "Adab mulia",
                                    "Tidak penting",
                                    "Amalan baik",
                                },
                                0
                            ),
                            new Question(
                                "Apabila menghadiri majlis keramaian kita hendaklah?",
                                new List<string>
                                {
                                    "Memberi salam",
                                    "Membuat bising",
                                    "Menyusahkan tuan rumah",
                                    "Menghina",
                                },
                                0
                            ),
                            new Question(
                                "Berpakaian sopan ketika majlis adalah?",
                                new List<string>
                                {
                                    "Adab mulia",
                                    "Adab buruk",
                                    "Tidak penting",
                                    "Tidak perlu",
                                },
                                0
                            ),
                            new Question(
                                "Membantu tuan rumah dalam majlis adalah?",
                                new List<string>
                                {
                                    "Akhlak mulia",
                                    "Akhlak buruk",
                                    "Tidak penting",
                                    "Tidak perlu",
                                },
                                0
                            ),
                            new Question(
                                "Apabila makan di majlis kita hendaklah?",
                                new List<string>
                                {
                                    "Tidak membazir",
                                    "Membazir",
                                    "Membuat bising",
                                    "Menghina",
                                },
                                0
                            ),
                            new Question(
                                "Menghormati tetamu lain dalam majlis adalah?",
                                new List<string>
                                {
                                    "Adab mulia",
                                    "Adab buruk",
                                    "Tidak penting",
                                    "Tidak perlu",
                                },
                                0
                            ),
                        },
                    },
                    new Levels // Level Akidah Tahap 5
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Apakah pengertian sifat Iradah Allah?",
                                new List<string>
                                {
                                    "Allah Maha Mendengar",
                                    "Allah Maha Berkuasa",
                                    "Allah Menentukan segala kehendak-Nya",
                                    "Allah Maha Melihat",
                                },
                                2
                            ),
                            new Question(
                                "Dalil agli Allah bersifat Iradah ialah ...",
                                new List<string>
                                {
                                    "Mustahil Allah tidak berkehendak",
                                    "Allah Maha Mendengar",
                                    "Allah Maha Melihat",
                                    "Mustahil Allah berkuasa",
                                },
                                0
                            ),
                            new Question(
                                "Sifat berlawanan dengan Iradah ialah ...",
                                new List<string> { "Kehendak", "Terpaksa", "Ilmu", "Hidup" },
                                1
                            ),
                            new Question(
                                "Kesan beriman dengan sifat Iradah ialah ...",
                                new List<string>
                                {
                                    "Tenang menerima takdir Allah",
                                    "Putus asa dengan hidup",
                                    "Tidak percaya pada takdir",
                                    "Tidak mahu berusaha",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beriman dengan sifat Iradah ialah ...",
                                new List<string>
                                {
                                    "Hidup bahagia",
                                    "Lemah iman",
                                    "Semakin yakin pada takdir",
                                    "Meningkatkan amal",
                                },
                                1
                            ),
                            new Question(
                                "Apakah pengertian sifat Ilmu Allah?",
                                new List<string>
                                {
                                    "Allah Maha Mengetahui segala perkara",
                                    "Allah Maha Mendengar",
                                    "Allah Maha Melihat",
                                    "Allah Maha Berkuasa",
                                },
                                0
                            ),
                            new Question(
                                "Dalil naqli Allah Maha Mengetahui ialah ...",
                                new List<string>
                                {
                                    "Surah Al-Baqarah ayat 255",
                                    "Surah Al-Fatihah ayat 1",
                                    "Surah Al-Ikhlas ayat 1",
                                    "Surah Al-Kafirun ayat 6",
                                },
                                0
                            ),
                            new Question(
                                "Dalil agli Allah bersifat Ilmu ialah ...",
                                new List<string>
                                {
                                    "Mustahil Allah jahil",
                                    "Mustahil Allah berkuasa",
                                    "Mustahil Allah mendengar",
                                    "Mustahil Allah hidup",
                                },
                                0
                            ),
                            new Question(
                                "Perbezaan ilmu Allah dengan ilmu manusia ialah ...",
                                new List<string>
                                {
                                    "Ilmu manusia terbatas, ilmu Allah tidak terbatas",
                                    "Ilmu manusia sempurna",
                                    "Ilmu Allah terbatas",
                                    "Ilmu Allah sama dengan manusia",
                                },
                                0
                            ),
                            new Question(
                                "Sifat berlawanan dengan Ilmu ialah ...",
                                new List<string> { "Tahu", "Jahil", "Hidup", "Berkuasa" },
                                1
                            ),
                            new Question(
                                "Kesan beriman dengan sifat Ilmu ialah ...",
                                new List<string>
                                {
                                    "Yakin Allah mengetahui segala amal",
                                    "Tidak takut melakukan dosa",
                                    "Berbuat sesuka hati",
                                    "Tidak berusaha",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beriman dengan sifat Ilmu ialah ...",
                                new List<string>
                                {
                                    "Menjadi lebih bertakwa",
                                    "Hilang rasa takut kepada Allah",
                                    "Menambah amal soleh",
                                    "Semakin rajin beribadah",
                                },
                                1
                            ),
                            new Question(
                                "Apakah pengertian sifat Sama'?",
                                new List<string>
                                {
                                    "Allah Maha Melihat",
                                    "Allah Maha Mendengar",
                                    "Allah Maha Berkuasa",
                                    "Allah Maha Mengetahui",
                                },
                                1
                            ),
                            new Question(
                                "Dalil naqli Allah Maha Mendengar ialah ...",
                                new List<string>
                                {
                                    "Surah Al-Baqarah ayat 127",
                                    "Surah Al-Fatihah ayat 1",
                                    "Surah Al-Ikhlas ayat 2",
                                    "Surah An-Nas ayat 6",
                                },
                                0
                            ),
                            new Question(
                                "Dalil agli Allah bersifat Sama' ialah ...",
                                new List<string>
                                {
                                    "Mustahil Allah tuli",
                                    "Mustahil Allah bisu",
                                    "Mustahil Allah jahil",
                                    "Mustahil Allah mati",
                                },
                                0
                            ),
                            new Question(
                                "Perbezaan pendengaran Allah dengan manusia ialah ...",
                                new List<string>
                                {
                                    "Allah mendengar dengan telinga",
                                    "Allah mendengar tanpa alat, manusia perlukan telinga",
                                    "Allah mendengar sedikit sahaja",
                                    "Allah mendengar sama seperti manusia",
                                },
                                1
                            ),
                            new Question(
                                "Sifat berlawanan dengan Sama' ialah ...",
                                new List<string> { "Mendengar", "Tuli", "Melihat", "Jahil" },
                                1
                            ),
                            new Question(
                                "Kesan beriman dengan sifat Sama' ialah ...",
                                new List<string>
                                {
                                    "Takut berkata buruk",
                                    "Tidak peduli berkata apa-apa",
                                    "Tidak menjaga lidah",
                                    "Suka bergaduh",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beriman dengan sifat Sama' ialah ...",
                                new List<string>
                                {
                                    "Sentiasa berzikir",
                                    "Tidak menjaga percakapan",
                                    "Menjadi lebih berhati-hati",
                                    "Sentiasa takut kepada Allah",
                                },
                                1
                            ),
                            new Question(
                                "Apakah pengertian sifat Basar?",
                                new List<string>
                                {
                                    "Allah Maha Melihat",
                                    "Allah Maha Mendengar",
                                    "Allah Maha Berkuasa",
                                    "Allah Maha Hidup",
                                },
                                0
                            ),
                            new Question(
                                "Dalil naqli Allah Maha Melihat ialah ...",
                                new List<string>
                                {
                                    "Surah Al-Baqarah ayat 233",
                                    "Surah Al-Mulk ayat 19",
                                    "Surah Al-Fatihah ayat 5",
                                    "Surah Al-Ikhlas ayat 1",
                                },
                                1
                            ),
                            new Question(
                                "Dalil agli Allah bersifat Basar ialah ...",
                                new List<string>
                                {
                                    "Mustahil Allah buta",
                                    "Mustahil Allah bisu",
                                    "Mustahil Allah jahil",
                                    "Mustahil Allah tuli",
                                },
                                0
                            ),
                            new Question(
                                "Sifat berlawanan dengan Basar ialah ...",
                                new List<string> { "Melihat", "Buta", "Tuli", "Jahil" },
                                1
                            ),
                            new Question(
                                "Kesan beriman dengan sifat Basar ialah ...",
                                new List<string>
                                {
                                    "Yakin Allah melihat perbuatan kita",
                                    "Berani buat maksiat",
                                    "Tidak menjaga perbuatan",
                                    "Tidak peduli orang lain",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beriman dengan sifat Basar ialah ...",
                                new List<string>
                                {
                                    "Hidup bahagia",
                                    "Suka buat maksiat",
                                    "Rajin beribadah",
                                    "Suka menolong",
                                },
                                1
                            ),
                            new Question(
                                "Apakah pengertian sifat Hayat?",
                                new List<string>
                                {
                                    "Allah Maha Hidup",
                                    "Allah Maha Mendengar",
                                    "Allah Maha Mengetahui",
                                    "Allah Maha Melihat",
                                },
                                0
                            ),
                            new Question(
                                "Dalil naqli Allah Maha Hidup ialah ...",
                                new List<string>
                                {
                                    "Surah Al-Baqarah ayat 255",
                                    "Surah Al-Fatihah ayat 6",
                                    "Surah Al-Ikhlas ayat 3",
                                    "Surah An-Nas ayat 5",
                                },
                                0
                            ),
                            new Question(
                                "Dalil agli Allah bersifat Hayat ialah ...",
                                new List<string>
                                {
                                    "Mustahil Allah mati",
                                    "Mustahil Allah tuli",
                                    "Mustahil Allah buta",
                                    "Mustahil Allah lemah",
                                },
                                0
                            ),
                            new Question(
                                "Sifat berlawanan dengan Hayat ialah ...",
                                new List<string> { "Hidup", "Mati", "Tidur", "Lupa" },
                                1
                            ),
                            new Question(
                                "Perbezaan Hayat Allah dengan manusia ialah ...",
                                new List<string>
                                {
                                    "Hayat manusia kekal",
                                    "Hayat Allah kekal, manusia sementara",
                                    "Hayat Allah sementara",
                                    "Hayat Allah sama dengan manusia",
                                },
                                1
                            ),
                            new Question(
                                "Kesan beriman dengan sifat Hayat Allah ialah ...",
                                new List<string>
                                {
                                    "Yakin Allah Maha Hidup selama-lamanya",
                                    "Takut mati",
                                    "Tidak beribadah",
                                    "Tidak mahu belajar",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beriman dengan sifat Hayat ialah ...",
                                new List<string>
                                {
                                    "Tidak yakin kepada Allah",
                                    "Semakin bertakwa",
                                    "Semakin rajin beribadah",
                                    "Semakin tawakal",
                                },
                                0
                            ),
                            new Question(
                                "Apakah pengertian Rasul?",
                                new List<string>
                                {
                                    "Lelaki pilihan Allah yang menerima wahyu",
                                    "Malaikat yang patuh",
                                    "Wali Allah",
                                    "Sahabat Nabi",
                                },
                                0
                            ),
                            new Question(
                                "Sifat wajib bagi Rasul ialah ...",
                                new List<string>
                                {
                                    "Siddiq, Amanah, Tabligh, Fatonah",
                                    "Jahil, Khianat, Menipu, Lalai",
                                    "Kaya, Miskin, Kuat, Lemah",
                                    "Tinggi, Rendah, Cepat, Lambat",
                                },
                                0
                            ),
                            new Question(
                                "Sifat mustahil bagi Rasul ialah ...",
                                new List<string> { "Siddiq", "Khianat", "Amanah", "Tabligh" },
                                1
                            ),
                            new Question(
                                "Sifat harus bagi Rasul ialah ...",
                                new List<string>
                                {
                                    "Berkahwin atau tidak",
                                    "Kaya",
                                    "Miskin",
                                    "Tidak mati",
                                },
                                0
                            ),
                            new Question(
                                "Hukum beriman dengan sifat Rasul ialah ...",
                                new List<string> { "Harus", "Sunat", "Wajib", "Makruh" },
                                2
                            ),
                            new Question(
                                "Kesan beriman dengan sifat Rasul ialah ...",
                                new List<string>
                                {
                                    "Menjadikan Rasul contoh teladan",
                                    "Tidak mengikut Rasul",
                                    "Membenci Rasul",
                                    "Lalai daripada sunnah",
                                },
                                0
                            ),
                            new Question(
                                "Apakah maksud perkara Sam'iyat?",
                                new List<string>
                                {
                                    "Perkara yang hanya diketahui melalui wahyu",
                                    "Perkara yang dapat dibuktikan akal",
                                    "Perkara yang boleh dilihat",
                                    "Perkara yang boleh dirasa",
                                },
                                0
                            ),
                            new Question(
                                "Hukum beriman dengan perkara Sam'iyat ialah ...",
                                new List<string> { "Wajib", "Sunat", "Harus", "Makruh" },
                                0
                            ),
                            new Question(
                                "Antara contoh perkara Sam'iyat ialah ...",
                                new List<string>
                                {
                                    "Alam barzakh",
                                    "Membaca doa",
                                    "Mengaji Al-Quran",
                                    "Menunaikan haji",
                                },
                                0
                            ),
                            new Question(
                                "Nama malaikat yang wajib diketahui ialah ...",
                                new List<string>
                                {
                                    "Jibril, Mikail, Israfil, Izrail",
                                    "Jibril, Malik, Raqib, Atid",
                                    "Mikail, Israfil, Nakir, Munkar",
                                    "Hanya Jibril",
                                },
                                0
                            ),
                            new Question(
                                "Soalan kubur ditanya oleh ..",
                                new List<string>
                                {
                                    "Malaikat Raqib dan Atid",
                                    "Malaikat Munkar dan Nakir",
                                    "Malaikat Mikail dan Israfil",
                                    "Malaikat Jibril dan Izrail",
                                },
                                1
                            ),
                            new Question(
                                "Contoh nikmat kubur ialah ...",
                                new List<string>
                                {
                                    "Bau harum dari syurga",
                                    "Azab dengan api",
                                    "Dihimpit kubur",
                                    "Dipukul malaikat",
                                },
                                0
                            ),
                            new Question(
                                "Contoh azab kubur ialah ...",
                                new List<string>
                                {
                                    "Cahaya terang dari syurga",
                                    "Kubur diluaskan",
                                    "Himpitan kubur",
                                    "Bau harum",
                                },
                                2
                            ),
                            new Question(
                                "Padang Mahsyar ialah.",
                                new List<string>
                                {
                                    "Tempat berkumpul manusia selepas dibangkitkan",
                                    "Tempat manusia belajar",
                                    "Tempat orang mati disemadikan",
                                    "Tempat malaikat tinggal",
                                },
                                0
                            ),
                            new Question(
                                "Hisab bermaksud ...",
                                new List<string>
                                {
                                    "Timbangan amalan",
                                    "Soal jawab amalan manusia",
                                    "Tempat manusia berkumpul",
                                    "Jambatan menuju syurga",
                                },
                                1
                            ),
                            new Question(
                                "Mizan ialah ...",
                                new List<string>
                                {
                                    "Timbangan amalan baik dan buruk",
                                    "Soalan kubur",
                                    "Nikmat kubur",
                                    "Hari kiamat",
                                },
                                0
                            ),
                            new Question(
                                "Titian Sirat ialah ...",
                                new List<string>
                                {
                                    "Jambatan di atas neraka menuju syurga",
                                    "Jalan menuju padang Mahsyar",
                                    "Pintu masuk syurga",
                                    "Pintu masuk neraka",
                                },
                                0
                            ),
                            new Question(
                                "Golongan ahli syurga ialah ...",
                                new List<string>
                                {
                                    "Orang beriman dan beramal soleh",
                                    "Orang kafir",
                                    "Orang munafik",
                                    "Orang engkar",
                                },
                                0
                            ),
                        },
                    },
                    new Levels // Level Ibadah Tahap 5
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Apakah pengertian solat sunat rawatib?",
                                new List<string>
                                {
                                    "Solat yang dilakukan pada waktu malam sahaja",
                                    "Solat yang mengiringi solat fardhu",
                                    "Solat yang dilakukan hanya pada bulan Ramadan",
                                    "Solat yang dilakukan ketika ada hajat tertentu",
                                },
                                1
                            ),
                            new Question(
                                "Solat sunat rawatib dilakukan ...",
                                new List<string>
                                {
                                    "Sebelum dan selepas solat fardhu",
                                    "Selepas solat jenazah",
                                    "Selepas solat istikharah",
                                    "Pada malam Jumaat sahaja",
                                },
                                0
                            ),
                            new Question(
                                "Hukum solat sunat rawatib ialah ...",
                                new List<string>
                                {
                                    "Wajib",
                                    "Sunat muakkad",
                                    "Sunat biasa",
                                    "Harus",
                                },
                                1
                            ),
                            new Question(
                                "Bilangan rakaat solat sunat rawatib muakkad yang paling utama ialah ...",
                                new List<string>
                                {
                                    "6 rakaat",
                                    "8 rakaat",
                                    "10 rakaat",
                                    "12 rakaat",
                                },
                                3
                            ),
                            new Question(
                                "Antara fadhilat solat rawatib ialah ...",
                                new List<string>
                                {
                                    "Mendapat pahala syahid",
                                    "Dibina rumah di syurga",
                                    "Mendapat rezeki melimpah",
                                    "Umur dipanjangkan",
                                },
                                1
                            ),
                            new Question(
                                "Apakah pengertian solat tarawih?",
                                new List<string>
                                {
                                    "Solat sunat di bulan Ramadan pada malam hari",
                                    "Solat sunat selepas Subuh",
                                    "Solat sunat untuk memohon hajat",
                                    "Solat sunat pada pagi hari raya",
                                },
                                0
                            ),
                            new Question(
                                "Bilangan rakaat solat witir yang paling sedikit ialah ...",
                                new List<string> { "1 rakaat", "2 rakaat", "3 rakaat", "4 rakaat" },
                                0
                            ),
                            new Question(
                                "Fadhilat solat tarawih antaranya ialah ...",
                                new List<string>
                                {
                                    "Menghapuskan dosa-dosa kecil",
                                    "Memberi kesihatan tubuh badan",
                                    "Memanjangkan umur",
                                    "Menyembuhkan penyakit",
                                },
                                0
                            ),
                            new Question(
                                "Apakah pengertian solat hajat?",
                                new List<string>
                                {
                                    "Solat sunat kerana gerhana",
                                    "Solat sunat untuk memohon sesuatu hajat",
                                    "Solat sunat selepas solat fardhu",
                                    "Solat sunat di bulan Syawal",
                                },
                                1
                            ),
                            new Question(
                                "Bilangan rakaat solat hajat ialah ...",
                                new List<string> { "1 rakaat", "2 rakaat", "3 rakaat", "4 rakaat" },
                                1
                            ),
                            new Question(
                                "Antara fadhilat solat hajat ialah ...",
                                new List<string>
                                {
                                    "Hajat dipermudahkan Allah",
                                    "Umur dipanjangkan",
                                    "Mendapat rumah di syurga",
                                    "Doa ditolak",
                                },
                                0
                            ),
                            new Question(
                                "Bilakah waktu solat dhuha bermula?",
                                new List<string>
                                {
                                    "Selepas matahari naik hingga tergelincir",
                                    "Selepas solat Maghrib",
                                    "Selepas Isyak",
                                    "Selepas Subuh",
                                },
                                0
                            ),
                            new Question(
                                "Bilangan rakaat solat dhuha paling sedikit ialah ...",
                                new List<string> { "2 rakaat", "4 rakaat", "6 rakaat", "8 rakaat" },
                                0
                            ),
                            new Question(
                                "Doa selepas solat dhuha memohon ...",
                                new List<string>
                                {
                                    "Kekuatan iman",
                                    "Rezeki yang berkat",
                                    "Kesembuhan dari sakit",
                                    "Umur panjang",
                                },
                                1
                            ),
                            new Question(
                                "Apakah pengertian solat tahajud?",
                                new List<string>
                                {
                                    "Solat sunat selepas Subuh",
                                    "Solat sunat malam selepas tidur",
                                    "Solat sunat kerana gerhana",
                                    "Solat sunat berjemaah di bulan Ramadan",
                                },
                                1
                            ),
                            new Question(
                                "Syarat untuk solat tahajud ialah ...",
                                new List<string>
                                {
                                    "Perlu dilakukan berjemaah",
                                    "Perlu tidur dahulu sebelum bangun",
                                    "Perlu dilakukan selepas Asar",
                                    "Perlu dilakukan selepas Subuh",
                                },
                                1
                            ),
                            new Question(
                                "Antara fadhilat solat tahajud ialah ...",
                                new List<string>
                                {
                                    "Menyihatkan badan",
                                    "Mendekatkan diri kepada Allah",
                                    "Panjang umur",
                                    "Mendapat harta banyak",
                                },
                                1
                            ),
                            new Question(
                                "Solat istikharah dilakukan apabila ...",
                                new List<string>
                                {
                                    "Hendak membuat pilihan",
                                    "Hendak menziarahi kubur",
                                    "Hendak menyambut hari raya",
                                    "Hendak menunaikan haji",
                                },
                                0
                            ),
                            new Question(
                                "Bilangan rakaat solat istikharah ialah ...",
                                new List<string> { "1 rakaat", "2 rakaat", "3 rakaat", "4 rakaat" },
                                1
                            ),
                            new Question(
                                "Apakah fadhilat solat istikharah?",
                                new List<string>
                                {
                                    "Mendapat kekayaan",
                                    "Mendapat petunjuk Allah",
                                    "Mendapat umur panjang",
                                    "Mendapat kesihatan",
                                },
                                1
                            ),
                            new Question(
                                "Solat gerhana dilakukan ketika ...",
                                new List<string>
                                {
                                    "Berlaku gerhana matahari atau bulan",
                                    "Berlaku ribut",
                                    "Berlaku banjir",
                                    "Berlaku gempa bumi",
                                },
                                0
                            ),
                            new Question(
                                "Lafaz seruan untuk solat gerhana ialah ...",
                                new List<string>
                                {
                                    "Allahu Akbar",
                                    "As-salatu jami'ah",
                                    "La ilaha illallah",
                                    "Subhanallah",
                                },
                                1
                            ),
                            new Question(
                                "Bilangan rakaat solat gerhana matahari ialah ...",
                                new List<string> { "1 rakaat", "2 rakaat", "3 rakaat", "4 rakaat" },
                                1
                            ),
                            new Question(
                                "Apakah fadhilat solat gerhana?",
                                new List<string>
                                {
                                    "Mendapat petunjuk",
                                    "Mengingatkan kebesaran Allah",
                                    "Menyihatkan badan",
                                    "Menambahkan rezeki",
                                },
                                1
                            ),
                            new Question(
                                "Bilakah solat hari raya Aidilfitri dilaksanakan?",
                                new List<string>
                                {
                                    "Selepas Subuh",
                                    "Selepas matahari naik",
                                    "Selepas Maghrib",
                                    "Selepas Isyak",
                                },
                                1
                            ),
                            new Question(
                                "Bilangan rakaat solat hari raya ialah ...",
                                new List<string> { "1 rakaat", "2 rakaat", "3 rakaat", "4 rakaat" },
                                1
                            ),
                            new Question(
                                "Apakah lafaz takbir hari raya?",
                                new List<string>
                                {
                                    "Allahu Akbar 3 kali dan Alhamdulillah",
                                    "Allahu Akbar, Allahu Akbar, Allahu Akbar Walillahilhamd",
                                    "Subhanallah Walhamdulillah",
                                    "La ilaha illallah",
                                },
                                1
                            ),
                            new Question(
                                "Antara fadhilat solat hari raya ialah ...",
                                new List<string>
                                {
                                    "Menghapuskan dosa besar",
                                    "Mendapat ganjaran pahala",
                                    "Mendapat umur panjang",
                                    "Menjadi kaya",
                                },
                                1
                            ),
                            new Question(
                                "Apakah pengertian solat taubat?",
                                new List<string>
                                {
                                    "Solat sunat memohon keampunan dosa",
                                    "Solat sunat malam selepas tidur",
                                    "Solat sunat kerana hajat",
                                    "Solat sunat gerhana",
                                },
                                0
                            ),
                            new Question(
                                "Bilangan rakaat solat taubat ialah ...",
                                new List<string> { "1 rakaat", "2 rakaat", "3 rakaat", "4 rakaat" },
                                1
                            ),
                            new Question(
                                "Waktu yang sesuai untuk solat taubat ialah.",
                                new List<string>
                                {
                                    "Bila-bila masa kecuali waktu yang dilarang",
                                    "Selepas Subuh",
                                    "Selepas Asar",
                                    "Selepas Maghrib",
                                },
                                0
                            ),
                            new Question(
                                "Antara fadhilat solat taubat ialah.",
                                new List<string>
                                {
                                    "Dosa dihapuskan Allah",
                                    "Mendapat rumah di syurga",
                                    "Mendapat umur panjang",
                                    "Mendapat kesihatan",
                                },
                                0
                            ),
                            new Question(
                                "Apakah pengertian puasa?",
                                new List<string>
                                {
                                    "Menahan diri daripada makan, minum dan perkara membatalkan puasa",
                                    "Menahan diri dari bercakap",
                                    "Menahan diri dari tidur",
                                    "Menahan diri dari marah",
                                },
                                0
                            ),
                            new Question(
                                "Hukum berpuasa di bulan Ramadan ialah ...",
                                new List<string> { "Harus", "Sunat", "Wajib", "Makruh" },
                                2
                            ),
                            new Question(
                                "Antara perkara yang membatalkan puasa ialah ...",
                                new List<string>
                                {
                                    "Mandi wajib",
                                    "Makan dan minum dengan sengaja",
                                    "Tidur pada siang hari",
                                    "Berjalan jauh",
                                },
                                1
                            ),
                            new Question(
                                "Antara fadhilat puasa Ramadan ialah ...",
                                new List<string>
                                {
                                    "Mendapat kesihatan",
                                    "Menghapuskan dosa",
                                    "Mendapat umur panjang",
                                    "Menjadi kaya",
                                },
                                1
                            ),
                            new Question(
                                "Apakah kepentingan puasa bagi seorang Muslim?",
                                new List<string>
                                {
                                    "Melatih diri bersabar",
                                    "Menjadi kuat",
                                    "Menjadi kaya",
                                    "Menjadi pandai",
                                },
                                0
                            ),
                            new Question(
                                "Antara jenis puasa wajib selain Ramadan ialah ...",
                                new List<string>
                                {
                                    "Puasa Isnin Khamis",
                                    "Puasa Arafah",
                                    "Puasa Nazar",
                                    "Puasa Syawal",
                                },
                                2
                            ),
                            new Question(
                                "Antara contoh puasa sunat ialah ...",
                                new List<string>
                                {
                                    "Puasa Ramadan",
                                    "Puasa Kifarah",
                                    "Puasa Isnin dan Khamis",
                                    "Puasa Nazar",
                                },
                                2
                            ),
                            new Question(
                                "Antara hikmah puasa terhadap kesihatan ialah ...",
                                new List<string>
                                {
                                    "Mengurangkan berat badan",
                                    "Menyihatkan tubuh badan",
                                    "Menjadi kuat",
                                    "Panjang umur",
                                },
                                1
                            ),
                            new Question(
                                "Antara hikmah puasa dari segi rohani ialah ...",
                                new List<string>
                                {
                                    "Membersihkan hati",
                                    "Mendapat umur panjang",
                                    "Menjadi kaya",
                                    "Mendapat pangkat",
                                },
                                0
                            ),
                            new Question(
                                "Antara larangan ketika berpuasa ialah ...",
                                new List<string>
                                {
                                    "Makan dan minum pada siang hari",
                                    "Tidur pada siang hari",
                                    "Belajar pada siang hari",
                                    "Bekerja pada siang hari",
                                },
                                0
                            ),
                            new Question(
                                "Antara hikmah puasa terhadap hubungan sosial ialah ...",
                                new List<string>
                                {
                                    "Menjauhkan diri dari masyarakat",
                                    "Menimbulkan rasa simpati",
                                    "Menjadi kaya",
                                    "Mendapat pangkat",
                                },
                                1
                            ),
                            new Question(
                                "Puasa enam hari di bulan Syawal dinamakan puasa ...",
                                new List<string>
                                {
                                    "Puasa Nazar",
                                    "Puasa Sunat Syawal",
                                    "Puasa Arafah",
                                    "Puasa Isnin Khamis",
                                },
                                1
                            ),
                        },
                    },
                    new Levels // Level Sirah Tahap 5
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Apakah peristiwa penting yang berlaku dalam Perang Badar?",
                                new List<string>
                                {
                                    "Rasulullah SAW berhijrah ke Madinah",
                                    "Pertempuran pertama antara Islam dan Quraisy",
                                    "Perjanjian Hudaibiyah ditandatangani",
                                    "Pembukaan Kota Mekah",
                                },
                                1
                            ),
                            new Question(
                                "Sebab utama berlakunya Perang Badar ialah?",
                                new List<string>
                                {
                                    "Orang Quraisy merampas harta orang Islam",
                                    "Orang Quraisy menyerang Madinah",
                                    "Orang Quraisy membantu Yahudi",
                                    "Orang Quraisy menghalang Rasulullah SAW berdakwah",
                                },
                                0
                            ),
                            new Question(
                                "Bilangan tentera Islam dalam Perang Badar ialah lebih kurang?",
                                new List<string>
                                {
                                    "313 orang",
                                    "500 orang",
                                    "700 orang",
                                    "1000 orang",
                                },
                                0
                            ),
                            new Question(
                                "Bilangan tentera Quraisy dalam Perang Badar ialah lebih kurang?",
                                new List<string>
                                {
                                    "200 orang",
                                    "500 orang",
                                    "1000 orang",
                                    "1500 orang",
                                },
                                2
                            ),
                            new Question(
                                "Pertolongan Allah kepada tentera Islam dalam Perang Badar ialah dengan?",
                                new List<string>
                                {
                                    "Turunnya hujan",
                                    "Turunnya malaikat",
                                    "Turunnya ribut pasir",
                                    "Turunnya guruh dan kilat",
                                },
                                1
                            ),
                            new Question(
                                "Apakah hasil daripada Perang Badar?",
                                new List<string>
                                {
                                    "Islam kalah",
                                    "Islam menang dengan pertolongan Allah",
                                    "Quraisy menyerah diri",
                                    "Tentera Islam lari dari medan perang",
                                },
                                1
                            ),
                            new Question(
                                "Apakah hikmah daripada Perang Badar?",
                                new List<string>
                                {
                                    "Menunjukkan kelemahan tentera Islam",
                                    "Menguatkan iman dan semangat umat Islam",
                                    "Mengurangkan dakwah Rasulullah SAW",
                                    "Menghalang Islam berkembang",
                                },
                                1
                            ),
                            new Question(
                                "Apakah peristiwa penting yang berlaku dalam Perang Uhud?",
                                new List<string>
                                {
                                    "Rasulullah SAW diboikot",
                                    "Rasulullah SAW cedera",
                                    "Rasulullah SAW berhijrah",
                                    "Rasulullah SAW wafat",
                                },
                                1
                            ),
                            new Question(
                                "Sebab utama Perang Uhud berlaku ialah?",
                                new List<string>
                                {
                                    "Orang Quraisy ingin membalas kekalahan di Badar",
                                    "Orang Quraisy ingin menghalang hijrah",
                                    "Orang Quraisy ingin menawan Madinah",
                                    "Orang Quraisy ingin berdamai",
                                },
                                0
                            ),
                            new Question(
                                "Siapakah sahabat yang menjaga Rasulullah SAW dalam Perang Uhud?",
                                new List<string>
                                {
                                    "Abu Bakar",
                                    "Ali bin Abi Talib",
                                    "Talhah bin Ubaidillah",
                                    "Umar Al-Khattab",
                                },
                                2
                            ),
                            new Question(
                                "Apakah strategi tentera Islam dalam Perang Uhud?",
                                new List<string>
                                {
                                    "Memasang parit",
                                    "Menempatkan pemanah di Bukit Uhud",
                                    "Menyerang pada waktu malam",
                                    "Berlindung dalam masjid",
                                },
                                1
                            ),
                            new Question(
                                "Mengapa tentera Islam kalah dalam Perang Uhud?",
                                new List<string>
                                {
                                    "Mereka lapar",
                                    "Pemanah tidak mematuhi arahan Nabi",
                                    "Mereka terlalu sedikit",
                                    "Mereka tiada senjata",
                                },
                                1
                            ),
                            new Question(
                                "Siapakah yang terbunuh dalam Perang Uhud sebagai syahid terkenal?",
                                new List<string>
                                {
                                    "Hamzah bin Abdul Muttalib",
                                    "Bilal bin Rabah",
                                    "Abu Ubaidah Al-Jarrah",
                                    "Abdullah bin Mas'ud",
                                },
                                0
                            ),
                            new Question(
                                "Apakah hikmah daripada Perang Uhud?",
                                new List<string>
                                {
                                    "Tentera Islam tidak perlu taat perintah",
                                    "Umat Islam belajar pentingnya taat pemimpin",
                                    "Tentera Quraisy semakin takut",
                                    "Islam semakin lemah",
                                },
                                1
                            ),
                            new Question(
                                "Apakah peristiwa penting yang berlaku dalam Perang Khandaq?",
                                new List<string>
                                {
                                    "Tentera Islam menggali parit",
                                    "Tentera Islam menawan Mekah",
                                    "Tentera Islam berdamai dengan Quraisy",
                                    "Tentera Islam lari dari perang",
                                },
                                0
                            ),
                            new Question(
                                "Sebab utama Perang Khandaq berlaku ialah?",
                                new List<string>
                                {
                                    "Quraisy ingin membalas dendam Uhud",
                                    "Quraisy mahu berdamai",
                                    "Quraisy mahu membantu Yahudi",
                                    "Quraisy mahu menawan Madinah",
                                },
                                0
                            ),
                            new Question(
                                "Siapakah yang mencadangkan strategi menggali parit?",
                                new List<string>
                                {
                                    "Abu Hurairah",
                                    "Salman Al-Farisi",
                                    "Abu Bakar",
                                    "Umar",
                                },
                                1
                            ),
                            new Question(
                                "Pertolongan Allah kepada tentera Islam dalam Perang Khandaq ialah?",
                                new List<string>
                                {
                                    "Hujan ribut yang kuat",
                                    "Tentera Quraisy kelaparan",
                                    "Tentera Quraisy diserang binatang",
                                    "Tentera Quraisy sakit",
                                },
                                0
                            ),
                            new Question(
                                "Bilangan tentera Quraisy dan sekutunya dalam Perang Khandaq lebih kurang?",
                                new List<string>
                                {
                                    "3000 orang",
                                    "5000 orang",
                                    "10,000 orang",
                                    "15,000 orang",
                                },
                                2
                            ),
                            new Question(
                                "Apakah gelaran lain bagi Perang Khandaq?",
                                new List<string>
                                {
                                    "Perang Ahzab",
                                    "Perang Tabuk",
                                    "Perang Hunain",
                                    "Perang Badar",
                                },
                                0
                            ),
                            new Question(
                                "Apakah hikmah daripada Perang Khandaq?",
                                new List<string>
                                {
                                    "Menunjukkan kelemahan umat Islam",
                                    "Menunjukkan pentingnya strategi dan kesabaran",
                                    "Menunjukkan kehebatan tentera Quraisy",
                                    "Melemahkan umat Islam",
                                },
                                1
                            ),
                            new Question(
                                "Apakah peristiwa penting yang berlaku di Hudaibiyah?",
                                new List<string>
                                {
                                    "Tentera Islam berperang",
                                    "Rasulullah SAW mengadakan perjanjian damai",
                                    "Rasulullah SAW berhijrah",
                                    "Rasulullah SAW wafat",
                                },
                                1
                            ),
                            new Question(
                                "Sebab utama Perjanjian Hudaibiyah diadakan ialah?",
                                new List<string>
                                {
                                    "Orang Islam mahu masuk Mekah untuk umrah",
                                    "Orang Islam mahu berdagang",
                                    "Orang Islam mahu berhijrah",
                                    "Orang Islam mahu berperang",
                                },
                                0
                            ),
                            new Question(
                                "Siapakah utusan Rasulullah SAW yang dihantar ke Mekah?",
                                new List<string>
                                {
                                    "Abu Sufyan",
                                    "Uthman bin Affan",
                                    "Ali bin Abi Talib",
                                    "Abu Bakar",
                                },
                                1
                            ),
                            new Question(
                                "Antara isi kandungan Perjanjian Hudaibiyah ialah?",
                                new List<string>
                                {
                                    "Gencatan senjata selama 10 tahun",
                                    "Quraisy mesti masuk Islam",
                                    "Tentera Islam mesti kalah",
                                    "Umat Islam tidak boleh berhijrah",
                                },
                                0
                            ),
                            new Question(
                                "Kesan Perjanjian Hudaibiyah kepada umat Islam ialah?",
                                new List<string>
                                {
                                    "Islam semakin lemah",
                                    "Islam semakin berkembang",
                                    "Islam kalah dalam peperangan",
                                    "Islam berhijrah ke Habsyah",
                                },
                                1
                            ),
                            new Question(
                                "Mengapa Perjanjian Hudaibiyah dianggap kemenangan besar Islam?",
                                new List<string>
                                {
                                    "Kerana Islam boleh berdagang",
                                    "Kerana Islam boleh menyebarkan dakwah dengan aman",
                                    "Kerana Islam menang perang",
                                    "Kerana Islam dapat harta rampasan",
                                },
                                1
                            ),
                            new Question(
                                "Apakah hikmah daripada Perjanjian Hudaibiyah?",
                                new List<string>
                                {
                                    "Pentingnya menepati janji dan kesabaran",
                                    "Pentingnya melanggar janji",
                                    "Pentingnya peperangan",
                                    "Pentingnya menipu musuh",
                                },
                                0
                            ),
                            new Question(
                                "Apakah peristiwa penting dalam Pembukaan Kota Mekah?",
                                new List<string>
                                {
                                    "Rasulullah SAW wafat",
                                    "Rasulullah SAW dan tentera Islam memasuki Mekah tanpa pertumpahan darah",
                                    "Tentera Quraisy menyerang Madinah",
                                    "Perjanjian Hudaibiyah ditandatangani",
                                },
                                1
                            ),
                            new Question(
                                "Sebab utama Pembukaan Kota Mekah ialah?",
                                new List<string>
                                {
                                    "Quraisy melanggar Perjanjian Hudaibiyah",
                                    "Quraisy menyerang Madinah",
                                    "Quraisy menghina Rasulullah SAW",
                                    "Quraisy menawan sahabat",
                                },
                                0
                            ),
                            new Question(
                                "Bilangan tentera Islam yang menuju ke Mekah ialah lebih kurang?",
                                new List<string>
                                {
                                    "2000 orang",
                                    "5000 orang",
                                    "10,000 orang",
                                    "20,000 orang",
                                },
                                2
                            ),
                            new Question(
                                "Sikap Rasulullah SAW terhadap Quraisy setelah menang ialah?",
                                new List<string>
                                {
                                    "Membalas dendam",
                                    "Membunuh semua musuh",
                                    "Memberi pengampunan",
                                    "Menghalau mereka",
                                },
                                2
                            ),
                            new Question(
                                "Apakah kesan Pembukaan Kota Mekah?",
                                new List<string>
                                {
                                    "Islam semakin kuat dan berkembang",
                                    "Quraisy semakin berkuasa",
                                    "Islam semakin lemah",
                                    "Islam berhijrah lagi",
                                },
                                0
                            ),
                            new Question(
                                "Apakah pengajaran daripada Pembukaan Kota Mekah?",
                                new List<string>
                                {
                                    "Kemenangan Islam dengan pertolongan Allah",
                                    "Pentingnya berperang selalu",
                                    "Membalas dendam itu mulia",
                                    "Islam mesti berundur",
                                },
                                0
                            ),
                            new Question(
                                "Apakah hikmah daripada Pembukaan Kota Mekah?",
                                new List<string>
                                {
                                    "Islam menjadi agama yang kuat dan tersebar luas",
                                    "Islam menjadi lemah",
                                    "Islam berhenti berkembang",
                                    "Islam hanya untuk Mekah",
                                },
                                0
                            ),
                            new Question(
                                "Apakah peristiwa sebelum kewafatan Rasulullah SAW?",
                                new List<string>
                                {
                                    "Rasulullah SAW sakit",
                                    "Rasulullah SAW berhijrah",
                                    "Rasulullah SAW berperang",
                                    "Rasulullah SAW wafat",
                                },
                                0
                            ),
                            new Question(
                                "Sebab utama kewafatan Rasulullah SAW ialah?",
                                new List<string>
                                {
                                    "Baginda cedera di Badar",
                                    "Baginda cedera di Uhud",
                                    "Baginda sakit tenat",
                                    "Baginda berhijrah",
                                },
                                2
                            ),
                            new Question(
                                "Siapakah yang menjadi pengganti Rasulullah SAW selepas kewafatan baginda?",
                                new List<string>
                                {
                                    "Umar Al-Khattab",
                                    "Abu Bakar As-Siddiq",
                                    "Ali bin Abi Talib",
                                    "Uthman bin Affan",
                                },
                                1
                            ),
                            new Question(
                                "Bagaimanakah sikap sahabat ketika menghadapi kewafatan Rasulullah SAW?",
                                new List<string>
                                {
                                    "Menangis, sedih tetapi redha",
                                    "Bergembira",
                                    "Berperang",
                                    "Melarikan diri",
                                },
                                0
                            ),
                            new Question(
                                "Apakah iktibar daripada kewafatan Rasulullah SAW?",
                                new List<string>
                                {
                                    "Setiap yang hidup pasti akan mati",
                                    "Rasulullah SAW kekal hidup",
                                    "Islam berakhir",
                                    "Umat Islam hilang agama",
                                },
                                0
                            ),
                            new Question(
                                "Apakah ketokohan Rasulullah SAW dalam keluarga?",
                                new List<string>
                                {
                                    "Pemimpin yang zalim",
                                    "Suami dan ayah yang penyayang",
                                    "Abang yang kasar",
                                    "Bapa saudara yang garang",
                                },
                                1
                            ),
                            new Question(
                                "Apakah contoh akhlak Rasulullah SAW terhadap isteri baginda?",
                                new List<string>
                                {
                                    "Suka memarahi",
                                    "Membantu dalam urusan rumah",
                                    "Mengabaikan tanggungjawab",
                                    "Tidak bercakap",
                                },
                                1
                            ),
                            new Question(
                                "Apakah contoh Rasulullah SAW dalam mendidik anak?",
                                new List<string>
                                {
                                    "Mengabaikan pendidikan anak",
                                    "Memberi kasih sayang dan tunjuk ajar",
                                    "Membiarkan tanpa bimbingan",
                                    "Bersikap kasar",
                                },
                                1
                            ),
                            new Question(
                                "Apakah ketokohan Rasulullah SAW dalam bersosial?",
                                new List<string>
                                {
                                    "Menjauhi jiran",
                                    "Mengasihi jiran dan masyarakat",
                                    "Membenci orang miskin",
                                    "Tidak peduli dengan masyarakat",
                                },
                                1
                            ),
                            new Question(
                                "Apakah sikap Rasulullah SAW dalam perhubungan dengan sahabat?",
                                new List<string>
                                {
                                    "Sombong",
                                    "Mementingkan diri",
                                    "Mesra dan menghormati mereka",
                                    "Tidak bercakap dengan mereka",
                                },
                                2
                            ),
                            new Question(
                                "Apakah sifat Rasulullah SAW ketika bermesyuarat dengan sahabat?",
                                new List<string>
                                {
                                    "Tidak mendengar pandangan",
                                    "Bermusyawarah dan mendengar pendapat sahabat",
                                    "Membuat keputusan sendiri sahaja",
                                    "Menolak pandangan semua",
                                },
                                1
                            ),
                            new Question(
                                "Apakah sifat utama Rasulullah SAW yang menjadi contoh?",
                                new List<string>
                                {
                                    "Jujur, amanah, menyampaikan, bijaksana",
                                    "Menipu dan khianat",
                                    "Zalim dan sombong",
                                    "Pemarah dan kasar",
                                },
                                0
                            ),
                            new Question(
                                "Apakah iktibar daripada ketokohan Rasulullah SAW dalam keluarga?",
                                new List<string>
                                {
                                    "Kita mesti berkasar dengan keluarga",
                                    "Kita mesti menunaikan tanggungjawab dengan kasih sayang",
                                    "Kita tidak perlu peduli keluarga",
                                    "Kita hanya pentingkan diri",
                                },
                                1
                            ),
                            new Question(
                                "Apakah iktibar daripada ketokohan Rasulullah SAW dalam bersosial?",
                                new List<string>
                                {
                                    "Mengasihi jiran dan masyarakat",
                                    "Membenci jiran",
                                    "Mengabaikan masyarakat",
                                    "Memutuskan silaturahim",
                                },
                                0
                            ),
                            new Question(
                                "Apakah iktibar daripada ketokohan Rasulullah SAW dalam perhubungan dengan sahabat?",
                                new List<string>
                                {
                                    "Hormat-menghormati dan setia kawan",
                                    "Bermusuhan dengan kawan",
                                    "Tidak peduli sahabat",
                                    "Mementingkan diri",
                                },
                                0
                            ),
                        },
                    },
                    new Levels // Level Adab Tahap 5
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "Apakah maksud berinteraksi?",
                                new List<string>
                                {
                                    "Bercakap seorang diri",
                                    "Berhubung dengan orang lain",
                                    "Menulis sahaja",
                                    "Duduk diam",
                                },
                                1
                            ),
                            new Question(
                                "Antara adab berinteraksi ialah?",
                                new List<string>
                                {
                                    "Menggunakan kata-kata kasar",
                                    "Senyum dan memberi salam",
                                    "Memotong percakapan",
                                    "Menjerit",
                                },
                                1
                            ),
                            new Question(
                                "Apabila berbual dengan orang lain, kita hendaklah?",
                                new List<string>
                                {
                                    "Menghina",
                                    "Mendengar dengan sopan",
                                    "Menyampuk",
                                    "Menengking",
                                },
                                1
                            ),
                            new Question(
                                "Menghormati orang ketika berinteraksi menunjukkan?",
                                new List<string>
                                {
                                    "Akhlak mulia",
                                    "Akhlak buruk",
                                    "Tidak penting",
                                    "Sia-sia",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak beradab ketika berinteraksi ialah?",
                                new List<string>
                                {
                                    "Disayangi",
                                    "Dibenci",
                                    "Dihormati",
                                    "Dikasihi",
                                },
                                1
                            ),
                            new Question(
                                "Media sosial ialah?",
                                new List<string>
                                {
                                    "Tempat berjumpa",
                                    "Aplikasi dalam talian untuk berhubung",
                                    "Kedai membeli-belah",
                                    "Majlis rasmi",
                                },
                                1
                            ),
                            new Question(
                                "Adab menggunakan media sosial ialah?",
                                new List<string>
                                {
                                    "Menyebarkan fitnah",
                                    "Menghormati privasi orang lain",
                                    "Menghina kawan",
                                    "Berkata bohong",
                                },
                                1
                            ),
                            new Question(
                                "Perkara yang dilarang dalam media sosial ialah?",
                                new List<string>
                                {
                                    "Berkongsi ilmu bermanfaat",
                                    "Menyebarkan berita palsu",
                                    "Memberi salam",
                                    "Menulis doa",
                                },
                                1
                            ),
                            new Question(
                                "Menggunakan bahasa sopan dalam media sosial menunjukkan?",
                                new List<string>
                                {
                                    "Akhlak mulia",
                                    "Akhlak buruk",
                                    "Tidak penting",
                                    "Sia-sia",
                                },
                                0
                            ),
                            new Question(
                                "Akibat menyalahgunakan media sosial ialah?",
                                new List<string>
                                {
                                    "Mendapat kawan baru",
                                    "Hilang kepercayaan orang lain",
                                    "Mendapat ilmu bermanfaat",
                                    "Dikasihi",
                                },
                                1
                            ),
                            new Question(
                                "Apakah maksud muamalah?",
                                new List<string>
                                {
                                    "Hubungan sesama manusia",
                                    "Hubungan dengan haiwan",
                                    "Hubungan dengan tumbuhan",
                                    "Hubungan dengan alam sekitar",
                                },
                                0
                            ),
                            new Question(
                                "Apabila berhutang kita mesti?",
                                new List<string>
                                {
                                    "Melupakan hutang",
                                    "Membayar semula pada masa ditetapkan",
                                    "Tidak membayar",
                                    "Menipu pemberi hutang",
                                },
                                1
                            ),
                            new Question(
                                "Orang yang tidak membayar hutang hukumnya?",
                                new List<string> { "Wajib", "Sunat", "Haram", "Harus" },
                                2
                            ),
                            new Question(
                                "Antara adab berjual beli ialah?",
                                new List<string>
                                {
                                    "Menipu timbangan",
                                    "Jujur dan amanah",
                                    "Menyorok barang",
                                    "Mengambil untung berlebihan",
                                },
                                1
                            ),
                            new Question(
                                "Orang yang menipu dalam jual beli akan?",
                                new List<string>
                                {
                                    "Dikasihi Allah",
                                    "Dilaknat Allah",
                                    "Dipuji orang",
                                    "Dihormati",
                                },
                                1
                            ),
                            new Question(
                                "Berkongsi rezeki bersama orang lain akan?",
                                new List<string>
                                {
                                    "Menambah permusuhan",
                                    "Mendapat keberkatan",
                                    "Menambah kebencian",
                                    "Menimbulkan dendam",
                                },
                                1
                            ),
                            new Question(
                                "Bersedekah kepada orang miskin termasuk?",
                                new List<string>
                                {
                                    "Amalan sia-sia",
                                    "Amalan mulia",
                                    "Amalan tercela",
                                    "Amalan dilarang",
                                },
                                1
                            ),
                            new Question(
                                "Akibat menipu dalam hutang dan jual beli ialah?",
                                new List<string>
                                {
                                    "Mendapat keberkatan",
                                    "Kehilangan keberkatan",
                                    "Disayangi Allah",
                                    "Dipuji",
                                },
                                1
                            ),
                            new Question(
                                "Contoh harta benda awam ialah?",
                                new List<string>
                                {
                                    "Bas sekolah",
                                    "Taman permainan",
                                    "Jalan raya",
                                    "Semua di atas",
                                },
                                3
                            ),
                            new Question(
                                "Adab menjaga harta awam ialah?",
                                new List<string>
                                {
                                    "Merosakkan kerusi taman",
                                    "Menconteng dinding sekolah",
                                    "Menggunakannya dengan baik",
                                    "Membuang sampah merata-rata",
                                },
                                2
                            ),
                            new Question(
                                "Merosakkan harta awam hukumnya?",
                                new List<string> { "Harus", "Haram", "Sunat", "Makruh" },
                                1
                            ),
                            new Question(
                                "Kelebihan menjaga harta awam ialah?",
                                new List<string>
                                {
                                    "Mendapat pahala",
                                    "Dibenci orang",
                                    "Dihina",
                                    "Merugikan",
                                },
                                0
                            ),
                            new Question(
                                "Akibat merosakkan harta awam ialah?",
                                new List<string>
                                {
                                    "Disayangi masyarakat",
                                    "Ditimpa kerugian",
                                    "Dipuji orang",
                                    "Mendapat pahala",
                                },
                                1
                            ),
                            new Question(
                                "Antara contoh menjaga alam sekitar ialah?",
                                new List<string>
                                {
                                    "Membakar sampah sembarangan",
                                    "Membuang sampah di tempatnya",
                                    "Menebang pokok sesuka hati",
                                    "Mengotorkan sungai",
                                },
                                1
                            ),
                            new Question(
                                "Islam mengajar umatnya supaya?",
                                new List<string>
                                {
                                    "Merosakkan bumi",
                                    "Memelihara alam sekitar",
                                    "Mengabaikan kebersihan",
                                    "Membazir sumber",
                                },
                                1
                            ),
                            new Question(
                                "Membuang sampah merata-rata akan menyebabkan?",
                                new List<string>
                                {
                                    "Alam sekitar bersih",
                                    "Penyakit dan pencemaran",
                                    "Masyarakat sihat",
                                    "Mendapat pahala",
                                },
                                1
                            ),
                            new Question(
                                "Menanam pokok adalah amalan?",
                                new List<string>
                                {
                                    "Baik dan mendapat pahala",
                                    "Tidak berguna",
                                    "Buruk",
                                    "Haram",
                                },
                                0
                            ),
                            new Question(
                                "Akibat tidak menjaga alam sekitar ialah?",
                                new List<string>
                                {
                                    "Mendapat keberkatan",
                                    "Hidup sihat",
                                    "Bencana alam",
                                    "Ketenangan",
                                },
                                2
                            ),
                            new Question(
                                "Doa ketika masuk masjid ialah?",
                                new List<string>
                                {
                                    "Allahummaftah li abwaba rahmatik",
                                    "Allahumma inni as'aluka ilman nafi'a",
                                    "Subhanallah",
                                    "Bismillahirrahmanirrahim",
                                },
                                0
                            ),
                            new Question(
                                "Doa ketika keluar masjid ialah?",
                                new List<string>
                                {
                                    "Allahummaftah li abwaba rahmatik",
                                    "Allahumma inni as'aluka fadhlika",
                                    "Alhamdulillah",
                                    "Astaghfirullah",
                                },
                                1
                            ),
                            new Question(
                                "Apabila masuk masjid kita perlu?",
                                new List<string>
                                {
                                    "Berlari-lari",
                                    "Mendahulukan kaki kanan",
                                    "Membuat bising",
                                    "Membawa makanan",
                                },
                                1
                            ),
                            new Question(
                                "Apabila keluar masjid kita perlu?",
                                new List<string>
                                {
                                    "Mendahulukan kaki kiri",
                                    "Mendahulukan kaki kanan",
                                    "Melompat",
                                    "Membanting pintu",
                                },
                                0
                            ),
                            new Question(
                                "Antara larangan di masjid ialah?",
                                new List<string>
                                {
                                    "Membaca Al-Quran",
                                    "Tidur berlebihan",
                                    "Berzikir",
                                    "Solat sunat",
                                },
                                1
                            ),
                            new Question(
                                "Apakah maksud iktikaf?",
                                new List<string>
                                {
                                    "Duduk di masjid dengan niat tertentu",
                                    "Tidur di rumah",
                                    "Berjalan-jalan di taman",
                                    "Berjualan di pasar",
                                },
                                0
                            ),
                            new Question(
                                "Hukum iktikaf ialah?",
                                new List<string> { "Wajib", "Sunat", "Haram", "Makruh" },
                                1
                            ),
                            new Question(
                                "Antara amalan ketika iktikaf ialah?",
                                new List<string>
                                {
                                    "Membaca Al-Quran",
                                    "Bermain bola",
                                    "Membuat bising",
                                    "Tidur berlebihan",
                                },
                                0
                            ),
                            new Question(
                                "Orang yang beriktikaf hendaklah?",
                                new List<string>
                                {
                                    "Menjaga adab di masjid",
                                    "Merosakkan masjid",
                                    "Berjual beli",
                                    "Bergurau senda",
                                },
                                0
                            ),
                            new Question(
                                "Kelebihan iktikaf ialah?",
                                new List<string>
                                {
                                    "Mendapat pahala",
                                    "Dibenci Allah",
                                    "Dimarahi orang",
                                    "Dirugikan",
                                },
                                0
                            ),
                            new Question(
                                "Apabila guru sedang mengajar kita hendaklah?",
                                new List<string>
                                {
                                    "Bising",
                                    "Mendengar dengan khusyuk",
                                    "Bermain",
                                    "Berjalan-jalan",
                                },
                                1
                            ),
                            new Question(
                                "Antara adab di majlis ilmu ialah?",
                                new List<string>
                                {
                                    "Duduk sopan",
                                    "Menyampuk guru",
                                    "Ketawa kuat",
                                    "Berbual kosong",
                                },
                                0
                            ),
                            new Question(
                                "Mencatat ilmu ketika belajar menunjukkan?",
                                new List<string> { "Rajin", "Malas", "Lalai", "Tidak penting" },
                                0
                            ),
                            new Question(
                                "Menghormati guru dalam majlis ilmu hukumnya?",
                                new List<string> { "Wajib", "Harus", "Makruh", "Haram" },
                                0
                            ),
                            new Question(
                                "Akibat tidak beradab dalam majlis ilmu ialah?",
                                new List<string>
                                {
                                    "Mendapat keberkatan",
                                    "Hilang keberkatan ilmu",
                                    "Mendapat pahala",
                                    "Dihormati",
                                },
                                1
                            ),
                            new Question(
                                "Hukum solat Jumaat ialah?",
                                new List<string>
                                {
                                    "Wajib bagi lelaki",
                                    "Sunat bagi lelaki",
                                    "Harus bagi wanita",
                                    "Makruh",
                                },
                                0
                            ),
                            new Question(
                                "Apabila mendengar khutbah Jumaat kita mesti?",
                                new List<string>
                                {
                                    "Berbual",
                                    "Diam dan mendengar",
                                    "Tidur",
                                    "Keluar masjid",
                                },
                                1
                            ),
                            new Question(
                                "Antara adab solat Hari Raya ialah?",
                                new List<string>
                                {
                                    "Membaca takbir raya",
                                    "Bermain mercun di masjid",
                                    "Bising dalam saf",
                                    "Mengganggu orang solat",
                                },
                                0
                            ),
                            new Question(
                                "Sunat pergi ke solat Hari Raya dengan?",
                                new List<string>
                                {
                                    "Jalan yang sama pergi dan balik",
                                    "Jalan yang berbeza",
                                    "Tidak pergi",
                                    "Tidur",
                                },
                                1
                            ),
                            new Question(
                                "Hukum solat jenazah ialah?",
                                new List<string> { "Fardu kifayah", "Fardu ain", "Sunat", "Harus" },
                                0
                            ),
                            new Question(
                                "Bilangan takbir dalam solat jenazah ialah?",
                                new List<string> { "Tiga", "Empat", "Lima", "Enam" },
                                1
                            ),
                            new Question(
                                "Doa dalam solat jenazah dibaca untuk?",
                                new List<string>
                                {
                                    "Mayat sahaja",
                                    "Semua orang hidup",
                                    "Mayat dan orang Islam",
                                    "Orang bukan Islam",
                                },
                                2
                            ),
                            new Question(
                                "Mengiringi jenazah hingga ke kubur adalah?",
                                new List<string>
                                {
                                    "Amalan mulia",
                                    "Amalan buruk",
                                    "Tidak penting",
                                    "Dilarang",
                                },
                                0
                            ),
                            new Question(
                                "Kemudahan masjid seperti?",
                                new List<string>
                                {
                                    "Air, kipas, karpet",
                                    "Pasar malam",
                                    "Kedai makan",
                                    "Jalan raya",
                                },
                                0
                            ),
                            new Question(
                                "Menguruskan kemudahan masjid termasuk?",
                                new List<string>
                                {
                                    "Tanggungjawab bersama",
                                    "Tidak penting",
                                    "Kerja sia-sia",
                                    "Dilarang",
                                },
                                0
                            ),
                            new Question(
                                "Merosakkan kemudahan masjid hukumnya?",
                                new List<string> { "Harus", "Haram", "Sunat", "Makruh" },
                                1
                            ),
                            new Question(
                                "Menjaga kebersihan masjid adalah?",
                                new List<string>
                                {
                                    "Amalan mulia",
                                    "Amalan buruk",
                                    "Tidak penting",
                                    "Amalan dilarang",
                                },
                                0
                            ),
                        },
                    },
                }
            );
        }

        // Update is called once per frame
        void Update() { }
    }
}
