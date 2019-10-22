DECLARE 
    @errormessage  NVARCHAR(4000), 
    @ErrorServity INT;

BEGIN TRY
    RAISERROR('Problema', 17);
END TRY
BEGIN CATCH
    SELECT 
        @ErrorMessage = ERROR_MESSAGE(), 
        @ErrorServity = ERROR_SEVERITY();
		select @ErrorMessage, @ErrorServity;
END CATCH;