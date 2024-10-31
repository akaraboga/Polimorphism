# Polimorphism Bu pratikte base clasının alanhespala metoduna virtual diyerek dikucgenin alanını bulmak için override edicez. 

Kare, Dikdörtgen, Dik Üçgen nesnelerinden oluşacak bir uygulamada alan hesaplaması yapmak istiyoruz.

Yukarıda bahsettiğimiz nesnelerin her birini üretebilmemiz için classlara ihtiyacımız var.

Kare

Dikdortgen

DikUcgen

Classlarımızı ortak bir çatı altında toplayarak BaseGeometrikSekil classından türetebiliriz.

BaseGeometrikSekil için Propertyler -> Genişlik ve Yükseklik

AlanHesapla() metodu tüm geometrik şekillerde bulanacağından Base Class içerisinde tanımlayabiliriz.

 
