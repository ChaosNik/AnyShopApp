use Trgovina;
#Procedures

drop procedure if exists getStavkeNarudzbeById;
delimiter $$
create procedure getStavkeNarudzbeById(MyIdNarudzbe int)
begin
	select `Naziv`,`Vrsta proizvoda`,`Motiv`,`Vrsta motiva`,`Cijena`,`Kolicina`,`Ukupno` from SveStavkeNarudzbe where ID=MyIdNarudzbe;
end$$
delimiter ;

drop procedure if exists getNazivProdavniceById;
delimiter $$
create procedure getNazivProdavniceById(MyIdProdavnice int)
begin
	select NazivProdavnice from Prodavnica where IdProdavnice=MyIdProdavnice;
end$$
delimiter ;

drop procedure if exists getParoviPostanskiBrojNazivMjesta;
delimiter $$
create procedure getParoviPostanskiBrojNazivMjesta()
begin
	select PostanskiBrojMjesta,NazivMjesta from Postanski_broj;
end$$
delimiter ;

drop procedure if exists getUkupnaSumaNarudzbeById;
delimiter $$
create procedure getUkupnaSumaNarudzbeById(MyIdNarudzbe int)
begin
	select sum(Ukupno) from SveStavkeNarudzbe where IdNarudzbe = MyIdNarudzbe;
end$$
delimiter ;

drop procedure if exists getBrojZaposlenih;
delimiter $$
create procedure getBrojZaposlenih()
begin
	select count(IdZaposlenog) from Zaposleni;
end$$
delimiter ;

drop procedure if exists addZaposleni;
delimiter $$
create procedure addZaposleni(MyImeZaposlenog char(20),MyPrezimeZaposlenog char(20),
					MyJMBZaposlenog char(13),MyKorisnickoIme char(20),MyLozinka  int)
begin
	insert into Zaposleni(ImeZaposlenog, PrezimeZaposlenog, JMBZaposlenog, KorisnickoIme, Lozinka)
    values (MyImeZaposlenog, MyPrezimeZaposlenog, MyJMBZaposlenog, MyKorisnickoIme, MyLozinka);
end$$
delimiter ;

drop procedure if exists addProizvod;
delimiter $$
create procedure addProizvod(MyNazivProizvoda char(40), MyIdVrsteProizvoda int, MyIdMotiva int, MyCijena double)
begin
	insert into Proizvod(NazivProizvoda, IdVrsteProizvoda, IdMotiva, Cijena)
    values (MyNazivProizvoda, MyIdVrsteProizvoda, MyIdMotiva, MyCijena);
end$$
delimiter ;

drop procedure if exists getLozinkaByKorisnickoIme;
delimiter $$
create procedure getLozinkaByKorisnickoIme(MyKorisnickoIme char(20))
begin
	select Lozinka from Zaposleni where KorisnickoIme=MyKorisnickoIme;
end$$
delimiter ;

drop procedure if exists getImeByKorisnickoIme;
delimiter $$
create procedure getImeByKorisnickoIme(MyKorisnickoIme char(20))
begin
	select ImeZaposlenog from Zaposleni where KorisnickoIme=MyKorisnickoIme;
end$$
delimiter ;

drop procedure if exists getPrezimeByKorisnickoIme;
delimiter $$
create procedure getPrezimeByKorisnickoIme(MyKorisnickoIme char(20))
begin
	select PrezimeZaposlenog from Zaposleni where KorisnickoIme=MyKorisnickoIme;
end$$
delimiter ;

drop procedure if exists getImeAdministratoraByKorisnickoIme;
delimiter $$
create procedure getImeAdministratoraByKorisnickoIme(MyKorisnickoIme char(20))
begin
	select Zaposleni.ImeZaposlenog from Administrator
    inner join Zaposleni on Zaposleni.IdZaposlenog=Administrator.IdZaposlenog
    where Zaposleni.KorisnickoIme=MyKorisnickoIme;
end$$
delimiter ;

drop procedure if exists getImeProdavcaByKorisnickoIme;
delimiter $$
create procedure getImeProdavcaByKorisnickoIme(MyKorisnickoIme char(20))
begin
	select Zaposleni.ImeZaposlenog from Zaposleni_u_prodavnici
    inner join Zaposleni on Zaposleni.IdZaposlenog=Zaposleni_u_prodavnici.IdZaposlenog
    where Zaposleni.KorisnickoIme=MyKorisnickoIme;
end$$
delimiter ;

drop procedure if exists getImeSkladistaraByKorisnickoIme;
delimiter $$
create procedure getImeSkladistaraByKorisnickoIme(MyKorisnickoIme char(20))
begin
	select Zaposleni.ImeZaposlenog from Zaposleni_u_skladistu
    inner join Zaposleni on Zaposleni.IdZaposlenog=Zaposleni_u_skladistu.IdZaposlenog
    where Zaposleni.KorisnickoIme=MyKorisnickoIme;
end$$
delimiter ;

drop procedure if exists setNarudzba;
delimiter $$
create procedure setNarudzba(MyIdProdavnice int, MyIdDobavljaca int, MyDatum char(20), MyRokIsporuke char(20))
begin
	insert into Narudzba(IdProdavnice, IdDobavljaca, DatumKreiranjaNarudzbe, RokIsporuke)
    values (MyIdProdavnice, MyIdDobavljaca, STR_TO_DATE(MyDatum,'%d.%m.%Y.'), STR_TO_DATE(MyRokIsporuke,'%d.%m.%Y.'));
end$$
delimiter ;

drop procedure if exists setStavkaNarudzbe;
delimiter $$
create procedure setStavkaNarudzbe(MyIdNarudzbe int, MyIdProizvoda int, MyKolicina int)
begin
	insert into Stavka_narudzbe(IdNarudzbe, IdProizvoda, Kolicina)
    values (MyIdNarudzbe, MyIdProizvoda, MyKolicina);
end$$
delimiter ;