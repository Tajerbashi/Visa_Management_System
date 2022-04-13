using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using BEE;


namespace DAL
{
    public class DALCODE
    {
        BEE.DBCLASS db = new DBCLASS();
        
        // Owner Code Function
        public void CreateOwner(OWNER owner)
        {
            db.Owner.Add(owner);
            db.SaveChanges();
        }
        // Company Code Function
        public void CreateCompanyA(ACompany company)
        {
            db.aCompanies.Add(company);
            db.SaveChanges();
        }
        public void CreateCompanyB(BCompany company)
        {
            db.bCompanies.Add(company);
            db.SaveChanges();
        }
        // Log Information
        public void ALoginfor(ALogInformation log)
        {
            db.aLogInformation.Add(log);
            db.SaveChanges();
        }
        public void BLoginfor(BLogInformation log)
        {
            db.bLogInformation.Add(log);
            db.SaveChanges();
        }
        // Control Account
        public List<AAdmin> readadminA()
        {
            return (from i in db.aAdmins where i.DeleteStatus == false select i).ToList();
        }
        public List<BAdmin> readadminB()
        {
            return (from i in db.bAdmins where i.DeleteStatus == false select i).ToList();
        }

        public void ChangeStatusA(AAdmin admin)
        {
            if (admin.IsActive == true)
            {
                admin.IsActive = false;
            }
            else
            {
                admin.IsActive = true;
            }
            db.SaveChanges();
        }
        public void ChangeStatusB(BAdmin admin)
        {
            if (admin.IsActive == true)
            {
                admin.IsActive = false;
            }
            else
            {
                admin.IsActive = true;
            }
            db.SaveChanges();
        }

        public void DeleteAdminA(AAdmin admin)
        {
            admin.DeleteStatus = true;
            db.SaveChanges();
        }
        public void DeleteAdminB(BAdmin admin)
        {
            admin.DeleteStatus = true;
            db.SaveChanges();
        }


        public void RegisterAdminA(AAdmin admin)
        {
            db.aAdmins.Add(admin);
            db.SaveChanges();
        }
        public void RegisterAdminB(BAdmin admin)
        {
            db.bAdmins.Add(admin);
            db.SaveChanges();
        }

        
        public void CreateProductA(AProduct product)
        {
            db.aProducts.Add(product);
            db.SaveChanges();
        }
        public void CreateProductB(BProduct product)
        {
            db.bProducts.Add(product);
            db.SaveChanges();
        }

        public void EditProductA(AProduct product)
        {
            db.SaveChanges();
        }
        public void EditProductB(BProduct product)
        {
            db.SaveChanges();
        }

        public void DeleteProductA(AProduct product)
        {
            product.DeleteStatus = true;
            db.SaveChanges();
        }
        public void DeleteProductB(BProduct product)
        {
            product.DeleteStatus = true;
            db.SaveChanges();
        }
    }
}
