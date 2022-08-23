create table check_creditt( 
                           CVC_code Number(3) not null,
                           card_pass Number (4)  not null,
                           card_Number NUMBER (16) PRIMARY KEY,
                           eXPIRATION_DATE DATE NOT null,
                           balance Number(5) NOT null, 
                           user_id Number (16) not null
                           );
                           
create table user_accountt (
                           user_id Number (16) primary key ,
                          user_Fname varchar2(8) NOT nuLL  ,
                          user_Lname varchar2(8) NOT nuLL,
                           user_Email varchar2(20) NOT null,
                           user_address varchar2(5) NOT null
                           );
create table offer(
offer_count number (5)

)  ;                         
      
                           
create table room(
                         R_ID  Number (2) PRIMARY KEY,
                         Cap varchar2(10) NOT null,
                        R_Type varchar2(10) NOT  NULL,
                        PR_Room Number(6) not null,
                         no_Floor NUMBER(3) NOT NULL
                        
                         
                         );                        
create table booking_rooms(
                         room_id  Number (2) primary key,
                         user_ID Number (16) not null
                         );
                         


create table availability (
R_ID  Number (2) not null,
strat_date date not null,
end_date date not null,
availableRoom varchar2(3) NOT null

); 

insert into offer values(10);
insert into offer values(100);
insert into offer values(1000);


insert into check_creditt values
(123,2000,1234567891234567,'30-Dec-2025',20000,1234123412341234);
insert into check_creditt values
(456,2001,2234567891234567,'15-Jun-2027',30000,5678567856785678);
insert into check_creditt values
(789,2002,3234567891234567,'10-Oct-2024',40000,7891789178917891);
insert into check_creditt values
(101,2003,4234567891234567,'12-Jul-2023',50000,1000100010001000);
insert into check_creditt values
(202,2004,5234567891234567,'20-Mar-2026',60000,2000200020002000);

Insert into user_accountt values
(1234123412341234,'Shimaa', 'Alaa','shimaa@gmail.com','cairo');
Insert into user_accountt values
(5678567856785678,'Eman', 'Moutaz','eman@gmail.com','cairo');
Insert into user_accountt values
(7891789178917891,'Alaa', 'Mohsen','alaa@gmail.com','cairo');
Insert into user_accountt values
(1000100010001000,'Mariam', 'Tarek','mariam@gmail.com','cairo');
Insert into user_accountt values
(2000200020002000,'Habiba', 'Youssef','habiba@gmail.com','cairo');

Insert into room values
(1,'single','VIP',20000,3);
Insert into room values
(7,'single','VIP',20000,3);
Insert into room values
(2,'Double','Normal',300000,4);
Insert into room values
(3,'single','Normal',15000,5);
Insert into room values
(4, 'Double','VIP',400000,6);
Insert into room values
(5, 'single','VIP',55000,7);


Insert into  booking_rooms values
(2,5678567856785678);
Insert into  booking_rooms values
(4,1000100010001000);




insert into availability values
(1,'05-Nov-2022','12-Nov-2022','yes' );
insert into availability values
(2,'15-Dec-2022','25-Dec-2022','no' );
insert into availability values
(3,'4-Jun-2022','9-Jun-2022','yes');
insert into availability values
(4,'18-May-2022','28-May-2022','no' );
insert into availability values
(5,'20-JUN-2022','30-JUN-2022','yes' );
commit;