#Creation
drop schema if exists Trgovina;
create schema Trgovina default character set utf8 default collate utf8_unicode_ci;
use Trgovina;

CREATE TABLE Adresa
(
	IdAdrese             INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	PostanskiBrojMjesta  INT NOT NULL,
	NazivUlice           CHAR(20) NOT NULL,
	RedniBrojObjekta     INT NULL #NULL je kao bb
);

/*ALTER TABLE Adresa
ADD PRIMARY KEY (IdAdrese);*/

CREATE TABLE Banka
(
	IdBanke              INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	NazivBanke           CHAR(20) NOT NULL
);

/*ALTER TABLE Banka
ADD PRIMARY KEY (IdBanke);*/

CREATE TABLE Dobavljac
(
	IdDobavljaca       		INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	NazivDobavljaca    		CHAR(20) NOT NULL,
	IdAdrese            	INT NOT NULL,
	IdNaloga_u_banci    	INT NOT NULL
);

/*ALTER TABLE Dobavljac
ADD PRIMARY KEY (IdDobavljaca);*/

CREATE TABLE Fizicko_lice
(
	IdKupca              INT NOT NULL,
	JMBFizickogLica      CHAR(13) NOT NULL,
	ImeFizickogLica      CHAR(20) NOT NULL,
	PrezimeFizickogLica  CHAR(20) NOT NULL,
	PolFizickogLica      BOOL NOT NULL
);

ALTER TABLE Fizicko_lice
ADD PRIMARY KEY (IdKupca);

CREATE TABLE Kupac
(
	IdKupca              INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	IdAdrese             INT NOT NULL,
	IdNaloga_u_banci     INT NOT NULL,
    Marza	DOUBLE NOT NULL
);

/*ALTER TABLE Kupac
ADD PRIMARY KEY (IdKupca);*/

CREATE TABLE Lanac_prodavnica
(
	IdLancaProdavnica    INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	NazivLancaProdavnica CHAR(20) NOT NULL,
	IdVrsteLancaProdavnica INT NOT NULL
);

/*ALTER TABLE Lanac_prodavnica
ADD PRIMARY KEY (IdLancaProdavnica);*/

CREATE TABLE Motiv
(
	IdMotiva             INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	NazivMotiva           CHAR(20) NOT NULL,
	IdVrsteMotiva        INT NOT NULL
);

/*ALTER TABLE Motiv
ADD PRIMARY KEY (IdMotiva);*/

CREATE TABLE Nalog_u_banci
(
	IdNaloga_u_banci     INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	IdBanke              INT NOT NULL,
	BrojNaloga           CHAR(20) NOT NULL
);

/*ALTER TABLE Nalog_u_banci
ADD PRIMARY KEY (IdNaloga_u_banci);*/

CREATE TABLE Narudzba
(
	IdNarudzbe           INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	IdProdavnice         INT NOT NULL,
	IdDobavljaca         INT NOT NULL,
	DatumKreiranjaNarudzbe DATE NOT NULL,
	RokIsporuke          DATE NOT NULL
);

/*ALTER TABLE Narudzba
ADD PRIMARY KEY (IdNarudzbe);*/

CREATE TABLE Pakovanje_proizvoda
(
	IdPakovanjaProizvoda INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	IdSkladista          INT NOT NULL,
	IdProizvoda          INT NOT NULL,
	Kolicina             DOUBLE NOT NULL
);

/*ALTER TABLE Pakovanje_proizvoda
ADD PRIMARY KEY (IdPakovanjaProizvoda);*/

CREATE TABLE Postanski_broj
(
	PostanskiBrojMjesta  INT NOT NULL,
	NazivMjesta         CHAR(20) NOT NULL
);

ALTER TABLE Postanski_broj
ADD PRIMARY KEY (PostanskiBrojMjesta);

CREATE TABLE Pravno_lice
(
	IdKupca              INT NOT NULL,
	JIBPravnogLica       CHAR(13) NOT NULL,
	NazivPravnogLica     CHAR(20) NOT NULL
);

ALTER TABLE Pravno_lice
ADD PRIMARY KEY (IdKupca);

CREATE TABLE Prodavnica
(
	IdProdavnice         INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	NazivProdavnice      CHAR(20) NULL,
	IdAdrese             INT NOT NULL,
	IdLancaProdavnica    INT NOT NULL,
	IdVrsteProdavnice    INT NOT NULL
);

/*ALTER TABLE Prodavnica
ADD PRIMARY KEY (IdProdavnice);*/

CREATE TABLE Proizvod
(
	IdProizvoda          INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	NazivProizvoda       CHAR(40) NULL,
	IdVrsteProizvoda     INT NOT NULL,
	IdMotiva             INT NOT NULL,
    Cijena 				 DOUBLE NOT NULL
);

/*ALTER TABLE Proizvod
ADD PRIMARY KEY (IdProizvoda);*/

CREATE TABLE Racun
(
	IdRacuna             INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	IdKupca              INT NOT NULL,
	DatumIzrade          DATE NOT NULL,
	RokZaPlacanje        DATE NOT NULL
);

/*ALTER TABLE Racun
ADD PRIMARY KEY (IdRacuna);*/

CREATE TABLE Skladiste
(
	IdSkladista          INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	IdAdrese             INT NOT NULL
);

/*ALTER TABLE Skladiste
ADD PRIMARY KEY (IdSkladista);*/

CREATE TABLE Stavka_narudzbe
(
	IdNarudzbe           INT NOT NULL,
	IdProizvoda          INT NOT NULL,
	Kolicina             DOUBLE NOT NULL
);

ALTER TABLE Stavka_narudzbe
ADD PRIMARY KEY (IdNarudzbe,IdProizvoda);

CREATE TABLE Stavka_racuna
(
	IdRacuna             INT NOT NULL,
	IdProizvoda          INT NOT NULL,
	Kolicina             DOUBLE NOT NULL
);

ALTER TABLE Stavka_racuna
ADD PRIMARY KEY (IdRacuna,IdProizvoda);

CREATE TABLE Vrsta_lanca_prodavnica
(
	IdVrsteLancaProdavnica INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	NazivVrsteLancaProdavnica CHAR(20) NOT NULL
);

/*ALTER TABLE Vrsta_lanca_prodavnica
ADD PRIMARY KEY (IdVrsteLancaProdavnica);*/

CREATE TABLE Vrsta_motiva
(
	IdVrsteMotiva        INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	NazivVrsteMotiva     CHAR(20) NOT NULL
);

/*ALTER TABLE Vrsta_motiva
ADD PRIMARY KEY (IdVrsteMotiva);*/

CREATE TABLE Vrsta_prodavnice
(
	IdVrsteProdavnice    INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	NazivVrsteProdavnice CHAR(20) NOT NULL
);

/*ALTER TABLE Vrsta_prodavnice
ADD PRIMARY KEY (IdVrsteProdavnice);*/

CREATE TABLE Vrsta_proizvoda
(
	IdVrsteProizvoda     INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	NazivVrsteProizvoda  CHAR(20) NOT NULL
);

/*ALTER TABLE Vrsta_proizvoda
ADD PRIMARY KEY (IdVrsteProizvoda);*/

CREATE TABLE Zaposleni
(
	IdZaposlenog         INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	ImeZaposlenog        CHAR(20) NOT NULL,
	PrezimeZaposlenog    CHAR(20) NOT NULL,
	JMBZaposlenog        CHAR(13) NOT NULL,
    KorisnickoIme		 CHAR(20) NOT NULL,
    Lozinka				 INT NOT NULL
);

/*ALTER TABLE Zaposleni
ADD PRIMARY KEY (IdZaposlenog);*/

CREATE TABLE Administrator
(
	IdZaposlenog         INT NOT NULL
);

ALTER TABLE Administrator
ADD PRIMARY KEY (IdZaposlenog);

CREATE TABLE Zaposleni_u_prodavnici
(
	IdZaposlenog         INT NOT NULL,
	IdProdavnice         INT NOT NULL
);

ALTER TABLE Zaposleni_u_prodavnici
ADD PRIMARY KEY (IdZaposlenog);

CREATE TABLE Zaposleni_u_skladistu
(
	IdZaposlenog         INT NOT NULL,
	IdSkladista          INT NOT NULL
);

ALTER TABLE Zaposleni_u_skladistu
ADD PRIMARY KEY (IdZaposlenog);

ALTER TABLE Adresa
ADD FOREIGN KEY R_61 (PostanskiBrojMjesta) REFERENCES Postanski_broj (PostanskiBrojMjesta)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Dobavljac
ADD FOREIGN KEY R_62 (IdAdrese) REFERENCES Adresa (IdAdrese)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Dobavljac
ADD FOREIGN KEY R_69 (IdNaloga_u_banci) REFERENCES Nalog_u_banci (IdNaloga_u_banci)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Fizicko_lice
ADD FOREIGN KEY (IdKupca) REFERENCES Kupac(IdKupca)
		ON DELETE CASCADE;

ALTER TABLE Kupac
ADD FOREIGN KEY R_63 (IdAdrese) REFERENCES Adresa (IdAdrese)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Kupac
ADD FOREIGN KEY R_83 (IdNaloga_u_banci) REFERENCES Nalog_u_banci (IdNaloga_u_banci)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Lanac_prodavnica
ADD FOREIGN KEY R_72 (IdVrsteLancaProdavnica) REFERENCES Vrsta_lanca_prodavnica (IdVrsteLancaProdavnica)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Motiv
ADD FOREIGN KEY R_60 (IdVrsteMotiva) REFERENCES Vrsta_motiva (IdVrsteMotiva)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Nalog_u_banci
ADD FOREIGN KEY R_30 (IdBanke) REFERENCES Banka (IdBanke)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Narudzba
ADD FOREIGN KEY R_86 (IdProdavnice) REFERENCES Prodavnica (IdProdavnice)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Narudzba
ADD FOREIGN KEY R_87 (IdDobavljaca) REFERENCES Dobavljac (IdDobavljaca)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Pakovanje_proizvoda
ADD FOREIGN KEY R_57 (IdSkladista) REFERENCES Skladiste (IdSkladista)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Pakovanje_proizvoda
ADD FOREIGN KEY R_58 (IdProizvoda) REFERENCES Proizvod (IdProizvoda)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Pravno_lice
ADD FOREIGN KEY (IdKupca) REFERENCES Kupac(IdKupca)
		ON DELETE CASCADE;

ALTER TABLE Prodavnica
ADD FOREIGN KEY R_55 (IdAdrese) REFERENCES Adresa (IdAdrese)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Prodavnica
ADD FOREIGN KEY R_39 (IdLancaProdavnica) REFERENCES Lanac_prodavnica (IdLancaProdavnica)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Prodavnica
ADD FOREIGN KEY R_74 (IdVrsteProdavnice) REFERENCES Vrsta_prodavnice (IdVrsteProdavnice)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Proizvod
ADD FOREIGN KEY R_90 (IdVrsteProizvoda) REFERENCES Vrsta_proizvoda (IdVrsteProizvoda)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Proizvod
ADD FOREIGN KEY R_91 (IdMotiva) REFERENCES Motiv (IdMotiva)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Racun
ADD FOREIGN KEY R_84 (IdKupca) REFERENCES Kupac (IdKupca)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Skladiste
ADD FOREIGN KEY R_56 (IdAdrese) REFERENCES Adresa (IdAdrese)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Stavka_narudzbe
ADD FOREIGN KEY R_51 (IdProizvoda) REFERENCES Proizvod (IdProizvoda)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Stavka_narudzbe
ADD FOREIGN KEY R_75 (IdNarudzbe) REFERENCES Narudzba (IdNarudzbe)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Stavka_racuna
ADD FOREIGN KEY R_76 (IdRacuna) REFERENCES Racun (IdRacuna)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Stavka_racuna
ADD FOREIGN KEY R_88 (IdProizvoda) REFERENCES Proizvod (IdProizvoda)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;
    
ALTER TABLE Administrator
ADD FOREIGN KEY (IdZaposlenog) REFERENCES Zaposleni(IdZaposlenog)
		ON DELETE CASCADE;

ALTER TABLE Zaposleni_u_prodavnici
ADD FOREIGN KEY (IdZaposlenog) REFERENCES Zaposleni(IdZaposlenog)
		ON DELETE CASCADE;

ALTER TABLE Zaposleni_u_prodavnici
ADD FOREIGN KEY R_54 (IdProdavnice) REFERENCES Prodavnica (IdProdavnice)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;

ALTER TABLE Zaposleni_u_skladistu
ADD FOREIGN KEY (IdZaposlenog) REFERENCES Zaposleni(IdZaposlenog)
		ON DELETE CASCADE;

ALTER TABLE Zaposleni_u_skladistu
ADD FOREIGN KEY R_55 (IdSkladista) REFERENCES Skladiste (IdSkladista)
	/**/ON UPDATE CASCADE
	/**/ON DELETE CASCADE;