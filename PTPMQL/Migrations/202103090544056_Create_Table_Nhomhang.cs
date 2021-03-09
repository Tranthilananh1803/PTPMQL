namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Nhomhang : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Donhang", "Makhachhang", "dbo.Khachhang");
            DropIndex("dbo.Donhang", new[] { "Makhachhang" });
            RenameColumn(table: "dbo.Donhang", name: "Makhachhang", newName: "Khachhang_Makhachhang");
            AlterColumn("dbo.Donhang", "Khachhang_Makhachhang", c => c.Int());
            CreateIndex("dbo.Donhang", "Khachhang_Makhachhang");
            AddForeignKey("dbo.Donhang", "Khachhang_Makhachhang", "dbo.Khachhang", "Makhachhang");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Donhang", "Khachhang_Makhachhang", "dbo.Khachhang");
            DropIndex("dbo.Donhang", new[] { "Khachhang_Makhachhang" });
            AlterColumn("dbo.Donhang", "Khachhang_Makhachhang", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Donhang", name: "Khachhang_Makhachhang", newName: "Makhachhang");
            CreateIndex("dbo.Donhang", "Makhachhang");
            AddForeignKey("dbo.Donhang", "Makhachhang", "dbo.Khachhang", "Makhachhang", cascadeDelete: true);
        }
    }
}
