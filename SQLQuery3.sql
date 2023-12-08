SET identity_insert [dbo].[vendortable] ON
INSERT INTO [dbo].[vendortable] ([id], [vendor_id], [comapny_name], [company_website], [company_address], [software_name], [type_of_software], [insert_date], [update_date],
[delete_date])
VALUES
(1, 1, "ADDEPAR, INC.", "https://addepar.com/", "23 Bedford Square (1st Floor) London, WC1B 3HH", "ADDEPAR", "Wealth Managment", "nil", "nil", "nil"),
(2, 2, "Allvue", "https://www.allvuesystems.com/", "Becket House, 7th FLoor, 36 Old Jewry, London EC2R 8DD", "Allvue", "Alternative investment", "nil", "nil", "nil")
SET IDENTITY_INSERT [dbo].[vendortable] OFF