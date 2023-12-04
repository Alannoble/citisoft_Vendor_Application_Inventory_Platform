create table vendortable
(
  id int primary key identity(1,1),
  vendor_id varchar(max) null,
  company_name varchar(max) null,
  company_website varchar (max) null,
  company_address varchar (max) null,
  software_name varchar(max) null,
  type_of_software varchar(max) null,
  insert_date date null,
  update_date date null,
  delete_date date null


  )
  
  select * from vendortable

  delete from vendortable