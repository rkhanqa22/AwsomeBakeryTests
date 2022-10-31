Feature: GET Request Validation

@ResponseStatusValidation
Scenario Outline: Validate successfull status code
	When Client able to send request with <id> 
	Then successful <statusCode> is recieved
Examples:
	|  id   | statusCode				  |  
	|  1	| OK						  |
	|  2	| OK						  |
	|  3	| OK						  |
	|  4	| OK						  |
	|  5	| OK						  |
	|  6	| OK						  |
	|  7	| OK						  |
	|  8	| OK						  |
	|  9	| OK						  |
	|  10	| OK						  |
	|  11	| OK						  |
	|  12	| OK						  |
	|  13	| OK						  |
	|  14	| OK						  |
	|  15	| OK						  |
	|  16	| OK						  |
	|  17	| OK						  |
	|  18	| OK						  |
	|  19	| OK						  |
	|  20	| OK						  |
	|  21	| OK						  |
	|  22	| OK						  |
	|  23	| OK						  |
	|  24	| OK						  |
	|  25	| OK						  |
	|  26	| OK						  |
	|  27	| OK						  |
	|  28	| OK						  |
	|  29	| OK						  |
	|  30	| OK						  |
	|  21	| OK						  |
	|  22	| OK						  |
	|  23	| OK						  |
	|  24	| OK						  |
	|  25	| OK						  |
	|  26	| OK						  |
	|  27	| OK						  |
	|  28	| OK						  |
	|  29	| OK						  |
	|  30	| OK						  |
	|  31	| OK						  |
	|  32	| OK						  |
	|  33	| OK						  |
	|  34	| OK						  |
	|  35	| OK						  |
	|  36	| OK						  |
	|  37	| OK						  |
	|  38	| OK						  |
	|  39	| OK						  |
	|  40	| OK						  |
	|  41	| OK						  |
	|  42	| OK						  |
	|  43	| OK						  |
	|  44	| OK						  |
	|  45	| OK						  |
	|  46	| OK						  |
	|  47	| OK						  |
	|  48	| OK						  |
	|  49	| OK						  |
	|  50	| OK						  |
	|  1000	| InternalServerError		  |


@ResponseContentValidation
Scenario Outline: Validate response content from the client
	When Client able to send request with <id> 
	Then client with <id> and <clientEmail> and <price> and <cakeName> and <Id> and <Price> and <Quantity> has been validted
Examples:
	| id | clientEmail                      | price  | cakeName                      | Id    | Price | Quantity |
	| 1  | "Caleigh_Cruickshank1@gmail.com" | 99.00  | "Intelligent Frozen Fish"     |       |       |          |
	| 2  | "Harry8@yahoo.com"               | 605.00 | "Awesome Metal Computer"      |       |       |          |
	| 3  | "Ines_Miller@gmail.com"          | 72.00  | "Electronic Concrete Shoes"   |       |       |          |
	| 4  | "Mittie72@gmail.com"             | 536.00 | "Luxurious Fresh Keyboard"    |       |       |          |
	| 5  | "Caleigh_Cruickshank1@gmail.com" | 100.00 | "TEST CAKE"                   |       |       |          |
	| 6  | "Jett_Considine69@yahoo.com"     | 564.00 | "Luxurious Wooden Computer"   |       |       |          |
	| 7  | "Dayna.Swaniawski85@hotmail.com" | 364.00 | "Incredible Concrete Soap"    |       |       |          |
	| 8  | "Emelie23@yahoo.com"             | 4.00   | "Intelligent Bronze Table"    |       |       |          |
	| 9  | "Danika68@hotmail.com"           | 76.00  | "Rustic Wooden Keyboard"      |       |       |          |
	| 10 | "Ellie90@hotmail.com"            | 836.00 | "Modern Steel Table"          |       |       |          |
	| 11 | "Donavon.Upton@gmail.com"        | 163.00 | "Ergonomic Fresh Towels"      |       |       |          |
	| 12 | "Uriel50@gmail.com"              | 448.00 | "Handcrafted Fresh Shoes"     |       |       |          |
	| 13 | "Roderick.Bednar50@hotmail.com"  | 387.00 | "Practical Rubber Keyboard"   |       |       |          |
	| 14 | "Dedric_Berge@gmail.com"         | 831.00 | "Tasty Steel Fish"            |       |       |          |
	| 15 | "Jaida50@yahoo.com"              | 331.00 | "Elegant Cotton Chicken"      |       |       |          |
	| 16 | "Richard_Ward@yahoo.com"         | 100.00 | "Generic Metal Bacon"         |       |       |          |
	| 17 | "Julien66@hotmail.com"           | 279.00 | "Unbranded Concrete Bacon"    |       |       |          |
	| 18 | "Ashleigh.Kertzmann@yahoo.com"   | 407.00 | "Handcrafted Concrete Table"  |       |       |          |
	| 19 | "Jules42@hotmail.com"            | 913.00 | "Gorgeous Wooden Keyboard"    |       |       |          |
	| 20 | "Kenna_Kreiger99@yahoo.com"      | 395.00 | "Oriental Plastic Chicken"    |       |       |          |
	| 21 | "Keith62@yahoo.com"              | 961.00 | "Incredible Metal Computer"   |       |       |          |
	| 22 | "Zetta52@yahoo.com"              | 231.00 | "Practical Granite Pants"     |       |       |          |
	| 23 | "Bennie_Schuppe51@hotmail.com"   | 979.00 | "Oriental Plastic Chicken"    |       |       |          |
	| 24 | "Deonte.Bogisich@yahoo.com"      | 322.00 | "Electronic Metal Shoes"      |       |       |          |
	| 25 | "Amelie.Hauck29@gmail.com"       | 635.00 | "Awesome Wooden Bike"         |       |       |          |
	| 26 | "Beatrice_Runte@hotmail.com"     | 556.00 | "Gorgeous Fresh Hat"          |       |       |          |
	| 27 | "Delphine42@yahoo.com"           | 441.00 | "Unbranded Concrete Fish"     |       |       |          |
	| 28 | "Heath19@yahoo.com"              | 710.00 | "Ergonomic Metal Chair"       |       |       |          |
	| 29 | "Ayla.Kshlerin1@yahoo.com"       | 392.00 | "Small Steel Gloves"          |       |       |          |
	| 30 | "Kelly_Morar@yahoo.com"          | 861.00 | "Handcrafted Concrete Gloves" |       |       |          |
	| 31 | "Armani_Gleason@hotmail.com"     | 514.00 | "Modern Steel Shirt"          |       |       |          |
	| 32 | "Laila_Bayer@hotmail.com"        | 738.00 | "Bespoke Bronze Cheese"       |       |       |          |
	| 33 | "Camilla21@gmail.com"            | 357.00 | "Handcrafted Metal Mouse"     |       |       |          |
	| 34 | "Betsy.Jerde@yahoo.com"          | 568.00 | "Generic Fresh Tuna"          |       |       |          |
	| 35 | "Neoma57@hotmail.com"            | 341.00 | "Elegant Frozen Chair"        |       |       |          |
	| 36 | "Georgette12@hotmail.com"        | 292.00 | "Small Plastic Gloves"        |       |       |          |
	| 37 | "Kobe_Mraz63@gmail.com"          | 774.00 | "Awesome Plastic Chair"       |       |       |          |
	| 38 | "Bert_Murray48@gmail.com"        | 942.00 | "Modern Bronze Chair"         |       |       |          |
	| 39 | "Marie15@gmail.com"              | 973.00 | "Modern Granite Cheese"       |       |       |          |
	| 40 | "Jaquan.Krajcik@yahoo.com"       | 334.00 | "Elegant Soft Table"          |       |       |          |
	| 41 | "Arnold_Shanahan71@hotmail.com"  | 346.00 | "Oriental Cotton Ball"        |       |       |          |
	| 42 | "Noah_Gleason31@hotmail.com"     | 454.00 | "Luxurious Frozen Chips"      |       |       |          |
	| 43 | "Priscilla.Dibbert59@gmail.com"  | 395.00 | "Ergonomic Bronze Shoes"      |       |       |          |
	| 44 | "Marguerite0@hotmail.com"        | 149.00 | "Incredible Steel Chips"      |       |       |          |
	| 45 | "Athena1@hotmail.com"            | 787.00 | "Intelligent Concrete Soap"   |       |       |          |
	| 46 | "Brisa_Miller19@hotmail.com"     | 92.00  | "Awesome Wooden Car"          |       |       |          |
	| 47 | "Karli.Nader@hotmail.com"        | 684.00 | "Practical Bronze Shoes"      |       |       |          |
	| 48 | "Otto24@hotmail.com"             | 232.00 | "Fantastic Granite Bacon"     |       |       |          |
	| 49 | "Lillian_Bergnaum@yahoo.com"     | 892.00 | "Incredible Cotton Shoes"     |       |       |          |
	| 50 | "Rasheed.DAmore58@gmail.com"     | 360.00 | "Fantastic Granite Hat"       |       |       |          |
	| 51 | "Amari18@yahoo.com"              | 432.00 | "Generic Soft Bacon"          | 78912 | 18    | 1        |
