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
        public bool SelectionCompanyA(ACompany company)
        {
            foreach (var item in db.aCompanies)
            {
                if (item.id != company.id && item.CompanyName == company.CompanyName && item.CompanyManager == company.CompanyManager)
                {
                    return true;
                }
            }
            return false;
        }
        public bool SelectionCompanyB(BCompany company)
        {
            foreach (var item in db.bCompanies)
            {
                if (item.id != company.id && item.CompanyName == company.CompanyName && item.CompanyManager == company.CompanyManager)
                {
                    return true;
                }
            }
            return false;
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

        public List<ACompany> ShowActiveDataCompanyA()
        {
            return (from i in db.aCompanies where i.isActive && !i.DeleteStatus select i).ToList();
        }
        public List<BCompany> ShowActiveDataCompanyB()
        {
            return (from i in db.bCompanies where i.isActive && !i.DeleteStatus select i).ToList();
        }

        public List<ACompany> ShowAllDataCompanyA()
        {
            return (from i in db.aCompanies where !i.DeleteStatus select i).ToList();
        }
        public List<BCompany> ShowAllDataCompanyB()
        {
            return (from i in db.bCompanies where !i.DeleteStatus select i).ToList();
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

        public void DeleteCompany(String Admin,int ID)
        {
            if(Admin == "1")
            {
                ACompany company = db.aCompanies.Where(c => c.id == ID).First();
                company.DeleteStatus = true;
                company.isActive = false;
            }
            else if(Admin == "2")
            {
                BCompany company = db.bCompanies.Where(c => c.id == ID).First();
                company.DeleteStatus = true;
                company.isActive = false;
            }
            db.SaveChanges();
        }

        public void ChangeStatusCompany(String Admin,int ID)
        {
            if (Admin == "1")
            {
                ACompany company = db.aCompanies.Where(c => c.id == ID).First();
                company.DeleteStatus = false;
                company.isActive = (company.isActive) ? false : true;
            }
            else if (Admin == "2")
            {
                BCompany company = db.bCompanies.Where(c => c.id == ID).First();
                company.DeleteStatus = false;
                company.isActive = (company.isActive) ? false : true;

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
            return (from i in db.aAdmins where !i.DeleteStatus select i).ToList();
        }
        public List<BAdmin> readadminB()
        {
            return (from i in db.bAdmins where !i.DeleteStatus select i).ToList();
        }

        public List<AAdmin> ShowAllAdminDataA()
        {
            return (from i in db.aAdmins where i.id>0 select i).ToList();
        }
        public List<BAdmin> ShowAllAdminDataB()
        {
            return (from i in db.bAdmins where i.id>0 select i).ToList();
        }

        public List<AAdmin> ShowSearchResultA(String AdminNumber, String Word)
        {
            return (from i in db.aAdmins where (i.Name.Contains(Word) || i.Family.Contains(Word)) && !i.DeleteStatus select i).ToList();
        }
        public List<BAdmin> ShowSearchResultB(String AdminNumber, String Word)
        {
            return (from i in db.bAdmins where (i.Name.Contains(Word) || i.Family.Contains(Word)) && !i.DeleteStatus select i).ToList();
        }

        public void ChangeStatusAdminA(int ID)
        {
            foreach(var item in db.aAdmins)
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
            foreach(var item in db.aAdmins)
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

        // Agent Register

        public bool SelectionAgentA(AAgent agent)
        {
            foreach (var item in db.aAgents)
            {
                if (item.Name == agent.Name && item.Family == agent.Family)
                {
                    return true;
                }
            }
            return false;
        }
        public bool SelectionAgentB(BAgent agent)
        {
            foreach (var item in db.bAgents)
            {
                if (item.Name == agent.Name && item.Family == agent.Family)
                {
                    return true;
                }
            }
            return false;
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

        public List<AAgent> ShowAllDataAgentA()
        {
            return (from i in db.aAgents where !i.DeleteStatus select i).ToList();
        }
        public List<BAgent> ShowAllDataAgentB()
        {
            return (from i in db.bAgents where !i.DeleteStatus select i).ToList();
        }

        public List<AAgent> ShowAllActiveDataAgentA()
        {
            return (from i in db.aAgents where !i.DeleteStatus && i.IsActive select i).ToList();
        }
        public List<BAgent> ShowAllActiveDataAgentB()
        {
            return (from i in db.bAgents where !i.DeleteStatus && i.IsActive select i).ToList();
        }

        public List<AAgent> ShowAllDataAgentcompleteA()
        {
            return (from i in db.aAgents select i).ToList();
        }
        public List<BAgent> ShowAllDataAgentcompleteB()
        {
            return (from i in db.bAgents select i).ToList();
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
                if (item.Id != agent.Id && item.Name == agent.Name && item.Family == agent.Family)
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
                if (item.Id != agent.Id && item.Name == agent.Name && item.Family == agent.Family)
                {
                    return false;
                }
            }
            agent.DeleteStatus = false;
            db.SaveChanges();
            return true;
        }

        public void DeleteAgent(String Admin,int ID)
        {
            if(Admin == "1")
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

        public void ChangeStatusAgent(String Admin,int ID)
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

    }
}
