//See https://aka.ms/new-console-template for more informat
//string[] names = new string[] { "array","hafiz" };
//int Count = 0;

//MYlength(names);

//void MYlength (string[] arr)
//{
//    while(arr.ElementAtOrDefault(Count) != null)
//    {
//        Count++;

//    }
//}
//int kavadratcagir (int a)
//{
//    return a;
//}
//using ConsoleApp3;
/*
while (true)
{
    Console.WriteLine("marka:");
    string marka = Console.ReadLine();
    Console.WriteLine("model");
    string model = Console.ReadLine();
    Console.WriteLine("Price");
    string price = Console.ReadLine();
    Console.WriteLine("vuruq var ?");
    string vuruq = Console.ReadLine();
    Car car = new Car();
    car.Marka = marka;
    car.Model = model;
    car.vuruq = vuruq;
    car.price = Convert.ToInt32(price);
    Console.WriteLine(marka + " " + model + " " + price + " " + vuruq + " Salmatciliqdi braaat");

}
*/

//string[] names = new string[] { "akif", "fazil", "dyadya" };

//static void main()
//{
//    byte i = 0;
//    while (i <= 10)
//    {
//        Console.WriteLine(i);
//        i++;
//    }
//    Console.ReadLine();

//}



//int toplam = 0, sayi = 0;
//do
//{
//    Console.Write("Bir number girun :");
//    sayi = Convert.ToInt32(Console.ReadLine());
//    toplam += sayi;

//}
//while (sayi != 0);
//{
//    Console.WriteLine("Numberin toplami =" + toplam);
//    Console.ReadLine();
//    Console.Beep();
//}
//string can = "85";
//int nuber =Convert.ToInt32(can);
//Console.WriteLine(nuber);
//Console.Write("ne lazim di qaqash ");
//var yas = Console.ReadLine();
//int yasim = Convert.ToInt32(yas);
//yasim = yasim/10;
//Console.Write(  "bu qeder endirim var di qet" + " " + yasim );
//Console.ReadLine();

//var tms = Environment.TickCount;
//var ts = tms / 1000;
//var sk = ts / 60;
//var s = sk / 60;
//Console.WriteLine(s + " saat");
//Console.ReadLine();

//int yil = DateTime.Today.Year;
//int ay = DateTime.Today.Month;
//int gun = DateTime.Today.Day;
//Console.WriteLine(yil +"." + ay+"." + gun);
//Console.ReadLine();

//ornek();
//Console.ReadLine();

//void ornek()
//{
//    Console.WriteLine("YASUVU GIR");
//    int can =  Convert.ToInt32(Console.ReadLine());
//    if(can <18)
//    {
//        Console.WriteLine("gre bilermersen");
//    }
//    else
//    {
//        Console.WriteLine("gire bolersen");
//    }


//}

//using ConsoleApp3;

//Mehsullar mehsullar = new Mehsullar();
//mehsullar.Name = "BMW";
//mehsullar.Price = 20000;
//mehsullar.Vergi = 30;


//ProductMeneger productMeneger = new ProductMeneger();
//Console.WriteLine("Mehsulun adin qeyd edin: ");
//string Name = Console.ReadLine();
//Console.WriteLine("mehsulun qiymeti :  ");
//int Price = Convert .ToInt32(mehsullar.Price);
//Console.WriteLine("Mhesulun vergisi :");
//int Vergi = Convert .ToInt32(Console.ReadLine());


//productMeneger.AddProduct(mehsullar);
//Console.WriteLine("");

//mehsullar.Price = Price;
//mehsullar.Name = Name;
//mehsullar.Vergi= Vergi;

// random funksiya si

//Random rand = new Random();
//long mynuber = 0;
//long cehd  = 0;
//while (mynuber != 1000)
//{
//    cehd++;
//    mynuber = rand.Next(100000);
//    //Console.WriteLine(mynuber);
//}
//Console.WriteLine(cehd + " cu cehdde");


// 1km  - 5az disa /. musteri nece km daxil etsin ona pulu qaytaraq / 
//  km uygun vaxt i desin ...
// basqa klass dar yaradib  nese elemeye casli

// claslar mentiqi 

//using ConsoleApp3;

//using ConsoleApp3;

//Console.WriteLine("Musterinin  qeyd edeceyi KM  :");
//decimal girilen = Convert.ToDecimal(Console.ReadLine());
//int Money = 5;
//int s = 30;
//decimal t = girilen / s;
//string time = t.toFixed(2);
//Console.WriteLine("Gedmey ucun odeyeceyiniz qiymet :" + Money * girilen + "manat" + " time :" + time + " deq");

//Console.Write("Mehsullarin adlari : ");
//string ad = Console.ReadLine();
//Console.Write("mehsullarin qiymetleri :");
//int qiymet  = Convert.ToInt32(Console.ReadLine());

//Mehsullar mehsullar = new Mehsullar();
//mehsullar.ad = ad;
//mehsullar.qiymet = qiymet;
//mehsullar.vergi = vergi;


//ProductMeneger meneger = new ProductMeneger();
//meneger.AddProduct(mehsullar);


// do While yapsi
using ConsoleApp3;

string right="";
Console.OutputEncoding = System.Text.Encoding.UTF8; //azerbyacan sirifti taninmagi ucun istifade edirik ) 
do
{
   
    Console.WriteLine("Masini daxil edin");

    Console.Write("MArka :");
    string marka = Console.ReadLine();

    Console.WriteLine("Model :");
    string model = Console.ReadLine();

    Console.WriteLine("FuellEff");
    string fuelEff = Console.ReadLine();

    Console.WriteLine("MAx fuel :");
    string maxFuel = Console.ReadLine();

    Console.WriteLine("Current fuel :");
    string currentFuel = Console.ReadLine();

    bool isCorret = false;

    try
    {
        decimal fuelEffdec = Convert.ToDecimal(fuelEff);
        decimal maxFueldec = Convert.ToDecimal(maxFuel);
        decimal currentFueldec = Convert.ToDecimal(currentFuel);

        Car car = new Car()
        {
            Marka = marka,
            Model = model,
            FullEff = fuelEffdec,
            MaxFuel = maxFueldec,
            CurrentFuel = currentFueldec


        };
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Marka adi " + marka + "Ugurla yaradildi /n");
        isCorret = true;

    }
    catch (Exception)
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Benzille bafli meliumatlari reqem daxil edin");
    }
    if (isCorret == true)
    {

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Welcome");
    Console.WriteLine("1.Go");
    Console.WriteLine("2.toUp");
    Console.WriteLine("3.Stop");
    Console.WriteLine("4.Exit");
    right = Console.ReadLine();
    try
    {
        int rightNumber = Convert.ToInt32(right);
        Console.Clear();
        //switc case

        switch (rightNumber)
        {
            case 1:
                Console.WriteLine("Benzin doldu");
                break;
             case 2:
                Console.WriteLine("Masin getdi");

                break ;
             case 3:
                Console.WriteLine("Stop");
                break;
             case 4:
                Console.WriteLine("Yaxsi yol");
              break;
                default:
                Console.WriteLine("Yuxardaki reqemlerden birini daxil edin");
                break;

        }


    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Clear();
        Console.WriteLine("XAis edirik reqem daxil edin");
    }
    }

} while (right != "4");






