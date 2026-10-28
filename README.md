# Cash Register Simulation – Retail Management System

A desktop retail management and point-of-sale (POS) system built with **C# / .NET 8** and **Windows Forms**.
It manages customers, products and promotions, runs a cashier checkout flow with automatic promotion pricing, and updates inventory when an order is placed.

The solution follows a strict **three-layer architecture** (UI → Business Logic → Data Access). The storage engine, in-memory lists or XML files, can be switched through a configuration file without changing any code.

---

## Table of Contents

- [Screenshots](#screenshots)
- [Features](#features)
- [Architecture](#architecture)
- [Solution Structure](#solution-structure)
- [Domain Model](#domain-model)
- [Order Pricing Algorithm](#order-pricing-algorithm)
- [Data Access Layer](#data-access-layer)
- [Error Handling](#error-handling)
- [Getting Started](#getting-started)
- [Configuration](#configuration)
- [Technologies & Concepts](#technologies--concepts)
- [Known Limitations](#known-limitations)
- [Author](#author)

---

## Screenshots

### Cashier – Shopping Cart
![Shopping Cart](prject-c%23/Images/cart.png)

### Manager – Product Management
![Product Management](prject-c%23/Images/products.png)

### Manager – Customer Management
![Customer Management](prject-c%23/Images/customers.png)

> The user interface is in Hebrew (right-to-left).

---

## Features

### Main Screen
The application opens on a home screen with two roles:

| Role | Description |
|------|-------------|
| **Manager** (מנהל) | Manages customers, products and promotions |
| **Cashier** (קופאי) | Builds a shopping cart and completes customer orders |

### Manager – Data Management
A single management screen with three sections. Each one has a data grid and an input form:

- **Customers**: add, update and delete customers (ID, full name, address, phone). The join date is set automatically.
- **Products**: add, update and delete products (name, category, quantity in stock, unit price). Product IDs are generated automatically.
- **Promotions (Sales)**: add, update and delete promotions for a product, for example *"3 units for ₪600"*, with a start date, an end date, and a club-members-only option.

Usability details:
- Selecting a row in a grid fills in the form fields automatically.
- Input is validated: numeric fields, a category must be selected, and the end date must come after the start date.
- Every delete asks for confirmation.
- Errors are shown in clear message boxes.

### Cashier – Checkout
- **Customer check**: enter a customer ID (button or Enter key). If the customer exists, they are treated as a **club member** and member-only promotions apply.
- **Add product**: pick a product from a product-selection dialog (double-click a row). Each click adds one unit.
- **Remove product**: lowers the quantity of the selected line by one. The line is removed when it reaches zero.
- **Live pricing**: the cart grid shows each product, its quantity, the promotions applied, and the final line price. The total updates after every change.
- **Stock validation**: you cannot add more units than are in stock.
- **Place order**: subtracts the ordered quantities from inventory and resets the cart.

---

## Architecture

```text
┌─────────────────────────────────────────────┐
│  Presentation Layer – UI (WinForms)          │
│  Index · SubMenu · CashierForm · ProductSel. │
└──────────────────────┬──────────────────────┘
                       │  BlApi.Factory.Get()
                       ▼
┌─────────────────────────────────────────────┐
│  Business Logic Layer – BL                   │
│  BO (business objects) · BlApi · BlImpl.     │
│  Order pricing, promotions, inventory update │
└──────────────────────┬──────────────────────┘
                       │  DalApi.Factory.Get   (reflection + dal-config.xml)
                       ▼
┌─────────────────────────────────────────────┐
│  Data Access Layer – DalFacade (contracts)   │
│        ┌───────────────┬───────────────┐     │
│        ▼               ▼               │     │
│     DalList         DalXml             │     │
│   (in-memory)    (XML files)           │     │
└─────────────────────────────────────────────┘
```

**Key principles**
- Each layer talks only to the **interfaces** of the layer below it. Concrete classes are `internal`.
- The BL works with its own **Business Objects (BO)** and converts them to and from **Data Objects (DO)** using extension methods in `BO/Tools.cs`.
- The DAL implementation is chosen **at runtime** with reflection, based on `xml/dal-config.xml`.

---

## Solution Structure

Solution file: `prject-c#/DotNet2025_6798_4298.sln`

```text
prject-c#/
├── Dalfacade/                 DAL contracts (no implementation)
│   ├── DO/                    Data Objects – immutable records
│   │   ├── Customer.cs
│   │   ├── Product.cs
│   │   ├── Sale.cs
│   │   ├── Enums.cs           Category: WOMAN, MAN, CHILDREN, BABY
│   │   └── Exceptions.cs
│   └── DalApi/
│       ├── ICrud.cs           Generic CRUD interface ICrud<T>
│       ├── ICustomer.cs / IProduct.cs / ISale.cs
│       ├── IDal.cs            Entry point: Customer, Product, Sale
│       ├── Config.cs          Reads dal-config.xml
│       └── Factory.cs         Loads the configured DAL via reflection
│
├── DalList/                   In-memory DAL (List<T>)
│   ├── DataSource.cs          Static lists + running ID generators
│   ├── DalList.cs             Singleton implementing IDal
│   └── *Implementation.cs     CRUD per entity (LINQ)
│
├── DalXml/                    Persistent DAL (XML serialization)
│   ├── Config.cs              Running IDs stored in data-config.xml
│   ├── DalXml.cs              Singleton implementing IDal
│   └── *Implementation.cs     Load → modify → save per operation
│
├── DalTest/                   Console tester for the DAL + seed data
│   ├── Initialization.cs      Creates sample customers, products, sales
│   └── Program (1).cs         Interactive CRUD menu
│
├── BL/                        Business Logic Layer
│   ├── BO/                    Business Objects
│   │   ├── Customer.cs, Product.cs, Sale.cs, Enums.cs
│   │   ├── Order.cs           Cart: member flag, product lines, total
│   │   ├── ProductInOrder.cs  Cart line: qty, applied sales, line total
│   │   ├── SaleInProduct.cs   A promotion applied to a cart line
│   │   ├── Exceptions.cs
│   │   └── Tools.cs           DO⇄BO converters + reflection ToString
│   ├── BlApi/                 IBl, ICustomer, IProduct, ISale, IOrder, Factory
│   └── BlImplementation/      Bl + Customer/Product/Sale/Order implementations
│
├── BlTest/                    Console tester for the BL
│
├── UI/                        Windows Forms application (startup project)
│   ├── Program.cs             Seeds data, opens the Index form
│   ├── Index.cs               Home screen – Manager / Cashier
│   ├── SubMenu.cs             Manager screen – customers, products, sales
│   ├── CashierForm.cs         Cashier screen – cart and checkout
│   └── ProductSelectionForm.cs Product picker dialog
│
├── xml/                       Configuration and XML data files
│   ├── dal-config.xml         Selects the active DAL (list / xml)
│   ├── data-config.xml        Running ID counters for the XML DAL
│   ├── customers.xml, products.xml, sales.xml
│
└── Images/                    README screenshots
```

---

## Domain Model

### Customer
| Field | Type | Notes |
|-------|------|-------|
| `CustomerId` | `int` | Entered by the user (national ID). Must be unique. |
| `CustomerName` | `string` | |
| `CustomerAdress` | `string` | |
| `CustomerPhone` | `string` | |
| `CustomerDateJoin` | `DateTime` | Set when the customer is created |

A customer that exists in the system is treated as a **club member** at checkout.

### Product
| Field | Type | Notes |
|-------|------|-------|
| `ProductId` | `int` | Generated automatically (starts at 1000) |
| `ProductName` | `string` | |
| `ProductCategory` | `Category` | `WOMAN`, `MAN`, `CHILDREN`, `BABY` |
| `ProductQuntity` | `int` | Units in stock |
| `ProductPrice` | `double` | Regular unit price |
| `ProductDateCreat` | `DateTime` | |

### Sale (Promotion)
| Field | Type | Notes |
|-------|------|-------|
| `SaleId` | `int` | Generated automatically |
| `ProductId` | `int` | The product the promotion applies to |
| `Count` | `int` | Units needed for the promotion |
| `Price` | `int` | Price for those `Count` units |
| `ForCustomerMember` | `bool` | `true` = club members only |
| `SaleDateStart` / `SaleDateEnd` | `DateTime` | When the promotion is valid |

Example: `Count = 3, Price = 600` means *"3 units for ₪600"*.

### Order-related Business Objects
- **`Order`**: `member` flag, list of `ProductInOrder`, `TotalPrice`.
- **`ProductInOrder`**: product ID, name, unit price, ordered quantity, applied promotions, line total.
- **`SaleInProduct`**: a promotion applied to a cart line (ID, unit count, price, members-only flag).

---

## Order Pricing Algorithm

The core business logic lives in `BL/BlImplementation/OrderImplementation.cs`.

### 1. `AddProductToOrder(order, productId, count)`
- Reads the product from the DAL and checks that `existing quantity + count ≤ stock`.
- If the product is already in the cart, its quantity is updated (a negative `count` removes units). If it reaches zero, the line is removed.
- Otherwise a new `ProductInOrder` line is created.
- Then it searches for promotions, recalculates the line price, and recalculates the order total.

### 2. `SearchSaleForProduct(line, isMember)`
Picks every promotion that:
1. belongs to this product,
2. is active today (`SaleDateStart ≤ now ≤ SaleDateEnd`),
3. needs no more units than were ordered,
4. is open to everyone, or the customer is a club member.

The matching promotions are **sorted by price per unit**, cheapest first.

### 3. `CalcTotalPriceForProduct(line)`: greedy application
```text
remaining = ordered quantity
for each promotion (cheapest per unit first):
    if remaining ≥ promotion.Count:
        times      = remaining / promotion.Count
        total     += times × promotion.Price
        remaining  = remaining % promotion.Count
total += remaining × regular unit price
```
Only the promotions that were actually used stay on the line, so the cashier sees exactly what was applied.

### 4. `CalcTotalPrice(order)`
Adds up all line totals into `Order.TotalPrice`.

### 5. `DoOrder(order)`
For each line, the ordered quantity is subtracted from the product's stock and saved through the DAL.

When the cashier checks a customer (and member status changes), every line is repriced, so member promotions are added or removed right away.

---

## Data Access Layer

### Generic CRUD Contract
```csharp
public interface ICrud<T>
{
    int  Create(T item);
    T?   Read(int id);
    T?   Read(Func<T, bool> filter);
    List<T?> ReadAll(Func<T, bool>? filter = null);
    void Delete(int id);
    void UpDate(T item);
}
```
`ICustomer`, `IProduct` and `ISale` extend `ICrud<T>`. `IDal` exposes all three.

### Implementations

| | **DalList** | **DalXml** |
|---|---|---|
| Storage | Static `List<T>` in `DataSource` | `customers.xml`, `products.xml`, `sales.xml` |
| Persistence | Lost when the app closes | Saved to disk |
| ID generation | Static counters (`Product` from 1000, `Sale` from 1) | Counters stored in `data-config.xml` |
| Mechanism | LINQ over lists | `XmlSerializer`: load → modify → save on every operation |
| Pattern | Singleton (`DalList.Instance`) | Singleton (`DalXml.Instance`) |

### Runtime DAL Selection (Factory + Reflection)
`DalApi.Factory.Get`:
1. reads the active DAL name from `xml/dal-config.xml`, for example `list`,
2. maps it to an assembly name, for example `DalList`,
3. loads the assembly with `Assembly.Load`,
4. finds the class `Dal.<Name>` and returns its static `Instance` property as `IDal`.

So the BL never references a concrete DAL class.

---

## Error Handling

Custom exception types are defined in both layers:

| Layer | Exceptions |
|-------|------------|
| DO (DAL) | `Dont_Found_Id_Exception`, `Already_Exist_Id_Exception`, `Dal_Dont_Faund_EntitysId_Exception`, `Dal_Entitys_Already_Exist_Exception` |
| DalApi | `DalConfigException`: missing or invalid configuration, DAL assembly fails to load |
| BO (BL) | `Dont_Found_Id_Exception`, `Already_Exist_Id_Exception`, `BL_Dont_Faund_EntitysId_Exception`, `BL_Entitys_Already_Exist_Exception` |

Typical cases: creating a customer with an existing ID, reading, updating or deleting an entity that doesn't exist, and asking for more units than are in stock. The UI catches these exceptions and shows a message box.

---

## Getting Started

### Prerequisites
- Windows (the UI uses Windows Forms)
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 (recommended)

### Run from Visual Studio
1. Open `prject-c#/DotNet2025_6798_4298.sln`.
2. Set **UI** as the startup project.
3. Build and run (F5).

All projects build into one shared output folder, `prject-c#/bin/`. This lets the DAL factory find `DalList.dll` / `DalXml.dll` at runtime.

### Run from the command line
```bash
cd prject-c#
dotnet build DotNet2025_6798_4298.sln
cd bin
./UI.exe
```

When it starts, the UI calls `DalTest.Initialization.Initialize()`, which adds sample data:
- 2 customers (IDs `123`, `234`)
- 2 products (`SnikersWomanBlack`, `SnikersWomanWhite`, ₪350 each)
- 2 promotions: *2 for ₪500* on product 1000 and *3 for ₪600* on product 1001, valid for one month

Try it: open **Cashier**, add product 1001 three times, and the "3 for ₪600" promotion is applied automatically.

### Console Testers
- **DalTest**: an interactive menu for CRUD operations directly on the DAL.
- **BlTest**: the same kind of menu for the business layer.

---

## Configuration

### `xml/dal-config.xml`: choose the data source
```xml
<config>
  <dal>list</dal>           <!-- "list" = in-memory, "xml" = XML files -->
  <dal-packages>
    <list>DalList</list>
    <xml>DalXml</xml>
  </dal-packages>
</config>
```
Change `<dal>` to `xml` to keep data between runs. No code changes are needed.

### `xml/data-config.xml`: ID counters (XML mode)
```xml
<config>
  <ProductNum>1008</ProductNum>
  <SaleNum>41</SaleNum>
</config>
```

---

## Technologies & Concepts

- **C# / .NET 8**, **Windows Forms**
- **Three-layer architecture**: presentation, business logic, data access
- **Design patterns**: Singleton (DAL instances), Factory (`DalApi.Factory`, `BlApi.Factory`), Facade (`IDal` / `IBl` as single entry points)
- **Generic interfaces**: `ICrud<T>`
- **C# records** with `with` expressions for immutable data objects
- **LINQ**: query syntax, filtering, ordering, projection
- **Reflection**: dynamic DAL loading and a generic `ToString` helper
- **XML**: `XmlSerializer` for data, `LINQ to XML` (`XElement`) for configuration
- **Extension methods** for DO ⇄ BO conversion
- **Delegates**: `Func<T, bool>` filters passed across layers
- **Custom exceptions** in each layer

---

## Known Limitations

- `IProduct.GetAllSale` is declared but not implemented yet (promotion lookup is handled by `IOrder.SearchSaleForProduct`).
- Customer membership is defined as "the customer exists in the system". There is no separate membership flag.
- XML file paths are relative to the working directory, so the XML DAL must run from the folder that contains `xml/`.
- In XML mode, the startup seed data runs every time and can try to create customers that already exist.
- Promotions are sorted by integer price-per-unit, so promotions with very close unit prices may not be ordered exactly.
- Build output (`bin/`, `obj/`) and Visual Studio cache files (`.vs/`) are committed to the repository and should be moved to `.gitignore`.

---

## Author

**Chana Davidov**

Software Engineering Graduate
Full-Stack Development | .NET | C# | Databases | APIs
