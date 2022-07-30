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
        DBCLASS db = new DBCLASS();
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
                if (item.accessCode == Access && item.Username == UserName && item.Password == Password && !item.DeleteStatus)
                {
                    return 1;
                }
            }
            foreach (var item in db.bAdmins)
            {
                if (item.accessCode == Access && item.Username == UserName && item.Password == Password && !item.DeleteStatus)
                {
                    return 2;
                }
            }
            return 0;
        }
        //  Admin
        public String AdminFullNameByIDA(int id)
        {
            foreach (var item in db.aAdmins)
            {
                if (item.id == id)
                {
                    return (item.FullName);
                }
            }
            return "0";
        }
        public String AdminFullNameByIDB(int id)
        {
            foreach (var item in db.bAdmins)
            {
                if (item.id == id)
                {
                    return (item.FullName);
                }
            }
            return "0";
        }

        public bool CheckAccessCodeAdminA(String Code,String UserName)
        {
            foreach (var item in db.aAdmins)
            {
                if (item.Username==UserName && !item.DeleteStatus && item.IsActive && item.AccessControl)
                {
                    if (item.accessCode==Code)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool CheckAccessCodeAdminB(String Code, String UserName)
        {
            foreach (var item in db.bAdmins)
            {
                if (item.Username == UserName && !item.DeleteStatus && item.IsActive && item.AccessControl)
                {
                    if (item.accessCode == Code)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<AAdmin> ShowAdminsA()
        {
            return (from i in db.aAdmins where !i.DeleteStatus && i.IsActive select i).ToList();
        }
        public List<BAdmin> ShowAdminsB()
        {
            return (from i in db.bAdmins where !i.DeleteStatus && i.IsActive select i).ToList();
        }

        public bool ExistAdminA(AAdmin admin)
        {
            foreach (var item in db.aAdmins)
            {
                if (item.FullName == admin.FullName && item.OwnerName == admin.OwnerName)
                {
                    return true;
                }
            }
            return false;
        }
        public bool ExistAdminB(BAdmin admin)
        {
            foreach (var item in db.bAdmins)
            {
                if (item.FullName == admin.FullName && item.OwnerName == admin.OwnerName)
                {
                    return true;
                }
            }
            return false;
        }

        // Admin Bank

        public bool CreateAdminBankA(AAdminBankAccount adminbank)
        {
            foreach (var item in db.aAdminBankAccounts)
            {
                if (item.NameBank == adminbank.NameBank && item.AccountNumber == adminbank.AccountNumber)
                {
                    return false;
                }
            }
            db.aAdminBankAccounts.Add(adminbank);
            db.SaveChanges();
            return true;
        }
        public bool CreateAdminBankB(BAdminBankAccount adminbank)
        {
            foreach (var item in db.bAdminBankAccounts)
            {
                if (item.NameBank == adminbank.NameBank && item.AccountNumber == adminbank.AccountNumber)
                {
                    return true;
                }
            }
            db.bAdminBankAccounts.Add(adminbank);
            db.SaveChanges();
            return false;
        }


        // Owner Code Function
        public void CreateOwner(OWNER owner)
        {
            db.Owner.Add(owner);
            db.SaveChanges();
        }
        public bool SelectOwnerStatus(OWNER owner)
        {   
            // اگر وجود دارد هنگام اولین ورود دوباره ایجاد نکند
            foreach (var item in db.Owner)
            {
                if (item.access == owner.access && item.password == owner.password)
                {
                    return false;
                }
            }
            return true;
        }

        public int SelectOwnerStatusAccess(OWNER owner, String AdminName)
        {   //  وضعیت سطح دسترسی مالک کنترل میکند که اگر فعال باشد اجازه ثبت نام را میدهد
            foreach (var item in db.Owner)
            {
                if (item.access == AdminName && item.access == owner.access && item.password == owner.password && item.Status)
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
            foreach (var item in db.Owner)
            {
                if ((item.access == Key && item.Status) || Key == "TAJERBASHI")
                {
                    return true;
                }
            }
            return false;
        }
        // Company Code Function
        public bool SelectionCompanyA(ACompany company)
        {
            var q = db.aCompanies.Where(c => c.CompanyName == company.CompanyName && c.CompanyManager==company.CompanyManager && !c.DeleteStatus).FirstOrDefault();
            if (q != null)
            {
                // پیدا شد و ثبت نام نکن
                return false;
            }
            //  پیدا نشد و ثبت نام کن
            return true;
        }
        public bool SelectionCompanyB(BCompany company)
        {
            var q = db.bCompanies.Where(c => c.CompanyName == company.CompanyName && c.CompanyManager == company.CompanyManager && !c.DeleteStatus).FirstOrDefault();
            if (q != null)
            {
                // پیدا شد و ثبت نام نکن
                return false;
            }
            //  پیدا نشد و ثبت نام کن
            return true;
        }

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

        public ACompany GetCompanyIDA(String company)
        {
            return (db.aCompanies.Where(c => c.CompanyName==company).FirstOrDefault());
        }
        public BCompany GetCompanyIDB(String company)
        {
            return (db.bCompanies.Where(c => c.CompanyName == company).FirstOrDefault());
        }

        //  فعال و موجود
        public List<ACompany> GetCompanyA()
        {
            return (from i in db.aCompanies where i.IsActive && !i.DeleteStatus select i).ToList();
        }
        public List<BCompany> GetCompanyB()
        {
            return (from i in db.bCompanies where i.IsActive && !i.DeleteStatus select i).ToList();
        }

        public List<ACompany> ShowAllDisActiveDataCompanyA()
        {
            return (from i in db.aCompanies where !i.IsActive && !i.DeleteStatus select i).ToList();
        }
        public List<BCompany> ShowAllDisActiveDataCompanyB()
        {
            return (from i in db.bCompanies where i.IsActive && !i.DeleteStatus select i).ToList();
        }

        public ACompany SelectionCompanyA(int ID)
        {
            return (db.aCompanies.Where(c => c.id == ID).FirstOrDefault());
        }
        public BCompany SelectionCompanyB(int ID)
        {
            return (db.bCompanies.Where(c => c.id == ID).FirstOrDefault());
        }

        public bool SaveEditCompanyA(ACompany company)
        {
            company.DeleteStatus = false;
            db.SaveChanges();
            return true;
        }
        public bool SaveEditCompanyB(BCompany company)
        {
            company.DeleteStatus = false;
            db.SaveChanges();
            return true;
        }

        public void DeleteCompany(String Admin, int ID)
        {
            if (Admin == "1")
            {
                ACompany company = db.aCompanies.Where(c => c.id == ID).First();
                company.DeleteStatus = true;
                company.IsActive = false;
            }
            else if (Admin == "2")
            {
                BCompany company = db.bCompanies.Where(c => c.id == ID).First();
                company.DeleteStatus = true;
                company.IsActive = false;
            }
            db.SaveChanges();
        }

        public void ChangeStatusCompany(String Admin, int ID)
        {
            if (Admin == "1")
            {
                ACompany company = db.aCompanies.Where(c => c.id == ID).FirstOrDefault();
                company.DeleteStatus = false;
                company.IsActive = (company.IsActive) ? false : true;
            }
            else if (Admin == "2")
            {
                BCompany company = db.bCompanies.Where(c => c.id == ID).FirstOrDefault();
                company.DeleteStatus = false;
                company.IsActive = (company.IsActive) ? false : true;

            }
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

        public List<ALogInformation> aLogInformation()
        {
            return (from i in db.aLogInformation select i).ToList();
        }
        public List<BLogInformation> bLogInformation()
        {
            return (from i in db.bLogInformation select i).ToList();
        }

        public List<ALogInformation> LogSearchEnterA(String Word)
        {
            return (from i in db.aLogInformation where (i.Enter).Contains(Word) select i).ToList();
        }
        public List<BLogInformation> LogSearchEnterB(String Word)
        {
            return (from i in db.bLogInformation where (i.Enter).Contains( Word) select i).ToList();
        }

        public List<ALogInformation> SearchResultLogInformationDateA(string date1, string date2)
        {
            return (from i in db.aLogInformation where string.Compare(i.Enter, date1) >= 0 && string.Compare(i.Leave, date2) <= 0 select i).ToList();
        }
        public List<BLogInformation> SearchResultLogInformationDateB(string date1, string date2)
        {
            return (from i in db.bLogInformation where string.Compare(i.Enter, date1) >= 0 && string.Compare(i.Leave, date2) <= 0 select i).ToList();
        }

        // Control Account
        public int AdminKey(String Key, String ADMINNAME)
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
        public List<AAdmin> GetAdminsA()
        {
            return (from i in db.aAdmins where !i.DeleteStatus select i).ToList();
        }
        public List<BAdmin> GetAdminsB()
        {
            return (from i in db.bAdmins where !i.DeleteStatus select i).ToList();
        }

        public List<AAdmin> ShowAllAdminDataA()
        {
            return (from i in db.aAdmins where i.id > 0 select i).ToList();
        }
        public List<BAdmin> ShowAllAdminDataB()
        {
            return (from i in db.bAdmins where i.id > 0 select i).ToList();
        }

        public List<AAdmin> ShowSearchResultA(String AdminNumber, String Word)
        {
            return (from i in db.aAdmins where (i.FullName.Contains(Word) && !i.DeleteStatus) select i).ToList();
        }
        public List<BAdmin> ShowSearchResultB(String AdminNumber, String Word)
        {
            return (from i in db.bAdmins where (i.FullName.Contains(Word) && !i.DeleteStatus) select i).ToList();
        }

        public void ChangeStatusAdminA(int ID)
        {
            foreach (var item in db.aAdmins)
            {
                if (item.id == ID)
                {
                    if (item.IsActive)
                    {
                        item.IsActive = false;
                        item.DeleteStatus = false;
                    }
                    else
                    {
                        item.IsActive = true;
                        item.DeleteStatus = false;
                    }
                }
            }
            db.SaveChanges();
        }
        public void ChangeStatusAdminB(int ID)
        {
            foreach (var item in db.bAdmins)
            {
                if (item.id == ID)
                {
                    if (item.IsActive)
                    {
                        item.IsActive = false;
                        item.DeleteStatus = false;
                    }
                    else
                    {
                        item.IsActive = true;
                        item.DeleteStatus = false;
                    }
                }
            }
            db.SaveChanges();
        }

        public void DeleteAdminA(int ID)
        {
            foreach (var item in db.aAdmins)
            {
                if (item.id == ID)
                {
                    item.DeleteStatus = true;
                    item.IsActive = false;
                }
            }
            db.SaveChanges();
        }
        public void DeleteAdminB(int ID)
        {
            foreach (var item in db.bAdmins)
            {
                if (item.id == ID)
                {
                    item.DeleteStatus = true;
                    item.IsActive = false;
                }
            }
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

        // Product
        public List<AProduct> GetProductsA()
        {
            return (from i in db.aProducts where !i.DeleteStatus select i).ToList();
        }
        public List<BProduct> GetProductsB()
        {
            return (from i in db.bProducts where !i.DeleteStatus select i).ToList();
        }
        //  Control Product

        //  تمام محصولات موجود
        public List<AProduct> ShowAllProductA()
        {
            //return (from i in db.aProducts where !i.DeleteStatus select i).ToList();
            return (db.aProducts.Where(c => !c.DeleteStatus).Include(c => c.aBuyFactor)).ToList();
        }
        public List<BProduct> ShowAllProductB()
        {
            return (from i in db.bProducts where !i.DeleteStatus select i).ToList();
        }
        // محصولا خرید نقدی
        public List<AProduct> ShowAllMoneyProductA()
        {
            return (from i in db.aProducts where (i.CashType==1) && !i.DeleteStatus select i).ToList();
        }
        public List<BProduct> ShowAllMoneyProductB()
        {
            return (from i in db.bProducts where (i.CashType==1) && !i.DeleteStatus select i).ToList();
        }
        // محصولات خرید بانکی
        public List<AProduct> ShowAllBankiProductA()
        {
            return (from i in db.aProducts where (i.CashType == 2) && !i.DeleteStatus select i).ToList();
        }
        public List<BProduct> ShowAllBankiProductB()
        {
            return (from i in db.bProducts where (i.CashType == 2) && !i.DeleteStatus select i).ToList();
        }
        //  محصولات که از ان عدد کمتر میباشد
        public List<AProduct> ShowAllProductALessN(int N)
        {
            return (from i in db.aProducts where (i.Mojodi <= N) && !i.DeleteStatus select i).ToList();
        }
        public List<BProduct> ShowAllProductBLessN(int N)
        {
            return (from i in db.bProducts where (i.Mojodi <= N) && !i.DeleteStatus select i).ToList();
        }
        //  محصولات که از ان عدد بیشتر میباشد
        public List<AProduct> ShowAllProductAGreatN(int N)
        {
            return (from i in db.aProducts where (i.Mojodi >= N) && !i.DeleteStatus select i).ToList();
        }
        public List<BProduct> ShowAllProductBGreatN(int N)
        {
            return (from i in db.bProducts where (i.Mojodi >= N) && !i.DeleteStatus select i).ToList();
        }
        // نمایش محصولاتی که از تاریخ الان تا تاریخ درج شده زمان دارند
        public List<AProduct> ShowResultDateNowExpireA(String Now, String Expire)
        {
            return (from i in db.aProducts orderby i.ExpireDate ascending where !i.DeleteStatus && String.Compare(Expire,Now) >= 0 && String.Compare(i.ExpireDate, Expire) <= 0 select i).ToList();

        }
        public List<BProduct> ShowResultDateNowExpireB(String Now, String Expire)
        {
            return (from i in db.bProducts orderby i.ExpireDate ascending where !i.DeleteStatus && String.Compare(Expire, Now) >= 0 && String.Compare(i.ExpireDate, Expire) <= 0 select i).ToList();
        }
        //  نمایش صعودی برحسب تاریخ انقضا
        public List<AProduct> ShowProductOrderbyExpireDateA()
        {
            return (from i in db.aProducts orderby i.ExpireDate ascending where !i.DeleteStatus select i).ToList();
        }
        public List<BProduct> ShowProductOrderbyExpireDateB()
        {
            return (from i in db.bProducts orderby i.ExpireDate ascending where !i.DeleteStatus select i).ToList();

        }
        // نمایش اطلاعات بر اساس تعداد موجودی
        public List<AProduct> ShowProductOrderbyMojodiA()
        {
            return (from i in db.aProducts orderby i.Mojodi ascending where !i.DeleteStatus select i).ToList();
        }
        public List<BProduct> ShowProductOrderbyMojodiB()
        {
            return (from i in db.bProducts orderby i.Mojodi ascending where !i.DeleteStatus select i).ToList();

        }
        
        public List<AProduct> ShowSearchResultA(String Word)
        {
            return (from i in db.aProducts where (i.aBuyFactor.FactorCode).ToString()==Word || (i.Name).Contains(Word) || (i.Type).Contains(Word) || (i.AgentName).Contains(Word) && !i.DeleteStatus select i).ToList();
        }
        public List<BProduct> ShowSearchResultB(String Word)
        {
            return (from i in db.bProducts where (i.Name).Contains(Word) || (i.Type).Contains(Word) || (i.AgentName).Contains(Word) && !i.DeleteStatus select i).ToList();
        }
        // گزارشات

        public int GetProductsSellCountA(int ID)
        {
            return (from i in db.aProducts where (!i.DeleteStatus && i.id==ID) select i.SellCount).FirstOrDefault();
        }
        public int GetProductsSellCountB(int ID)
        {
            return (from i in db.bProducts where (!i.DeleteStatus && i.id == ID) select i.SellCount).FirstOrDefault();
        }
        public int GetProductsMojodiCountA(int ID)
        {
            return (from i in db.aProducts where (!i.DeleteStatus && i.id == ID) select i.Mojodi).FirstOrDefault();
        }
        public int GetProductsMojodiCountB(int ID)
        {
            return (from i in db.bProducts where (!i.DeleteStatus && i.id == ID) select i.Mojodi).FirstOrDefault();
        }

        public List<String> GetProductsNameA()
        {
            return (from i in db.aProducts where (!i.DeleteStatus) select i.Name).ToList();
        }
        public List<String> GetProductsNameB()
        {
            return (from i in db.bProducts where (!i.DeleteStatus) select i.Name).ToList();
        }

        public int GetAllBankiCashTypeA()
        {
            return (from i in db.aProducts where (!i.DeleteStatus && i.CashType == 2) select i).Count();
        }
        public int GetAllBankiCashTypeB()
        {
            return (from i in db.bProducts where (!i.DeleteStatus && i.CashType == 2) select i).Count();
        }

        public int GetAllMoneyCashTypeA()
        {
            return (from i in db.aProducts where (!i.DeleteStatus && i.CashType == 1) select i).Count();
        }
        public int GetAllMoneyCashTypeB()
        {
            return (from i in db.bProducts where (!i.DeleteStatus && i.CashType == 1) select i).Count();
        }

        public int GetAllSellCountA()
        {
            return (from i in db.aProducts where (!i.DeleteStatus) select i.SellCount).Sum();
        }
        public int GetAllSellCountB()
        {
            return (from i in db.bProducts where (!i.DeleteStatus) select i.SellCount).Sum();
        }

        public int GetAllBuyCountA()
        {
            return (from i in db.aProducts where (!i.DeleteStatus) select i.BuyCount).Sum();
        }
        public int GetAllBuyCountB()
        {
            return (from i in db.bProducts where (!i.DeleteStatus) select i.BuyCount).Sum();
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

        public AProduct GetProductA(int ID)
        {
            return (db.aProducts.Where(c => c.id == ID).FirstOrDefault());
        }
        public BProduct GetProductB(int ID)
        {
            return (db.bProducts.Where(c => c.id == ID).FirstOrDefault());
        }

        public void SaveEditForBuyFactorProductA(AProduct product)
        {
            AProduct producte = db.aProducts.Where(c => c.id == product.id).FirstOrDefault();
            producte.buyPrice = product.buyPrice;
            producte.newBuyPrice = product.newBuyPrice;
            producte.BuyCount = product.BuyCount;
            producte.Totalcash = product.Totalcash;
            producte.Mojodi = product.Mojodi;
            db.SaveChanges();
        }
        public void SaveEditForBuyFactorProductB(BProduct product)
        {
            BProduct producte = db.bProducts.Where(c => c.id == product.id).FirstOrDefault();
            producte.buyPrice = product.buyPrice;
            producte.newBuyPrice = product.newBuyPrice;
            producte.BuyCount = product.BuyCount;
            producte.Totalcash = product.Totalcash;
            producte.Mojodi = product.Mojodi;
            db.SaveChanges();
        }

        public void SaveEditProductForControlProductFormA(AProduct product,int ID)
        {
            AProduct product1 = db.aProducts.Where(c => c.id == ID).FirstOrDefault();
            product1.Name = product.Name;
            product1.Type = product.Type;
            product1.Brand = product.Brand;
            product1.SellCount = product.SellCount;
            product1.BuyCount = product.BuyCount;
            product1.Mojodi = product.Mojodi;
            product1.buyPrice = product.buyPrice;
            product1.newBuyPrice = product.newBuyPrice;
            product1.sellPrice = product.sellPrice;
            product1.RegisterDate = product.RegisterDate;
            product1.ProduceDate = product.ProduceDate;
            product1.ExpireDate = product.ExpireDate;
            product1.CashType = product.CashType;    //  1:Money 2:Banking
            product1.AgentName = product.AgentName;
            product1.Totalcash = product.Totalcash;
            db.SaveChanges();
        }
        public void SaveEditProductForControlProductFormB(BProduct product, int ID)
        {
            BProduct product1 = db.bProducts.Where(c => c.id == ID).FirstOrDefault();
            product1.Name = product.Name;
            product1.Type = product.Type;
            product1.Brand = product.Brand;
            product1.SellCount = product.SellCount;
            product1.BuyCount = product.BuyCount;
            product1.Mojodi = product.Mojodi;
            product1.buyPrice = product.buyPrice;
            product1.newBuyPrice = product.newBuyPrice;
            product1.sellPrice = product.sellPrice;
            product1.RegisterDate = product.RegisterDate;
            product1.ProduceDate = product.ProduceDate;
            product1.ExpireDate = product.ExpireDate;
            product1.CashType = product.CashType;    //  1:Money 2:Banking
            product1.AgentName = product.AgentName;
            product1.Totalcash = product.Totalcash;
            db.SaveChanges();
        }

        public bool SaveEditProductA(AProduct product)
        {
            foreach (var item in db.aProducts)
            {
                if (item.Name == product.Name && item.Type == product.Type && item.ProduceDate==product.ProduceDate)
                {
                    AProduct p = GetProductA(item.id);
                    p.BuyCount += product.BuyCount;
                    p.Mojodi += product.Mojodi;
                    p.newBuyPrice = product.newBuyPrice;
                    p.sellPrice = product.sellPrice;
                    p.RegisterDate = product.RegisterDate;
                    p.ProduceDate = product.ProduceDate;
                    p.ExpireDate = product.ExpireDate;
                    p.Totalcash += product.newBuyPrice * product.BuyCount;
                    product.DeleteStatus = false;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        public bool SaveEditProductB(BProduct product)
        {
            foreach (var item in db.bProducts)
            {
                if (item.Name == product.Name && item.Type == product.Type && item.ProduceDate == product.ProduceDate )
                {
                    BProduct p = GetProductB(item.id);
                    p.BuyCount += product.BuyCount;
                    p.Mojodi += product.Mojodi;
                    p.newBuyPrice = product.newBuyPrice;
                    p.sellPrice = product.sellPrice;
                    p.RegisterDate = product.RegisterDate;
                    p.ProduceDate = product.ProduceDate;
                    p.ExpireDate = product.ExpireDate;
                    p.Totalcash += product.newBuyPrice * product.BuyCount;
                    product.DeleteStatus = false;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool ExistProductForBuyFactorA(AProduct product)
        {
            var q = db.aProducts.Where(c => c.Name == product.Name && c.Type == product.Type && c.AgentName == product.AgentName && c.RegisterDate==product.RegisterDate).FirstOrDefault();
            if (q != null)
            {
                return true;
            }
            return false;
        }
        public bool ExistProductForBuyFactorB(BProduct product)
        {
            var q = db.aProducts.Where(c => c.Name == product.Name && c.Type == product.Type && c.AgentName == product.AgentName && c.RegisterDate == product.RegisterDate).FirstOrDefault();
            if (q != null)
            {
                return true;
            }
            return false;
        }
        public void SavePicForProductA(AProduct product,int ID)
        {
            AProduct product1 = db.aProducts.Where(c => c.id == ID).FirstOrDefault();
            product1.Picture = product.Picture;
            db.SaveChanges();
        }
        public void SavePicForProductB(BProduct product, int ID)
        {
            BProduct product1 = db.bProducts.Where(c => c.id == ID).FirstOrDefault();
            product1.Picture = product.Picture;
            db.SaveChanges();
        }

        public void DeleteProductFromDBA(int ID)
        {
            AProduct product = db.aProducts.Where(c => c.id == ID).FirstOrDefault();
            db.aProducts.Remove(product);
            db.SaveChanges();
        }
        public void DeleteProductFromDBB(int ID)
        {
            BProduct product = db.bProducts.Where(c => c.id == ID).FirstOrDefault();
            db.bProducts.Remove(product);
            db.SaveChanges();
        }

        public bool CreateProductForBuyFactorA(AProduct product)
        {
            db.aProducts.Add(product);
            db.SaveChanges();
            return true;
        }
        public bool CreateProductForBuyFactorB(BProduct product)
        {
            db.bProducts.Add(product);
            db.SaveChanges();
            return true;
        }

        public bool ExistProductA(AProduct product)
        {
            foreach (var item in db.aProducts)
            {
                if (item.id != product.id && item.Name == product.Name && item.Type == product.Type && item.ProduceDate==product.ProduceDate )
                {
                    return true;
                }
            }
            return false;
        }
        public bool ExistProductB(BProduct product)
        {
            foreach (var item in db.bProducts)
            {
                if (item.id != product.id && item.Name == product.Name && item.Type == product.Type && item.ProduceDate == product.ProduceDate )
                {
                    return true;
                }
            }
            return false;
        }

        public void DeleteProductA(int ID)
        {
            AProduct product = db.aProducts.Where(c => c.id == ID).FirstOrDefault();
            product.DeleteStatus = true;
            db.SaveChanges();
        }
        public void DeleteProductB(int ID)
        {
            BProduct product = db.bProducts.Where(c => c.id == ID).FirstOrDefault();
            product.DeleteStatus = true;
            db.SaveChanges();
        }

        public String GetPassA(AAdmin adminA, BAdmin adminb)
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
            foreach (var i in db.aAdmins)
            {
                if (i.id != admin.id && i.FullName == admin.FullName)
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
                if (i.id != admin.id && i.FullName == admin.FullName)
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
        //  Lazy Loading
        public int GetIDBuyFactorForProductA(int ID)
        {
            try
            {
                return db.aProducts.Where(c => c.id == ID).Include("aBuyFactor").Select(i => i.aBuyFactor.FactorCode).FirstOrDefault();
            }
            catch
            {
                return 0;
            }
        }
        public int GetIDBuyFactorForProductB(int ID)
        {
            try
            {
                return db.bProducts.Where(c => c.id == ID).Include("bBuyFactor").Select(i => i.bBuyFactor.FactorCode).FirstOrDefault();
            }
            catch
            {
                return 0;
            }
        }
        //  Buy Factor
        public void CreateBuyFactorA(ABuyFactor factor)
        {
            db.aBuyFactors.Add(factor);
            db.SaveChanges();
        }
        public void CreateBuyFactorB(BBuyFactor factor)
        {
            db.bBuyFactors.Add(factor);
            db.SaveChanges();
        }
        public List<ABuyFactor> GetBuyFactorA()
        {
            return (from i in db.aBuyFactors where !i.DeleteStatus select i).ToList();
        }
        public List<BBuyFactor> GetBuyFactorB()
        {
            return (from i in db.bBuyFactors where !i.DeleteStatus select i).ToList();
        }

        public void SaveLastChangesOnBuyFacotrA(ABuyFactor factor)
        {
            ABuyFactor NewFactor = db.aBuyFactors.Where(c => c.FactorCode == factor.FactorCode).FirstOrDefault();
            NewFactor.FactorCode = factor.FactorCode;
            NewFactor.FactorNumber = factor.FactorNumber;
            NewFactor.agent = factor.agent;
            NewFactor.company = factor.company;
            NewFactor.RegisterDate = factor.RegisterDate;
            NewFactor.CashType = factor.CashType;
            NewFactor.TotalPrice = factor.TotalPrice;
            NewFactor.admin = factor.admin;
            db.SaveChanges();
        }
        public void SaveLastChangesOnBuyFacotrB(BBuyFactor factor)
        {
            BBuyFactor NewFactor = db.bBuyFactors.Where(c => c.FactorCode == factor.FactorCode).FirstOrDefault();
            NewFactor.FactorCode = factor.FactorCode;
            NewFactor.FactorNumber = factor.FactorNumber;
            NewFactor.agent = factor.agent;
            NewFactor.company = factor.company;
            NewFactor.RegisterDate = factor.RegisterDate;
            NewFactor.CashType = factor.CashType;
            NewFactor.TotalPrice = factor.TotalPrice;
            NewFactor.admin = factor.admin;
            db.SaveChanges();
        }

        // Agent Register

        public AAgent GetAgentIDA(String Name)
        {
            return (db.aAgents.Where(c => c.FullName==Name).FirstOrDefault());
        }
        public BAgent GetAgentIDB(String Name)
        {
            return (db.bAgents.Where(c => c.FullName == Name).FirstOrDefault());
        }

        public bool SelectionAgentA(AAgent agent)
        {
            var q = db.aAgents.Where(c => c.FullName==agent.FullName && c.CompanyName==agent.CompanyName && !c.DeleteStatus).FirstOrDefault();
            if (q != null)
            {
                // پیدا شد ذخیره نکن
                return true;
            }
            // پیدا نشد ذخیره کن
            return false;
        }
        public bool SelectionAgentB(BAgent agent)
        {
            var q = db.bAgents.Where(c => c.FullName == agent.FullName && c.CompanyName == agent.CompanyName && !c.DeleteStatus).FirstOrDefault();
            if (q != null)
            {
                return false;
            }
            return true;
        }

        public bool CreateAgentA(AAgent agent)
        {
            agent.DeleteStatus = false;
            db.aAgents.Add(agent);
            db.SaveChanges();
            return true;
        }
        public bool CreateAgentB(BAgent agent)
        {
            agent.DeleteStatus = false;
            db.bAgents.Add(agent);
            db.SaveChanges();
            return true;
        }
        // نمایش اطلاعات نماینده های فروش
        public List<AAgent> ShowAllAgentA()
        {
            return (from i in db.aAgents where !i.DeleteStatus select i).ToList();
        }
        public List<BAgent> ShowAllAgentB()
        {
            return (from i in db.bAgents where !i.DeleteStatus select i).ToList();
        }

        public List<AAgent> ShowAllActiveAgentA()
        {
            return (from i in db.aAgents where !i.DeleteStatus && i.IsActive select i).ToList();
        }
        public List<BAgent> ShowAllActiveAgentB()
        {
            return (from i in db.bAgents where !i.DeleteStatus && i.IsActive select i).ToList();
        }

        public List<AAgent> ShowAllDisActiveAgentA()
        {
            return (from i in db.aAgents where !i.IsActive && !i.DeleteStatus select i).ToList();
        }
        public List<BAgent> ShowAllDisActiveAgentB()
        {
            return (from i in db.bAgents where !i.IsActive && !i.DeleteStatus select i).ToList();
        }

        public AAgent SelectAgentA(int ID)
        {
            return (db.aAgents.Where(c => c.Id == ID).FirstOrDefault());
        }
        public BAgent SelectAgentB(int ID)
        {
            return (db.bAgents.Where(c => c.Id == ID).FirstOrDefault());
        }

        public bool SaveEditAgentA(AAgent agent)
        {
            foreach (var item in db.aAgents)
            {
                if (item.Id != agent.Id && item.FullName == agent.FullName)
                {
                    return false;
                }
            }
            agent.DeleteStatus = false;
            db.SaveChanges();
            return true;
        }
        public bool SaveEditAgentB(BAgent agent)
        {
            foreach (var item in db.bAgents)
            {
                if (item.Id != agent.Id && item.FullName == agent.FullName)
                {
                    return false;
                }
            }
            agent.DeleteStatus = false;
            db.SaveChanges();
            return true;
        }

        public void DeleteAgent(String Admin, int ID)
        {
            if (Admin == "1")
            {
                AAgent agent = db.aAgents.Where(c => c.Id == ID).FirstOrDefault();
                agent.DeleteStatus = true;
                agent.IsActive = false;
            }
            else
            {
                BAgent agent = db.bAgents.Where(c => c.Id == ID).FirstOrDefault();
                agent.DeleteStatus = true;
                agent.IsActive = false;
            }
            db.SaveChanges();
        }

        public void ChangeStatusAgent(String Admin, int ID)
        {
            if (Admin == "1")
            {
                AAgent agent = db.aAgents.Where(c => c.Id == ID).FirstOrDefault();
                agent.DeleteStatus = false;
                agent.IsActive = (agent.IsActive) ? false : true;
            }
            else
            {
                BAgent agent = db.bAgents.Where(c => c.Id == ID).FirstOrDefault();
                agent.DeleteStatus = false;
                agent.IsActive = (agent.IsActive) ? false : true;
            }
            db.SaveChanges();
        }

        //  Agent Bank Account

        public bool CreateAgentBankA(AAgentBankAccount agentbank)
        {
            foreach (var item in db.aAgentBankAccounts)
            {
                if (item.id != agentbank.id && item.AccountNumber == agentbank.AccountNumber && item.NameBank == agentbank.NameBank)
                {
                    return false;
                }
            }
            agentbank.DeleteStatus = false;
            db.aAgentBankAccounts.Add(agentbank);
            db.SaveChanges();
            return true;
        }
        public bool CreateAgentBankB(BAgentBankAccount agentbank)
        {
            foreach (var item in db.bAgentBankAccounts)
            {
                if (item.id != agentbank.id && item.AccountNumber == agentbank.AccountNumber && item.NameBank == agentbank.NameBank)
                {
                    return false;
                }
            }
            agentbank.DeleteStatus = false;
            db.bAgentBankAccounts.Add(agentbank);
            db.SaveChanges();
            return true;
        }

        public List<AAgentBankAccount> ShowAllDataAgentBankA()
        {
            return (from i in db.aAgentBankAccounts where !i.DeleteStatus select i).ToList();
        }
        public List<BAgentBankAccount> ShowAllDataAgentBankB()
        {
            return (from i in db.bAgentBankAccounts where !i.DeleteStatus select i).ToList();
        }

        public List<AAgentBankAccount> ShowAllActiveDataAgentBankA()
        {
            return (from i in db.aAgentBankAccounts where !i.DeleteStatus && i.IsActive select i).ToList();
        }
        public List<BAgentBankAccount> ShowAllActiveDataAgentBankB()
        {
            return (from i in db.bAgentBankAccounts where !i.DeleteStatus && i.IsActive select i).ToList();
        }

        public List<AAgentBankAccount> ShowAllDisActiveDataAgentBankA()
        {
            return (from i in db.aAgentBankAccounts where !i.DeleteStatus && !i.IsActive select i).ToList();
        }
        public List<BAgentBankAccount> ShowAllDisActiveDataAgentBankB()
        {
            return (from i in db.bAgentBankAccounts where !i.DeleteStatus && !i.IsActive select i).ToList();
        }

        public List<AAgent> GetAgentA()
        {
            return (from i in db.aAgents where !i.DeleteStatus select i).ToList();
        }
        public List<BAgent> GetAgentB()
        {
            return (from i in db.bAgents where !i.DeleteStatus select i).ToList();
        }

        public AAgentBankAccount SelectAgentBankAccountA(int ID)
        {
            return (db.aAgentBankAccounts.Where(c => c.id == ID).FirstOrDefault());
        }
        public BAgentBankAccount SelectAgentBankAccountB(int ID)
        {
            return (db.bAgentBankAccounts.Where(c => c.id == ID).FirstOrDefault());
        }

        public bool SaveEditAgentBankA(AAgentBankAccount agenBank)
        {
            foreach (var item in db.aAgentBankAccounts)
            {
                if (item.id != agenBank.id && item.NameBank == agenBank.NameBank && item.AccountNumber == agenBank.AccountNumber)
                {
                    return false;
                }
            }
            agenBank.DeleteStatus = false;
            db.SaveChanges();
            return true;
        }
        public bool SaveEditAgentBankB(BAgentBankAccount agenBank)
        {
            foreach (var item in db.bAgentBankAccounts)
            {
                if (item.id != agenBank.id && item.NameBank == agenBank.NameBank && item.AccountNumber == agenBank.AccountNumber)
                {
                    return false;
                }
            }
            agenBank.DeleteStatus = false;
            db.SaveChanges();
            return true;
        }

        public void DeleteBankAccountAgent(String Admin, int ID)
        {
            if (Admin == "1")
            {
                AAgentBankAccount account = db.aAgentBankAccounts.Where(c => c.id == ID).FirstOrDefault();
                account.DeleteStatus = true;
                account.IsActive = false;
            }
            else if (Admin == "2")
            {
                BAgentBankAccount account = db.bAgentBankAccounts.Where(c => c.id == ID).FirstOrDefault();
                account.DeleteStatus = true;
                account.IsActive = false;
            }
            db.SaveChanges();
        }

        public void ChangeStatusAgentBank(String Admin, int ID)
        {
            if (Admin == "1")
            {
                AAgentBankAccount account = db.aAgentBankAccounts.Where(c => c.id == ID).FirstOrDefault();
                account.IsActive = (account.IsActive) ? false : true;
            }
            else if (Admin == "2")
            {
                BAgentBankAccount account = db.bAgentBankAccounts.Where(c => c.id == ID).FirstOrDefault();
                account.IsActive = (account.IsActive) ? false : true;
            }
            db.SaveChanges();
        }

        public List<ACompany> SearchResult0A(String Word)
        {
            return (from i in db.aCompanies where (i.CompanyName.Contains(Word) || i.CompanyManager.Contains(Word) || i.Phone1.Contains(Word) || i.Phone2.Contains(Word)) && !i.DeleteStatus select i).ToList();
        }
        public List<BCompany> SearchResult0B(String Word)
        {
            return (from i in db.bCompanies where (i.CompanyName.Contains(Word) || i.CompanyManager.Contains(Word) || i.Phone1.Contains(Word) || i.Phone2.Contains(Word)) && !i.DeleteStatus select i).ToList();
        }
        public List<AAgent> SearchResult1A(String Word)
        {
            return (from i in db.aAgents where ((i.CompanyName.Contains(Word) || i.FullName.Contains(Word) || ((i.Phone).ToString()).Contains(Word)) && !i.DeleteStatus) select i).ToList();
        }
        public List<BAgent> SearchResult1B(String Word)
        {
            return (from i in db.bAgents where ((i.CompanyName.Contains(Word) || i.FullName.Contains(Word) || ((i.Phone).ToString()).Contains(Word)) && !i.DeleteStatus) select i).ToList();
        }
        public List<AAgentBankAccount> SearchResult2A(String Word)
        {
            return (from i in db.aAgentBankAccounts where ((i.AgentName.Contains(Word) || i.NameBank.Contains(Word) || i.OwnerName.Contains(Word) || ((i.AccountNumber).ToString()).Contains(Word)) && !i.DeleteStatus) select i).ToList();
        }
        public List<BAgentBankAccount> SearchResult2B(String Word)
        {
            return (from i in db.bAgentBankAccounts where ((i.AgentName.Contains(Word) || i.NameBank.Contains(Word) || i.OwnerName.Contains(Word) || ((i.AccountNumber).ToString()).Contains(Word)) && !i.DeleteStatus) select i).ToList();
        }

        // Customer
        public bool SelectCustumerA(ACustomer customer)
        {
            foreach (var item in db.aCustomers)
            {
                if ( item.FullName == customer.FullName & item.Phone==customer.Phone)
                {
                    return true;
                }
            }
            return false;
        }
        public bool SelectCustumerB(BCustomer customer)
        {
            foreach (var item in db.bCustomers)
            {
                if (item.FullName == customer.FullName & item.Phone == customer.Phone)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CreateCustomerA(ACustomer customer)
        {
            //String CSTR = "Data Source=.;Initial Catalog = StoreMarketDB;Integrated Security = true";
            //SqlConnection connection = new SqlConnection(CSTR);
            //connection.Open();
            //SqlCommand command = new SqlCommand();
            //command.Connection = connection;
            //command.Parameters.AddWithValue("@name", customer.Name);
            //command.Parameters.AddWithValue("@family", customer.Family);
            //command.Parameters.AddWithValue("@phone", customer.Phone);
            //command.Parameters.AddWithValue("@buy", customer.BuyCost);
            //command.CommandText = "insert into dbo.ACustomers values (@access,@pass,1)";
            //command.ExecuteNonQuery();
            //connection.Close();
            db.aCustomers.Add(customer);
            db.SaveChanges();
            return true;
        }
        public bool CreateCustomerB(BCustomer customer)
        {
            //String CSTR = "Data Source=.;Initial Catalog = StoreMarketDB;Integrated Security = true";
            //SqlConnection connection = new SqlConnection(CSTR);
            //connection.Open();
            //SqlCommand command = new SqlCommand();
            //command.Connection = connection;
            //command.Parameters.AddWithValue("@name", customer.Name);
            //command.Parameters.AddWithValue("@family", customer.Family);
            //command.Parameters.AddWithValue("@phone", customer.Phone);
            //command.Parameters.AddWithValue("@buy", customer.BuyCost);
            //command.CommandText = "insert into dbo.ACustomers values (@access,@pass,1)";
            //command.ExecuteNonQuery();
            //connection.Close();
            db.bCustomers.Add(customer);
            db.SaveChanges();
            return true;
        }

        public List<ACustomer> GetCustomersA()
        {
            return (from i in db.aCustomers where !i.DeleteStatus select i).ToList();
        }
        public List<BCustomer> GetCustomersB()
        {
            return (from i in db.bCustomers where !i.DeleteStatus select i).ToList();
        }

        public void DeleteCustomerA(int ID)
        {
            ACustomer customer = db.aCustomers.Where(c => c.id == ID).FirstOrDefault();
            customer.DeleteStatus = true;
            db.SaveChanges();
        }
        public void DeleteCustomerB(int ID)
        {
            BCustomer customer = db.bCustomers.Where(c => c.id == ID).FirstOrDefault();
            customer.DeleteStatus = true;
            db.SaveChanges();
        }
        public bool EditCustomerA(ACustomer customer, int ID)
        {
            foreach (var item in db.aCustomers)
            {
                if (item.id != ID && item.FullName == customer.FullName && item.Phone == customer.Phone)
                {
                    return false;
                }
            }
            ACustomer aCustomer = db.aCustomers.Where(c => c.id == ID).FirstOrDefault();
            aCustomer.FullName = customer.FullName;
            aCustomer.Phone = customer.Phone;
            aCustomer.BuyCost += customer.BuyCost;
            db.SaveChanges();
            return true;
        }
        public bool EditCustomerB(BCustomer customer, int ID)
        {
            foreach (var item in db.bCustomers)
            {
                if (item.id != ID && item.FullName == customer.FullName && item.Phone==customer.Phone)
                {
                    return false;
                }
            }
            BCustomer bCustomer = db.bCustomers.Where(c => c.id == ID).FirstOrDefault();
            bCustomer.FullName = customer.FullName;
            bCustomer.Phone = customer.Phone;
            bCustomer.BuyCost += customer.BuyCost;
            db.SaveChanges();
            return true;
        }

        public List<ACustomer> PrintSerchResultCustomerA ( String Word )
        {
            return (from i in db.aCustomers where i.FullName.Contains(Word) select i).ToList();
        }
        public List<BCustomer> PrintSerchResultCustomerB ( String Word )
        {
            return (from i in db.bCustomers where i.FullName.Contains(Word) select i).ToList();
        }

        //  Buy Factor
        public int GetLastBuyFactorNumberA()
        {
            try
            {
                int code = ((from i in db.aBuyFactors select i.FactorNumber).Max() + 1);
                return code;
            }
            catch
            {
                return 1;
            }
        }
        public int GetLastBuyFactorNumberB()
        {
            try
            {
                int code = ((from i in db.bBuyFactors select i.FactorNumber).Max() + 1);
                return code;
            }
            catch
            {
                return 1;
            }
        }

        public int GetLastBuyFactorCodeA()
        {
            try
            {
                int code = ((from i in db.aBuyFactors select i.FactorCode).Max() + 1);
                return code;
            }
            catch
            {
                return 1001;
            }
        }
        public int GetLastBuyFactorCodeB()
        {
            try
            {
                int code = ((from i in db.bBuyFactors select i.FactorCode).Max() + 1);
                return code;
            }
            catch
            {
                return 1001;
            }
        }

        // Sell Factor

        public List<ASellFactor> GetSellFactorsA()
        {
            return (db.aSellFactors.Where(c => !c.DeleteStatus)).ToList();
        }
        public List<BSellFactor> GetSellFactorsB()
        {
            return (db.bSellFactors.Where(c => !c.DeleteStatus)).ToList();
        }

        public int GetLastSellFactorNumberA()
        {
            try
            {
                int code = ((from i in db.aSellFactors select i.FactorNumber).Max() + 1);
                return code;
            }
            catch
            {
                return 1;
            }
        }
        public int GetLastSellFactorNumberB()
        {
            try
            {
                int code = ((from i in db.bSellFactors select i.FactorNumber).Max() + 1);
                return code;
            }
            catch
            {
                return 1;
            }
        }

        public int GetLastSellFactorCodeA()
        {
            try
            {
                int code = ((from i in db.aSellFactors select i.FactorCode).Max() + 1);
                return code;
            }
            catch
            {
                return 1001;
            }
        }
        public int GetLastSellFactorCodeB()
        {
            try
            {
                int code = ((from i in db.bSellFactors select i.FactorCode).Max() + 1);
                return code;
            }
            catch
            {
                return 1001;
            }
        }

        public void CreateSellFactorA(ASellFactor factor)
        {
            db.aSellFactors.Add(factor);
            db.SaveChanges();
        }
        public void CreateSellFactorB(BSellFactor factor)
        {
            db.bSellFactors.Add(factor);
            db.SaveChanges();
        }
        public void SaveLastChangesOnSellFacotrA(ASellFactor factor)
        {
            ASellFactor Factor = db.aSellFactors.Where(c => c.FactorCode == factor.FactorCode).FirstOrDefault();
            Factor.FactorCode = factor.FactorCode;
            Factor.FactorNumber = factor.FactorNumber;
            Factor.RegisterDate = factor.RegisterDate;
            //Factor.Customer = factor.Customer;
            //Factor.admin = factor.admin;
            Factor.TotalPrice = factor.TotalPrice;
            Factor.CashType = factor.CashType;    //  نقدی
            Factor.Products.AddRange(factor.Products);
            db.SaveChanges();
        }
        public void SaveLastChangesOnSellFacotrB(BSellFactor factor)
        {
            BSellFactor Factor = db.bSellFactors.Where(c => c.FactorCode == factor.FactorCode).FirstOrDefault();
            Factor.FactorCode = factor.FactorCode;
            Factor.FactorNumber = factor.FactorNumber;
            Factor.RegisterDate = factor.RegisterDate;
            //Factor.Customer = factor.Customer;
            //Factor.admin = factor.admin;
            Factor.TotalPrice = factor.TotalPrice;
            Factor.CashType = factor.CashType;    //  نقدی
            Factor.Products.AddRange(factor.Products);
            db.SaveChanges();
        }
        //  Customer
        public ACustomer GetCustomerByPhoneA(String Phone)
        {
            return (db.aCustomers.Where(c => c.Phone == Phone).FirstOrDefault());
        }
        public BCustomer GetCustomerByPhoneB(String Phone)
        {
            return (db.bCustomers.Where(c => c.Phone == Phone).FirstOrDefault());
        }

        public void SaveEditCustomerA(ACustomer customer)
        {
            ACustomer CU= db.aCustomers.Where(c => c.Phone == customer.Phone).FirstOrDefault();
            CU.BuyCost = customer.BuyCost;
            db.SaveChanges();
        }
        public void SaveEditCustomerB(BCustomer customer)
        {
            BCustomer CU = db.bCustomers.Where(c => c.Phone == customer.Phone).FirstOrDefault();
            CU.BuyCost = customer.BuyCost;
            db.SaveChanges();
        }

        public List<ACheckBank> GetCheckBanksA()
        {
            return (db.aCheckBanks.Where(c => !c.DeleteStatus).OrderBy(c  => c.PassDate)).ToList();
        }
        public List<BCheckBank> GetCheckBanksB()
        {
            return (db.bCheckBanks.Where(c => !c.DeleteStatus).OrderBy(c => c.PassDate)).ToList();
        }

        public List<ACheckBank> GetCheckBanksSortSaveA()
        {
            return (db.aCheckBanks.Where(c => !c.DeleteStatus)).ToList();
        }
        public List<BCheckBank> GetCheckBanksSortSaveB()
        {
            return (db.bCheckBanks.Where(c => !c.DeleteStatus)).ToList();
        }

        public void CreateCheckBankA(ACheckBank checkBank)
        {
            db.aCheckBanks.Add(checkBank);
            db.SaveChanges();
        }
        public void CreateCheckBankB(BCheckBank checkBank)
        {
            db.bCheckBanks.Add(checkBank);
            db.SaveChanges();
        }

        public void UpdateCheckBankA(ACheckBank checkBank1,int ID)
        {
            ACheckBank checkBank = db.aCheckBanks.Where(c => c.id == ID).FirstOrDefault();
            checkBank.CustomerName = checkBank1.CustomerName;
            checkBank.BankName = checkBank1.BankName;
            checkBank.CheckNumber = checkBank1.CheckNumber;
            checkBank.SariNumber = checkBank1.SariNumber;
            checkBank.DayDate = checkBank1.DayDate;
            checkBank.PassDate = checkBank1.PassDate;
            checkBank.Details = checkBank1.Details;
            checkBank.Price = checkBank1.Price;
            db.SaveChanges();
        }
        public void UpdateCheckBankB(BCheckBank checkBank1, int ID)
        {
            BCheckBank checkBank = db.bCheckBanks.Where(c => c.id == ID).FirstOrDefault();
            checkBank.CustomerName = checkBank1.CustomerName;
            checkBank.BankName = checkBank1.BankName;
            checkBank.CheckNumber = checkBank1.CheckNumber;
            checkBank.SariNumber = checkBank1.SariNumber;
            checkBank.DayDate = checkBank1.DayDate;
            checkBank.PassDate = checkBank1.PassDate;
            checkBank.Details = checkBank1.Details;
            checkBank.Price = checkBank1.Price;
            db.SaveChanges();
        }

        public ACheckBank GetCheckBankA(int ID)
        {
            return (db.aCheckBanks.Where(c => c.id == ID).FirstOrDefault());
        }
        public BCheckBank GetCheckBankB(int ID)
        {
            return (db.bCheckBanks.Where(c => c.id == ID).FirstOrDefault());
        }

        public void DeleteCheckBanksA(int ID)
        {
            ACheckBank checkBank = db.aCheckBanks.Where(c => c.id == ID).FirstOrDefault();
            checkBank.DeleteStatus = true;
            db.SaveChanges();
        }
        public void DeleteCheckBanksB(int ID)
        {
            BCheckBank checkBank = db.bCheckBanks.Where(c => c.id == ID).FirstOrDefault();
            checkBank.DeleteStatus = true;
            db.SaveChanges();
        }
        public void ChangeStatusCheckBankA(int ID)
        {
            ACheckBank checkBank = db.aCheckBanks.Where(c => c.id == ID).FirstOrDefault();
            checkBank.Status = (checkBank.Status) ? false :true;
            db.SaveChanges();
        }
        public void ChangeStatusCheckBankB(int ID)
        {
            BCheckBank checkBank = db.bCheckBanks.Where(c => c.id == ID).FirstOrDefault();
            checkBank.Status = (checkBank.Status) ? false : true;
            db.SaveChanges();
        }

        public List<ACheckBank> ShowSearchResultForCheckBankA(String Word)
        {
            return (db.aCheckBanks.Where(c => c.PassDate == Word || c.CheckNumber.Contains(Word) || c.SariNumber.Contains(Word) || c.BankName.Contains(Word) || c.CustomerName.Contains(Word) || (c.FactorCode).ToString()==Word ).OrderBy(c => c.PassDate)).ToList();
        }
        public List<BCheckBank> ShowSearchResultForCheckBankB(String Word)
        {
            return (db.bCheckBanks.Where(c => c.PassDate == Word || c.CheckNumber.Contains(Word) || c.SariNumber.Contains(Word) || c.BankName.Contains(Word) || c.CustomerName.Contains(Word) || c.FactorCode == int.Parse(Word)).OrderBy(c => c.PassDate)).ToList();
        }

        public List<ACheckBank> ShowTodayChecksA(String Date)
        {
            return (db.aCheckBanks.Where(c => c.PassDate == Date ).OrderBy(c => c.PassDate)).ToList();
        }
        public List<BCheckBank> ShowTodayChecksB(String Date)
        {
            return (db.bCheckBanks.Where(c => c.PassDate == Date ).OrderBy(c => c.PassDate)).ToList();
        }

        public List<ACheckBank> ShowAllChecksBankPassedA()
        {
            return (db.aCheckBanks.Where( c => c.Status ).OrderBy(c => c.PassDate)).ToList();
        }
        public List<BCheckBank> ShowAllChecksBankPassedB()
        {
            return (db.bCheckBanks.Where( c => c.Status ).OrderBy(c => c.PassDate)).ToList();
        }

        public List<ACheckBank> ShowAllChecksBankNotPassedA()
        {
            return (db.aCheckBanks.Where( c => !c.Status ).OrderBy(c => c.PassDate)).ToList();
        }
        public List<BCheckBank> ShowAllChecksBankNotPassedB()
        {
            return (db.bCheckBanks.Where( c => !c.Status ).OrderBy(c => c.PassDate)).ToList();
        }

        public void PassingTodayChecksA(int ID)
        {
            ACheckBank checkBank = db.aCheckBanks.Where(c => c.id == ID).FirstOrDefault();
            checkBank.Status = true;
            db.SaveChanges();
        }
        public void PassingTodayChecksB(int ID)
        {
            BCheckBank checkBank = db.bCheckBanks.Where(c => c.id == ID).FirstOrDefault();
            checkBank.Status = true;
            db.SaveChanges();
        }

        //  گزارش گیری
        //  محصولات خریده شده در سال 
        public List<AProduct> ShowSearchResultForYearA(String Start,String End)
        {
            return (db.aProducts.Where(c => !c.DeleteStatus && (String.Compare(c.RegisterDate, Start) == 1 && String.Compare(End, c.RegisterDate) == 1)).OrderBy(c => c.RegisterDate).ThenBy(c => c.SellCount)).ToList();
        }
        public List<BProduct> ShowSearchResultForYearB(String Start,String End)
        {
            return (db.bProducts.Where(c => !c.DeleteStatus && (String.Compare(c.RegisterDate, Start) == 1 && String.Compare(End, c.RegisterDate) == 1)).OrderBy(c => c.RegisterDate).ThenBy(c => c.SellCount)).ToList();
        }
        //  پر فروش ترین ها
        public List<AProduct> ShowMoreSellProductA()
        {
            return (from i in db.aProducts orderby i.SellCount descending where !i.DeleteStatus select i).ToList();
        }
        public List<BProduct> ShowMoreSellProductB()
        {
            return (from i in db.bProducts orderby i.SellCount descending where !i.DeleteStatus select i).ToList();
        }
        //  کم فروش ترین ها
        public List<AProduct> ShowLessSellProductA()
        {
            return (from i in db.aProducts orderby i.SellCount where !i.DeleteStatus select i).ToList();
        }
        public List<BProduct> ShowLessSellProductB()
        {
            return (from i in db.bProducts orderby i.SellCount where !i.DeleteStatus select i).ToList();
        }
        //  پر فروش ترین ها بانکی
        public List<AProduct> ShowMoreBankiSellProductA()
        {
            return (from i in db.aProducts orderby i.SellCount descending where (!i.DeleteStatus && i.CashType==2) select i).ToList();
        }
        public List<BProduct> ShowMoreBankiSellProductB()
        {
            return (from i in db.bProducts orderby i.SellCount descending where ( !i.DeleteStatus && i.CashType == 2 ) select i).ToList();
        }
        //  پر فروش ترین ها نقدی
        public List<AProduct> ShowMoreMoneySellProductA()
        {
            return (from i in db.aProducts orderby i.SellCount descending where (!i.DeleteStatus && i.CashType == 1) select i).ToList();
        }
        public List<BProduct> ShowMoreMoneySellProductB()
        {
            return (from i in db.bProducts orderby i.SellCount descending where (!i.DeleteStatus && i.CashType == 1) select i).ToList();
        }
        //  کم فروش ترین ها بانکی
        public List<AProduct> ShowLessBankiSellProductA()
        {
            return (from i in db.aProducts orderby i.SellCount descending where (!i.DeleteStatus && i.CashType == 2) select i).ToList();
        }
        public List<BProduct> ShowLessBankiSellProductB()
        {
            return (from i in db.bProducts orderby i.SellCount descending where (!i.DeleteStatus && i.CashType == 2) select i).ToList();
        }
        //  کم فروش ترین ها نقدی
        public List<AProduct> ShowLessMoneySellProductA()
        {
            return (from i in db.aProducts orderby i.SellCount where (!i.DeleteStatus && i.CashType == 1) select i).ToList();
        }
        public List<BProduct> ShowLessMoneySellProductB()
        {
            return (from i in db.bProducts orderby i.SellCount where (!i.DeleteStatus && i.CashType == 1) select i).ToList();
        }

    }
}