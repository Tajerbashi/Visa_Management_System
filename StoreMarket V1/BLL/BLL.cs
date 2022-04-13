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
        #region OWNER
        public bool CheckOwnerEXISTA(OWNER owner)
        {
            DBCLASS DB = new DBCLASS();
            foreach (var item in DB.Owner)
            {
                if (item.access == owner.access && item.password == owner.password)
                {
                    return true; // اگر موجود بود عملیات تمام میشود
                }
            }
            // اگر موجود نبود میسازد
            DALCODE dlc = new DALCODE();
            dlc.CreateOwner(owner);

            return false;
        }
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
        #endregion
        DBCLASS DB = new DBCLASS();
        DALCODE dlc = new DALCODE();
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
            return (DB.aAdmins.Where(c => c.id == ID).FirstOrDefault());
        }
        public BAdmin EditAdminB(int ID)
        {
            return (DB.bAdmins.Where(c => c.id == ID).FirstOrDefault());
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


        public void ProductEditA(int ID)
        {
            AProduct product = DB.aProducts.Where(c => c.id == ID).First();
            dlc.EditProductA(product);
        }
        public void ProductEditB(int ID)
        {
            BProduct product= DB.bProducts.Where(c => c.id == ID).First();
            dlc.EditProductB(product);
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



    }
}
