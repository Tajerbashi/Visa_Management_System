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
        //  Public Keys
        public int PublicKey(String Key)
        {
            if (Key == "TAJERBASHI1")
            {
                return 1;
            }
            else if (Key == "TAJERBASHI2")
            {
                return 2;
            }
            return 0;
        }

        // Login Code Admin
        public int LoginCodeAdmin(String Access, String UserName, String Password)
        {
            foreach (var item in db.aAdmins)
            {
                if (item.accessCode == Access && item.Username == UserName && item.Password == Password)
                {
                    return 1;
                }
            }
            foreach (var item in db.bAdmins)
            {
                if (item.accessCode == Access && item.Username == UserName && item.Password == Password)
                {
                    return 2;
                }
            }
            return 0;
        }



        // Owner Code Function
        public void CreateOwner(OWNER owner)
        {   // اگر لایه هارا رد کرده باشد و وجود نداشته باشد ذخیره کند
            db.Owner.Add(owner);
            db.SaveChanges();
        }
        public bool SelectOwnerStatus(OWNER owner)
        {   // اگر وجود دارد هنگام اولین ورود دوباره ایجاد نکند
            foreach (var item in db.Owner)
            {
                if(item.access==owner.access && item.password==owner.password )
                {
                    return true;
                }
            }
            return false;
        }
        public int SelectOwnerStatusAccess(OWNER owner,String AdminName)
        {   //  وضعیت سطح دسترسی مالک کنترل میکند که اگر فعال باشد اجازه ثبت نام را میدهد
            foreach (var item in db.Owner)
            {
                if (item.access==AdminName && item.access == owner.access && item.password == owner.password && item.Status)
                {
                    return item.id;
                }
            }
            return 0;
        }
        public OWNER SelectOwner(String Name)
        {   //  مالک که با آن وارد شدید را انتخاب میکند و برمیگرداند برای انجام عملیات غیر فعال کردن
            return (db.Owner.Where(c => c.access == Name).FirstOrDefault());
        }
        public void ChangeStatusOwner(OWNER owner)
        {
            owner.Status = false;
            db.SaveChanges();
        }
        public bool OwmerAccessKey(String Key)
        {
            foreach(var item in db.Owner)
            {
                if((item.access == Key && item.Status) || Key == "TAJERBASHI" )
                {
                    return true;
                }
            }
            return false;
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
        public int AdminKey(String Key,String ADMINNAME)
        {
            foreach (var item in db.aAdmins)
            {
                if (item.Username == ADMINNAME && item.accessCode == Key && item.IsActive && !item.DeleteStatus)
                {
                    return 1;
                }
            }
            foreach (var item in db.bAdmins)
            {
                if (item.Username == ADMINNAME && item.accessCode == Key && item.IsActive && !item.DeleteStatus)
                {
                    return 2;
                }
            }
            return 0;
        }
        public List<AAdmin> readadminA()
        {
            return (from i in db.aAdmins where i.DeleteStatus == false select i).ToList();
        }
        public List<BAdmin> readadminB()
        {
            return (from i in db.bAdmins where i.DeleteStatus == false select i).ToList();
        }

        public void ChangeStatusAdminA(AAdmin admin)
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
        public void ChangeStatusAdminB(BAdmin admin)
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

        public void SAVEDB()
        {
            db.SaveChanges();
        }

        public String GetPassA(AAdmin adminA,BAdmin adminb)
        {
            foreach (var item in db.aAdmins)
            {
                if (item.Username == adminA.Username && item.accessCode == adminA.accessCode && item.Phone == adminA.Phone)
                {
                    return item.Password;
                }
            }
            foreach (var item in db.bAdmins)
            {
                if (item.Username == adminb.Username && item.accessCode == adminb.accessCode && item.Phone == adminb.Phone)
                {
                    return item.Password;
                }
            }

            return "0";
        }

        public List<AAdminBankAccount> ReadBankAccountA()
        {
            return (from i in db.aAdminBankAccounts where !i.DeleteStatus select i).ToList();
        }
        public List<BAdminBankAccount> ReadBankAccountB()
        {
            return (from i in db.bAdminBankAccounts where !i.DeleteStatus select i).ToList();
        }

        public void CreateAdminBankAccountA(AAdminBankAccount adminbank)
        {
            db.aAdminBankAccounts.Add(adminbank);
            db.SaveChanges();
        }
        public void CreateAdminBankAccountB(BAdminBankAccount adminbank)
        {
            db.bAdminBankAccounts.Add(adminbank);
            db.SaveChanges();
        }

        public AAdminBankAccount SelectAdminBankAccountA(int ID)
        {
            return (db.aAdminBankAccounts.Where(c => c.id == ID).FirstOrDefault());
        }
        public BAdminBankAccount SelectAdminBankAccountB(int ID)
        {
            return (db.bAdminBankAccounts.Where(c => c.id == ID).FirstOrDefault());
        }

        public void DeleteAdminBankAccountA(int ID)
        {
            AAdminBankAccount adminbank = db.aAdminBankAccounts.Where(c => c.id == ID).FirstOrDefault();
            adminbank.DeleteStatus = true;
            db.SaveChanges();
        }
        public void DeleteAdminBankAccountB(int ID)
        {
            BAdminBankAccount adminbank = db.bAdminBankAccounts.Where(c => c.id == ID).FirstOrDefault();
            adminbank.DeleteStatus = true;
            db.SaveChanges();
        }

        public bool ExistAdminBankA(AAdminBankAccount adminbank)
        {
            foreach (var item in db.aAdminBankAccounts)
            {
                if (item.id != adminbank.id && item.OwnerName == adminbank.OwnerName && item.AccountNumber == adminbank.AccountNumber)
                {
                    return true;
                }
            }
            return false;
        }
        public bool ExistAdminBankB(BAdminBankAccount adminbank)
        {
            foreach (var item in db.bAdminBankAccounts)
            {
                if (item.id != adminbank.id && item.OwnerName == adminbank.OwnerName && item.AccountNumber == adminbank.AccountNumber)
                {
                    return true;
                }
            }
            return false;
        }

        public void SaveEditAdminBankAccountA(AAdminBankAccount adminbank)
        {
            adminbank.DeleteStatus = false;
            db.SaveChanges();
        }
        public void SaveEditAdminBankAccountB(BAdminBankAccount adminbank)
        {
            adminbank.DeleteStatus = false;
            db.SaveChanges();
        }

        public bool SelectAdminA(AAdmin admin)
        {
            foreach(var i in db.aAdmins)
            {
                if(i.id != admin.id && i.Name==admin.Name && i.Family == admin.Family)
                {
                    return true;
                }
            }
            db.SaveChanges();
            return false;
        }
        public bool SelectAdminB(BAdmin admin)
        {
            foreach (var i in db.bAdmins)
            {
                if (i.id != admin.id && i.Name == admin.Name && i.Family == admin.Family)
                {
                    return true;
                }
            }
            db.SaveChanges();
            return false;
        }

        public AAdmin SelectAdminAccountA(int ID)
        {
            return (db.aAdmins.Where(c => c.id == ID).FirstOrDefault());
        }
        public BAdmin SelectAdminAccountB(int ID)
        {
            return (db.bAdmins.Where(c => c.id == ID).FirstOrDefault());
        }

    }
}
