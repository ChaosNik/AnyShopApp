use Trgovina;
#Initialisation
insert into Postanski_broj(PostanskiBrojMjesta, NazivMjesta) values (74270,'Teslić');
insert into Postanski_broj(PostanskiBrojMjesta, NazivMjesta) values (78000,'Banja Luka');
insert into Postanski_broj(PostanskiBrojMjesta, NazivMjesta) values (74101,'Doboj');
insert into Postanski_broj(PostanskiBrojMjesta, NazivMjesta) values (71123,'Istočno Sarajevo');
insert into Postanski_broj(PostanskiBrojMjesta, NazivMjesta) values (76300,'Bijeljina');

insert into Adresa(/*IdAdrese, */PostanskiBrojMjesta, NazivUlice, RedniBrojObjekta) values (74270,'Majora Gavrilovića',32);
insert into Adresa(/*IdAdrese, */PostanskiBrojMjesta, NazivUlice, RedniBrojObjekta) values (78000,'Gundulićeva',23);
insert into Adresa(/*IdAdrese, */PostanskiBrojMjesta, NazivUlice, RedniBrojObjekta) values (74101,'Vidovdanska',13);
insert into Adresa(/*IdAdrese, */PostanskiBrojMjesta, NazivUlice, RedniBrojObjekta) values (74270,'Donji Ruzević',NULL);
insert into Adresa(/*IdAdrese, */PostanskiBrojMjesta, NazivUlice, RedniBrojObjekta) values (74270,'Donji Ranković',124);

insert into Vrsta_motiva(/*IdVrsteMotiva,	*/NazivVrsteMotiva) values ('Ostalo');
insert into Vrsta_motiva(/*IdVrsteMotiva,	*/NazivVrsteMotiva) values ('Ikona');
insert into Vrsta_motiva(/*IdVrsteMotiva,	*/NazivVrsteMotiva) values ('Grad');

insert into Motiv(/*IdMotiva,	*/NazivMotiva, IdVrsteMotiva) values ('Bez motiva',1);
insert into Motiv(/*IdMotiva,	*/NazivMotiva, IdVrsteMotiva) values ('Georgije',2);
insert into Motiv(/*IdMotiva,	*/NazivMotiva, IdVrsteMotiva) values ('Jovan',2);
insert into Motiv(/*IdMotiva,	*/NazivMotiva, IdVrsteMotiva) values ('Stefan',2);
insert into Motiv(/*IdMotiva,	*/NazivMotiva, IdVrsteMotiva) values ('Teslić',3);
insert into Motiv(/*IdMotiva,	*/NazivMotiva, IdVrsteMotiva) values ('Doboj',3);

insert into Vrsta_proizvoda(/*IdVrsteProizvoda, */NazivVrsteProizvoda) values ('Repro materijal');
insert into Vrsta_proizvoda(/*IdVrsteProizvoda, */NazivVrsteProizvoda) values ('Flaša');
insert into Vrsta_proizvoda(/*IdVrsteProizvoda, */NazivVrsteProizvoda) values ('Ploska');
insert into Vrsta_proizvoda(/*IdVrsteProizvoda, */NazivVrsteProizvoda) values ('Stalak');
insert into Vrsta_proizvoda(/*IdVrsteProizvoda, */NazivVrsteProizvoda) values ('Duborez');
insert into Vrsta_proizvoda(/*IdVrsteProizvoda, */NazivVrsteProizvoda) values ('Naljepnica');

insert into Proizvod(/*IdProizvoda, */NazivProizvoda, IdVrsteProizvoda, IdMotiva, Cijena) values ('Velika ploska sa staklenom bocom',3,2,80.00);
insert into Proizvod(/*IdProizvoda, */NazivProizvoda, IdVrsteProizvoda, IdMotiva, Cijena) values ('Srednja ploska sa staklenom bocom',3,3,60.00);
insert into Proizvod(/*IdProizvoda, */NazivProizvoda, IdVrsteProizvoda, IdMotiva, Cijena) values ('Slagana ploska',3,2,400.00);
insert into Proizvod(/*IdProizvoda, */NazivProizvoda, IdVrsteProizvoda, IdMotiva, Cijena) values ('Ikona 20cm X 30cm',5,4,300.00);
insert into Proizvod(/*IdProizvoda, */NazivProizvoda, IdVrsteProizvoda, IdMotiva, Cijena) values ('Daska 25mm X 10cm X 2m',1,1,10.00);
insert into Proizvod(/*IdProizvoda, */NazivProizvoda, IdVrsteProizvoda, IdMotiva, Cijena) values ('Daska 12mm X 10cm X 2m',1,1,5.00);
insert into Proizvod(/*IdProizvoda, */NazivProizvoda, IdVrsteProizvoda, IdMotiva, Cijena) values ('Flaša Grecija 0.7l',1,1,0.70);

insert into Banka(/*IdBanke, */NazivBanke) values ('Sberbank');
insert into Banka(/*IdBanke, */NazivBanke) values ('Nova Banka');
insert into Banka(/*IdBanke, */NazivBanke) values ('Addico Bank');
insert into Banka(/*IdBanke, */NazivBanke) values ('Sparkasse Bank');
insert into Banka(/*IdBanke, */NazivBanke) values ('NLB Banka');

insert into Nalog_u_banci(/*IdNaloga_u_banci, */IdBanke, BrojNaloga) values (2,10111213);
insert into Nalog_u_banci(/*IdNaloga_u_banci, */IdBanke, BrojNaloga) values (2,14151617);
insert into Nalog_u_banci(/*IdNaloga_u_banci, */IdBanke, BrojNaloga) values (4,18192021);
insert into Nalog_u_banci(/*IdNaloga_u_banci, */IdBanke, BrojNaloga) values (4,22232425);
insert into Nalog_u_banci(/*IdNaloga_u_banci, */IdBanke, BrojNaloga) values (4,26272829);

insert into Dobavljac(/*IdDobavljaca, */NazivDobavljaca, IdAdrese, IdNaloga_u_banci) values ('Elgrad',5,4);
insert into Dobavljac(/*IdDobavljaca, */NazivDobavljaca, IdAdrese, IdNaloga_u_banci) values ('Slavuljica',4,2);

insert into Vrsta_lanca_prodavnica(/*IdVrsteLancaProdavnica, */NazivVrsteLancaProdavnica) values ('Lokalni');
insert into Vrsta_lanca_prodavnica(/*IdVrsteLancaProdavnica, */NazivVrsteLancaProdavnica) values ('Regionalni');
insert into Vrsta_lanca_prodavnica(/*IdVrsteLancaProdavnica, */NazivVrsteLancaProdavnica) values ('Nacionalni');
insert into Vrsta_lanca_prodavnica(/*IdVrsteLancaProdavnica, */NazivVrsteLancaProdavnica) values ('Internacionalni');

insert into Lanac_prodavnica(/*IdLancaProdavnica,	*/NazivLancaProdavnica, IdVrsteLancaProdavnica) values ('Suvenir Karpić',2);

insert into Vrsta_Prodavnice(/*IdVrsteProdavnice, */NazivVrsteProdavnice) values ('Tvornica');
insert into Vrsta_Prodavnice(/*IdVrsteProdavnice, */NazivVrsteProdavnice) values ('Automat');
insert into Vrsta_Prodavnice(/*IdVrsteProdavnice, */NazivVrsteProdavnice) values ('Online');
insert into Vrsta_Prodavnice(/*IdVrsteProdavnice, */NazivVrsteProdavnice) values ('Specijalizovana');
insert into Vrsta_Prodavnice(/*IdVrsteProdavnice, */NazivVrsteProdavnice) values ('Robna kuća');
insert into Vrsta_Prodavnice(/*IdVrsteProdavnice, */NazivVrsteProdavnice) values ('Tržni centar');
insert into Vrsta_Prodavnice(/*IdVrsteProdavnice, */NazivVrsteProdavnice) values ('Supermarket');
insert into Vrsta_Prodavnice(/*IdVrsteProdavnice, */NazivVrsteProdavnice) values ('Hipermarket');

insert into Prodavnica(/*IdProdavnice, */NazivProdavnice, IdAdrese, IdLancaProdavnica, IdVrsteProdavnice) values ('Suvenir Karpić',1,1,1);
insert into Prodavnica(/*IdProdavnice, */NazivProdavnice, IdAdrese, IdLancaProdavnica, IdVrsteProdavnice) values ('Slavuljica',4,1,7);
insert into Prodavnica(/*IdProdavnice, */NazivProdavnice, IdAdrese, IdLancaProdavnica, IdVrsteProdavnice) values ('VRS Banjaluka',2,1,4);

insert into Zaposleni(/*IdZaposlenog, */ImeZaposlenog, PrezimeZaposlenog, JMBZaposlenog, KorisnickoIme, Lozinka) values ('Nikola','Karpić','3107995123584','chaosnik',787007925);
insert into Zaposleni(/*IdZaposlenog, */ImeZaposlenog, PrezimeZaposlenog, JMBZaposlenog, KorisnickoIme, Lozinka) values ('Mitar','Mitrović','3112199012355','mitrina',1210137196);
insert into Zaposleni(/*IdZaposlenog, */ImeZaposlenog, PrezimeZaposlenog, JMBZaposlenog, KorisnickoIme, Lozinka) values ('Marko','Marković','1010198813245','markouson',1197111017);
insert into Zaposleni(/*IdZaposlenog, */ImeZaposlenog, PrezimeZaposlenog, JMBZaposlenog, KorisnickoIme, Lozinka) values ('Milana','Milanović','1010991666321','milana91',303295663);
insert into Zaposleni(/*IdZaposlenog, */ImeZaposlenog, PrezimeZaposlenog, JMBZaposlenog, KorisnickoIme, Lozinka) values ('Nikola','Nikolić','0803198123234','nikoniko',186884220);

insert into Administrator(IdZaposlenog) values (1);

insert into Zaposleni_u_prodavnici(IdZaposlenog, IdProdavnice) values (2,1);
insert into Zaposleni_u_prodavnici(IdZaposlenog, IdProdavnice) values (3,3);
insert into Zaposleni_u_prodavnici(IdZaposlenog, IdProdavnice) values (4,2);
insert into Zaposleni_u_prodavnici(IdZaposlenog, IdProdavnice) values (5,1);

insert into Narudzba(/*IdNarudzbe, */IdProdavnice, IdDobavljaca, DatumKreiranjaNarudzbe, RokIsporuke) values (1,1,STR_TO_DATE('30.3.2017.', '%d.%m.%Y.'),STR_TO_DATE('30.5.2017.', '%d.%m.%Y.'));
insert into Narudzba(/*IdNarudzbe, */IdProdavnice, IdDobavljaca, DatumKreiranjaNarudzbe, RokIsporuke) values (1,2,STR_TO_DATE('3.4.2017.', '%d.%m.%Y.'),STR_TO_DATE('10.4.2017.', '%d.%m.%Y.'));
insert into Narudzba(/*IdNarudzbe, */IdProdavnice, IdDobavljaca, DatumKreiranjaNarudzbe, RokIsporuke) values (1,1,STR_TO_DATE('10.7.2017.', '%d.%m.%Y.'),STR_TO_DATE('10.8.2017.', '%d.%m.%Y.'));
insert into Narudzba(/*IdNarudzbe, */IdProdavnice, IdDobavljaca, DatumKreiranjaNarudzbe, RokIsporuke) values (1,1,STR_TO_DATE('12.8.2017.', '%d.%m.%Y.'),STR_TO_DATE('12.10.2017.', '%d.%m.%Y.'));

insert into Stavka_narudzbe(IdNarudzbe, IdProizvoda, Kolicina) values (1,5,10);
insert into Stavka_narudzbe(IdNarudzbe, IdProizvoda, Kolicina) values (1,6,10);
insert into Stavka_narudzbe(IdNarudzbe, IdProizvoda, Kolicina) values (2,7,25);
insert into Stavka_narudzbe(IdNarudzbe, IdProizvoda, Kolicina) values (3,5,20);
insert into Stavka_narudzbe(IdNarudzbe, IdProizvoda, Kolicina) values (3,6,25);
insert into Stavka_narudzbe(IdNarudzbe, IdProizvoda, Kolicina) values (4,5,25);
insert into Stavka_narudzbe(IdNarudzbe, IdProizvoda, Kolicina) values (1,7,25);