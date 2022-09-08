SELECT Kartoteki.First_name,Kartoteki.Last_name,PaymentType.Payment_name,Payment.Pay_month,Payment.Pay_date 
FROM ((Kartoteki INNER JOIN Payment ON Kartoteki.EGN = Payment.Kartoteka) INNER JOIN PaymentDetails ON Payment.ID = PaymentDetails.Payment) INNER JOIN PaymentType ON PaymentDetails.Payment_type = PaymentType.ID 

