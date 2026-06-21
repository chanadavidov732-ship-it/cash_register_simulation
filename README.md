# Retail Management System

A layered retail management system developed in C# and .NET, designed to manage products, customers, sales, and purchase orders while demonstrating software architecture principles and design patterns.

## Overview

This project simulates a retail store management system and provides functionality for:

- Product management
- Customer management
- Sales and promotions management
- Order creation and processing
- Inventory updates
- Data persistence through DAL implementations

The system was developed using a multi-layered architecture and follows object-oriented programming principles.

---

## Screenshots

### Shopping Cart
![Shopping Cart](Images/cart.png)

### Product Management
![Product Management](Images/products.png)

### Customer Management
![Customer Management](Images/customers.png)

---

## Architecture

The project is built using a layered architecture:

```text
Presentation Layer (PL / Console Tests)
            │
            ▼
Business Layer (BL)
            │
            ▼
Data Access Layer (DAL)
```

### DAL Components

#### DalFacade
Contains:

- Entity definitions (DO)
- DAL interfaces
- Generic CRUD contracts
- Custom exceptions
- Factory implementation

#### DalList
In-memory data source implementation using Lists.

#### DalXml
XML-based data persistence implementation.

#### DalTest
Console application for testing DAL functionality.

### BL Components

#### BO
Business entities used by the application.

#### BlApi
Business layer interfaces.

#### BlImplementation
Business logic implementation.

#### BlTest
Manual testing application for BL operations.

---

## Features

### Customer Management

- Create customer
- Update customer
- Delete customer
- Retrieve customer information

### Product Management

- Add products
- Update inventory
- Delete products
- Retrieve product details

### Sales Management

- Create promotions
- Update promotions
- Delete promotions
- Retrieve active promotions

### Order Processing

- Add products to an order
- Apply available promotions
- Calculate product price
- Calculate order total
- Update inventory after purchase

---

## Technologies

- C#
- .NET
- LINQ
- XML Serialization
- Object-Oriented Programming (OOP)
- Generic Programming
- Reflection
- Layered Architecture

---

## Design Patterns

The project demonstrates the use of several software design patterns:

### Singleton

Used for DAL implementations to ensure a single data access instance.

### Factory

Used to create DAL and BL implementations without exposing concrete classes.

### Three-Layer Architecture

Separation of:

- Presentation Layer
- Business Layer
- Data Access Layer

---

## CRUD Operations

Each entity supports:

- Create
- Read
- Read All
- Update
- Delete

Implemented through a generic CRUD interface.

---

## Exception Handling

Custom exceptions are used across the application for:

- Duplicate identifiers
- Missing entities
- Invalid operations
- Configuration errors

---

## Data Storage Options

The system supports multiple data sources:

### List-Based Storage

- Fast in-memory access
- Suitable for testing

### XML Storage

- Persistent storage
- Serialization support
- Configurable through Factory pattern

---

## Project Structure

```text
RetailManagementSystem
│
├── DalFacade
│   ├── DO
│   └── DalApi
│
├── DalList
│
├── DalXml
│
├── DalTest
│
├── BL
│   ├── BO
│   ├── BlApi
│   └── BlImplementation
│
└── BlTest
```

---

## Key Concepts Demonstrated

- Layered Architecture
- Generic Interfaces
- LINQ Queries
- XML Serialization
- Reflection
- Dependency Abstraction
- Factory Pattern
- Singleton Pattern
- Exception Handling
- OOP Principles

---

## Learning Outcomes

This project demonstrates practical experience with:

- Full software architecture design
- Data access abstraction
- Business logic implementation
- Generic programming
- Design patterns
- Data persistence
- Clean code principles
- Enterprise-level project structure

---

## Author

**Chana Davidov**

Software Engineering Graduate  
Full-Stack Development | .NET | C# | Databases | APIs