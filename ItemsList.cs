-- Write only the T-SQL code that solves the problem and nothing else
CREATE PROCEDURE ItemsBought (@date DATE) AS
BEGIN
    SELECT DAY(dateBought), MONTH(dateBought), name FROM items WHERE dateBought BETWEEN @date AND DATEADD(month,1, @date)
END;
