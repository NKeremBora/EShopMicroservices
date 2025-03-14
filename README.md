# E-Commerce Microservices with .NET

This project demonstrates a real-world **e-commerce microservices architecture** implemented with **.NET** and various cloud-native tools. It follows best practices for **scalability, resilience, and maintainability**.

## Overview

The solution consists of multiple microservices that handle different **e-commerce** functionalities such as:

- **Catalog Service** – Manages product details and categories using **MongoDB** (NoSQL).
- **Basket Service** – Stores shopping cart data in **Redis** (in-memory NoSQL).
- **Discount Service** – Provides discount functionality with **PostgreSQL**.
- **Ordering Service** – Manages order processing and stores data in **SQL Server**.
- **API Gateway (YARP)** – Provides a single entry point for the system.
- **RabbitMQ** – Facilitates asynchronous communication between services.
- **gRPC & REST APIs** – Enables inter-service communication.

This system uses **containerization (Docker, Kubernetes)** and cloud-native services to ensure **high availability and performance**.

---

## **Microservices Architecture**
Each microservice is developed as an independent unit, following **Domain-Driven Design (DDD)**, **CQRS**, and **Event-Driven Architecture**.

**List of Microservices:**

| Microservice | Description | Database | Communication |
|-------------|-------------|-------------|-------------|
| **Catalog API** | Manages products and categories | PostgresSQL | REST |
| **Basket API** | Manages user carts | Redis, PostgresSQL | REST, gRPC |
| **Discount API** | Handles discount codes | PostgreSQL | gRPC |
| **Ordering API** | Manages orders | SQL Server | REST, gRPC |
| **API Gateway** | Handles client requests | - | YARP Reverse Proxy |
| **Event Bus** | Message broker for async events | RabbitMQ | Pub/Sub |

---
## Technologies - Libraries

- ✔️ **[`.NET 9`](https://github.com/dotnet/aspnetcore)** - .NET Framework and .NET Core, including ASP.NET and ASP.NET Core.
- ✔️ **[`gRPC`](https://github.com/grpc)** - High-performance, open-source universal RPC framework for inter-service communication.
- ✔️ **[`MediatR`](https://github.com/jbogard/MediatR)** - Simple, unambitious mediator implementation in .NET.
- ✔️ **[`FluentValidation`](https://github.com/FluentValidation/FluentValidation)** - Popular .NET validation library for building strongly-typed validation rules.
- ✔️ **[`Serilog`](https://github.com/serilog/serilog)** - Simple .NET logging with fully-structured events.
- ✔️ **[`Polly`](https://github.com/App-vNext/Polly)** - Polly is a .NET resilience and transient-fault-handling library that allows developers to express policies such as Retry, Circuit Breaker, Timeout, Bulkhead Isolation, and Fallback in a fluent and thread-safe manner.
- ✔️ **[`Scrutor`](https://github.com/khellang/Scrutor)** - Assembly scanning and decoration extensions for Microsoft.Extensions.DependencyInjection.
- ✔️ **[`Mapster`](https://github.com/MapsterMapper/Mapster)** - Convention-based object-object mapper in .NET.
- ✔️ **[`Marten`](https://github.com/JasperFx/marten)** - Assembly scanning and decoration extensions for Microsoft.Extensions.DependencyInjection.
-  **[`Carter`](https://github.com/CarterCommunity/Carter)** - Lightweight and modular ASP.NET Core framework for building APIs with minimal boilerplate.
---

## **How to Run the Project**

Clone the repository:
```sh
git clone https://github.com/your-repo/ecommerce-microservices.git
cd ecommerce-microservices
```

To start all services using Docker Compose, run the following command:

```sh
docker-compose up -d
```
