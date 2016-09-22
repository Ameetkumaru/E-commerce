	
	create table ProductTypes 
				(id integer(8) primary key AUTO_INCREMENT,
					name varchar(50)) ;
					
	
	create table Product
					(id integer(8) primary key AUTO_INCREMENT,
						typeId integer(8) ,
							name varchar(100) ,
								price int(8) ,
									description text ,
										image varchar(300) ,
											foreign key(typeId) references ProductTypes(id)) ;
											
	
	create table Cart
					(id integer(8) primary key AUTO_INCREMENT,
						ClientId varchar(50) NOT NULL ,
							ProductId integer(8) ,
								Amount integer(8) NOT NULL,
									DatePurchased datetime ,
									isInCart BIT NOT NULL,
										authID varchar(20),
											partName varchar(30) ,
												foreign key(ProductId) references ProductDB(id)) ;
											
											
											
	create table ProductDB
					(id integer(8) primary key,
						typeId integer(8) ,
							name varchar(100) ,
								qty integer(8) ,
									image varchar(300) ,
										foreign key(typeId) references ProductTypes(id)) ;
										
										
										
										
										
	create table user 
		(ClientId integer(8) primary key AUTO_INCREMENT,
			name varchar(20) ,
				username varchar(20) not null,
					password varchar(15) not null ,
						number integer(10),
							address varchar(99)) ;
											
											
											
	create table guest
		(id integer(1) primary key ,
			name varchar(25) not null ,
				shippingAddress varchar(99) not null) ;
				
				
	create table warehouse
		(orderId integer(8) Primary key AUTO_INCREMENT NOT NULL ,
			paymentID varchar(15),
				Name varchar(25),
					shippingAddress varchar(99) ,
						packagingStatus varchar(15) , 
							ShippingStatus varchar(15) ,
								DeliveryStatus varchar(15)) ;
				