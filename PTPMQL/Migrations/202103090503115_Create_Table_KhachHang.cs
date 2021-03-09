namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KhachHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chitietdonhang",
                c => new
                    {
                        Machitietdonhang = c.Int(nullable: false),
                        Madonhang = c.Int(nullable: false),
                        Mathang = c.Int(nullable: false),
                        Dongia = c.Decimal(nullable: false, storeType: "money"),
                        Soluong = c.Int(nullable: false),
                        Thanhtien = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.Machitietdonhang)
                .ForeignKey("dbo.Danhmuchang", t => t.Mathang, cascadeDelete: true)
                .ForeignKey("dbo.Donhang", t => t.Madonhang, cascadeDelete: true)
                .Index(t => t.Madonhang)
                .Index(t => t.Mathang);
            
            CreateTable(
                "dbo.Danhmuchang",
                c => new
                    {
                        Mathang = c.Int(nullable: false),
                        Tenhang = c.String(nullable: false, maxLength: 50),
                        Manhomhang = c.Int(nullable: false),
                        Donvitinh = c.String(maxLength: 30),
                        Dongia = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.Mathang)
                .ForeignKey("dbo.Nhomhang", t => t.Manhomhang, cascadeDelete: true)
                .Index(t => t.Manhomhang);
            
            CreateTable(
                "dbo.Nhomhang",
                c => new
                    {
                        Manhomhang = c.Int(nullable: false),
                        Tennhomhang = c.String(nullable: false, maxLength: 50),
                        Mota = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Manhomhang);
            
            CreateTable(
                "dbo.Donhang",
                c => new
                    {
                        Madonhang = c.Int(nullable: false),
                        Makhachhang = c.Int(nullable: false),
                        Ngaydathang = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Madonhang)
                .ForeignKey("dbo.Khachhang", t => t.Makhachhang, cascadeDelete: true)
                .Index(t => t.Makhachhang);
            
            CreateTable(
                "dbo.Khachhang",
                c => new
                    {
                        Makhachhang = c.Int(nullable: false),
                        Hodem = c.String(nullable: false, maxLength: 50),
                        Ten = c.String(nullable: false, maxLength: 20),
                        Diachi = c.String(maxLength: 200),
                        Sodienthoai = c.String(maxLength: 20),
                        Email = c.String(maxLength: 50),
                        Gioitinh = c.Boolean(),
                        Ngaysinh = c.DateTime(),
                    })
                .PrimaryKey(t => t.Makhachhang);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Donhang", "Makhachhang", "dbo.Khachhang");
            DropForeignKey("dbo.Chitietdonhang", "Madonhang", "dbo.Donhang");
            DropForeignKey("dbo.Danhmuchang", "Manhomhang", "dbo.Nhomhang");
            DropForeignKey("dbo.Chitietdonhang", "Mathang", "dbo.Danhmuchang");
            DropIndex("dbo.Donhang", new[] { "Makhachhang" });
            DropIndex("dbo.Danhmuchang", new[] { "Manhomhang" });
            DropIndex("dbo.Chitietdonhang", new[] { "Mathang" });
            DropIndex("dbo.Chitietdonhang", new[] { "Madonhang" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.Khachhang");
            DropTable("dbo.Donhang");
            DropTable("dbo.Nhomhang");
            DropTable("dbo.Danhmuchang");
            DropTable("dbo.Chitietdonhang");
        }
    }
}
