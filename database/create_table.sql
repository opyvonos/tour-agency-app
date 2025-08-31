CREATE TABLE account (
    account_number      INTEGER NOT NULL,
    booking_booking_id  INTEGER NOT NULL,
    account_date        DATE,
    sum                 NUMBER(7, 2)
);

ALTER TABLE account ADD CONSTRAINT account_pk PRIMARY KEY ( account_number );

CREATE TABLE booking (
    booking_id               INTEGER NOT NULL,
    customer_cust_id         INTEGER NOT NULL,
    tour_manager_manager_id  INTEGER NOT NULL,
    tour_tour_id             INTEGER NOT NULL,
    booking_date             DATE,
    booking_status           NVARCHAR2(20)
);

ALTER TABLE booking ADD CONSTRAINT booking_pk PRIMARY KEY ( booking_id );

CREATE TABLE city (
    city_id             INTEGER NOT NULL,
    country_country_id  INTEGER NOT NULL,
    city_name           NVARCHAR2(20)
);

ALTER TABLE city ADD CONSTRAINT city_pk PRIMARY KEY ( city_id );

CREATE TABLE country (
    country_id    INTEGER NOT NULL,
    country_name  NVARCHAR2(20)
);

ALTER TABLE country ADD CONSTRAINT country_pk PRIMARY KEY ( country_id );

CREATE TABLE customer (
    cust_id          INTEGER NOT NULL,
    first_name       NVARCHAR2(20),
    last_name        NVARCHAR2(20),
    birthdate        DATE,
    passport_number  NVARCHAR2(20),
    address          NVARCHAR2(40),
    phone_number     NVARCHAR2(20)
);

ALTER TABLE customer ADD CONSTRAINT customer_pk PRIMARY KEY ( cust_id );

CREATE TABLE hotel (
    hotel_id      INTEGER NOT NULL,
    city_city_id  INTEGER NOT NULL,
    name          NVARCHAR2(20),
    address       NVARCHAR2(40),
    rooms_count   INTEGER
);

ALTER TABLE hotel ADD CONSTRAINT hotel_pk PRIMARY KEY ( hotel_id );

CREATE TABLE tour (
    tour_id                 INTEGER NOT NULL,
    tour_type_tour_type_id  INTEGER NOT NULL,
    transport_transport_id  INTEGER NOT NULL,
    hotel_hotel_id          INTEGER NOT NULL,
    number_of_days          INTEGER,
    price                   NUMBER(7, 2)
);

ALTER TABLE tour ADD CONSTRAINT tour_pk PRIMARY KEY ( tour_id );

CREATE TABLE tour_manager (
    manager_id    INTEGER NOT NULL,
    first_name    NVARCHAR2(20),
    last_name     NVARCHAR2(20),
    phone_number  NVARCHAR2(20),
    hire_date     DATE,
    salary        NUMBER(7, 2)
);

ALTER TABLE tour_manager ADD CONSTRAINT tour_manager_pk PRIMARY KEY ( manager_id );

CREATE TABLE tour_type (
    tour_type_id  INTEGER NOT NULL,
    type_name     NVARCHAR2(20)
);

ALTER TABLE tour_type ADD CONSTRAINT tour_type_pk PRIMARY KEY ( tour_type_id );

CREATE TABLE transport (
    transport_id    INTEGER NOT NULL,
    transport_type  NVARCHAR2(20)
);

ALTER TABLE transport ADD CONSTRAINT transport_pk PRIMARY KEY ( transport_id );

ALTER TABLE account
    ADD CONSTRAINT account_booking_fk FOREIGN KEY ( booking_booking_id )
        REFERENCES booking ( booking_id );

ALTER TABLE booking
    ADD CONSTRAINT booking_customer_fk FOREIGN KEY ( customer_cust_id )
        REFERENCES customer ( cust_id );

ALTER TABLE booking
    ADD CONSTRAINT booking_tour_fk FOREIGN KEY ( tour_tour_id )
        REFERENCES tour ( tour_id );

ALTER TABLE booking
    ADD CONSTRAINT booking_tour_manager_fk FOREIGN KEY ( tour_manager_manager_id )
        REFERENCES tour_manager ( manager_id );

ALTER TABLE city
    ADD CONSTRAINT city_country_fk FOREIGN KEY ( country_country_id )
        REFERENCES country ( country_id );

ALTER TABLE hotel
    ADD CONSTRAINT hotel_city_fk FOREIGN KEY ( city_city_id )
        REFERENCES city ( city_id );

ALTER TABLE tour
    ADD CONSTRAINT tour_hotel_fk FOREIGN KEY ( hotel_hotel_id )
        REFERENCES hotel ( hotel_id );

ALTER TABLE tour
    ADD CONSTRAINT tour_tour_type_fk FOREIGN KEY ( tour_type_tour_type_id )
        REFERENCES tour_type ( tour_type_id );

ALTER TABLE tour
    ADD CONSTRAINT tour_transport_fk FOREIGN KEY ( transport_transport_id )
        REFERENCES transport ( transport_id );