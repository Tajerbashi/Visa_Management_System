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
        DALCODE dlc = new DALCODE();

        #region OWNER
        public int PublicKey(String Key)
        {   //  کلید کلی برای باز کردن فرم
            return (dlc.PublicKey(Key));
        }
        public bool CreateNewOwner(OWNER owner)
        {   // برای ساخت مالک در اولین اجرا برنامه میباشد وبعد از آن کاربردی ندارد
            if (dlc.SelectOwnerStatus(owner))
            {
                dlc.CreateOwner(owner);
                return true;
            }
            return false;
        }
        public int CheckAccessOwner(OWNER owner, String AdminName)
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
            return (dlc.aLogInformation());
        }
        public List<BLogInformation> bLogInformation()
        {
            return (dlc.bLogInformation());
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
            return (dlc.LogSearchEnterA(Word).ToList());
        }
        public List<BLogInformation> LogSearchEnterB(String Word)
        {
            return (dlc.LogSearchEnterB(Word).ToList());
        }

        public List<ALogInformation> SearchResultLogInformationDateA(string date1, string date2)
        {
            return (dlc.SearchResultLogInformationDateA(date1, date2)).ToList();
        }
        public List<BLogInformation> SearchResultLogInformationDateB(string date1, string date2)
        {
            return (dlc.SearchResultLogInformationDateB(date1, date2)).ToList();
        }
        #endregion
        // Control Account
        #region Control

        public int AdminKey(String Key, String ADMINNAME)
        {
            return (dlc.AdminKey(Key, ADMINNAME));
        }

        public List<AAdmin> GetAdminsA()
        {
            return (dlc.GetAdminsA().ToList());
        }
        public List<BAdmin> GetAdminsB()
        {
            return (dlc.GetAdminsB().ToList());
        }

        public String AdminFullNameByIDA(int id)
        {
            return (dlc.AdminFullNameByIDA(id));
        }
        public String AdminFullNameByIDB(int id)
        {
            return (dlc.AdminFullNameByIDB(id));
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

        public List<AAdmin> ShowAdminsA()
        {
            return (dlc.ShowAdminsA()).ToList();
        }
        public List<BAdmin> ShowAdminsB()
        {
            return (dlc.ShowAdminsB()).ToList();
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
            if (dlc.SelectAdminA(admin))
            {
                return false;
            }
            dlc.RegisterAdminA(admin);
            return true;
        }
        public bool RegisterAdminB(BAdmin admin)
        {
            if (dlc.SelectAdminB(admin))
            {
                return false;
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
            if (dlc.SelectionCompanyA(company))
            {
                dlc.CreateCompanyA(company);
                return true;
            }
            return false;
        }
        public bool CreatCompanyB(BCompany company)
        {
            if (dlc.SelectionCompanyB(company))
            {
                dlc.CreateCompanyB(company);
                return true;
            }
            return false;
        }
        // نمایش شرکت های  فعال
        public List<ACompany> ShowAllActiveDataCompanyA()
        {
            return (dlc.GetCompanyA()).ToList();
        }
        public List<BCompany> ShowAllActiveDataCompanyB()
        {
            return (dlc.GetCompanyB()).ToList();
        }
        //  نمایش شرکت های غیر فعال
        public List<ACompany> ShowAllDisActiveDataCompanyA()
        {
            return (dlc.ShowAllDisActiveDataCompanyA()).ToList();
        }
        public List<BCompany> ShowAllDisActiveDataCompanyB()
        {
            return (dlc.ShowAllDisActiveDataCompanyB()).ToList();
        }

        public ACompany SelectCompanyA(int ID)
        {
            return (dlc.SelectionCompanyA(ID));
        }
        public BCompany SelectCompanyB(int ID)
        {
            return (dlc.SelectionCompanyB(ID));
        }

        public bool SaveEditCompanyA(ACompany company)
        {
            if (!dlc.SelectionCompanyA(company))
            {
                dlc.SaveEditCompanyA(company);
                return true;
            }
            return false;
        }
        public bool SaveEditCompanyB(BCompany company)
        {
            if (!dlc.SelectionCompanyB(company))
            {
                dlc.SaveEditCompanyB(company);
                return true;
            }
            return false;
        }

        public void DeleteCompany(String Admin, int ID)
        {
            dlc.DeleteCompany(Admin, ID);
        }

        public void ChangeStatusCompany(String Admin, int ID)
        {
            dlc.ChangeStatusCompany(Admin, ID);
        }

        public List<ACompany> GetCompanyA()
        {
            return (dlc.GetCompanyA()).ToList();
        }
        public List<BCompany> GetCompanyB()
        {
            return (dlc.GetCompanyB()).ToList();
        }
        #endregion
        //  Product Control Form
        #region Product
        //  تمام محصولات موجود
        public List<AProduct> ShowAllProductA()
        {
            return (dlc.ShowAllProductA().ToList());
        }
        public List<BProduct> ShowAllProductB()
        {
            return (dlc.ShowAllProductB().ToList());

        }
        // محصولا خرید نقدی
        public List<AProduct> ShowAllMoneyProductA()
        {
            return (dlc.ShowAllMoneyProductA().ToList());

        }
        public List<BProduct> ShowAllMoneyProductB()
        {
            return (dlc.ShowAllMoneyProductB().ToList());

        }
        // محصولات خرید بانکی
        public List<AProduct> ShowAllBankiProductA()
        {
            return (dlc.ShowAllBankiProductA().ToList());

        }
        public List<BProduct> ShowAllBankiProductB()
        {
            return (dlc.ShowAllBankiProductB().ToList());

        }
        //  محصولات که از ان عدد کمتر میباشد
        public List<AProduct> ShowAllProductALessN(int N)
        {
            return (dlc.ShowAllProductALessN(N).ToList());

        }
        public List<BProduct> ShowAllProductBLessN(int N)
        {
            return (dlc.ShowAllProductBLessN(N).ToList());

        }
        //  محصولات که از ان عدد بیشتر میباشد
        public List<AProduct> ShowAllProductAGreatN(int N)
        {
            return (dlc.ShowAllProductAGreatN(N).ToList());

        }
        public List<BProduct> ShowAllProductBGreatN(int N)
        {
            return (dlc.ShowAllProductBGreatN(N).ToList());

        }
        //  نتایج جستجو
        public List<AProduct> ShowSearchResultA(String Word)
        {
            return (dlc.ShowSearchResultA(Word));
        }
        public List<BProduct> ShowSearchResultB(String Word)
        {
            return (dlc.ShowSearchResultB(Word));

        }
        //نتایج تاریخ امروز تا انقضا
        public List<AProduct> ShowResultDateNowExpireA(String Now, String Expire)
        {
            return (dlc.ShowResultDateNowExpireA(Now, Expire));
        }
        public List<BProduct> ShowResultDateNowExpireB(String Now, String Expire)
        {
            return (dlc.ShowResultDateNowExpireB(Now, Expire));
        }

        // مرتب سازی بر اساس تاریخ انقضا
        public List<AProduct> ShowProductOrderbyExpireDateA()
        {
            return (dlc.ShowProductOrderbyExpireDateA());
        }
        public List<BProduct> ShowProductOrderbyExpireDateB()
        {
            return (dlc.ShowProductOrderbyExpireDateB());
        }
        // برند های محصولات
        public List<AProduct> GetProductsA()
        {
            return (dlc.GetProductsA()).ToList();
        }
        public List<BProduct> GetProductsB()
        {
            return (dlc.GetProductsB()).ToList();
        }
        //  مرتب سازی بر اساس موجودی
        public List<AProduct> ShowProductOrderbyMojodiA()
        {
            return (dlc.ShowProductOrderbyMojodiA()).ToList();
        }
        public List<BProduct> ShowProductOrderbyMojodiB()
        {
            return (dlc.ShowProductOrderbyMojodiB()).ToList();
        }

        public bool CreateProductForBuyFactorA(AProduct product)
        {
            if (dlc.ExistProductForBuyFactorA(product))
            {
                return false;
            }
            return (dlc.CreateProductForBuyFactorA(product));
        }
        public bool CreateProductForBuyFactorB(BProduct product)
        {
            if (dlc.ExistProductForBuyFactorB(product))
            {
                return false;
            }
            return (dlc.CreateProductForBuyFactorB(product));
        }

        public bool CreateProductA(AProduct product)
        {
            if (dlc.SaveEditProductA(product))
            {
                return false;
            }
            dlc.CreateProductA(product);
            return true;
            //if false editesave else create new
        }
        public bool CreateProductB(BProduct product)
        {
            if (dlc.SaveEditProductB(product))
            {
                return false;
            }
            dlc.CreateProductB(product);
            return true;
            //if false editesave else create new
        }

        public void DeleteProductFromDBA(int ID)
        {
            dlc.DeleteProductFromDBA(ID);
        }
        public void DeleteProductFromDBB(int ID)
        {
            dlc.DeleteProductFromDBB(ID);
        }

        public AProduct GetProductA(int ID)
        {
            return (dlc.GetProductA(ID));
        }
        public BProduct GetProductB(int ID)
        {
            return (dlc.GetProductB(ID));
        }

        public bool ExistProductA(AProduct product)
        {
            return (dlc.ExistProductA(product));
        }
        public bool ExistProductB(BProduct product)
        {
            return (dlc.ExistProductB(product));
        }

        public void SaveEditProductA(AProduct product)
        {
            dlc.SaveEditProductA(product);
        }
        public void SaveEditProductB(BProduct product)
        {
            dlc.SaveEditProductB(product);
        }

        public void SaveEditForBuyFactorProductA(AProduct product)
        {
            dlc.SaveEditForBuyFactorProductA(product);
        }
        public void SaveEditForBuyFactorProductB(BProduct product)
        {
            dlc.SaveEditForBuyFactorProductB(product);
        }
        public void SaveEditProductForControlProductFormA(AProduct product, int ID)
        {
            dlc.SaveEditProductForControlProductFormA(product, ID);
        }
        public void SaveEditProductForControlProductFormB(BProduct product, int ID)
        {
            dlc.SaveEditProductForControlProductFormB(product, ID);
        }

        public void DeleteProductA(int ID)
        {
            dlc.DeleteProductA(ID);
        }
        public void DeleteProductB(int ID)
        {
            dlc.DeleteProductB(ID);
        }

        #endregion
        //  Lazy Loading
        public int GetIDBuyFactorForProductA(int ID)
        {
            return (dlc.GetIDBuyFactorForProductA(ID));
        }
        public int GetIDBuyFactorForProductB(int ID)
        {
            return (dlc.GetIDBuyFactorForProductB(ID));
        }
        //  Buy Factor
        public void CreateBuyFactorA(ABuyFactor factor)
        {
            dlc.CreateBuyFactorA(factor);
        }
        public void CreateBuyFactorB(BBuyFactor factor)
        {
            dlc.CreateBuyFactorB(factor);
        }
        public List<ABuyFactor> GetBuyFactorA()
        {
            return (dlc.GetBuyFactorA()).ToList();
        }
        public List<BBuyFactor> GetBuyFactorB()
        {
            return (dlc.GetBuyFactorB()).ToList();
        }

        public void SaveLastChangesOnBuyFacotrA(ABuyFactor factor)
        {
            dlc.SaveLastChangesOnBuyFacotrA(factor);
        }
        public void SaveLastChangesOnBuyFacotrB(BBuyFactor factor)
        {
            dlc.SaveLastChangesOnBuyFacotrB(factor);
        }

        //  Admin Control Register Form
        #region AdminControl
        public bool ExistAdminA(AAdmin admin)
        {
            return (dlc.ExistAdminA(admin));
        }
        public bool ExistAdminB(BAdmin admin)
        {
            return (dlc.ExistAdminB(admin));
        }
        public String ResetAdminPassword(AAdmin adminA, BAdmin adminB)
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
            return (dlc.CreateAdminBankA(adminbank));
        }
        public bool CreateAdminBankB(BAdminBankAccount adminbank)
        {
            return (dlc.CreateAdminBankB(adminbank));
        }

        public AAdminBankAccount adminbankacountA(int ID)
        {
            return (dlc.SelectAdminBankAccountA(ID));
        }
        public BAdminBankAccount adminbankacountB(int ID)
        {
            return (dlc.SelectAdminBankAccountB(ID));
        }

        public void DeleteAdminBankAccountA(int ID)
        {
            dlc.DeleteAdminBankAccountA(ID);
        }
        public void DeleteAdminBankAccountB(int ID)
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
        // Company

        public ACompany GetCompanyIDA(String company)
        {
            return (dlc.GetCompanyIDA(company));
        }
        public BCompany GetCompanyIDB(String company)
        {
            return (dlc.GetCompanyIDB(company));
        }

        //  Agent Register

        public AAgent GetAgentIDA(String Name)
        {
            return (dlc.GetAgentIDA(Name));
        }
        public BAgent GetAgentIDB(String Name)
        {
            return (dlc.GetAgentIDB(Name));
        }

        public bool CreatAgentA(AAgent agent)
        {
            if (!dlc.SelectionAgentA(agent))
            {
                return (dlc.CreateAgentA(agent));
            }
            return false;
        }
        public bool CreatAgentB(BAgent agent)
        {
            if (!dlc.SelectionAgentB(agent))
            {
                return (dlc.CreateAgentB(agent));
            }
            return false;
        }

        public List<AAgent> ShowAllAgentA()
        {
            return (dlc.ShowAllAgentA()).ToList();
        }
        public List<BAgent> ShowAllAgentB()
        {
            return (dlc.ShowAllAgentB()).ToList();
        }

        public List<AAgent> ShowAllActiveAgentA()
        {
            return (dlc.ShowAllActiveAgentA()).ToList();
        }
        public List<BAgent> ShowAllActiveAgentB()
        {
            return (dlc.ShowAllActiveAgentB()).ToList();
        }

        public List<AAgent> ShowAllDisActiveAgentA()
        {
            return (dlc.ShowAllDisActiveAgentA()).ToList();
        }
        public List<BAgent> ShowAllDisActiveAgentB()
        {
            return (dlc.ShowAllDisActiveAgentB()).ToList();
        }

        public AAgent SelectAgentA(int ID)
        {
            return (dlc.SelectAgentA(ID));
        }
        public BAgent SelectAgentB(int ID)
        {
            return (dlc.SelectAgentB(ID));
        }

        public bool SaveEditAgentA(AAgent agent)
        {
            return (dlc.SaveEditAgentA(agent));
        }
        public bool SaveEditAgentB(BAgent agent)
        {
            return (dlc.SaveEditAgentB(agent));
        }

        public void DeleteAgent(String Admin, int ID)
        {
            dlc.DeleteAgent(Admin, ID);
        }

        public void ChangeStatusAgent(String Admin, int ID)
        {
            dlc.ChangeStatusAgent(Admin, ID);
        }

        //  Agent Bank Account

        public bool CreateAgentBankA(AAgentBankAccount agentBank)
        {
            return (dlc.CreateAgentBankA(agentBank));
        }
        public bool CreateAgentBankB(BAgentBankAccount agentBank)
        {
            return (dlc.CreateAgentBankB(agentBank));
        }

        public List<AAgentBankAccount> ShowAllDataAgentBankA()
        {
            return (dlc.ShowAllDataAgentBankA()).ToList();
        }
        public List<BAgentBankAccount> ShowAllDataAgentBankB()
        {
            return (dlc.ShowAllDataAgentBankB()).ToList();
        }

        public List<AAgentBankAccount> ShowAllActiveDataAgentBankA()
        {
            return (dlc.ShowAllActiveDataAgentBankA()).ToList();
        }
        public List<BAgentBankAccount> ShowAllActiveDataAgentBankB()
        {
            return (dlc.ShowAllActiveDataAgentBankB()).ToList();
        }

        public List<AAgentBankAccount> ShowAllDisActiveDataAgentBankA()
        {
            return (dlc.ShowAllDisActiveDataAgentBankA()).ToList();
        }
        public List<BAgentBankAccount> ShowAllDisActiveDataAgentBankB()
        {
            return (dlc.ShowAllDisActiveDataAgentBankB()).ToList();
        }

        public AAgentBankAccount SelectAgentBankAccountA(int ID)
        {
            return (dlc.SelectAgentBankAccountA(ID));
        }
        public BAgentBankAccount SelectAgentBankAccountB(int ID)
        {
            return (dlc.SelectAgentBankAccountB(ID));
        }

        public bool SaveEditAgentBankA(AAgentBankAccount agentBank)
        {
            return (dlc.SaveEditAgentBankA(agentBank));
        }
        public bool SaveEditAgentBankB(BAgentBankAccount agentBank)
        {
            return (dlc.SaveEditAgentBankB(agentBank));
        }

        public void DeleteBankAccountAgent(String Admin, int ID)
        {
            dlc.DeleteBankAccountAgent(Admin, ID);
        }


        public void ChangeStatusAgentBank(String Admin, int ID)
        {
            dlc.ChangeStatusAgentBank(Admin, ID);
        }

        public List<ACompany> SearchResult0A(String Word)
        {
            return (dlc.SearchResult0A(Word));
        }
        public List<BCompany> SearchResult0B(String Word)
        {
            return (dlc.SearchResult0B(Word));
        }

        public List<AAgent> SearchResult1A(String Word)
        {
            return (dlc.SearchResult1A(Word));
        }
        public List<BAgent> SearchResult1B(String Word)
        {
            return (dlc.SearchResult1B(Word));
        }

        public List<AAgentBankAccount> SearchResult2A(String Word)
        {
            return (dlc.SearchResult2A(Word));
        }
        public List<BAgentBankAccount> SearchResult2B(String Word)
        {
            return (dlc.SearchResult2B(Word));
        }

        //  Customer

        public bool CreateCustomerA(ACustomer customer)
        {
            if (dlc.SelectCustumerA(customer))
            {
                return false;
            }
            return dlc.CreateCustomerA(customer);
        }
        public bool CreateCustomerB(BCustomer customer)
        {
            if (dlc.SelectCustumerB(customer))
            {
                return false;
            }

            return dlc.CreateCustomerB(customer);
        }
        public List<ACustomer> GetCustomersA()
        {
            return (dlc.GetCustomersA()).ToList();
        }
        public List<BCustomer> GetCustomersB()
        {
            return (dlc.GetCustomersB()).ToList();
        }
        public void DeleteCustomerA(int ID)
        {
            dlc.DeleteCustomerA(ID);
        }
        public void DeleteCustomerB(int ID)
        {
            dlc.DeleteCustomerB(ID);
        }

        public bool EditCustomerA(ACustomer customer, int ID)
        {
            return (dlc.EditCustomerA(customer, ID));
        }
        public bool EditCustomerB(BCustomer customer, int ID)
        {
            return (dlc.EditCustomerB(customer, ID));
        }
        public List<ACustomer> PrintSerchResultCustomerA(String Word)
        {
            return (dlc.PrintSerchResultCustomerA(Word).ToList());
        }
        public List<BCustomer> PrintSerchResultCustomerB(String Word)
        {
            return (dlc.PrintSerchResultCustomerB(Word).ToList());
        }

        //  Agent
        public List<AAgent> GetAgentA()
        {
            return (dlc.GetAgentA()).ToList();
        }
        public List<BAgent> GetAgentB()
        {
            return (dlc.GetAgentB()).ToList();
        }

        //  Buy Factor
        public int GetLastBuyFactorNumberA()
        {
            return (dlc.GetLastBuyFactorNumberA());
        }
        public int GetLastBuyFactorNumberB()
        {
            return (dlc.GetLastBuyFactorNumberB());
        }

        public int GetLastBuyFactorCodeA()
        {
            return (dlc.GetLastBuyFactorCodeA());
        }
        public int GetLastBuyFactorCodeB()
        {
            return (dlc.GetLastBuyFactorCodeB());
        }

        //  Sell Factor

        public List<ASellFactor> GetSellFactorsA()
        {
            return (dlc.GetSellFactorsA()).ToList();
        }
        public List<BSellFactor> GetSellFactorsB()
        {
            return (dlc.GetSellFactorsB()).ToList();
        }

        public int GetLastSellFactorNumberA()
        {
            return (dlc.GetLastSellFactorNumberA());
        }
        public int GetLastSellFactorNumberB()
        {
            return (dlc.GetLastSellFactorNumberB());
        }

        public int GetLastSellFactorCodeA()
        {
            return (dlc.GetLastSellFactorCodeA());
        }
        public int GetLastSellFactorCodeB()
        {
            return (dlc.GetLastSellFactorCodeB());
        }
        public void CreateSellFactorA(ASellFactor factor)
        {
            dlc.CreateSellFactorA(factor);
        }
        public void CreateSellFactorB(BSellFactor factor)
        {
            dlc.CreateSellFactorB(factor);
        }

        public void SaveLastChangesOnSellFacotrA(ASellFactor factor)
        {
            dlc.SaveLastChangesOnSellFacotrA(factor);
        }
        public void SaveLastChangesOnSellFacotrB(BSellFactor factor)
        {
            dlc.SaveLastChangesOnSellFacotrB(factor);
        }

    }
}
