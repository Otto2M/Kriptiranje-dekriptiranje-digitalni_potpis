# Kriptiranje, dekriptiranje i digitalni potpis

Ovim projektom izrađen je program koji korisniku omogućuje sljedeće:
- stvaranje i pohranjivanje kriptografskih ključeva u datoteke tajni_kljuc.txt, javni_kljuc.txt i privatni_kljuc.txt
- kriptiranje, odnosno dekriptiranje zadane datoteke simetričnim i asimetričnim algoritmom
- izračunavanje sažetka poruke (ulazne datoteke)
- digitalno potpisivanje ulazne datoteke te provjeru digitalnog potpisa

Za **simetrično** kriptiranje i dekriptiranje sadržaja datoteke korišten je AES algoritam, dok je za **asimetrično** kriptiranje i dekriptiranje korišten RSA algoritam. Digitalni potpis kreiran je korištenjem RSA algoritma.
Za izradu cijelog programa korišten je alat Visual Studio, a program je realiziran u obliku Windows Forms aplikacije.
Radi jednostavnosti korištenja izrađena je jedna forma kroz koju su omogućene sve funkcionalnosti, a sadrži osnovne i pregledne elemente kako bi se korisnik što lakše snašao. 

<br>
**Korištenje aplikacije**
1. pokretanjem aplikacije otvara se forma koja omogućuje korisniku prethodno navedene funkcionalnosti
2. korisnik najprije učitava sadržaj .txt datoteku koji želi kriptirati
3. klikom na gumb "Generiraj ključeve" kreiraju se ključevi i spremaju u zasebne datoteke
4. ovisno o željenoj vrsti kriptiranja (simetrično ili asimetrično) korisnik označava potrebni check box
5. pritiskom na gumb "Kriptiraj" kriptira se sadržaj ulazne datoteke
6. pritiskom na gumb "Deriptiraj" dekriptira se sadržaj
7. za iste je moguće dodatno izračunati sažetak poruke
8. korisnik ima mogućnost kreiranja digitalnog potpisa za željeni sadržaj, te provjeru ispravnosti istog
