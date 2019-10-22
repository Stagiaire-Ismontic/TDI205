
DECLARE --DEALLOCATE cursor_product1; 
    @product_name VARCHAR(MAX)='Test', 
    @list_price   DECIMAL=15;
	DECLARE cursor_product2 CURSOR
	FOR SELECT 
        @product_name, 
        @list_price

OPEN cursor_product2;
 
FETCH NEXT FROM cursor_product2 INTO --fetch offset thaded bls u taffch
    @list_price;
 
WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT @product_name + CAST(@list_price AS varchar);-- affichage
        FETCH NEXT FROM cursor_product2 INTO 
            @product_name, 
            @list_price;
    END;
 
CLOSE cursor_product2;
 
