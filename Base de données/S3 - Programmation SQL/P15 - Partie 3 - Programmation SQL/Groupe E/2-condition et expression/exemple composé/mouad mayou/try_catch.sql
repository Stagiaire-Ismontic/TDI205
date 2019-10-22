declare 
@Errormessage varchar(4000),
@Errorseverity int,
@Errorstate int;
BEGIN TRY
  RAISERROR('false',3,20);
END TRY
BEGIN CATCH
SELECT
  @Errormessage= ERROR_MESSAGE(),
 @Errorseverity= ERROR_SEVERITY(),
  @Errorstate = ERROR_STATE();
  RAISERROR (@Errormessage,@Errorseverity,@Errorstate);
  END CATCH
   