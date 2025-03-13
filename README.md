#   Semerbak Bunga Hotel Information System

This project is from study cases of [LKS IT Software Solution Jawa Barat 2019](https://github.com/hafizcode02/bunga-hotel/blob/master/3.%20Soal%20Lengkap.pdf)

##   Project Overview

This project involves developing an information system for Semerbak Bunga Hotel in Puncak, Bogor. The system aims to address the hotel's management challenges, particularly during peak seasons, by providing a comprehensive solution for managing bookings, transactions, and other hotel operations.

##   Features

The system is structured into several modules, each with specific functionalities:

###   Module 1: Database Development, Data Insertion, and User Interface Design

* **Database Development:**
    * Creation of a database using MS SQL Server based on the provided ERD and Data Dictionary.
    * Table creation includes:
        * TipeKendaraan (Vehicle Type)
        * Penghuni (Resident)
        * Fasilitas (Facility)
        * TipeKamar (Room Type)
        * Kamar (Room)
        * TipeHari (Day Type)
        * HargaKamar (Room Price)
        * HargaFluktuatif (Fluctuating Price)
        * FasilitasBerdasarkanTipeKamar (Facilities by Room Type)
        * FasilitasTambahan (Additional Facility)
        * JenisPemesanan (Booking Type)
        * Karyawan (Employee)
        * Pemesanan (Booking)
        * Pembayaran (Payment)
        * PerbaikanKamar (Room Repair)
* **Data Insertion:**
    * Insertion of master data from "master-data.xlsx" into the respective database tables.
* **User Interface Design:**
    * Design of user interfaces for the Semerbak Bunga Hotel system based on the provided wireframes.
    * Form design includes:
        * Login Form
        * Main Form
        * Change Password Form
        * Booking Room Form
        * Manage Booking Form
        * View Payment Form
        * Input Payment Form
        * Manage Room Type Form
        * Manage Room Form
        * Manage Room Facility Form
        * Manage Room Repairment Form
        * Manage Daily Price Form
        * Manage Holiday Price Form
        * Manage Employee Form
        * Manage Guest Form

###   Module 2: Master Form Development

* **Login Form:**
    * Functionality to authenticate users using employee email and password.
    * Displaying an error message for invalid login credentials.
    * Redirecting successful logins to the Main Form and hiding the Login Form.
* **Main Form:**
    * Serves as the central hub of the application, housing all other forms.
    * Navigation menu for accessing various modules:
        * Change Password
        * Logout
        * Exit
        * Booking Room
        * Manage Booking
        * View Payment
        * Input Payment
        * Manage Room Type
        * Manage Room
        * Manage Room Facility
        * Manage Room Repairment
        * Manage Daily Price
        * Manage Holiday Price
        * Manage Employee
        * Manage Guest
* **Change Password Form:**
    * Verifies the old password against the database.
    * Updates the user's password upon successful verification.
* **Manage Guest Form:**
    * Loads guest data from the database.
    * Enables searching for guests by name, email, or phone number.
    * Adds new guest data to the database with validation.
    * Allows editing of existing guest information.
    * Deletes guest data from the database.
* **Manage Employee Form:**
    * Loads employee data from the database.
    * Enables searching for employees by name, email, or phone number.
    * Adds new employee data to the database with validation.
    * Allows editing of existing employee information.
    * Deletes employee data from the database.
* **Manage Room Type Form:**
    * Loads room type data from the database.
    * Enables searching for room types by name, description, or ID.
    * Adds new room type data to the database with validation.
    * Allows editing of existing room type information.
    * Deletes room type data from the database.
* **Manage Room Form:**
    * Loads room data from the database.
    * Enables searching for rooms by type name, description, or ID.
    * Adds new room data to the database with validation.
    * Allows editing of existing room information.
    * Deletes room data from the database.
* **Manage Room Facility Form:**
    * Loads room data with associated facility data from the database.
    * Enables searching for room facilities by room number, facility name, facility ID, or room ID.
    * Adds new room facility data to the database with validation.
    * Allows editing of existing room facility information.
    * Deletes room facility data from the database.
* **Manage Room Repairment Form:**
    * Loads room data with associated room repairment data from the database.
    * Enables searching for room repairments by room type name, floor, room number, or room type ID.
    * Adds new room repairment data to the database with validation.
    * Allows editing of existing room repairment information.
    * Deletes room repairment data from the database.

###   Module 3: Transaction Form Development

* **Manage Daily Price Form:**
    * Validates that all fields are filled.
    * Loads room type data and day type data from the database.
    * Enables searching for daily prices by room ID, floor, room number, or room type name.
    * Adds new daily price data to the database with validation.
    * Allows editing of existing daily price information.
    * Deletes daily price data from the database.
* **Manage Holiday Price Form:**
    * Validates that all fields are filled.
    * Loads room type data from the database.
    * Enables searching for holiday prices by room ID, floor, room number, or room type name.
    * Adds new holiday price data to the database with validation.
    * Allows editing of existing holiday price information.
    * Deletes holiday price data from the database.
* **Booking Room Form:**
    * Validates that all fields are filled.
    * Loads room type data, booking type data, and room availability data.
    * Provides a link to add a new guest and stores the new guest's data.
    * Refreshes guest data.
    * Adds additional facility data to a data grid.
    * Loads data into combo boxes.
    * Performs calculations.
    * Stores data with the correct process when the submit button is clicked.
    * Creates a design to load room availability data.
    * Inserts data into the database.
* **Manage Booking Form:**
    * Loads booking data and related data from the database.
    * Allows changing the booking status to "cancel" and updates the database.
* **Input Payment Form:**
    * Validates that all fields are filled.
    * Inserts payment data into the database.
* **View Payment Form:**
    * Enables searching for payments by payment date, payment ID, booking ID, guest name, room number, or employee name.
    * Loads all payment data in the correct format upon initial load.

###   Module 4: Report

* **Transaction Report:**
    * Loads room type data into a combo box.
    * Generates a report based on the selected room type.
    * Displays all transaction data (base and fluctuating prices) if "ALL" room type is selected.
    * Displays data for a specific room type if one is selected.
* **Room Availability Report:**
    * Loads room type data into a checkbox format.
    * Allows selection of a begin month and duration (3, 6, 9, or 12 months).
    * Generates a report based on selected room types.
    * Displays the average room availability for each month based on room type.
    * Calculates the average using a specific formula.
