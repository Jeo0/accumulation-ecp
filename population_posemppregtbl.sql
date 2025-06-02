
use POSDB;
select * from INFORMATION_SCHEMA.tables;

-- population of the pos_empRegTbl
insert into pos_empRegTbl (
empReg_id, -- int IDENTITY(1,1),
emp_id, -- varchar(20) PRIMARY KEY,
emp_fname, -- varchar(100),
emp_mname, -- varchar(50),
emp_surname, -- varchar(100),

emp_age, -- int,
emp_gender, -- varchar(30),

emp_sss_no, -- int,
emp_tin_no, -- int,
emp_philhealth_no, -- int,
emp_pagibig_no, -- int,
emp_status, -- varchar(50),

emp_height, -- varchar(50),
emp_weight, -- varchar(50),

add_yrs_stay, -- int,
add_house_no, -- int,
add_sub_name, -- text,
add_phase_no, -- int,
add_street, -- varchar(100),
add_barangay, -- varchar(100),
add_municipality, -- varchar(100),
add_city, -- varchar(100),
add_state_province, -- varchar(100),
add_country, -- varchar(100), 
add_zipcode, -- int,

elem_name, -- text,
elem_address, -- text,

elem_yr_grad, -- varchar(50),
lem_award, -- varchar(50),

junior_high_name, -- text,
junior_high_address, -- text,
junior_high_yr_grad, -- varchar(50),
junior_high_award, -- varchar(50),

senior_high_name, -- text,
senior_high_address, -- text,
senior_high_yr_grad, -- varchar(50),
senior_high_award, -- varchar(50),
track, -- varchar(50),

college_school_name, -- text, 
college_address, -- text,
college_yr_grad, -- varchar(50),
college_award, -- varchar(50),
college_course, -- varchar(100),
others, -- text,

position, -- varchar(50),
emp_work_status, -- varchar(50),
emp_date_hired, -- varchar(100),
emp_department, -- varchar(50),

emp_no_of_dependents, -- int, 
picpath -- text
)

values (
    '1',
    '123',
    'ako',
    'ay',
    'pogi',

    12,
    'male',

    123123,
    345345,
    12341234,
    435345,
    'whaaat independent',

    '170',
    '64',

    5,
    23,
    'sunnyboroke',
    3,
    'streeeet',
    'gay',
    'gay manulicipal',
    'city of gay',
    'probinsya',
    'worst',
    123,

    'ipsa',
    'saudi',

    '2018',
    'wala',

    'lpu',
    'manggahan',
    '2020',
    'wala',
    'stim',

    'lpu',
    'manggahan',
    '2026',
    'wala',
    'bscpue',
    'awalang other',

    'student posititoin',
    'employed',
    '2020',
    'coecsa',

    4,
    'C:\Users\wherever.png'
)
