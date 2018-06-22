using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using GemStones;
using Diamond;

namespace Models
{
    public class TestData
    {
        private alphaContext context = new Models.alphaContext();
        public static List<Person> GetPerson()
        {
            List<Person> PersonList = new List<Person>();
            PersonList.Add(new Person { PersonID = 1, PersonType = "Customer", FirstName = "James", LastName = "Beaver", });
            PersonList.Add(new Person { PersonID = 2, PersonType = "Customer", FirstName = "Seth", LastName = "Dupont" });
            PersonList.Add(new Person { PersonID = 3, PersonType = "Customer", FirstName = "Anna", LastName = "Persavil" });
            PersonList.Add(new Person { PersonID = 4, PersonType = "Vendor Contact", FirstName = "Raymond", LastName = "Morris" });

            return PersonList;
        }

        public static List<Customer> GetCustomers(List<Person> People)
        {
            using (Models.alphaContext context = new Models.alphaContext())
            {
                List<Customer> PersonList = new List<Customer>();
                var returnValue = new List<Customer>();
                returnValue.Add(new Customer { CustomerID = 1, IsActive = true, PersonID = context.People.Single(i => i.LastName == "Beaver").PersonID });
                returnValue.Add(new Customer { CustomerID = 2, IsActive = true, PersonID = context.People.Single(i => i.LastName == "Dupont").PersonID });
                returnValue.Add(new Customer { CustomerID = 2, IsActive = true, PersonID = context.People.Single(i => i.LastName == "Persavil").PersonID });

                return returnValue;
            }
        }
        public static List<Vendor> GetVendor()
        {
            //List<Vendor> PersonList = new List<Vendor>();
            var returnValue = new List<Vendor>();
            returnValue.Add(new Vendor { VendorID = 1, VendorName = "Stuller", WebSite = "www.Stuller.com" });

            return returnValue;
        }

        public static List<VendorContact> GetVendorContact()
        {
            using (Models.alphaContext context = new Models.alphaContext())
            {
                //List<VendorContact> PersonList = new List<VendorContact>();
                var returnValue = new List<VendorContact>();
                returnValue.Add(new VendorContact
                {
                    VendorContactID = 1,
                    VendorID = 1,
                    PersonID = context.People.Single(i => i.LastName == "Morris").PersonID,
                    VendorContactType = "Sales Person"
                });

                return returnValue;
            }

        }

        public static List<CustomerSpecialDate> GetCustomerSpecialDates()
        {
            var returnValue = new List<CustomerSpecialDate>();
            returnValue.Add(new CustomerSpecialDate
            {
                CustomerID = 1,
                SpecialDateDateType = "Aniversary",
                SpecialDateID = 1,
                TheDate = new DateTime(1984, 3, 31)
            });
            returnValue.Add(new CustomerSpecialDate
            {
                CustomerID = 1,
                SpecialDateDateType = "Birthday",
                SpecialDateID = 2,
                TheDate = new DateTime(1960, 2, 10)
            }
            );
            return returnValue;
        }


        public static List<Address> GetAddressList()
        {
            List<Address> returnValue = new List<Address>();

            using (Models.alphaContext context = new Models.alphaContext())
            {
                returnValue.Add(new Address
                {
                    PersonID = context.People.Single(i => i.LastName == "Beaver").PersonID,
                    AddressID = 1,
                    AddressType = "Home",
                    Add1 = "SomeWhere",
                    Add2 = "",
                    City = "San Antonio",
                    State = "TX",
                    PostalCode = "33033",
                    Country = "USA"
                });
                returnValue.Add(new Address
                {
                    PersonID = context.People.Single(i => i.LastName == "Morris").PersonID,
                    AddressID = 2,
                    AddressType = "Shipping",
                    Add1 = "AnyWhere",
                    Add2 = "",
                    City = "San Antonio",
                    State = "TX",
                    PostalCode = "33033",
                    Country = "USA"
                });
                return returnValue;
            }
        }
        public static List<EmailAddress> GetEmailAddressList()
        {
            using (alphaContext context = new alphaContext())
            {
                List<EmailAddress> returnValue = new List<EmailAddress>();

                returnValue.Add(new EmailAddress
                {
                    EmailAddressID = 1,
                    PersonID = context.People.Single(i => i.LastName == "Dupont").PersonID,
                    Addresstype = "Work",
                    ThAddress = "someone@somewhere.com"
                });
                returnValue.Add(new EmailAddress
                {
                    EmailAddressID = 2,
                    PersonID = context.People.Single(i => i.LastName == "Morris").PersonID,
                    Addresstype = "Work",
                    ThAddress = "someone@somewhere.com"
                });

                return returnValue;
            }
        }

        public static List<Item> GetItems()
        {
            List<Item> retrunValue = new List<Item>();

            using (alphaContext context = new alphaContext())
            {
                retrunValue.Add(new Item
                {
                    ItemType = "Repair",
                    Description = "Item Description",
                    ItemID = 1
                }
                );
            }
            return retrunValue;
        }


        public static List<Repair> GetRepairsList()
        {
            List<Repair> retrunValue = new List<Repair>();

            using (alphaContext context = new alphaContext())
            {
                retrunValue.Add(new Repair
                {
                    RepairID = 1,
                    CustomerID = 1,                    
                    TakeInDate = DateTime.Today,
                    PromiseDate = DateTime.Today.AddDays(3),
                });
                return retrunValue;
            }
        }

      
    public static List<ItemRepair> GetRepairItems()
    {
        List<ItemRepair> retrunValue = new List<ItemRepair>();

        using (alphaContext context = new alphaContext())
        {

            retrunValue.Add(new ItemRepair {
                CompletionDate = DateTime.Now,
                Instruction = "Size 10",
                EstimatedValue = 300.00m,
                PickupDate = DateTime.Now,
                ItemID = 3,
                RepairID = 6               
            });
            return retrunValue;
        } }

        #region Parts
        public static List<Part> GetParts()
        {
            List<Part> retrunValue = new List<Part>();
            retrunValue.Add(new Part
            {
                PartTypeID  = 1,
                Quantity = 14,
                Description = "My Description",
                Cost = 25.00m,
                ItemID = 3,
                PartID = 1
            });
            retrunValue.Add(new Part
            {
                PartTypeID =2,
                Quantity = 14,
                Description = "Amethyst",
                Cost = 300.00m,
                ItemID = 3,
                PartID = 2
            });


            return retrunValue;

        }

        public static List<PartMetal> GetMetalParts()
        {
            List<PartMetal> retrunValue = new List<PartMetal>();
            retrunValue.Add(new PartMetal
            {
                MetalFinishID = 1,
                PartID = 2,
                IsStamped = true,
                MetalTypeID = 1,
                PartMetalID = 1,
                Weight = 3.2m
            });
            //retrunValue.Add(new PartMetal
            //{
            //    MetalFinishID = 1,
            //    PartID = 2,
            //    IsStamped = false,
            //    MetalTypeID = 1,
            //    PartMetalID = 2,
            //    Weight = 4.2m
            //});

            return retrunValue;

        }

        public static  void  GetGemParts(Models.alphaContext context)
        {

            var Part = new PartGem
            {
                PartID = 3,
                ActualWeight = .90m,
                PartGemID = 1,
                Color = "Green",
                GemStoneTypeID = 1, //Amethys
                GemShapeID = 1, //Round 
                IsEstWeight = true,
                IsSynthetic = false,
                PricePerCarat = 50,
                PricePerStone = 2,
                Weight = .55m,
                Finish = "Good"
                
            };
                //GemShapeMeasurements = ShapeMeasurements

    
            context.PartGems.Add(Part);

            context.SaveChanges();


            var ShapeMeasurements = new GemShapeMeasurements { PartGemID = Part.PartGemID, Depth = 3m };

            context.GemShapeMeasurements.Add(ShapeMeasurements);

            context.SaveChanges();

            List<GemDiameterMeasurement> DiameterList = new List<GemDiameterMeasurement>();

            DiameterList.Add(new GemDiameterMeasurement {GemShapeMesurementsID = ShapeMeasurements.GemShapeMesurementsID, Diameter = 5 });
            DiameterList.Add(new GemDiameterMeasurement { GemShapeMesurementsID = ShapeMeasurements.GemShapeMesurementsID, Diameter = 5.2m });

            context.GemDiameterMeasurements.AddRange(DiameterList);

            context.SaveChanges();
        
        }
        public static void AddDiamondPart(alphaContext context)
        {
            int count = context.PartDiamonds.Count();
            if (count == 0)
            {
                PartDiamond DiamondPart =
                    new PartDiamond
                    {
                        PartDiamondID = 1,
                        DiamondShapeID = 1, //Round
                        LowerClarityGrade = "VS2",
                        TopClarityGrade = "VS1",
                        LowerColorGrade = "J",
                        TopColorGrade = "H",
                        PricePerCarat = 1000.00m,
                        DiamondMeasurement = new DiamondMeasurement
                        {
                            DiamondMesurementsID = 1,
                            Depth = 3.52m,
                            DiamondDiameterMeasurements = new List<DiamondDiameterMeasurement>
                                    { new DiamondDiameterMeasurement { Diameter = 5m },
                                        new DiamondDiameterMeasurement {Diameter = 5.1m},
                                        new DiamondDiameterMeasurement {Diameter = 5.22m},
                                        new DiamondDiameterMeasurement {Diameter = 5.13m}
                                    },
                            DiamondTableMeasurements = new List<DiamondTableMeasurement>
                               {
                                   new DiamondTableMeasurement
                                   {
                                       DiamondMesurementID = 1,
                                       DiamondTableMeasurementsID = 1,
                                       TableMeasurement = 4m
                                   },
                                   new DiamondTableMeasurement
                                   {
                                       DiamondMesurementID = 1,
                                       DiamondTableMeasurementsID = 2,
                                       TableMeasurement = 4.3m
                                   }
                               }
                        }
                    };
                    

                context.DiamondShapes.AddRange(Diamond.DiamondData.CreateDiamondShapeList());
            }

            context.SaveChanges();
        }


        #endregion Parts
    }
}


  


