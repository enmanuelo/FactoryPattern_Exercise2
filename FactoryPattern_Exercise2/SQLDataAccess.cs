using System;
namespace FactoryPattern_Exercise2
{
	public class SQLDataAccess : IDataAccess
	{
		public SQLDataAccess()
		{
		}
		public void LoadData()
		{
			Console.WriteLine("I am reading data from an SQL database");
		}
		public void SaveData()
		{
			Console.WriteLine("I am saving data from an SQL database");
		}
	}
}

