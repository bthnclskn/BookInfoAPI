# BookInfoAPI

BookInfoAPI is a simple ASP.NET Core Web API project that provides information about books. This API supports CRUD (Create, Read, Update, Delete) operations for books, authors, and categories.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)
- [License](#license)

## Features

- Add, list, update, and delete books
- Add, list, update, and delete authors
- Add, list, update, and delete categories
- Database operations with Entity Framework Core
- ASP.NET Core Web API

## Installation

Clone the repository and install the necessary dependencies:

```sh
git clone https://github.com/yourusername/BookInfoAPI.git
cd BookInfoAPI
dotnet restore
dotnet ef migrations add InitialCreate
dotnet ef database update
Usage
Once the project is running, the API will be available at the following endpoints:

GET /api/books - List all books
GET /api/books/{id} - Get a specific book
POST /api/books - Add a new book
PUT /api/books/{id} - Update an existing book
DELETE /api/books/{id} - Delete a book
Similar endpoints are available for authors and categories.
Books
GET /api/books - Retrieves all books.
GET /api/books/{id} - Retrieves a specific book.
POST /api/books - Creates a new book.
PUT /api/books/{id} - Updates an existing book.
DELETE /api/books/{id} - Deletes a specific book.
Authors
GET /api/authors - Retrieves all authors.
GET /api/authors/{id} - Retrieves a specific author.
POST /api/authors - Creates a new author.
PUT /api/authors/{id} - Updates an existing author.
DELETE /api/authors/{id} - Deletes a specific author.
Categories
GET /api/categories - Retrieves all categories.
GET /api/categories/{id} - Retrieves a specific category.
POST /api/categories - Creates a new category.
PUT /api/categories/{id} - Updates an existing category.
DELETE /api/categories/{id} - Deletes a specific category.
Contributing
Contributions are welcome! Please feel free to submit a Pull Request.

License
This project is licensed under the MIT License. See the LICENSE file for details.

Bu README dosyasını projenizin kök dizinine `README.md` adıyla kaydedin. MIT lisansını eklemek için de `LICENSE` adlı bir dosya oluşturup aşağıdaki metni ekleyin:

```text
MIT License

Copyright (c) 2024 bthnclskn

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

