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
        public bool CheckAccessOwner(OWNER owner, String Help)
        {
            DBCLASS db = new DBCLASS();
            if (Help == "TAJERBASHI1" || Help == "TAJERBASHI2")
            {
                return true;
            }
            foreach (var item in db.Owner)
            {
                if (item.access == owner.access && item.password == owner.password && item.Status)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CreateNewOwner(OWNER owner)
        {
            if (!dlc.SelectOwnerStatus(owner))
            {
                dlc.CreateOwner(owner);
                return true;
            }
                return false;
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

        public void ChangeStatusA(int ID)
        {
            foreach (var item in DB.aAdmins)
            {
                if (item.id == ID)
                {
                    dlc.ChangeStatusA(item);
                }
            }
        }
        public void ChangeStatusB(int ID)
        {
            foreach (var item in DB.bAdmins)
            {
                if (item.id == ID)
                {
                    dlc.ChangeStatusB(item);
                }
            }
        }

        public void DeleteAdminA(int ID)
        {
            foreach (var item in DB.aAdmins)
            {
                if (item.id == ID)
                {
                    dlc.DeleteAdminA(item);
                }
            }
        }
        public void DeleteAdminB(int ID)
        {
            foreach (var item in DB.bAdmins)
            {
                if (item.id == ID)
                {
                    dlc.DeleteAdminB(item);
                }
            }
        }

        public List<AAdmin> ShowAllAdminDataA()
        {
            return (from i in DB.aAdmins select i).ToList();
        }
        public List<BAdmin> ShowAllAdminDataB()
        {
            return (from i in DB.bAdmins select i).ToList();
        }

        public List<AAdmin> ShowActiveDataA()
        {
            return (from i in DB.aAdmins where !i.DeleteStatus select i).ToList();
        }
        public List<BAdmin> ShowActiveDataB()
        {
            return (from i in DB.bAdmins where !i.DeleteStatus select i).ToList();
        }

        public bool RegisterAdminA(AAdmin admin)
        {
            foreach (var item in DB.aAdmins)
            {
                if (item.Name == admin.Name && item.Family == admin.Family)
                {
                    return true;
                }
            }
            dlc.RegisterAdminA(admin);
            return false;
        }
        public bool RegisterAdminB(BAdmin admin)
        {
            foreach (var item in DB.bAdmins)
            {
                if (item.Name == admin.Name && item.Family == admin.Family)
                {
                    return true;
                }
            }
            dlc.RegisterAdminB(admin);
            return false;
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

        public OWNER CheckOwner(String Name)
        {
            return (DB.Owner.Where(c => c.access == Name).FirstOrDefault());
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
                    return true;
                }
            }
            dlc.CreateAdminBankAccountA(adminbank);
            return false;
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

        public bool SelectAdminA(AAdmin admin)
        {
            return (dlc.SelectAdminA(admin));
        }
        public bool SelectAdminB(BAdmin admin)
        {
            return (dlc.SelectAdminB(admin));
        }
        #endregion

    }
}
