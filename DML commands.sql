select * from Client

-- Add new Clients by inserting new rows to the Client table
insert into Client values ('client1','queen','2020-02-02')
           
-- insert row without value for agreement date which can be null
insert into Client(Client_name,Contact_person) values ('client5','queen')
          
-- update contact person for client_id 2
update client set Contact_Person = 'Raja', Agreement_Date = '2020-06-05' where client_id = 2;

-- deleting rows from table
DELETE FROM Client WHERE client_id = 2; 