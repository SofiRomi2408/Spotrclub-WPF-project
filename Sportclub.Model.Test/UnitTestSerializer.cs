using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sportclub.Model.Serialization;
using System;
using System.Collections.Generic;

namespace Sportclub.Model.Test
{
    [TestClass]
    public class UnitTestSerializer
    {
        [TestMethod]
        public void TestMethodSerialize()
        {
            var model = new DataModel();
            model.Clients = new List<Client>() {
            new Client
    {
            ClientID = 1,
            FirstName = "John",
            LastName = "Doe",
            DateOfBirth = new DateTime(1990, 5, 24),
            PhoneNumber = "123-456-7890",
            Email = "john.doe@example.com"
    }

            };
           

            DataSerializer.SerializeData(@"C:\Users\User\Desktop\5_sem_Univer_Romaniv\KPZ_labs_Romaniv\Sportclub\sportclub.dat", model);

        }

        [TestMethod]
        public void TestMethodDeSerialize()
        {
            var model = DataSerializer.DeserializeItem(@"C:\Users\User\Desktop\5_sem_Univer_Romaniv\KPZ_labs_Romaniv\Sportclub\sportclub.dat");
        }
    }
}
