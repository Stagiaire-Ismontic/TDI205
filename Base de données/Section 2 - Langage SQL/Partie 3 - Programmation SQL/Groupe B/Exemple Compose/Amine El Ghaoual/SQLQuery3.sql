DECLARE 
   @EM  NVARCHAR(4000),
   @Esev  int,
   @Est  int;

   BEGIN TRY
       RAISERROR ('ERROR',10,20);
   END TRY
   BEGIN CATCH
   SELECT
      @Est=ERROR_MESSAGE(),
	  @Esev=ERROR_SEVERITY(),
	  @Est=ERROR_STATE();
	  RAISERROR(@EM,@Esev,@Est);
END CATCH
