namespace RPGGameCharacterCreator
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CharacterCreatorDB : DbContext
    {
        // Your context has been configured to use a 'CharacterCreatorDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'RPGGameCharacterCreator.CharacterCreatorDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CharacterCreatorDB' 
        // connection string in the application configuration file.
        public CharacterCreatorDB()
            : base("name=CharacterCreatorDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<GameCharacter> GameCharacters { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}