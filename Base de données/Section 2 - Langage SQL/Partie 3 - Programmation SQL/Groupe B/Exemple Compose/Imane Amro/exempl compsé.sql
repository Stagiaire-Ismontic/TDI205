DECLARE 
    @ErrorMessage  NVARCHAR(4000), 
    @ErrorSeverity int, 
    @ErrorState    int;
 
BEGIN TRY
    RAISERROR('false', 3, 20);
END TRY
BEGIN CATCH
    SELECT 
        @ErrorMessage = ERROR_MESSAGE(), 
       @ErrorSeverity= ERROR_SEVERITY(), 
         @ErrorState  = ERROR_STATE();
		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
END CATCH;