
namespace StockDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alphabetical list of products",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        SupplierId = c.Guid(nullable: false),
                        CategoryId = c.Guid(nullable: false),
                        QuantityPerUnit = c.String(maxLength: 20),
                        UnitPrice = c.Decimal(precision: 18, scale: 2),
                        UnitsInStock = c.Short(),
                        UnitsOnOrder = c.Short(),
                        ReorderLevel = c.Short(),
                        Discontinued = c.Boolean(nullable: false),
                        CategoryName = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AlphabeticalListOfProducts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        SupplierId = c.Guid(nullable: false),
                        CategoryId = c.Guid(nullable: false),
                        QuantityPerUnit = c.String(maxLength: 20),
                        UnitPrice = c.Decimal(precision: 18, scale: 2),
                        UnitsInStock = c.Short(),
                        UnitsOnOrder = c.Short(),
                        ReorderLevel = c.Short(),
                        Discontinued = c.Boolean(nullable: false),
                        CategoryName = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Guid(nullable: false),
                        CategoryName = c.String(nullable: false, maxLength: 15),
                        Description = c.String(),
                        Picture = c.Binary(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Guid(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        SupplierId = c.Guid(nullable: false),
                        CategoryId = c.Guid(nullable: false),
                        QuantityPerUnit = c.String(maxLength: 20),
                        UnitPrice = c.Decimal(precision: 18, scale: 2),
                        UnitsInStock = c.Short(),
                        UnitsOnOrder = c.Short(),
                        ReorderLevel = c.Short(),
                        Discontinued = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId)
                .Index(t => t.SupplierId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailId = c.Guid(nullable: false),
                        OrderId = c.Guid(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Short(nullable: false),
                        Discount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.OrderDetailId)
                .ForeignKey("dbo.Orders", t => t.OrderId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Guid(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                        EmployeeId = c.Guid(nullable: false),
                        OrderDate = c.DateTime(),
                        RequiredDate = c.DateTime(),
                        ShippedDate = c.DateTime(),
                        ShipVia = c.Int(),
                        Freight = c.Decimal(precision: 18, scale: 2),
                        ShipName = c.String(maxLength: 40),
                        ShipAddress = c.String(maxLength: 60),
                        ShipCity = c.String(maxLength: 15),
                        ShipRegion = c.String(maxLength: 15),
                        ShipPostalCode = c.String(maxLength: 10),
                        ShipCountry = c.String(maxLength: 15),
                        Shipper_ShipperId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .ForeignKey("dbo.Shippers", t => t.Shipper_ShipperId)
                .Index(t => t.CustomerId)
                .Index(t => t.EmployeeId)
                .Index(t => t.Shipper_ShipperId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Guid(nullable: false),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        ContactName = c.String(maxLength: 30),
                        ContactTitle = c.String(maxLength: 30),
                        Address = c.String(maxLength: 60),
                        City = c.String(maxLength: 15),
                        Region = c.String(maxLength: 15),
                        PostalCode = c.String(maxLength: 10),
                        Country = c.String(maxLength: 15),
                        Phone = c.String(maxLength: 24),
                        Fax = c.String(maxLength: 24),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Guid(nullable: false),
                        LastName = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(nullable: false, maxLength: 10),
                        Title = c.String(maxLength: 30),
                        TitleOfCourtesy = c.String(maxLength: 25),
                        BirthDate = c.DateTime(),
                        HireDate = c.DateTime(),
                        Address = c.String(maxLength: 60),
                        City = c.String(maxLength: 15),
                        Region = c.String(maxLength: 15),
                        PostalCode = c.String(maxLength: 10),
                        Country = c.String(maxLength: 15),
                        HomePhone = c.String(maxLength: 24),
                        Extension = c.String(maxLength: 4),
                        Photo = c.Binary(),
                        Notes = c.String(),
                        ReportsTo = c.Int(),
                        PhotoPath = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Territories",
                c => new
                    {
                        TerritoryId = c.Guid(nullable: false),
                        TerritoryDescription = c.String(nullable: false, maxLength: 50, fixedLength: true),
                        RegionId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.TerritoryId)
                .ForeignKey("dbo.Region", t => t.RegionId)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.Region",
                c => new
                    {
                        RegionId = c.Guid(nullable: false),
                        RegionDescription = c.String(nullable: false, maxLength: 50, fixedLength: true),
                    })
                .PrimaryKey(t => t.RegionId);
            
            CreateTable(
                "dbo.Shippers",
                c => new
                    {
                        ShipperId = c.Guid(nullable: false),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        Phone = c.String(maxLength: 24),
                    })
                .PrimaryKey(t => t.ShipperId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.Guid(nullable: false),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        ContactName = c.String(maxLength: 30),
                        ContactTitle = c.String(maxLength: 30),
                        Address = c.String(maxLength: 60),
                        City = c.String(maxLength: 15),
                        Region = c.String(maxLength: 15),
                        PostalCode = c.String(maxLength: 10),
                        Country = c.String(maxLength: 15),
                        Phone = c.String(maxLength: 24),
                        Fax = c.String(maxLength: 24),
                        HomePage = c.String(),
                    })
                .PrimaryKey(t => t.SupplierId);
            
            CreateTable(
                "dbo.OrderDetailsExtended",
                c => new
                    {
                        OrderDetailExtendedId = c.Guid(nullable: false),
                        OrderId = c.Guid(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Short(nullable: false),
                        Discount = c.Single(nullable: false),
                        ExtendedPrice = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderDetailExtendedId);
            
            CreateTable(
                "dbo.OrderSubtotals",
                c => new
                    {
                        OrderId = c.Guid(nullable: false),
                        Subtotal = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.EmployeeTerritories",
                c => new
                    {
                        EmployeeId = c.Guid(nullable: false),
                        TerritoryId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployeeId, t.TerritoryId })
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Territories", t => t.TerritoryId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.TerritoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Shipper_ShipperId", "dbo.Shippers");
            DropForeignKey("dbo.Orders", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.EmployeeTerritories", "TerritoryId", "dbo.Territories");
            DropForeignKey("dbo.EmployeeTerritories", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Territories", "RegionId", "dbo.Region");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.EmployeeTerritories", new[] { "TerritoryId" });
            DropIndex("dbo.EmployeeTerritories", new[] { "EmployeeId" });
            DropIndex("dbo.Territories", new[] { "RegionId" });
            DropIndex("dbo.Orders", new[] { "Shipper_ShipperId" });
            DropIndex("dbo.Orders", new[] { "EmployeeId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "SupplierId" });
            DropTable("dbo.EmployeeTerritories");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.OrderSubtotals");
            DropTable("dbo.OrderDetailsExtended");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Shippers");
            DropTable("dbo.Region");
            DropTable("dbo.Territories");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
            DropTable("dbo.AlphabeticalListOfProducts");
            DropTable("dbo.Alphabetical list of products");
        }
    }
}
