namespace Receptbank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ett : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.IngredientRecipes", newName: "RecipeIngredients");
            DropForeignKey("dbo.Notes", "Recipe_Id", "dbo.Recipes");
            DropIndex("dbo.Notes", new[] { "Recipe_Id" });
            DropPrimaryKey("dbo.RecipeIngredients");
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Recipe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id)
                .Index(t => t.Recipe_Id);
            
            AddColumn("dbo.Recipes", "ImageUrl", c => c.String());
            AlterColumn("dbo.Recipes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Notes", "Comment", c => c.String(nullable: false));
            AlterColumn("dbo.Notes", "Recipe_Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.RecipeIngredients", new[] { "Recipe_Id", "Ingredient_Id" });
            CreateIndex("dbo.Notes", "Recipe_Id");
            AddForeignKey("dbo.Notes", "Recipe_Id", "dbo.Recipes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.Tags", "Recipe_Id", "dbo.Recipes");
            DropIndex("dbo.Tags", new[] { "Recipe_Id" });
            DropIndex("dbo.Notes", new[] { "Recipe_Id" });
            DropPrimaryKey("dbo.RecipeIngredients");
            AlterColumn("dbo.Notes", "Recipe_Id", c => c.Int());
            AlterColumn("dbo.Notes", "Comment", c => c.String());
            AlterColumn("dbo.Recipes", "Name", c => c.String());
            DropColumn("dbo.Recipes", "ImageUrl");
            DropTable("dbo.Tags");
            AddPrimaryKey("dbo.RecipeIngredients", new[] { "Ingredient_Id", "Recipe_Id" });
            CreateIndex("dbo.Notes", "Recipe_Id");
            AddForeignKey("dbo.Notes", "Recipe_Id", "dbo.Recipes", "Id");
            RenameTable(name: "dbo.RecipeIngredients", newName: "IngredientRecipes");
        }
    }
}
