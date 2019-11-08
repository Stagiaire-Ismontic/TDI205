create trigger corriger_nombre_jours on Projets

after insert
 
as
begin
    exec corrige

end