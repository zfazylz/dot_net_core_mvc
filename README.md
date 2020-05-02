# PCShop

Subject: __Microsoft .NET Framework, Application Development Foundation(c.w.) (Даулетбек Е.)__ <br>
Team: __Nurtugan & Fazylzhan__

### Models:
+ Hardware
+ Category
+ Order
+ Order Details
+ Shopping Cart
+ Shopping Cart Item

### Relationships:
| Model 1 | Model 2 | Relationship |
| :-------------: | :-------------: | :-----: |
| Category | Hardware | one to many |
| Order Details | Order | many to one |
| Shopping Cart | Shopping Cart Item | one to many |
| Role | User | many to many |
