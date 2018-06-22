namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        PersonID = c.Int(nullable: false),
                        VendorID = c.Int(nullable: false),
                        AddressType = c.String(nullable: false, maxLength: 30),
                        Add1 = c.String(nullable: false, maxLength: 50),
                        Add2 = c.String(maxLength: 50),
                        City = c.String(maxLength: 30),
                        State = c.String(nullable: false, maxLength: 2),
                        PostalCode = c.String(nullable: false, maxLength: 5),
                        Country = c.String(),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Person_PersonID = c.Int(),
                        Vendor_VendorID = c.Int(),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.People", t => t.Person_PersonID)
                .ForeignKey("dbo.Vendors", t => t.Vendor_VendorID)
                .Index(t => t.AddressType)
                .Index(t => t.Person_PersonID)
                .Index(t => t.Vendor_VendorID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        PersonType = c.String(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Address_AddressID = c.Int(),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressID)
                .Index(t => t.Address_AddressID);
            
            CreateTable(
                "dbo.EmailAddresses",
                c => new
                    {
                        EmailAddressID = c.Int(nullable: false, identity: true),
                        PersonID = c.Int(nullable: false),
                        Addresstype = c.String(nullable: false),
                        ThAddress = c.String(),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.EmailAddressID)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        ImageType = c.String(),
                        FileName = c.String(nullable: false, maxLength: 257),
                        Description = c.String(maxLength: 100),
                        ImageName = c.String(),
                        Caption = c.String(),
                        PersonID = c.Int(nullable: false),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ImageID)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.PhoneNumbers",
                c => new
                    {
                        PhoneNumberID = c.Int(nullable: false, identity: true),
                        PersonID = c.Int(nullable: false),
                        PhoneNumberType = c.String(nullable: false, maxLength: 10),
                        ThePhoneNumber = c.String(nullable: false),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.PhoneNumberID)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        VendorID = c.Int(nullable: false, identity: true),
                        VendorName = c.String(),
                        WebSite = c.String(),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Address_AddressID = c.Int(),
                    })
                .PrimaryKey(t => t.VendorID)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressID)
                .Index(t => t.Address_AddressID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 500),
                        ItemType = c.String(nullable: false, maxLength: 50),
                        TotalCost = c.Decimal(nullable: false, storeType: "money"),
                        Markup = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Vendor_VendorID = c.Int(),
                        Customer_CustomerID = c.Int(),
                    })
                .PrimaryKey(t => t.ItemID)
                .ForeignKey("dbo.Vendors", t => t.Vendor_VendorID)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerID)
                .Index(t => t.Vendor_VendorID)
                .Index(t => t.Customer_CustomerID);
            
            CreateTable(
                "dbo.Parts",
                c => new
                    {
                        PartID = c.Int(nullable: false, identity: true),
                        ItemID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Description = c.String(maxLength: 500),
                        PartTypeID = c.Int(nullable: false),
                        Cost = c.Decimal(nullable: false, storeType: "money"),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.PartID)
                .ForeignKey("dbo.Items", t => t.ItemID, cascadeDelete: true)
                .ForeignKey("dbo.PartTypes", t => t.PartTypeID, cascadeDelete: true)
                .Index(t => t.ItemID)
                .Index(t => t.PartTypeID);
            
            CreateTable(
                "dbo.PartTypes",
                c => new
                    {
                        PartTypeID = c.Int(nullable: false, identity: true),
                        PartName = c.String(nullable: false),
                        Markup = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.PartTypeID);
            
            CreateTable(
                "dbo.VendorContacts",
                c => new
                    {
                        VendorContactID = c.Int(nullable: false, identity: true),
                        VendorID = c.Int(nullable: false),
                        VendorContactType = c.String(),
                        PersonID = c.Int(nullable: false),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.VendorContactID)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .ForeignKey("dbo.Vendors", t => t.VendorID, cascadeDelete: true)
                .Index(t => t.VendorID)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        PersonID = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.CustomerSpecialDates",
                c => new
                    {
                        SpecialDateID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        SpecialDateDateType = c.String(nullable: false),
                        TheDate = c.DateTime(nullable: false),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.SpecialDateID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.DiamondDiameterMeasurements",
                c => new
                    {
                        DiamondDiameterMeasurementsID = c.Int(nullable: false, identity: true),
                        DiamondShapeMesurementsID = c.Int(nullable: false),
                        Diameter = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiamondMeasurement_DiamondMesurementsID = c.Int(),
                    })
                .PrimaryKey(t => t.DiamondDiameterMeasurementsID)
                .ForeignKey("dbo.DiamondMeasurements", t => t.DiamondMeasurement_DiamondMesurementsID)
                .Index(t => t.DiamondMeasurement_DiamondMesurementsID);
            
            CreateTable(
                "dbo.DiamondMeasurements",
                c => new
                    {
                        DiamondMesurementsID = c.Int(nullable: false, identity: true),
                        PartDiamondID = c.Int(nullable: false),
                        Depth = c.Decimal(nullable: false, precision: 18, scale: 2),
                        isEstimatedDepth = c.Boolean(nullable: false),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.DiamondMesurementsID);
            
            CreateTable(
                "dbo.DiamondTableMeasurements",
                c => new
                    {
                        DiamondTableMeasurementsID = c.Int(nullable: false, identity: true),
                        DiamondMesurementID = c.Int(nullable: false),
                        TableMeasurement = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiamondMeasurement_DiamondMesurementsID = c.Int(),
                        PartSingleDiamond_SingleDiamondPartID = c.Int(),
                    })
                .PrimaryKey(t => t.DiamondTableMeasurementsID)
                .ForeignKey("dbo.DiamondMeasurements", t => t.DiamondMeasurement_DiamondMesurementsID)
                .ForeignKey("dbo.PartSingleDiamonds", t => t.PartSingleDiamond_SingleDiamondPartID)
                .Index(t => t.DiamondMeasurement_DiamondMesurementsID)
                .Index(t => t.PartSingleDiamond_SingleDiamondPartID);
            
            CreateTable(
                "dbo.DiamondShapes",
                c => new
                    {
                        DiamondShapeID = c.Int(nullable: false),
                        ShapeName = c.String(),
                        PlotDiagram = c.Binary(),
                    })
                .PrimaryKey(t => t.DiamondShapeID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        PersonID = c.Int(nullable: false),
                        Position = c.String(),
                        HireDate = c.DateTime(nullable: false),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.GemDiameterMeasurements",
                c => new
                    {
                        GemDiameterMeasurementsID = c.Int(nullable: false, identity: true),
                        GemShapeMesurementsID = c.Int(nullable: false),
                        Diameter = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.GemDiameterMeasurementsID)
                .ForeignKey("dbo.GemShapeMeasurements", t => t.GemShapeMesurementsID, cascadeDelete: true)
                .Index(t => t.GemShapeMesurementsID);
            
            CreateTable(
                "dbo.GemShapeMeasurements",
                c => new
                    {
                        GemShapeMesurementsID = c.Int(nullable: false, identity: true),
                        PartGemID = c.Int(nullable: false),
                        Depth = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.GemShapeMesurementsID);
            
            CreateTable(
                "dbo.GemShapes",
                c => new
                    {
                        GemShapeID = c.Int(nullable: false, identity: true),
                        GemPartID = c.Int(nullable: false),
                        ShapeName = c.String(),
                        ImageLocation = c.String(),
                        Image = c.Binary(),
                        FileExtension = c.String(),
                        WeightFactor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.GemShapeID);
            
            CreateTable(
                "dbo.GemStoneLocations",
                c => new
                    {
                        GemStoneLocationID = c.Int(nullable: false, identity: true),
                        GemStoneTypeID = c.Int(nullable: false),
                        Country = c.String(),
                        CityRegion = c.String(),
                    })
                .PrimaryKey(t => t.GemStoneLocationID)
                .ForeignKey("dbo.GemStoneTypes", t => t.GemStoneTypeID, cascadeDelete: true)
                .Index(t => t.GemStoneTypeID);
            
            CreateTable(
                "dbo.GemStoneTypes",
                c => new
                    {
                        GemStoneTypeID = c.Int(nullable: false, identity: true),
                        GemName = c.String(),
                        BirthstoneMonth = c.String(),
                        MosHardnessRange = c.String(),
                        CrystlStructure = c.String(),
                        ChemicalFormula = c.String(),
                        GemMineral = c.String(),
                        RefractiveIndexLowRange = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RefractiveIndexHighRange = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Birefringence = c.String(),
                        SpecificGravityLowRange = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SpecificGravityHighRange = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.GemStoneTypeID);
            
            CreateTable(
                "dbo.ItemInventories",
                c => new
                    {
                        ItemInventoryID = c.Int(nullable: false, identity: true),
                        ItemID = c.Int(nullable: false),
                        ItemType = c.String(nullable: false, maxLength: 50),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ItemInventoryID)
                .ForeignKey("dbo.Items", t => t.ItemID, cascadeDelete: true)
                .Index(t => t.ItemID);
            
            CreateTable(
                "dbo.ItemRepairs",
                c => new
                    {
                        ItemRepairID = c.Int(nullable: false, identity: true),
                        CompletionDate = c.DateTime(nullable: false),
                        EstimatedValue = c.Decimal(nullable: false, storeType: "money"),
                        ItemType = c.String(),
                        Instruction = c.String(nullable: false, maxLength: 500),
                        PickupDate = c.DateTime(nullable: false),
                        RepairID = c.Int(nullable: false),
                        ItemID = c.Int(nullable: false),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ItemRepairID)
                .ForeignKey("dbo.Items", t => t.ItemID, cascadeDelete: true)
                .ForeignKey("dbo.Repairs", t => t.RepairID, cascadeDelete: true)
                .Index(t => t.RepairID)
                .Index(t => t.ItemID);
            
            CreateTable(
                "dbo.Repairs",
                c => new
                    {
                        RepairID = c.Int(nullable: false, identity: true),
                        TakeInDate = c.DateTime(nullable: false),
                        PromiseDate = c.DateTime(nullable: false),
                        PickupDate = c.DateTime(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.RepairID);
            
            CreateTable(
                "dbo.LaborTypes",
                c => new
                    {
                        LaborTypeID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        PerHourRate = c.Decimal(nullable: false, storeType: "money"),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.LaborTypeID);
            
            CreateTable(
                "dbo.MetalFinishes",
                c => new
                    {
                        MetalFinishID = c.Int(nullable: false, identity: true),
                        Finish = c.String(),
                        Description = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.MetalFinishID);
            
            CreateTable(
                "dbo.MetalTypes",
                c => new
                    {
                        MetalTypeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MetalTypeName = c.String(),
                        Qualtity = c.String(),
                        Color = c.String(),
                        SpecificGravity = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MetalTypeID);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        NoteID = c.Int(nullable: false, identity: true),
                        OwnerKey = c.Guid(nullable: false),
                        NoteText = c.String(nullable: false, maxLength: 500),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.NoteID);
            
            CreateTable(
                "dbo.PartDiamonds",
                c => new
                    {
                        PartDiamondID = c.Int(nullable: false, identity: true),
                        PartID = c.Int(nullable: false),
                        PricePerCarat = c.Decimal(nullable: false, storeType: "money"),
                        DiamondShapeID = c.Int(nullable: false),
                        TopClarityGrade = c.String(),
                        LowerClarityGrade = c.String(),
                        TopColorGrade = c.String(),
                        LowerColorGrade = c.String(),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        DiamondMeasurement_DiamondMesurementsID = c.Int(),
                    })
                .PrimaryKey(t => t.PartDiamondID)
                .ForeignKey("dbo.DiamondMeasurements", t => t.DiamondMeasurement_DiamondMesurementsID)
                .ForeignKey("dbo.DiamondShapes", t => t.DiamondShapeID, cascadeDelete: true)
                .ForeignKey("dbo.Parts", t => t.PartID, cascadeDelete: true)
                .Index(t => t.PartID)
                .Index(t => t.DiamondShapeID)
                .Index(t => t.DiamondMeasurement_DiamondMesurementsID);
            
            CreateTable(
                "dbo.PartGems",
                c => new
                    {
                        PartGemID = c.Int(nullable: false, identity: true),
                        PartID = c.Int(nullable: false),
                        Color = c.String(),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ActualWeight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstimatedWeight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsEstWeight = c.Boolean(nullable: false),
                        IsSynthetic = c.Boolean(nullable: false),
                        Finish = c.String(),
                        PricePerStone = c.Decimal(nullable: false, storeType: "money"),
                        PricePerCarat = c.Decimal(nullable: false, storeType: "money"),
                        GemStoneTypeID = c.Int(nullable: false),
                        GemShapeID = c.Int(nullable: false),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        GemShapeMeasurements_GemShapeMesurementsID = c.Int(),
                    })
                .PrimaryKey(t => t.PartGemID)
                .ForeignKey("dbo.GemShapes", t => t.GemShapeID, cascadeDelete: true)
                .ForeignKey("dbo.GemShapeMeasurements", t => t.GemShapeMeasurements_GemShapeMesurementsID)
                .ForeignKey("dbo.GemStoneTypes", t => t.GemStoneTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Parts", t => t.PartID, cascadeDelete: true)
                .Index(t => t.PartID)
                .Index(t => t.GemStoneTypeID)
                .Index(t => t.GemShapeID)
                .Index(t => t.GemShapeMeasurements_GemShapeMesurementsID);
            
            CreateTable(
                "dbo.PartMetals",
                c => new
                    {
                        PartMetalID = c.Int(nullable: false, identity: true),
                        PartID = c.Int(nullable: false),
                        MetalTypeID = c.Int(nullable: false),
                        IsStamped = c.Boolean(nullable: false),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MetalFinishID = c.Int(nullable: false),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.PartMetalID)
                .ForeignKey("dbo.MetalFinishes", t => t.MetalFinishID, cascadeDelete: true)
                .ForeignKey("dbo.MetalTypes", t => t.MetalTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Parts", t => t.PartID, cascadeDelete: true)
                .Index(t => t.PartID)
                .Index(t => t.MetalTypeID)
                .Index(t => t.MetalFinishID);
            
            CreateTable(
                "dbo.RoundGemWidths",
                c => new
                    {
                        RoundGemWidthID = c.Int(nullable: false, identity: true),
                        OwnerID = c.Int(nullable: false),
                        Mesurement = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        PartSingleDiamond_SingleDiamondPartID = c.Int(),
                    })
                .PrimaryKey(t => t.RoundGemWidthID)
                .ForeignKey("dbo.PartSingleDiamonds", t => t.PartSingleDiamond_SingleDiamondPartID)
                .Index(t => t.PartSingleDiamond_SingleDiamondPartID);
            
            CreateTable(
                "dbo.PartSingleDiamonds",
                c => new
                    {
                        SingleDiamondPartID = c.Int(nullable: false, identity: true),
                        PartID = c.Int(nullable: false),
                        DiamondColor = c.String(),
                        IsFancy = c.Boolean(nullable: false),
                        Shape = c.String(),
                        Length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Depth = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GirdleThickness = c.String(),
                        GirdleFinish = c.String(),
                        CulitSize = c.String(),
                        Polish = c.String(),
                        ClarityGrade = c.String(),
                        ColorGrade = c.String(),
                        Floresence = c.String(),
                        IsEnhanced = c.Boolean(nullable: false),
                        HowEnhanced = c.String(),
                        PlotImage = c.Binary(),
                        SymmetryGrade = c.String(),
                        RecordGuid = c.Guid(nullable: false),
                        RCD = c.DateTime(nullable: false),
                        LMD = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.SingleDiamondPartID)
                .ForeignKey("dbo.Parts", t => t.PartID, cascadeDelete: true)
                .Index(t => t.PartID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoundGemWidths", "PartSingleDiamond_SingleDiamondPartID", "dbo.PartSingleDiamonds");
            DropForeignKey("dbo.PartSingleDiamonds", "PartID", "dbo.Parts");
            DropForeignKey("dbo.DiamondTableMeasurements", "PartSingleDiamond_SingleDiamondPartID", "dbo.PartSingleDiamonds");
            DropForeignKey("dbo.PartMetals", "PartID", "dbo.Parts");
            DropForeignKey("dbo.PartMetals", "MetalTypeID", "dbo.MetalTypes");
            DropForeignKey("dbo.PartMetals", "MetalFinishID", "dbo.MetalFinishes");
            DropForeignKey("dbo.PartGems", "PartID", "dbo.Parts");
            DropForeignKey("dbo.PartGems", "GemStoneTypeID", "dbo.GemStoneTypes");
            DropForeignKey("dbo.PartGems", "GemShapeMeasurements_GemShapeMesurementsID", "dbo.GemShapeMeasurements");
            DropForeignKey("dbo.PartGems", "GemShapeID", "dbo.GemShapes");
            DropForeignKey("dbo.PartDiamonds", "PartID", "dbo.Parts");
            DropForeignKey("dbo.PartDiamonds", "DiamondShapeID", "dbo.DiamondShapes");
            DropForeignKey("dbo.PartDiamonds", "DiamondMeasurement_DiamondMesurementsID", "dbo.DiamondMeasurements");
            DropForeignKey("dbo.ItemRepairs", "RepairID", "dbo.Repairs");
            DropForeignKey("dbo.ItemRepairs", "ItemID", "dbo.Items");
            DropForeignKey("dbo.ItemInventories", "ItemID", "dbo.Items");
            DropForeignKey("dbo.GemStoneLocations", "GemStoneTypeID", "dbo.GemStoneTypes");
            DropForeignKey("dbo.GemDiameterMeasurements", "GemShapeMesurementsID", "dbo.GemShapeMeasurements");
            DropForeignKey("dbo.Employees", "PersonID", "dbo.People");
            DropForeignKey("dbo.DiamondTableMeasurements", "DiamondMeasurement_DiamondMesurementsID", "dbo.DiamondMeasurements");
            DropForeignKey("dbo.DiamondDiameterMeasurements", "DiamondMeasurement_DiamondMesurementsID", "dbo.DiamondMeasurements");
            DropForeignKey("dbo.Customers", "PersonID", "dbo.People");
            DropForeignKey("dbo.Items", "Customer_CustomerID", "dbo.Customers");
            DropForeignKey("dbo.CustomerSpecialDates", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Vendors", "Address_AddressID", "dbo.Addresses");
            DropForeignKey("dbo.VendorContacts", "VendorID", "dbo.Vendors");
            DropForeignKey("dbo.VendorContacts", "PersonID", "dbo.People");
            DropForeignKey("dbo.Items", "Vendor_VendorID", "dbo.Vendors");
            DropForeignKey("dbo.Parts", "PartTypeID", "dbo.PartTypes");
            DropForeignKey("dbo.Parts", "ItemID", "dbo.Items");
            DropForeignKey("dbo.Addresses", "Vendor_VendorID", "dbo.Vendors");
            DropForeignKey("dbo.People", "Address_AddressID", "dbo.Addresses");
            DropForeignKey("dbo.PhoneNumbers", "PersonID", "dbo.People");
            DropForeignKey("dbo.Images", "PersonID", "dbo.People");
            DropForeignKey("dbo.EmailAddresses", "PersonID", "dbo.People");
            DropForeignKey("dbo.Addresses", "Person_PersonID", "dbo.People");
            DropIndex("dbo.PartSingleDiamonds", new[] { "PartID" });
            DropIndex("dbo.RoundGemWidths", new[] { "PartSingleDiamond_SingleDiamondPartID" });
            DropIndex("dbo.PartMetals", new[] { "MetalFinishID" });
            DropIndex("dbo.PartMetals", new[] { "MetalTypeID" });
            DropIndex("dbo.PartMetals", new[] { "PartID" });
            DropIndex("dbo.PartGems", new[] { "GemShapeMeasurements_GemShapeMesurementsID" });
            DropIndex("dbo.PartGems", new[] { "GemShapeID" });
            DropIndex("dbo.PartGems", new[] { "GemStoneTypeID" });
            DropIndex("dbo.PartGems", new[] { "PartID" });
            DropIndex("dbo.PartDiamonds", new[] { "DiamondMeasurement_DiamondMesurementsID" });
            DropIndex("dbo.PartDiamonds", new[] { "DiamondShapeID" });
            DropIndex("dbo.PartDiamonds", new[] { "PartID" });
            DropIndex("dbo.ItemRepairs", new[] { "ItemID" });
            DropIndex("dbo.ItemRepairs", new[] { "RepairID" });
            DropIndex("dbo.ItemInventories", new[] { "ItemID" });
            DropIndex("dbo.GemStoneLocations", new[] { "GemStoneTypeID" });
            DropIndex("dbo.GemDiameterMeasurements", new[] { "GemShapeMesurementsID" });
            DropIndex("dbo.Employees", new[] { "PersonID" });
            DropIndex("dbo.DiamondTableMeasurements", new[] { "PartSingleDiamond_SingleDiamondPartID" });
            DropIndex("dbo.DiamondTableMeasurements", new[] { "DiamondMeasurement_DiamondMesurementsID" });
            DropIndex("dbo.DiamondDiameterMeasurements", new[] { "DiamondMeasurement_DiamondMesurementsID" });
            DropIndex("dbo.CustomerSpecialDates", new[] { "CustomerID" });
            DropIndex("dbo.Customers", new[] { "PersonID" });
            DropIndex("dbo.VendorContacts", new[] { "PersonID" });
            DropIndex("dbo.VendorContacts", new[] { "VendorID" });
            DropIndex("dbo.Parts", new[] { "PartTypeID" });
            DropIndex("dbo.Parts", new[] { "ItemID" });
            DropIndex("dbo.Items", new[] { "Customer_CustomerID" });
            DropIndex("dbo.Items", new[] { "Vendor_VendorID" });
            DropIndex("dbo.Vendors", new[] { "Address_AddressID" });
            DropIndex("dbo.PhoneNumbers", new[] { "PersonID" });
            DropIndex("dbo.Images", new[] { "PersonID" });
            DropIndex("dbo.EmailAddresses", new[] { "PersonID" });
            DropIndex("dbo.People", new[] { "Address_AddressID" });
            DropIndex("dbo.Addresses", new[] { "Vendor_VendorID" });
            DropIndex("dbo.Addresses", new[] { "Person_PersonID" });
            DropIndex("dbo.Addresses", new[] { "AddressType" });
            DropTable("dbo.PartSingleDiamonds");
            DropTable("dbo.RoundGemWidths");
            DropTable("dbo.PartMetals");
            DropTable("dbo.PartGems");
            DropTable("dbo.PartDiamonds");
            DropTable("dbo.Notes");
            DropTable("dbo.MetalTypes");
            DropTable("dbo.MetalFinishes");
            DropTable("dbo.LaborTypes");
            DropTable("dbo.Repairs");
            DropTable("dbo.ItemRepairs");
            DropTable("dbo.ItemInventories");
            DropTable("dbo.GemStoneTypes");
            DropTable("dbo.GemStoneLocations");
            DropTable("dbo.GemShapes");
            DropTable("dbo.GemShapeMeasurements");
            DropTable("dbo.GemDiameterMeasurements");
            DropTable("dbo.Employees");
            DropTable("dbo.DiamondShapes");
            DropTable("dbo.DiamondTableMeasurements");
            DropTable("dbo.DiamondMeasurements");
            DropTable("dbo.DiamondDiameterMeasurements");
            DropTable("dbo.CustomerSpecialDates");
            DropTable("dbo.Customers");
            DropTable("dbo.VendorContacts");
            DropTable("dbo.PartTypes");
            DropTable("dbo.Parts");
            DropTable("dbo.Items");
            DropTable("dbo.Vendors");
            DropTable("dbo.PhoneNumbers");
            DropTable("dbo.Images");
            DropTable("dbo.EmailAddresses");
            DropTable("dbo.People");
            DropTable("dbo.Addresses");
        }
    }
}
