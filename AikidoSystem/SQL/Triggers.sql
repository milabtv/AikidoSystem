CREATE TRIGGER Insert_Grouplist 
ON GroupList
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO GroupList (ID,Kartoteka,Group_name)
    SELECT
        i.ID,i.Kartoteka,i.Group_name
    FROM
        inserted i
    WHERE
        i.ID NOT IN (
            SELECT 
               ID
            FROM
               GroupList
        );
END

