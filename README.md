# Stock Management System
This project is the Final Project for (Visual Programming 2) Subject ` 2021-05-21 `

# Table of Contents
* [Requirements](#requirements)
* [Technologies](#technologies)
* [Design Patterns](#design-patterns)
* [Features](#features)
* [Credentials](#credentials)
* [Notes](#notes)
* [Permissions](#permissions)
* [Team](#team)

# Requirements
1. Microsoft Vistal Studio
2. MySQL Driver

# Technologies
* C#

# Design Patterns
* Singleton (Database Connection)
* Command (Database Queries)
* Factory + Strategy (User Authentication)

# Features
* Use __MVC__ Design Pattern
* Authentication
    * Login
    * Logout
* User Management
    * Show All Users
    * Add New User (Includes specifying the Role)
    * Edit User
    * Delete User
    * Search
* Product Management
    * Show All Products
    * Add New Product (Quantity Not Involved Here)
    * Edit Product
    * Delete Product
    * Search
* Category Management
    * Show All Categories
    * Add New Category
    * Edit Category
    * Delete Category
    * Search
* Stock Management
    * Inert Quantities to Many Products
* Order Management
    * Show All Orders
    * Add New Order
    * Edit Order
    * Delete Order
    * Search
* Reports
    * Product Movement Report
    * Out of Stock
    * Top Selling
* Settings
    * User Can Edit his own Data

# Credentials
* Super Admin:
    * Username: super_admin
    * Password: secret
* Sales Employee:
    * Username: israa
    * Password: secret
* Warehouse Employee:
    * Username: jannat
    * Password: secret
    
# Notes
* There are 3 Types of User (Super Admin - Sales Employee - Warehouse Employee)
* There is Unit Testing (for Insert New Order)
* There are 5 DB Triggers
* Depending on User Role Some Features either be Enabled or Disabled

# Permissions
* Super Admin:
    * Can do Anything
* Sales Employee:
    * Show All Products
    * Order Management
* Warehouse Employee:
    * product Management
    * Stock Management
    * Category Management

# Team
Aya Kamal         © 2021 | bd58296@gmail.com

Aya Saher         © 2021 | aya.saheer@gmail.com

Israa Alsarwi     © 2021 | israa18ali99@gmail.com

Jannat Mgawshi    © 2021 | j.m.almgawshi@gmail.com

Khawla Alhode\iry © 2021 | khawla.alhodiry@gmail.com