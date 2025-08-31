CREATE VIEW CUST_VU (ID, CUSTOMER, PASSPORT, PHONE) AS SELECT cust_id, first_name || ' ' || last_name, passport_number, phone_number FROM CUSTOMER;

CREATE VIEW BOOKING_VU (ID, CUSTOMER, MANAGER, TOUR, BOOKING_DATE, STATUS) AS SELECT b.booking_id, c.first_name || ' ' || c.last_name, m.first_name || ' ' || m.last_name, b.tour_tour_id, b.booking_date, b.booking_status FROM BOOKING b, CUSTOMER c, TOUR_MANAGER m WHERE b.customer_cust_id = c.cust_id AND b.tour_manager_manager_id = m.manager_id;

CREATE VIEW CITY_VU (ID, CITY, COUNTRY) AS SELECT t.city_id, t.city_name, d.country_name FROM CITY t, COUNTRY d WHERE t.country_country_id = d.country_id;

CREATE VIEW ACCOUNT_VU (ID, CUSTOMER, TOUR, ACCOUNT_DATE, SUM) AS SELECT a.account_number, c.first_name || ' ' || c.last_name, b.tour_tour_id, a.account_date, a.sum FROM ACCOUNT a, BOOKING b, CUSTOMER c WHERE a.booking_booking_id = b.booking_id AND b.customer_cust_id = c.cust_id;

CREATE VIEW MANAGER_VU (ID, MANAGER, PHONE) AS SELECT manager_id, first_name || ' ' || last_name, phone_number FROM TOUR_MANAGER;

CREATE VIEW TOUR_VU (ID, TYPE, DURATION, CITY, COUNTRY, PRICE) AS SELECT t.tour_id, d.type_name, t.number_of_days, c.city_name, n.country_name, t.price FROM TOUR t, TOUR_TYPE d, HOTEL h, CITY c, COUNTRY n WHERE t.tour_type_tour_type_id = d.tour_type_id AND t.hotel_hotel_id = h.hotel_id AND h.city_city_id = c.city_id AND c.country_country_id = n.country_id;

CREATE VIEW HOTEL_VU (ID, NAME, CITY, COUNTRY, ROOMS) AS SELECT h.hotel_id, h.name, t.city_name, d.country_name, h.rooms_count FROM HOTEL h, CITY t, COUNTRY d WHERE h.city_city_id = t.city_id AND t.country_country_id = d.country_id;