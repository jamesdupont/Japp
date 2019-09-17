namespace Models
{
    using System.Data.Entity;
    using GemStones;
    using Metals;
    //using Diamond;

    public class AlphaContext : DbContext
    {
        // Your context has been configured to use a 'alphaContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Models.alphaContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'alphaContext' 
        // connection string in the application configuration file.
        public AlphaContext()
            : base("name=alphaContext")
        {

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Person> People { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Vendor> Vendors { get; set; }


        public virtual DbSet<Employee> Employees { get; set; }
        //TODO: InventoryItmes
        public virtual DbSet<ItemInventory> ItemInventorys { get; set; }

        public virtual DbSet<Item> Items { get; set; }

        public virtual DbSet<VendorContact> VendorContacts { get; set; }

        public virtual DbSet<CustomerSpecialDate> CustomerSpecialDates { get; set; }

        public virtual DbSet<EmailAddress> EmailAddressess { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }

        public virtual DbSet<Note> Notes { get; set; }

        public virtual DbSet<Part> Parts { get; set; }

        public virtual DbSet<PartGem> PartGems { get; set; }

        public virtual DbSet<PartMetal> PartMetals { get; set; }

        public virtual DbSet<PartDiamond> PartDiamonds { get; set; }      
        public virtual DbSet<Repair> Repairs { get; set; }
        public virtual DbSet<ItemRepair> ItemRepairs { get; set; }

        public virtual DbSet<Image> Images { get; set; }

        public virtual DbSet<RoundGemWidth> RoundGemWidths { get; set; }

        public virtual DbSet<PartSingleDiamond> SingleDiamondParts { get; set; }

        public virtual DbSet<Diamond.DiamondMeasurement> DiamondMeasurements { get; set; }
        public virtual DbSet<Diamond.DiamondDiameterMeasurement> DiamondDiameterMeasurements { get; set; }
        public virtual DbSet<Diamond.DiamondTableMeasurement> DiamondTableMesurements { get; set; }
        public virtual DbSet<Diamond.DiamondShape> DiamondShapes { get; set; }
        public virtual DbSet<GemStoneType> Gemstones { get; set; }

        public virtual DbSet<GemShape> GemShapes { get; set; }

        public virtual DbSet<GemShapeMeasurements> GemShapeMeasurements { get; set; }

        public virtual DbSet<GemDiameterMeasurement> GemDiameterMeasurements { get; set; }
        public virtual DbSet<GemStoneLocation> GemStoneLocations { get; set; }

        public virtual DbSet<MetalType> MetalTypes { get; set; }

        public virtual DbSet<PartType> PartTypes { get; set; }
        public virtual DbSet<MetalFinish> MetalFinish { get; set; }

        public virtual DbSet<LaborType> LaborPart { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new baseEntityConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new Customer.CustomercConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new Image.ImageConfiguration());
        }

    }
}