use Trgovina;
#Views
drop view if exists SveAdrese;
create view SveAdrese as
	select Adresa.IdAdrese as 'ID',
            Adresa.NazivUlice as 'Naziv ulice',
            Adresa.RedniBrojObjekta as 'Broj',
            Postanski_broj.NazivMjesta as 'Mjesto',
            Adresa.PostanskiBrojMjesta as 'Postanski broj'
	from Adresa
	inner join Postanski_broj on Adresa.PostanskiBrojMjesta=Postanski_broj.PostanskiBrojMjesta
    order by 'ID';

drop view if exists SveStavkeNarudzbe;
create view SveStavkeNarudzbe as
	select Stavka_narudzbe.IdNarudzbe as 'ID',
			Proizvod.NazivProizvoda as 'Naziv',
			Vrsta_proizvoda.NazivVrsteProizvoda as 'Vrsta proizvoda',
			Motiv.NazivMotiva as 'Motiv',
            Vrsta_motiva.NazivVrsteMotiva as 'Vrsta motiva',
			Proizvod.Cijena as 'Cijena',
			Stavka_narudzbe.Kolicina as 'Kolicina',
			Proizvod.Cijena*Stavka_narudzbe.Kolicina as 'Ukupno'
	from Stavka_narudzbe
	inner join Proizvod on Stavka_narudzbe.IdProizvoda=Proizvod.IdProizvoda
	inner join Vrsta_proizvoda on Vrsta_proizvoda.IdVrsteProizvoda=Proizvod.IdVrsteProizvoda
	inner join Motiv on Motiv.IdMotiva=Proizvod.IdMotiva
    inner join Vrsta_motiva on Vrsta_motiva.IdVrsteMotiva=Motiv.IdVrsteMotiva
    order by 'ID narudzbe';
    
drop view if exists SveNarudzbe;
create view SveNarudzbe as
	select Narudzba.IdNarudzbe as 'ID',
			Prodavnica.NazivProdavnice as 'Prodavnica',
            Dobavljac.NazivDobavljaca as 'Dobavljac',
            Narudzba.DatumKreiranjaNarudzbe as 'Naruceno',
            Narudzba.RokIsporuke as 'Rok isporuke'
	from Narudzba
    inner join Prodavnica on Prodavnica.IdProdavnice=Narudzba.IdProdavnice
    inner join Dobavljac on Dobavljac.IdDobavljaca=Narudzba.IdDobavljaca
    order by 'ID narudzbe';
    
drop view if exists SviProizvodi;
create view SviProizvodi as
	select Proizvod.IdProizvoda as 'ID',
			Proizvod.NazivProizvoda as 'Naziv',
            Vrsta_proizvoda.NazivVrsteProizvoda as 'Vrsta',
            Motiv.NazivMotiva as 'Motiv',
            Vrsta_motiva.NazivVrsteMotiva as 'Vrsta motiva',
            Proizvod.Cijena as 'Osnovna cijena'
	from Proizvod
    inner join Vrsta_proizvoda on Vrsta_proizvoda.IdVrsteProizvoda=Proizvod.IdVrsteProizvoda
    inner join Motiv on Motiv.IdMotiva=Proizvod.IdMotiva
    inner join Vrsta_motiva on Vrsta_motiva.IdVrsteMotiva=Motiv.IdVrsteMotiva
    order by 'ID';
    
drop view if exists SviZaposleni;
create view SviZaposleni as
	select Zaposleni.IdZaposlenog as 'ID',
			Zaposleni.ImeZaposlenog as 'Ime',
            Zaposleni.PrezimeZaposlenog as 'Prezime',
            Zaposleni.JMBZaposlenog as 'JMB',
            Zaposleni.KorisnickoIme as 'Korisničko ime'
	from Zaposleni
    order by 'ID';
    
drop view if exists SviZaposleniUProdavnici;
create view SviZaposleniUProdavnici as
	select Zaposleni.IdZaposlenog as 'ID',
			Zaposleni.ImeZaposlenog as 'Ime',
            Zaposleni.PrezimeZaposlenog as 'Prezime',
            Zaposleni.JMBZaposlenog as 'JMB',
            Lanac_prodavnica.NazivLancaProdavnica as 'Lanac prodavnica',
            Prodavnica.NazivProdavnice as 'Prodavnica'
	from Zaposleni_u_prodavnici
    inner join Zaposleni on Zaposleni.IdZaposlenog=Zaposleni_u_prodavnici.IdZaposlenog
    inner join Prodavnica on Prodavnica.IdProdavnice=Zaposleni_u_prodavnici.IdProdavnice
    inner join Lanac_prodavnica on Lanac_prodavnica.IdLancaProdavnica=Prodavnica.IdLancaProdavnica
    order by 'ID';
    
drop view if exists SviZaposleniUSkladistu;
create view SviZaposleniUSkladistu as
	select Zaposleni.IdZaposlenog as 'ID',
			Zaposleni.ImeZaposlenog as 'Ime',
            Zaposleni.PrezimeZaposlenog as 'Prezime',
            Zaposleni.JMBZaposlenog as 'JMB',
            Adresa.NazivUlice as 'Naziv ulice skladista',
            Adresa.RedniBrojObjekta as 'Broj skladista',
            Postanski_broj.NazivMjesta as 'Mjesto skladista',
            Adresa.PostanskiBrojMjesta as 'Postanski broj'
	from Zaposleni_u_skladistu
    inner join Zaposleni on Zaposleni.IdZaposlenog=Zaposleni_u_skladistu.IdZaposlenog
    inner join Skladiste on Skladiste.IdSkladista=Zaposleni_u_skladistu.IdSkladista
    inner join Adresa on Adresa.IdAdrese=Skladiste.IdAdrese
    inner join Postanski_broj on Postanski_broj.PostanskiBrojMjesta=Adresa.PostanskiBrojMjesta
    order by 'ID';
    
drop view if exists SveProdavnice;
create view SveProdavnice as
	select Prodavnica.IdProdavnice as 'ID',
			Prodavnica.NazivProdavnice as 'Naziv',
            Adresa.NazivUlice as 'Naziv ulice',
            Adresa.RedniBrojObjekta as 'Broj',
            Postanski_broj.NazivMjesta as 'Mjesto',
            Adresa.PostanskiBrojMjesta as 'Postanski broj',
            Lanac_prodavnica.NazivLancaProdavnica as 'Lanac prodavnica',
            Vrsta_prodavnice.NazivVrsteProdavnice as 'Vrsta'
	from Prodavnica
    inner join Adresa on Adresa.IdAdrese=Prodavnica.IdAdrese
    inner join Postanski_broj on Postanski_broj.PostanskiBrojMjesta=Adresa.PostanskiBrojMjesta
    inner join Lanac_prodavnica on Lanac_prodavnica.IdLancaProdavnica=Prodavnica.IdLancaProdavnica
    inner join Vrsta_prodavnice on Vrsta_prodavnice.IdVrsteProdavnice=Prodavnica.IdVrsteProdavnice
    order by 'ID';
    
/*select * from SveAdrese;
select * from SveStavkeNarudzbe;
select * from SveNarudzbe;
select * from SviProizvodi;
select * from SviZaposleni;
select * from SviZaposleniUProdavnici;
select * from SviZaposleniUSkladistu;
select * from SveProdavnice;*/