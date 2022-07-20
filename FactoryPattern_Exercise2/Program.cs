using FactoryPattern_Exercise2;

Console.WriteLine("What databse would you like to use?\nList, SQL, or Mongo");
var userInput = Console.ReadLine().ToLower();

IDataAccess userDatabase = DataAccessFactory.GetDataAccessType(userInput);

userDatabase.LoadData();
userDatabase.SaveData();