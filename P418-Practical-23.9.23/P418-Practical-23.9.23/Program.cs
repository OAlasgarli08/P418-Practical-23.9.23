// Number 1

//int[] nums = { 1, 2, 3, 4, 5, 6 };

//var result = nums.Rank;

//Console.WriteLine(result);

// -------------------------------------------------------------------------

// Number 2

//int[] nums = { 10, 2, 3, 4, 5, 6 };

//Array.Sort(nums);

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}

// -------------------------------------------------------------------------

// Number 3

//int[] nums = { 10, 2, 3, 4, 5, 6 };

//Array.Reverse(nums);

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}

// -------------------------------------------------------------------------

// Number 4

//int[] nums = { 10, 2, 3, 4, 5, 6 };

//var newArr = nums.Clone() as int[];

//foreach (var item in newArr)
//{
//    Console.WriteLine(item);
//}

// -------------------------------------------------------------------------

// Number 5

//var source = new[] { "A", "B", "C" };
//var target = new string[4];

//source.CopyTo(target, 0);

//foreach (var item in target)
//{
//    Console.WriteLine(item);
//}

// -------------------------------------------------------------------------

// Number 6

//int[] numbs = { 1, 2, 3, 4, 5, 7, 9, 10 };
//int[] newArr = { 11, 14, 17 };

//int arrayCount = newArr.Length;

//Array.Resize(ref newArr, numbs.Length + newArr.Length);

//numbs.CopyTo(newArr, arrayCount);

//foreach (var item in newArr)
//{
//    Console.WriteLine(item);
//}

// -------------------------------------------------------------------------

// Number 7

//int[] nums = { 10, 2, 3, 4, 5, 6 };

//var result = Array.Exists(nums, x => x == 1);
//Console.WriteLine(result);

// -------------------------------------------------------------------------

// Number 8

//int[] nums = { 10, 2, 3, 4, 5, 6 };

//var result = Array.Find(nums, x => x == 1);
//Console.WriteLine(result);

// -------------------------------------------------------------------------

// Number 9

//var stu1 = new
//{
//    name = "A",
//    surname = "B",
//    age = 30,
//};

//var stu2 = new
//{
//    name = "D",
//    surname = "E",
//    age = 40,
//};

//Console.WriteLine(stu2.name);

// -------------------------------------------------------------------------

// Number 10


//using P418_Practical_23._9._23;

//Student stu1 = new Student();
//stu1.name = "A";
//Console.WriteLine(stu1.name);

//Student stu2 = new Student();
//stu2.name =  "B";
//Console.WriteLine(stu2.name);

// -------------------------------------------------------------------------

// Number 11


//using P418_Practical_23._9._23;


//Student stu1 = new Student();
//stu1.name = "A";
//stu1.age = 20;
//stu1.surname = "B";

//Student stu2 = new Student();
//stu2.name = "D";
//stu2.age = 30;
//stu2.surname = "E";

//Console.WriteLine(stu1.name + " " + stu1.surname);
//Console.WriteLine(stu2.name + " " + stu2.surname);