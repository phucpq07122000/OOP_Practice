# Project Ecommerce_Store
+The project is coded according to the idea of an e-commerce store\
+built according to the cleave architecture design pattern\
+and the project is made by 4 members
# Role_Project 
## **1. Customer** 
-This is the default role for all signed-in users. You can browse products, add them to your cart, place orders, and transfer money.				
#### Customer (No login) Functions

     a. **ViewAllListProduct()**
          - Description: Displays a list of all available products.
     
     b. **ViewDetailsProduct()**
        - Description: Allows customers to view detailed information about a specific product.
     
     c. **ViewProductsAreAvailableAtTheBranch()**
        - Description: Shows a list of products that are currently available at a specific branch.
     
     d. **SearchProduct()**
        - Description: Enables customers to search for a specific product using keywords.
     
     e. **SearchByCategory()**
        - Description: Allows customers to filter products by category for easier navigation.
     
     f. **Filter()**
        - Description: Search by options of customers to filter products based on various criteria such as price, brand, etc.
     
     g. **Login()**
        - Description: Allows customers to log in to their accounts.
     
     j. **Register()**
          - Description: Allows new customers to create an account.
# Customer (Login) Functions

      a. CRUD Profile Customer
          -Update Profile:** Allows customers to update their profile information.     
          -View Profile:** Displays the customer's profile information.

      b. CRUD Cart
        - Update Cart: Allows customers to update the quantity of products in their shopping cart.
        - Create Cart: Enables customers to create a new shopping cart.
        - Delete Product: Allows customers to remove a product from their shopping cart.

      c. ViewOrder()
        Description: Displays a list of customer orders.
           - ViewOrderByMoney(): Provides a view of orders based on the total amount spent.
           - ViewOrderByDate(): Displays orders sorted by date.

      h. Rating
        Description: Enables customers to rate products they have purchased.

      j. Comment
        Description: Allows customers to leave comments or feedback on products or the overall shopping experience.


 
## **2. Store Owner**:
-This role is assigned to users who are storekeepers. You can do everything that a Store Employee can do, plus You can add, update, and remove your products, store employees, and revenue statistics of your store.

## **3. Super Admin**: 
-This role is assigned to users who have full control over the app. You can do everything that an Admin can do, plus you can view, add, or remove Admin Role or Store Owner, Store Employee.
