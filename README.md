<!DOCTYPE html>
<html lang="en">
  <body>
      <h1 class="title">Libraries used</h1>
      <div>
        <ul>
          <li>
            HotChocolate.AspNetCore 13.9.0
          </li>
          <li>
            HotChocolate.Data 13.9.0
          </li>
          <li>
            Microsoft.EntityFrameworkCore 8.0.4
          </li>
          <li>
            Microsoft.EntityFrameworkCore.SqlServer 8.0.4
          </li>
          <li>
            Microsoft.EntityFrameworkCore.Tools 8.0.4
          </li>
        </ul>
      </div>
      <h1 class="title">Database setup</h1>
      <p>
        First of all
        The database is managed with SQL Express, first of all download it from the official site.
        Continue running the command Update-Database in the NuGet CLI, this will create the tables and seed ProductCategories and Customers Tables.
      </p>
      <p>
        To access the database select the SQL Express server using Windows Authentication, here you can check the tables in the Ecommerce database. The project is configured to seed the table
        Products if is empty.
      </p>
      <p>
        Run the project and a tab with the domain "http://localhost:5001/" will be opened. To test queries access GraphQL playground typing graphql after the domain mentioned: 
        "http://localhost:5001/graphql"
       </p>
       <h3>
         Queries
       </h3>
       <p>
         Here are some examples to get data (Queries) and do operations in the database (mutations)
       </p>
       <ul>
         <li>
           <div>
             <p>This query obtains all the products available in the system:</p>
             <code>
              query{
                products{
                  nodes{
                    id
                    name
                    imageUrl
                    description
                    unitPrice
                    stock
                    productCategories
                   {
                      id
                      name
                      description
                    }
                  }
                  pageInfo{
                    endCursor
                    hasNextPage
                  }
              }
              }
            </code>
           </div>
         </li>
          <li>
            <div>
               <p>The response will be this, you can use the endCursor value to retrieve the next batch of products</p>
              <code>
              {
                "data": {
                "products": {
                  "nodes": [
                  {
                    "id": 1,
                    "name": "Product 1 for category Sport Shoes",
                    "imageUrl": "Sport Shoes",
                    "description": "Description for Product 1",
                    "unitPrice": 89,
                    "stock": 76,
                    "productCategories": [
                     {
                        "id": 1,
                        "name": "Sport Shoes",
                        "description": "Shoes for various sports activities"
                      },
                      {
                        "id": 2,
                        "name": "Sport Shirt",
                        "description": "Shirts for sports enthusiasts"
                      }
                    ]
                  },
                  //Other 9 products
                  ],
                 "pageInfo": {
                  "endCursor": "OQ==",
                  "hasNextPage": true
                  }
                }
               }
              }
              </code>
           </div>
         </li>
          <li>
           <div>
             <p>The next batch can be returned using this query:</p>
             <code>
              query{
                products(after:"OQ==" ){
                  nodes{
                    id
                    name
                    imageUrl
                    description
                    unitPrice
                    stock
                    productCategories
                   {
                      id
                      name
                      description
                    }
                  }
                  pageInfo{
                    endCursor
                    hasNextPage
                  }
              }
              }
            </code>
           </div>
        </li>
      </ul>

      <h1 class="title">Running tests</h1>
      <p>Use the <code>dotnet test</code> command from the repository root to execute the unit tests. The tests are contained in the <code>ECommerceApi.Tests</code> project.</p>

  </body>
  <footer>
     <h3 class="title">About me</h3>
    <p>Check more of my background on my LinkedIn account: <a href="https://www.linkedin.com/in/jhon-guisao" target="_blank" rel="noopener noreferrer">https://www.linkedin.com/in/jhon-guisao</a></p>
  </footer>
</html>
