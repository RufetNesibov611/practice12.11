


using System.Collections;
using System.Xml.Linq;

//ArrayList  list = new ArrayList();

//list.Add("salam");

//list.Add(5);

//list.Add(true);

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}


//Hashtable hashtable = new Hashtable();

//hashtable.Add(1, "salam");
//hashtable.Add(2, "sagol");

//foreach (DictionaryEntry item in hashtable)
//{
//    Console.WriteLine(item.Key + " " + item.Value);
//}

//SortedList sortedList = new SortedList();

//sortedList.Add("a", "salam");
//sortedList.Add("c", "telefonla oynama");
//sortedList.Add("b", "hello");

//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Key + " " + item.Value);
//}

//SortedList<int, string> datas = new SortedList<int, string>();

//datas.Add(1, "telefo");

//datas.Add(2, "oynam");
//foreach (KeyValuePair<int,string> data in datas)
//{
//    if(data.Key == 1)
//    {
//        Console.WriteLine(data.Value);
//    }
//}

Dictionary<int,string>roles = new Dictionary<int,string>();

roles.Add(1, "Admin");
roles.Add(2, "Member");

foreach (KeyValuePair<int,string>item in roles)
{
    Console.WriteLine(item.Value);
}



