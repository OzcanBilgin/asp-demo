namespace JwtWithMongo.Database
{
	public interface IDatabaseSettings
	{
		string CollectionName { get; set; }

		string CollectionString { get; set; }

		string DatabaseName { get; set; }
	}
}

