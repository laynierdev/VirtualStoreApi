# 🚗 Car Parts Store API

Welcome to the Car Parts Store API. This API allows you to manage products, categories, orders, and users for an auto parts store. It is built with ASP.NET Core and uses Entity Framework Core for database management.

## 📚 Table of Contents

- Features
- Technologies
- Installation
- Usage
- Endpoints
- Contributing
- License

## ✨ Features

- Manage products and categories
- Manage orders and order details
- Manage users
- RESTful API
- Support for CRUD operations

## 🛠️ Technologies

- ASP.NET Core
- Entity Framework Core
- Swagger

## 🚀 Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/your-username/carparts-api.git
    cd carparts-api
    ```

2. Configure the database in `appsettings.json`.

3. Run the SQL script to create the database (no migrations are used):
    - You will find the SQL script in the repository.

4. Start the application:
    ```bash
    dotnet run
    ```

## 📖 Usage

You can interact with the API using tools like Postman or directly from Swagger UI.

## 📌 Endpoints

### Categories

- **GET** `/api/categories` - Get all categories
- **POST** `/api/categories` - Create a new category

### Products

- **GET** `/api/products` - Get all products
- **POST** `/api/products` - Create a new product

### Orders

- **GET** `/api/orders` - Get all orders
- **POST** `/api/orders` - Create a new order

### Users

- **GET** `/api/users` - Get all users
- **POST** `/api/users` - Create a new user

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. Fork the project.
2. Create a new branch (`git checkout -b feature/new-feature`).
3. Make your changes and commit them (`git commit -am 'Add new feature'`).
4. Push the branch (`git push origin feature/new-feature`).
5. Open a Pull Request.

## 📄 License

This project is licensed under the MIT License. See the LICENSE file for details.

---

Thank you for using the Car Parts Store API! 🚗🔧
