using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WFKS.Check.Search.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class UserContext : DbContext
    {
        /// <summary>
        ///您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        ///使用“ContactsModel”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        ///“MvcApplication1.Models.ContactsModel”数据库。
        /// 
        ///如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“ContactsModel”
        ///连接字符串。
        /// </summary>
        public UserContext()
            : base("name=Sqlite")
        {
        }

        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

        /// <summary>
        /// 文件DbSet
        /// </summary>
        public virtual DbSet<User> User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //解决EF动态建库数据库表名变为复数问题  
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}
