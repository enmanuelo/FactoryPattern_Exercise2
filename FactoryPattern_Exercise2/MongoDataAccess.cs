using System;
namespace FactoryPattern_Exercise2
{
	public class MongoDataAccess : IDataAccess
	{
		public MongoDataAccess()
		{
		}
		public void LoadData()
		{
			Console.WriteLine("I am reading data from a mongo database");
		}
		public void SaveData()
		{
			Console.WriteLine("I am saving data from a mongo database");
		}
	}
}

