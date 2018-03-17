namespace RPGGameCharacterCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCharacterID : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameCharacters",
                c => new
                    {
                        CharacterID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        XP = c.Int(nullable: false),
                        VIT = c.Int(nullable: false),
                        STR = c.Int(nullable: false),
                        DEF = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CharacterID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GameCharacters");
        }
    }
}
