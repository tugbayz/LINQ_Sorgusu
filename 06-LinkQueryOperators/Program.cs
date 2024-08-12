
using _06_LinkQueryOperators;

List<Person> personList = new List<Person>()
{
    new Person(){personID=1,PersonName="Jhon",Age=20,City="İstanbul"},
    new Person(){personID=2,PersonName="Ali",Age=22,City="İstanbul"},
    new Person(){personID=3,PersonName="Selen",Age=15,City="İstanbul"},
    new Person(){personID=4,PersonName="Merve",Age=19,City="Ankara"},
    new Person(){personID=5,PersonName="Deniz",Age=20,City="İzmir"}
};

#region Select
// query syntax
var select1 = from p in personList select p; // select* from PersonList
var selectColumn1 = from p in personList select new { p.PersonName, p.City }; // select personNeame, city from PersonList
// metot syntax
var select2 = personList.ToList(); // select * from personList
var selectColumn2 = personList.Select(p => new { p.PersonName, p.City });

#endregion

#region where
// where, belirli bir ölçüt ifadesine göre koleksiyonu filtreler ve yeni bir koleksiyon döndürür,
// Kriterler lamda ifadesi veya  Func temsilci tütü olarak belitilebilir.
//Query syntax
var where1 = from p in personList where p.Age > 12 && p.Age < 30 select p;
foreach(var item in where1)
{
    Console.WriteLine($"person ıd : {item.personID} Name: {item.PersonName}");
}


#endregion

#region orderBy
//orderBy bir koleksiyonun değerlerini artan yada azalan düzende sıralar.
//Query syntax
var orderby1 = from p in personList orderby p.PersonName ascending select p;
var orderbyDesc1 =  from p in personList orderby p.PersonName descending select p;
//metot syntax
var orderby2 = personList.OrderBy(p => p.PersonName);
var orderbyDesc2= personList.OrderByDescending(p => p.PersonName);
#endregion

#region groupby
// groupby bazı anahtar değerleri temel alarak verilen koleksiyondan bir grup öğe döndürür

// Query syntax
var groupby1 = from p in personList group p by p.Age;
// metot syntax
var groupby2 = personList.GroupBy(p => p.Age);

#endregion
#region Any
// herhangi bir elemanın verilen koşulu sağlayıp sağlamadığını kontrol eder.
//metot syntax,
bool any1 =personList.Any(p=>p.City=="İstanbul");

#endregion
#region Conteins
// koleksiyonda belirtilen bir öğenin var olup olmadığını kontrol eder ve bir bool döndürür.
//metot syntax
Person prs = new Person() { personID = 3, PersonName = "Bill", Age = 25, City = "İstanbul" };
bool conteins1 = personList.Contains(prs);
#endregion

#region Avarage
//sayısal verilerin ortalamasını döndürür
//Method syntax
var avg = personList.Average(p => p.Age);

#endregion

#region Count
// Koleksiyondaki öğelerin sayısını veya verilen koşulu sağlayan öğelerin sayısını döndürür.
var Count = personList.Count();

#endregion
#region maxMin
// sayısal verilerin max min dödürür.
//metot syntax
var max = personList.Max(p => p.Age);
var min = personList.Min(p => p.Age);
#endregion

#region Sum
//Sayısal verilen toplamıını döndürür.
var sum = personList.Sum(p => p.Age);

#endregion