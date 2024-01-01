# OrderProcessing

## Overview

This repository contains three projects built with .NET 6:

1. **Customer API**: A web API for managing customer-related operations.
2. **Product API**: A web API for managing product-related operations.
3. **API Gateway**: Routes upstream and downstream requests to specified routes for the customer and product APIs.

## Description

Since microservices-based applications comprise several different services, you often need a common interface or gateway to call these services so that you define and manage all concerns in one place rather than replicate them across all downstream services. This is precisely why I undertook such a project to understand and showcase the capabilities of a API Gateway which gives us consistent way to connect with the microservices.

## Technologies Used

- [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0)
- [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core)
- [API Gateway](https://github.com/ThreeMammals/Ocelot) 

## Project Structure

- **Customer API**: [customer-api/](OrderProcessing.Customer/)
  - Contains the source code and configuration for the Customer API.

- **Product API**: [product-api/](OrderProcessing.Product/)
  - Contains the source code and configuration for the Product API.

- **API Gateway**: [api-gateway/](OrderProcessing/)
  - Contains the source code and configuration for the API Gateway.

## Getting Started

1. Clone the repository:

   ```bash
   git clone https://github.com/battletremor/OrderProcessing.git
   cd OrderProcessing
   ```
2. Build and run the projects:
  - Navigate to each project directory (OrderProcessing.Customer/, OrderProcessing.Product/, OrderProcessing/) and run:
    ```bash
    dotnet build
    dotnet run
    ```
3. Open your browser and navigate to the API endpoints:
   
  - Customer API: http://localhost:5001/swagger
   
  - Product API: http://localhost:5002/swagger
  
  - API Gateway: http://localhost:5000/swagger

## Configuration

- Each project may have its own configuration files. Check the appsettings.json or respective configuration files for customization.

## Contributing
If you would like to contribute to this project, please follow the [Contributing Guidelines](contributing-guidelines/).

> [!CAUTION]
> This project uses http scheme, additionally it has support for https but the ports may vary. Please check launchSettings.json of each project to know more about.

> [!TIP]
> The two webapi projects OrderProcessing.Customer, OrderProcessing.Product have swaggeeUI enabled which can be disabled by commenting the launchUrl key-value pair in launchSettings.json
> The gateway can be tested with PostMan for more details you can check out the official website of [Postman](https://www.postman.com/)
