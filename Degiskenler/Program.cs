// degiskenleri en cok kullanilan degiskenlerden baslayarak tanimlayalim

int a = 5;
string b = "Kalem a";
char c = 'l';

Console.WriteLine("basit degiskenlerin sonucu = " + a + " " + b + c);

// sonuc 5 kalem al aciklamasi

// a 5 tir, b Kalem a' dir ve c character oldugundan sadece bir deger alir ve 'l' alinmistir.

// diger degiskenler

// var

var q = 29;
var w = 30;

Console.WriteLine("var orneginin sonucu ="+(q+w));

//bool dogru ve yanlis degiskeni geriye true veya false dondurur

bool b1 = 5 > 3;
bool b2 = 5 < 3;

Console.WriteLine("b1 sonucu= "+b1+" b2 sonucu= "+b2);


// Object cSharb in en ustunde yer alan degisken turudur icine her turden veri atanabilir

object a1 = 11; // int
object b3 = 'd'; // karakter
object c1 = "metin"; // string
object d1 = 12.9f; // float ifade

Console.WriteLine("Objectin ciksisi= "+a1+" "+b3+" "+c1+" "+d1);

// byte 0-255 arasi tam sayi tutar

byte a5 = 5;
byte b5 = 8;
Console.WriteLine("byte sonucu = "+a5 +"ve b5= "+ b5);


// Asagida degiskenlerin kullanimini dort islem ile gosterelim

// toplama

int x = 12;

int y = 13;

int z = 14;

int topla = x + y + z;

Console.WriteLine("toplama sonucu ="+topla);


// cikarma

int cikar = x - y;

Console.WriteLine("cikarma sonucu ="+cikar);

// bolme


decimal bolme = (decimal)y / x;

Console.WriteLine("bolme sonucu =" + bolme);


int carpma = x * y;

Console.WriteLine("carpma sonucu ="+carpma);
