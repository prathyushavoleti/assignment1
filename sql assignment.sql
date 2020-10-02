create table categories(
id int not null primary key identity(1,1),
category_name varchar(64),
tax decimal
)
insert into categories values('category5',25000)
select *from categories


create table product(
id int not null primary key identity(1,1),
product_name varchar(64),
open_stock decimal ,
cur_stock decimal,
sal_price decimal,
category int not null foreign key references categories(id)
)
insert into product values('product5',340.00,240.00,10000,5)
select *from product

create table customers(
id int not null primary key identity(1,1),
customer_name varchar(32),
mobile varchar(15),
open_bal decimal not null default '0',
is_active Bit default '1'
)
insert into customers values('harika',14361,32000,0)

select*from customers

create table saleshead(
sale_inv_no int not null primary key identity(1,1),
sale_date date not null,
customer int not null foreign key references customers(id),
card_type char 
)
insert into saleshead values('2020-06-23',5,'C')

select*from saleshead

create table salesdetail(
sale_inv_no int not null foreign key references saleshead(sale_inv_no),
product_id int not null foreign key references product(id),
qty decimal not null,
rate decimal not null
)
insert into salesdetail values(6,5,12,19000)

select*from salesdetail

select product_name,category_name,cur_stock from product as p, categories as c where p.id=c.id --query to select product name,category name and current stock--
select * from customers where is_active= 1--query2
select customer,customer_name,open_bal from customers as c,saleshead as s where c.id=s.customer--query3
select sum(qty) as sum1 from salesdetail as sd,saleshead as s where sale_date='2020-06-23' and s.sale_inv_no=sd.sale_inv_no---query4
select product_name from Product p inner join SalesDetail sd on p.id=sd.product_id where sd.qty=(select max(qty) from SalesDetail)
select product_name from Product p inner join SalesDetail sd on p.id=sd.product_id where sd.qty=(select min(qty) from SalesDetail)


