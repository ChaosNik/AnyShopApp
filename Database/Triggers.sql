use Trgovina;
#Triggers

drop trigger if exists CiscenjePostanskihBrojevaInsert;
delimiter |
create trigger CiscenjePostanskihBrojevaInsert before insert on Adresa
  for each row
  begin
    delete from Postanski_broj WHERE Postanski_broj.PostanskiBrojMjesta > 99999;
  end;
|
delimiter ;

drop trigger if exists CiscenjePostanskihBrojevaUpdate;
delimiter |
create trigger CiscenjePostanskihBrojevaUpdate before insert on Adresa
  for each row
  begin
    delete from Postanski_broj WHERE Postanski_broj.PostanskiBrojMjesta > 99999;
  end;
|
delimiter ;

/*drop trigger if exists CiscenjePostanskihBrojevaInsert;
drop trigger if exists CiscenjePostanskihBrojevaUpdate;*/