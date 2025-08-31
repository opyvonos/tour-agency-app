INSERT INTO customer(cust_id, first_name, last_name, birthdate, passport_number, address, phone_number)
VALUES(1, 'Bella', 'Anderson', to_date('24.05.1992', 'DD.MM.YYYY'), 'P28043715', 'New York, USA', '2103942765');

INSERT INTO customer(cust_id, first_name, last_name, birthdate, passport_number, address, phone_number)
VALUES(2, 'Karen', 'Page', to_date('13.01.1989', 'DD.MM.YYYY'), '149912377', 'Kadiz, Spain', '619803270');

INSERT INTO customer(cust_id, first_name, last_name, birthdate, passport_number, address, phone_number)
VALUES(3, 'Peter', 'Collins', to_date('03.11.1983', 'DD.MM.YYYY'), '830021614', 'Verne, Belgium', '472461907');

INSERT INTO customer(cust_id, first_name, last_name, birthdate, passport_number, address, phone_number)
VALUES(4, 'John', 'Alves', to_date('05.05.2001', 'DD.MM.YYYY'), 'E47883902', 'Jacksonville, USA', '3129475803');

INSERT INTO customer(cust_id, first_name, last_name, birthdate, passport_number, address, phone_number)
VALUES(5, 'Thomas', 'Cooper', to_date('17.06.1993', 'DD.MM.YYYY'), '425570309', 'Cologne, Germany', '15167385901');

INSERT INTO customer(cust_id, first_name, last_name, birthdate, passport_number, address, phone_number)
VALUES(6, 'Daisy', 'Carter', to_date('08.09.1995', 'DD.MM.YYYY'), '787456329', 'Ravenna, Italy', '3295820912');

INSERT INTO customer(cust_id, first_name, last_name, birthdate, passport_number, address, phone_number)
VALUES(7, 'Charlie', 'Mason', to_date('31.12.1999', 'DD.MM.YYYY'), '225499753', 'London, England', '7405884291');

INSERT INTO customer(cust_id, first_name, last_name, birthdate, passport_number, address, phone_number)
VALUES(8, 'Edward', 'Williams', to_date('27.08.1968', 'DD.MM.YYYY'), '152934164', 'Cordoba, Spain', '629701297');


INSERT INTO tour_manager(manager_id, first_name, last_name, phone_number, hire_date, salary)
VALUES(201, 'Ashley', 'Baker', '8907131097', to_date('17.11.2015', 'DD.MM.YYYY'), 1600);

INSERT INTO tour_manager(manager_id, first_name, last_name, phone_number, hire_date, salary)
VALUES(202, 'Sophia', 'Jones', '9231815608', to_date('04.01.2013', 'DD.MM.YYYY'), 2300);

INSERT INTO tour_manager(manager_id, first_name, last_name, phone_number, hire_date, salary)
VALUES(203, 'James', 'Hayes', '1779001033', to_date('31.05.2019', 'DD.MM.YYYY'), 950);

INSERT INTO tour_manager(manager_id, first_name, last_name, phone_number, hire_date, salary)
VALUES(204, 'Emma', 'Harrison', '2054341795', to_date('24.08.2021', 'DD.MM.YYYY'), 750);

INSERT INTO tour_manager(manager_id, first_name, last_name, phone_number, hire_date, salary)
VALUES(205, 'Ben', 'Lewis', '7051361866', to_date('10.12.2017', 'DD.MM.YYYY'), 1200);


INSERT INTO tour_type(tour_type_id, type_name)
VALUES(1, 'Sightseeing');
INSERT INTO tour_type(tour_type_id, type_name)
VALUES(2, 'Beach');

INSERT INTO tour_type(tour_type_id, type_name)
VALUES(3, 'Cruise');

INSERT INTO tour_type(tour_type_id, type_name)
VALUES(4, 'Hiking');

INSERT INTO tour_type(tour_type_id, type_name)
VALUES(5, 'Cultural');


INSERT INTO transport(transport_id, transport_type)
VALUES(1, 'Airplane');

INSERT INTO transport(transport_id, transport_type)
VALUES(2, 'Bus');

INSERT INTO transport(transport_id, transport_type)
VALUES(3, 'Train');

INSERT INTO transport(transport_id, transport_type)
VALUES(4, 'Cruise ship');


INSERT INTO country(country_id, country_name)
VALUES(792, 'Turkey');

INSERT INTO country(country_id, country_name)
VALUES(620, 'Portugal');

INSERT INTO country(country_id, country_name)
VALUES(250, 'France');

INSERT INTO country(country_id, country_name)
VALUES(380, 'Italy');

INSERT INTO country(country_id, country_name)
VALUES(300, 'Greece');

INSERT INTO country(country_id, country_name)
VALUES(756, 'Switzerland');


INSERT INTO city(city_id, country_country_id, city_name)
VALUES(101, 380, 'Rome');

INSERT INTO city(city_id, country_country_id, city_name)
VALUES(102, 792, 'Istanbul');

INSERT INTO city(city_id, country_country_id, city_name)
VALUES(103, 792, 'Antalya');

INSERT INTO city(city_id, country_country_id, city_name)
VALUES(104, 250, 'Paris');

INSERT INTO city(city_id, country_country_id, city_name)
VALUES(105, 250, 'Cote dAzur');

INSERT INTO city(city_id, country_country_id, city_name)
VALUES(106, 620, 'Lisbon');
INSERT INTO city(city_id, country_country_id, city_name)
VALUES(107, 300, 'Chania');

INSERT INTO city(city_id, country_country_id, city_name)
VALUES(108, 756, 'Interlaken');


INSERT INTO hotel(hotel_id, city_city_id, name, address, rooms_count)
VALUES(25, 101, 'The Inn At The Spanish Steps', 'Via dei Condotti, 85, 00187', 25);

INSERT INTO hotel(hotel_id, city_city_id, name, address, rooms_count)
VALUES(30, 101, 'River Palace Hotel', 'Via Flaminia, 33, 00196', 72);

INSERT INTO hotel(hotel_id, city_city_id, name, address, rooms_count)
VALUES(35, 101, 'Hotel Villa Pinciana', 'Via Abruzzi, 11, 00187', 25);

INSERT INTO hotel(hotel_id, city_city_id, name, address, rooms_count)
VALUES(40, 102, 'Wish More Hotel', 'Kocatepe, Cicoz Yolu Cd. No:207, 34045', 198);

INSERT INTO hotel(hotel_id, city_city_id, name, address, rooms_count)
VALUES(45, 103, 'City Live Hotel', 'Fener Mah. Falez Cd. No:3, 07160', 59);

INSERT INTO hotel(hotel_id, city_city_id, name, address, rooms_count)
VALUES(50, 104, 'Hotel Saint-Marc', '36 rue Saint-Marc, 75002', 26);

INSERT INTO hotel(hotel_id, city_city_id, name, address, rooms_count)
VALUES(55, 104, 'Plug-Inn Hotel', '7 rue Aristide Bruant, 75018', 30);

INSERT INTO hotel(hotel_id, city_city_id, name, address, rooms_count)
VALUES(60, 105, 'OKKO Hotels Toulon Center', '20 rue Peiresc, 83000', 98);

INSERT INTO hotel(hotel_id, city_city_id, name, address, rooms_count)
VALUES(65, 105, 'La Reine Jane', '1 Quai des Cormorans, 83400', 14);

INSERT INTO hotel(hotel_id, city_city_id, name, address, rooms_count)
VALUES(70, 108, 'Hotel Interlaken', 'Hoheweg 74, 38000', 67);

INSERT INTO hotel(hotel_id, city_city_id, name, address, rooms_count)
VALUES(75, 107, 'Civitel Akali Hotel', 'Par. 5i Kissamou 55, 731 31', 70);

INSERT INTO hotel(hotel_id, city_city_id, name, address, rooms_count)
VALUES(80, 107, 'Santa Apolonia', NULL, 40);


INSERT INTO tour(tour_id, tour_type_tour_type_id, transport_transport_id, hotel_hotel_id, number_of_days, price)
VALUES(1, 1, 1, 40, 7, 1950);

INSERT INTO tour(tour_id, tour_type_tour_type_id, transport_transport_id, hotel_hotel_id, number_of_days, price)
VALUES(2, 5, 2, 40, 3, 845);

INSERT INTO tour(tour_id, tour_type_tour_type_id, transport_transport_id, hotel_hotel_id, number_of_days, price)
VALUES(3, 2, 1, 60, 14, 2500);

INSERT INTO tour(tour_id, tour_type_tour_type_id, transport_transport_id, hotel_hotel_id, number_of_days, price)
VALUES(4, 2, 1, 45, 7, 1100);

INSERT INTO tour(tour_id, tour_type_tour_type_id, transport_transport_id, hotel_hotel_id, number_of_days, price)
VALUES(5, 5, 2, 30, 10, 1700);

INSERT INTO tour(tour_id, tour_type_tour_type_id, transport_transport_id, hotel_hotel_id, number_of_days, price)
VALUES(6, 4, 1, 70, 5, 1800);

INSERT INTO tour(tour_id, tour_type_tour_type_id, transport_transport_id, hotel_hotel_id, number_of_days, price)
VALUES(7, 1, 1, 50, 10, 2900);

INSERT INTO tour(tour_id, tour_type_tour_type_id, transport_transport_id, hotel_hotel_id, number_of_days, price)
VALUES(8, 1, 1, 40, 12, 1950);

INSERT INTO tour(tour_id, tour_type_tour_type_id, transport_transport_id, hotel_hotel_id, number_of_days, price)
VALUES(9, 3, 4, 80, 12, 3800);

INSERT INTO tour(tour_id, tour_type_tour_type_id, transport_transport_id, hotel_hotel_id, number_of_days, price)
VALUES(10, 3, 4, 80, 3, 1400);

INSERT INTO tour(tour_id, tour_type_tour_type_id, transport_transport_id, hotel_hotel_id, number_of_days, price)
VALUES(11, 1, 1, 75, 7, 1300);

INSERT INTO tour(tour_id, tour_type_tour_type_id, transport_transport_id, hotel_hotel_id, number_of_days, price)
VALUES(12, 5, 1, 55, 5, 1300);

INSERT INTO tour(tour_id, tour_type_tour_type_id, transport_transport_id, hotel_hotel_id, number_of_days, price)
VALUES(13, 1, 1, 25, 7, 1900);


INSERT INTO booking(booking_id, customer_cust_id, tour_manager_manager_id, tour_tour_id, additional_services, booking_date, booking_status)
VALUES(1, 1, 202, 12, 'Y', to_date('18.05.2019', 'DD.MM.YYYY'), 'Completed');

INSERT INTO booking(booking_id, customer_cust_id, tour_manager_manager_id, tour_tour_id, additional_services, booking_date, booking_status)
VALUES(2, 8, 202, 2, 'N', to_date('24.08.2019', 'DD.MM.YYYY'), 'Completed');

INSERT INTO booking(booking_id, customer_cust_id, tour_manager_manager_id, tour_tour_id, additional_services, booking_date, booking_status)
VALUES(3, 5, 205, 9, 'Y', to_date('03.09.2019', 'DD.MM.YYYY'), 'Completed');

INSERT INTO booking(booking_id, customer_cust_id, tour_manager_manager_id, tour_tour_id, additional_services, booking_date, booking_status)
VALUES(4, 2, 203, 5, 'N', to_date('16.01.2020', 'DD.MM.YYYY'), 'Rejected');

INSERT INTO booking(booking_id, customer_cust_id, tour_manager_manager_id, tour_tour_id, additional_services, booking_date, booking_status)
VALUES(5, 6, 202, 10, 'N', to_date('08.04.2020', 'DD.MM.YYYY'), 'Completed');

INSERT INTO booking(booking_id, customer_cust_id, tour_manager_manager_id, tour_tour_id, additional_services, booking_date, booking_status)
VALUES(6, 3, 201, 8, 'N', to_date('20.02.2021', 'DD.MM.YYYY'), 'Cancelled');

INSERT INTO booking(booking_id, customer_cust_id, tour_manager_manager_id, tour_tour_id, additional_services, booking_date, booking_status)
VALUES(7, 2, 205, 6, 'N', to_date('11.08.2021', 'DD.MM.YYYY'), 'Completed');
INSERT INTO booking(booking_id, customer_cust_id, tour_manager_manager_id, tour_tour_id, additional_services, booking_date, booking_status)
VALUES(8, 7, 204, 11, 'Y', to_date('21.10.2021', 'DD.MM.YYYY'), 'Completed');

INSERT INTO booking(booking_id, customer_cust_id, tour_manager_manager_id, tour_tour_id, additional_services, booking_date, booking_status)
VALUES(9, 4, 201, 4, 'Y', to_date('03.07.2022', 'DD.MM.YYYY'), 'Cancelled');

INSERT INTO booking(booking_id, customer_cust_id, tour_manager_manager_id, tour_tour_id, additional_services, booking_date, booking_status)
VALUES(10, 5, 203, 3, 'N', to_date('13.08.2022', 'DD.MM.YYYY'), 'Completed');


INSERT INTO account(account_number, booking_booking_id, account_date, sum)
VALUES(1001, 1, to_date('24.05.2019', 'DD.MM.YYYY'), 1450);

INSERT INTO account(account_number, booking_booking_id, account_date, sum)
VALUES(1002, 2, to_date('27.08.2019', 'DD.MM.YYYY'), 845);

INSERT INTO account(account_number, booking_booking_id, account_date, sum)
VALUES(1003, 3, to_date('11.09.2019', 'DD.MM.YYYY'), 4200);

INSERT INTO account(account_number, booking_booking_id, account_date, sum)
VALUES(1004, 5, to_date('18.04.2020', 'DD.MM.YYYY'), 1400);

INSERT INTO account(account_number, booking_booking_id, account_date, sum)
VALUES(1005, 7, to_date('15.08.2021', 'DD.MM.YYYY'), 1800);

INSERT INTO account(account_number, booking_booking_id, account_date, sum)
VALUES(1006, 8, to_date('31.10.2021', 'DD.MM.YYYY'), 1520);

INSERT INTO account(account_number, booking_booking_id, account_date, sum)
VALUES(1007, 10, to_date('19.08.2022', 'DD.MM.YYYY'), 1800);