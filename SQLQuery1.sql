CREATE TABLE cardholders (
    cardholder_id INT NOT NULL PRIMARY KEY,
    full_name VARCHAR(50) NOT NULL,
    phone_number VARCHAR(10),
    card_type VARCHAR(10),
    card_number VARCHAR(16) NOT NULL UNIQUE,
    expiration_date DATE NOT NULL,
	amount int not null,
	pin int not null
);

CREATE TABLE withdrawaltransactions (
    transaction_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,  
    cardholder_id INT,               
    amount INT,                         
    transaction_date DATETIME DEFAULT GETDATE(),                    
    FOREIGN KEY (cardholder_id) REFERENCES cardholders(cardholder_id)
);

CREATE TABLE DepositDetails (
    deposit_id INT PRIMARY KEY IDENTITY(1,1),  
    cardholder_id INT NOT NULL,              
    deposit_amount int not NULL,   
    deposit_date DATETIME NOT NULL DEFAULT GETDATE(),                
    FOREIGN KEY (cardholder_id) REFERENCES cardholders(cardholder_id)
);


INSERT INTO cardholders (cardholder_id, full_name, phone_number, card_type, card_number, expiration_date, amount, pin) VALUES
(1, 'Mohamed Shiras', '0777777777', 'Visa', '1111111111111111', '2025-12-31',100000, 1234),
(2, 'Mohamed Zafri', '0744444444', 'MasterCard', '2222222222222222', '2026-11-30',150000, 1234);


select * from cardholders
select * from withdrawaltransactions
select * from DepositDetails


SELECT COUNT(1) FROM cardholders WHERE card_number = '11313'