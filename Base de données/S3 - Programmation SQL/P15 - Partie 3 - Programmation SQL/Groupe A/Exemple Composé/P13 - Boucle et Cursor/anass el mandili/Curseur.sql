
DECLARE 
    @product VARCHAR(MAX)='OMO', 
    @Qte   int =15;
	DECLARE cursor_product CURSOR
	FOR SELECT 
        @product, 
        @Qte

OPEN cursor_product;
 
FETCH NEXT FROM cursor_product INTO --fetch offset thaded bls u taffch
    @product, 
    @Qte;
 
WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT @product + CAST( @Qte AS varchar);-- affichage
        FETCH NEXT FROM cursor_product INTO 
            @product, 
            @Qte;
    END;
 
CLOSE cursor_product;
 
