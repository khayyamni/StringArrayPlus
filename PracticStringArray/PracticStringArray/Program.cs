//static string ReverseStr(string str)
//{
//    string result = "";
//    for (int i = str.Length - 1; i >= 0; i--)
//    {
//        result += str[i];
//    }

//    return result;
//}

//Console.WriteLine(ReverseStr("Cavid"));



//static void StrToUpper(string str, int index)
//{
//    var firstChar = str[0].ToString().ToUpper();
//    var charArray = str.ToCharArray();

//    charArray[0] = Convert.ToChar(firstChar);

//    string result = string.Empty;

//    foreach (var item in charArray)
//    {
//        result += item;
//    }

//    Console.WriteLine(result);
//}


//StrToUpper("fidan",1);


//string name = "Fidan";

//Console.WriteLine(name.Contains("i"));

//Console.WriteLine(name.Equals("Fidan"));

//Console.WriteLine(name.StartsWith("F"));

//Console.WriteLine(name.EndsWith("F"));

//Console.WriteLine(name.Substring(1,2));

//Console.WriteLine(name.LastIndexOf("n"));

//Console.WriteLine(name.GetType());


//static bool Search(string str, string searchText)
//{
//    if(str.Trim().ToLower().Contains(searchText.Trim().ToLower()))        return true;
//    return true;

//    return false;
//}

//Console.WriteLine(Search("Azerbaycan", "can"));


//static bool Search(string str,string searchText)
//{
//    return str.Trim().ToLower().Contains(searchText.Trim().ToLower());
//}

//if (Search("salam", "can"))
//{
//    Console.WriteLine("Found");
//}
//else
//{
//    Console.WriteLine("Notfound");
//}

//int[] arr1 = new int[2];
//int[] arr2 = new int[2] { 1, 5 };


//Array.Reverse(numbers);

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine(numbers.FirstOrDefault());

//Console.WriteLine(numbers.LastOrDefault());


//int[] numbers = { 1, 2, 55,32,3, 4, 5 };

//Console.WriteLine(numbers.Any(m=>m==5));

//Array.Sort(numbers);

//var data = numbers.OrderByDescending(x => x).ToArray();

//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}


//int[] nums = new int[3];
//nums[0] = 20;
//nums[1] = 30;
//nums[2] = 22;

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}


//int[] nums = new int[3];
//nums[0] = 20;
//nums[1] = 30;
//nums[2] = 22;

//Console.WriteLine(nums.Rank);


//static void Search(string searchText)
//{
//    string[] people = { "Kubra", "Fidan", "Samir", "Ismayil" };

//    foreach (var item in people)
//    {
//        if (item.Trim().ToLower() == searchText.Trim().ToLower()) ;
//        return;
//    }
//}

//Search("   fidan");


//string name1 = "Ismayil";
//string surname1 = "Efendizade";
//int age1 = 29;


//string name2 = "Xeyyam";
//string surname2 = "Isgenderov";
//int age2 = 29;


//string name3 = "Cahangir";
//string surname3 = "Axundov";
//int age3 = 20;

//string stu1 = $"{name1} {surname1} {age1}";
//string stu2 = $"{name2} {surname2} {age2}";
//string stu3 = $"{name3} {surname3} {age3}";

//Console.WriteLine(stu1);
//Console.WriteLine(stu2);
//Console.WriteLine(stu3);



//string name1 = "Ismayil";
//string surname1 = "Efendizade";
//int age1 = 29;


//string name2 = "Xeyyam";
//string surname2 = "Isgenderov";
//int age2 = 29;


//string name3 = "Cahangir";
//string surname3 = "Axundov";
//int age3 = 20;



//var stu1 = new
//{
//    name = "Ismayil",
//    surname = "Efendizade",
//    age = 29
//};

//var stu2 = new
//{
//    name = "Xeyyam",
//    surname = "Isgenderov",
//    age = 29
//};

//var stu3 = new
//{
//    name = "Cahangir",
//    surname = "Axundov",
//    age = 20
//};





//Console.WriteLine(stu1);
//Console.WriteLine(stu2);
//Console.WriteLine(stu3);

//string resul1 = $"{stu1.name} {stu1.surname} {stu1.age}";
//string resul2 = $"{stu2.name} {stu2.surname} {stu2.age}";




//Student stu1 = new Student();
//stu1.name = "Ismayil";
//stu1.surname = "Efendizade";
//stu1.age = 29;
//stu1.address = "Yasamal";


//Student stu2 = new Student();
//stu2.name = "Xeyyam";
//stu2.surname = "Xeyyam";
//stu2.age = 29;
//stu2.address = "Yasamal";




//Student stu3 = new()
//{
//        name = "Kubra",
//        surname = "Memmedova",
//        age = 25,
//        address = "Xalqlar"
//};

//Student [] students  = { stu1, stu2, stu3 };


//foreach (var item in students)
//{
//    Console.WriteLine(item.name + " " + item.surname);
//}






//class Student
//{
//    public string name;
//    public string surname;
//    public int age;
//    public string address;
//}

using PracticStringArray;

//Student stu1 = new Student();
//stu1.name = "Ismayil";
//stu1.surname = "Efendizade";
//stu1.age = 29;
//stu1.address = "Yasamal";


//Student stu2 = new Student();
//stu2.name = "Xeyyam";
//stu2.surname = "Xeyyam";
//stu2.age = 29;
//stu2.address = "Yasamal";


//Console.WriteLine("Add name:");
//string name = Console.ReadLine();

//Console.WriteLine("Add surnname:");
//string surname = Console.ReadLine();


//Console.WriteLine("Add age:");
//int age = int.Parse (Console.ReadLine());

//Console.WriteLine("Add address:");
//string address = Console.ReadLine();


//Student stu3 = new()
//{
//    name = name,
//    surname = surname,
//    age = age,
//    address = address
//};

//Console.WriteLine(stu3.name + " " +stu3.surname);





////Student[] students = { stu1, stu2, stu3 };


////foreach (var item in students)
////{
////    Console.WriteLine(item.name + " " + item.surname);
////}




////Book book1 = new Book()
////{
////    name = "Xosrov ve Shirin",
////    author = "Nizami",
////};

////Console.WriteLine(book1.name + " " + book1.author);