ZADATAK 
Napisati sledeće klase i sve testirati.  
Klasa Proizvod ima polja: sifra (string), naziv (string) i cena (double).  
U klasi Proizvod implementirati:  
konstruktor sa parametrima
svojstva za sva polja 
metod ToString  
Klasa Stavka ima polja: kolicina (int) i artikal (Proizvod).  
U klasi implementirati:  
konstruktor sa parametrima za kolicinu i proizvod
konstruktor sa parametrima za kolicinu i sifru, naziv i cenu artikla
metod double UkupnaCena() – vraća ukupnu cenu artikla (kolicina * cena). Moze se  realizovati i kao prop koji ima samo geter. 
metod ToString - vraća string sa podacima o artiklu, kolicini i ukupnoj ceni Obezbediti da svaka stavka ima definisan svoj proizvod. 

Obratiti paznju na to da klasa Stavka nema svojstva (props) za kolicinu i Proizvod. U klasi Program napisati metode 
- IznosRacuna koji za zadatu listu stavki izračunavati ukupan iznos. 
- StampajRacunAkcija koji za zadatu listu stavki i zadati popust ispisuje račun kao u primeru  ispod. 

Naziv prodavnice 
Danasnji datum 
====================== 
laptop kol: 2 ukupno: 1400.00  
miš kol:2 ukupno 30  
-------------------------------------- 
Ukupno: 1434.00  
Sa popustom 20%: 1144.00 
======================
Testirati konkretni slučaj. Izmisliti proizvode, naziv prodavnice i pronaći kako se dobija današnji datum. Po želji  formatirati lepše u odnosu na prikazano.
Omogućiti korisnički unos.
