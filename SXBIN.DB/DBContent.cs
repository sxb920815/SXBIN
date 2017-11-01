using System.Data.Entity;
using SXBIN.DB.Model;

namespace FMA.DB
{
	public class DBContext : DbContext
	{
        public DbSet<AdminUser> AdminUser { get; set; }
        public DbSet<Member> Member { get; set; }

        public DBContext()
		{
			Database.SetInitializer<DBContext>(new CreateDatabaseIfNotExists<DBContext>());

			/* 策略一：数据库不存在时重新创建数据库
			 * Database.SetInitializer<testContext>(new CreateDatabaseIfNotExists<testContext>());
			 * 
			 * 策略二：每次启动应用程序时创建数据库
			 * Database.SetInitializer<testContext>(new DropCreateDatabaseAlways<testContext>());
			 * 
			 * 策略三：模型更改时重新创建数据库
			 * Database.SetInitializer<testContext>(new DropCreateDatabaseIfModelChanges<testContext>());
			 * 
			 * 策略四：从不创建数据库
			 * Database.SetInitializer<testContext>(null);
			*/
			//
		}

		public DBContext(string conn)
			: base(conn)
		{
			//是否启用延迟加载:  
			//  true:   延迟加载（Lazy Loading）：获取实体时不会加载其导航属性，一旦用到导航属性就会自动加载  
			//  false:  直接加载（Eager loading）：通过 Include 之类的方法显示加载导航属性，获取实体时会即时加载通过 Include 指定的导航属性  
			this.Configuration.LazyLoadingEnabled = true;

			this.Configuration.AutoDetectChangesEnabled = true;  //自动监测变化，默认值为 true  
		}

		/// <summary>  
		/// 实体到数据库结构的映射是通过默认的约定来进行的，如果需要修改的话，有两种方式，分别是：Data Annotations 和 Fluent API  
		//  以下示范通过 Fluent API 来修改实体到数据库结构的映射  
		/// </summary>  
		/// <param name="modelBuilder"></param>  
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
