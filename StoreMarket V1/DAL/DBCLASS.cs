using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BEE;
namespace DAL
{
    public class DBCLASS : DbContext
    {

        #region Comment
        // Your context has been configured to use a 'DBCode1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Store_Market_1.DBCode1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBCode1' 
        // connection string in the application configuration file.
        #endregion
        public DBCLASS()
            : base("DBCLASS")
        {
            
        }
        public DbSet<OWNER> Owner { set; get; }
        public DbSet<AAdminBankAccount> aAdminBankAccounts { set; get; }
        public DbSet<BAdminBankAccount> bAdminBankAccounts { set; get; }
        public DbSet<AAgentBankAccount> aAgentBankAccounts { set; get; }
        public DbSet<BAgentBankAccount> bAgentBankAccounts { set; get; }
        public DbSet<AAdmin> aAdmins { set; get; }
        public DbSet<BAdmin> bAdmins { set; get; }
        public DbSet<ACustomer> aCustomers { set; get; }
        public DbSet<BCustomer> bCustomers { set; get; }
        public DbSet<AAgent> aAgents { set; get; }
        public DbSet<BAgent> bAgents { set; get; }
        public DbSet<ACompany> aCompanies { set; get; }
        public DbSet<BCompany> bCompanies { set; get; }
        public DbSet<ACheckBank> aCheckBanks { set; get; }
        public DbSet<BCheckBank> bCheckBanks { set; get; }
        public DbSet<ABuyFactor> aBuyFactors { set; get; }
        public DbSet<BBuyFactor> bBuyFactors { set; get; }
        public DbSet<ASellFactor> aSellFactors { set; get; }
        public DbSet<BSellFactor> bSellFactors { set; get; }
        public DbSet<AProduct> aProducts { set; get; }
        public DbSet<BProduct> bProducts { set; get; }
        public DbSet<ALogInformation> aLogInformation { get; set; }
        public DbSet<BLogInformation> bLogInformation { get; set; }

        #region Comment
        //Add a DbSet for each entity type that you want to include in your model.For more information

        //on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        #endregion

        #region Comment
        //public class MyEntity
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //}
        #endregion
    }
}