CREATE TRIGGER Insert_Kartoteka 
ON Kartoteki
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Kartoteki (EGN,First_name,Middle_name,.Last_name,Telephone,Email_,Address)
    SELECT
        i.EGN,i.First_name,i.Middle_name,i.Last_name,i.Telephone,i.Email_,i.Address
    FROM
        inserted i
    WHERE
        i.EGN NOT IN (
            SELECT 
               EGN
            FROM
               [Kartoteki]
        );
END