# OrderProcessing

## Overview

This repository contains three projects built with .NET 6:

1. **Customer API**: A web API for managing customer-related operations.
2. **Product API**: A web API for managing product-related operations.
3. **API Gateway**: Routes upstream and downstream requests to specified routes for the customer and product APIs.

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
   
  - Customer API: http://localhost:5001
   
  - Product API: http://localhost:5002
  
  - API Gateway: http://localhost:5000

## Configuration

- Each project may have its own configuration files. Check the appsettings.json or respective configuration files for customization.

## Contributing
If you would like to contribute to this project, please follow the [Contributing Guidelines](contributing-guidelines/).

> [!CAUTION]
> This project uses http scheme, additionally it has support for https but the ports may vary. Please check launchsettings.json of each project to know more about.
