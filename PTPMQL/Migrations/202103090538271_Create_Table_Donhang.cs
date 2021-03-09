namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Donhang : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Khachhang", "Hodem", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Khachhang", "Ten", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.Khachhang", "Diachi", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.Khachhang", "Sodienthoai", c => c.String(maxLength: 20, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Khachhang", "Sodienthoai", c => c.String(maxLength: 20));
            AlterColumn("dbo.Khachhang", "Diachi", c => c.String(maxLength: 200));
            AlterColumn("dbo.Khachhang", "Ten", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Khachhang", "Hodem", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
