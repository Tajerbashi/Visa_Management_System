using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEE;
using DAL;

namespace BLL
{
    public class BLLCode
    {
        DBCLASS DB = new DBCLASS();
        DALCODE dlc = new DALCODE();

        #region OWNER
        public int PublicKey(String Key)
        {   //  کلید کلی برای باز کردن فرم
            return (dlc.PublicKey(Key));
        }
        public bool CreateNewOwner(OWNER owner)
        {   // برای ساخت مالک در اولین اجرا برنامه میباشد وبعد از آن کاربردی ندارد
            if (!dlc.SelectOwnerStatus(owner))
            {
                dlc.CreateOwner(owner);
                return true;
            }
            return false;
        }
        public int CheckAccessOwner(OWNER owner,String AdminName)
        {   //  کنترل دسترسی میباشد اگر کلید وارد شود اجازه ورود بدهد
            //  اگر وضعیت کامل فعال بود ثبت نام و ورود انجام شود
            return (dlc.SelectOwnerStatusAccess(owner, AdminName));
        }
        public OWNER SelectOwner(String Name)
        {
            return (dlc.SelectOwner(Name));
        }
        public void ChangeOwnerStatus(OWNER owner)
        {   // وضعیت مالک تغییر میدهد و غیر فعال میکند
            dlc.ChangeStatusOwner(owner);
        }
        public bool OwnerKey(String Key)
        {
            return (dlc.OwmerAccessKey(Key));
        }
        #endregion
        // Login Load Code
        #region LogForm
        public void ALoginfor(ALogInformation log)
        {
            dlc.ALoginfor(log);
        }
        public void BLoginfor(BLogInformation log)
        {
            dlc.BLoginfor(log);
        }
        public List<ALogInformation> aLogInformation()
        {
            return (from i in DB.aLogInformation select i).ToList();
        }
        public List<BLogInformation> bLogInformation()
        {
            return (from i in DB.bLogInformation select i).ToList();
        }
        public int LoginCodeAdmin(String Access, String UserName, String Password)
        {
            return (dlc.LoginCodeAdmin(Access, UserName, Password));
        }
        #endregion
        // Admin Log Form
        #region LogSearch
        public List<ALogInformation> LogSearchEnterA(String Word)
        {
            return (from i in DB.aLogInformation where Word.Contains(i.Enter) select i).ToList();
        }
        public List<BLogInformation> LogSearchEnterB(String Word)
        {
            return (from i in DB.bLogInformation where Word.Contains(i.Enter) select i).ToList();
        }
        #endregion
        // Control Account
        #region Control

        public int AdminKey(String Key,String ADMINNAME)
        {
            return (dlc.AdminKey(Key, ADMINNAME));
        }

        public List<AAdmin> ReadAdminA()
        {
            return (dlc.readadminA().ToList());
        }
        public List<BAdmin> ReadAdminB()
        {
            return (dlc.readadminB().ToList());
        }

        public String FullNameA(int id)
        {
            foreach (var item in DB.aAdmins)
            {
                if (item.id == id)
                {
                    return (item.Name + " " + item.Family);
                }
            }
            return "";
        }
        public String FullNameB(int id)
        {
            foreach (var item in DB.bAdmins)
            {
                if (item.id == id)
                {
                    return (item.Name + " " + item.Family);
                }
            }
            return "";
        }

        public void ChangeStatusAdminA(int ID)
        {
            dlc.ChangeStatusAdminA(ID);
        }
        public void ChangeStatusAdminB(int ID)
        {
            dlc.ChangeStatusAdminB(ID);
        }

        public List<AAdmin> ShowSearchResultA(String AdminNumber, String Word)
        {
            return (dlc.ShowSearchResultA(AdminNumber, Word)).ToList();
        }
        public List<BAdmin> ShowSearchResultB(String AdminNumber, String Word)
        {
            return (dlc.ShowSearchResultB(AdminNumber, Word)).ToList();
        }

        public void DeleteAdminA(int ID)
        {
            dlc.DeleteAdminA(ID);
        }
        public void DeleteAdminB(int ID)
        {
            dlc.DeleteAdminB(ID);
        }

        public List<AAdmin> ShowAllAdminDataA()
        {
            return (dlc.ShowAllAdminDataA()).ToList();
        }
        public List<BAdmin> ShowAllAdminDataB()
        {
            return (dlc.ShowAllAdminDataB()).ToList();
        }

        public List<AAdmin> ShowActiveDataA()
        {
            return (from i in DB.aAdmins where !i.DeleteStatus && i.IsActive select i).ToList();
        }
        public List<BAdmin> ShowActiveDataB()
        {
            return (from i in DB.bAdmins where !i.DeleteStatus && i.IsActive select i).ToList();
        }
        
        public bool SelectAdminA(AAdmin admin)
        {
            return (dlc.SelectAdminA(admin));
        }
        public bool SelectAdminB(BAdmin admin)
        {
            return (dlc.SelectAdminB(admin));
        }

        public bool RegisterAdminA(AAdmin admin)
        {
            foreach (var item in DB.aAdmins)
            {
                if (item.Name == admin.Name && item.Family == admin.Family)
                {
                    return false;
                }
            }
            dlc.RegisterAdminA(admin);
            return true;
        }
        public bool RegisterAdminB(BAdmin admin)
        {
            foreach (var item in DB.bAdmins)
            {
                if (item.Name == admin.Name && item.Family == admin.Family)
                {
                    return false;
                }
            }
            dlc.RegisterAdminB(admin);
            return true;
        }

        public AAdmin EditAdminA(int ID)
        {
            return (dlc.SelectAdminAccountA(ID));
        }
        public BAdmin EditAdminB(int ID)
        {
            return (dlc.SelectAdminAccountB(ID));
        }

        #endregion
        // Company Form
        #region Company
        public bool CreatCompanyA(ACompany company)
        {
            foreach (var item in DB.aCompanies)
            {
                if (company.CompanyName == item.CompanyName && company.CompanyManager == item.CompanyManager)
                {
                    return true;
                }
            }
            dlc.CreateCompanyA(company);
            return false;
        }
        public bool CreatCompanyB(BCompany company)
        {
            foreach (var item in DB.bCompanies)
            {
                if (company.CompanyName == item.CompanyName && company.CompanyManager == item.CompanyManager)
                {
                    return true;
                }
            }
            dlc.CreateCompanyB(company);
            return false;
        }
        #endregion
        //  Product Control Form
        #region Product
        public List<AProduct> ShowAllProductA()
        {
            return (from i in DB.aProducts where !i.DeleteStatus select i).ToList();
        }
        public List<BProduct> ShowAllProductB()
        {
            return (from i in DB.bProducts where !i.DeleteStatus select i).ToList();
        }

        public List<ATypeProduct> ATypes()
        {
            return (from i in DB.atypeProducts select i).ToList();
        }
        public List<BTypeProduct> BTypes()
        {
            return (from i in DB.btypeProducts select i).ToList();
        }


        public List<AAgent> AgentA()
        {
            return (from i in DB.aAgents select i).ToList();
        }
        public List<BAgent> AgentB()
        {
            return (from i in DB.bAgents select i).ToList();
        }


        public List<AProduct> ProductA(int ID)
        {
            return (from i in DB.aProducts where i.id == ID select i).ToList();
        }
        public List<BProduct> ProductB(int ID)
        {
            return (from i in DB.bProducts where i.id == ID select i).ToList();
        }

        public bool CreateProductA(AProduct product)
        {
            foreach (var item in DB.aProducts)
            {
                if (item.Name == product.Name && item.Type == product.Type)
                {
                    return true;
                }
            }
            dlc.CreateProductA(product);
            return false;
        }
        public bool CreateProductB(BProduct product)
        {
            foreach (var item in DB.bProducts)
            {
                if (item.Name == product.Name && item.Type == product.Type)
                {
                    return true;
                }
            }
            dlc.CreateProductB(product);
            return false;
        }

        public bool ExistProductA(int ID, AProduct product)
        {
            foreach (var item in DB.aProducts)
            {
                if (item.id != ID && item.Name == product.Name && item.Type == product.Type)
                {
                    return true;
                }
            }
            return false;
        }
        public bool ExistProductB(int ID, BProduct product)
        {
            foreach (var item in DB.bProducts)
            {
                if (item.id != ID && item.Name == product.Name && item.Type == product.Type)
                {
                    return true;
                }
            }
            return false;
        }

        public AProduct ProductEditA(int ID)
        {
            AProduct product = DB.aProducts.Where(c => c.id == ID).First();
            if (!ExistProductA(ID, product))
            {
                dlc.EditProductA(product);
            }
            return product;
        }
        public BProduct ProductEditB(int ID)
        {
            BProduct product= DB.bProducts.Where(c => c.id == ID).First();
            if (!ExistProductB(ID, product))
            {
                dlc.EditProductB(product);
            }
            return product;
        }

        public void DeleteProductA(int ID)
        {
            AProduct product = DB.aProducts.Where(c => c.id == ID).First();
            dlc.DeleteProductA(product);
        }
        public void DeleteProductB(int ID)
        {
            BProduct product = DB.bProducts.Where(c => c.id == ID).First();
            dlc.DeleteProductB(product);
        }
        
        public void SAVEDB()
        {
            dlc.SAVEDB();
        }
        #endregion
        //  Admin Control Register Form
        #region AdminControl
        public bool ExistAdminA(AAdmin admin)
        {
            foreach (var item in DB.aAdmins)
            {
                if (item.Name == admin.Name && item.Family == admin.Family && item.OwnerName == admin.OwnerName)
                {
                    return true;
                }
            }
            return false;
        }
        public bool ExistAdminB(BAdmin admin)
        {
            foreach (var item in DB.bAdmins)
            {
                if (item.Name == admin.Name && item.Family == admin.Family && item.OwnerName == admin.OwnerName)
                {
                    return true;
                }
            }
            return false;
        }
        public String ResetAdminPassword(AAdmin adminA,BAdmin adminB)
        {
            return (dlc.GetPassA(adminA, adminB));
        }
        // AdminAccount Bank Form
        public List<AAdminBankAccount> ReadAdminbankA()
        {
            return (dlc.ReadBankAccountA().ToList());
        }
        public List<BAdminBankAccount> ReadAdminbankB()
        {
            return (dlc.ReadBankAccountB().ToList());
        }

        public bool CreateAdminBankA(AAdminBankAccount adminbank)
        {
            foreach (var item in DB.aAdminBankAccounts)
            {
                if (item.NameBank == adminbank.NameBank && item.AccountNumber == adminbank.AccountNumber)
                {
                    return false;
                }
            }
            dlc.CreateAdminBankAccountA(adminbank);
            return true;
        }
        public bool CreateAdminBankB(BAdminBankAccount adminbank)
        {
            foreach (var item in DB.bAdminBankAccounts)
            {
                if (item.NameBank == adminbank.NameBank && item.AccountNumber == adminbank.AccountNumber)
                {
                    return true;
                }
            }
            dlc.CreateAdminBankAccountB(adminbank);
            return false;
        }

        public AAdminBankAccount adminbankacountA(int ID)
        {
            return (dlc.SelectAdminBankAccountA(ID));
        }
        public BAdminBankAccount adminbankacountB(int ID)
        {
            return (dlc.SelectAdminBankAccountB(ID));
        }

        public void DeleteBankAccountA(int ID)
        {
            dlc.DeleteAdminBankAccountA(ID);
        }
        public void DeleteBankAccountB(int ID)
        {
            dlc.DeleteAdminBankAccountB(ID);
        }

        public AAdminBankAccount SelectAdminBankAccountA(int ID)
        {
            return (dlc.SelectAdminBankAccountA(ID));
        }
        public BAdminBankAccount SelectAdminBankAccountB(int ID)
        {
            return (dlc.SelectAdminBankAccountB(ID));
        }

        public void ExistAdminBankA(AAdminBankAccount AdminBank)
        {
            if (!dlc.ExistAdminBankA(AdminBank))
            {
                dlc.SaveEditAdminBankAccountA(AdminBank);
            }
        }
        public void ExistAdminBankB(BAdminBankAccount AdminBank)
        {
            if (!dlc.ExistAdminBankB(AdminBank))
            {
                dlc.SaveEditAdminBankAccountB(AdminBank);
            }
        }

        #endregion

    }
}
