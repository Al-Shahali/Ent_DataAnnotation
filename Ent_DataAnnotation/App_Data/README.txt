Connection String

	using System.IO;

1-	protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(@"Data Source =.\sqlexpress; AttachDbFilename="+ Path.GetFullPath(@"App_Data\BKStore.mdf;")+ @";Integrated Security=True;User Instance=True");
