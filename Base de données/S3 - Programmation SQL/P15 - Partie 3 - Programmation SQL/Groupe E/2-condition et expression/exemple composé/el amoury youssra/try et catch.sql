DECLARE 
    @Message  NVARCHAR(4000), 
    @Severity int, 
    @State    int;
 
BEGIN TRY
    RAISERROR('false', 3, 20);
END TRY
BEGIN CATCH
    SELECT 
        @Message = ERROR_MESSAGE(), 
       @Severity= ERROR_SEVERITY(), 
         @State  = ERROR_STATE();
		raiserror(@Message, @Severity, @State);
END CATCH;