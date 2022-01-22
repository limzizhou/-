// 常见资料形态 & 变数

// 字串 string "林某"
// 字元 char 'a'
// 整数 int 8964 -8964
// 浮点数 double 160.5
// 布林值 bool  true false
/*
string name = "林某";
char sex = 'M';
int age = 15;
double height = 170.5;
bool is_male = true;


System.Console.WriteLine("Hello, World!");
System.Console.WriteLine("登dua郎");
System.Console.WriteLine('a');
System.Console.WriteLine(123);
System.Console.WriteLine(false);
System.Console.WriteLine("-----------------------------");
System.Console.WriteLine(name);
System.Console.WriteLine(sex);
System.Console.WriteLine(age);
System.Console.WriteLine(height);
System.Console.WriteLine(is_male);
System.Console.WriteLine("-----------------------------");
System.Console.WriteLine("有一个人叫" + name);
System.Console.WriteLine(name + "今天" + age + "岁");
System.Console.WriteLine(name + "身高" + height + "公分");
System.Console.WriteLine(name + "讨厌自己" + age);

System.Console.WriteLine("-----------------------------");
// 字串常见的用法

System.Console.WriteLine("Hello\nMr.Lim");
System.Console.WriteLine("Hello\"Mr.Lim");
System.Console.WriteLine("Hello" + "Mr.Lim");
string pharase = "Hello Mr.Lim";
System.Console.WriteLine(pharase + "Mr.Lim");
System.Console.WriteLine(pharase.Length);
System.Console.WriteLine(pharase.ToUpper());
System.Console.WriteLine(pharase.ToLower());
System.Console.WriteLine(pharase.Contains("Hello"));
System.Console.WriteLine(pharase[0]);
System.Console.WriteLine(pharase.IndexOf('H'));
System.Console.WriteLine(pharase.Substring(6,6));

System.Console.WriteLine("-----------------------------");
//数字常见用法（整数 浮点数）

System.Console.WriteLine(System.Math.Round(3.5));


// 取得用户的输入

System.Console.Write("请输入您的名字：");
name = System.Console.ReadLine();
System.Console.Write("请输入您的年纪：");
age = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("你好啊" + name + "你今年" + age);


//基本计算机

System.Console.Write("请输入第一个数：");
double num1 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.Write("请输入第二个数字："); 
double num2 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine(num1 + num2);
*/

// Array 阵列

//int[] scores = { 50, 60, 70, 30, 20 };
//string[] phones = new string[10];

//phones[0] = "0106635666";
//phones[1] = "01120539870";

//System.Console.WriteLine(phones[0]);
//System.Console.WriteLine(phones[1]);

//scores[0] = 90;
//System.Console.WriteLine(scores[0]);
//System.Console.WriteLine(scores[1]);
//System.Console.WriteLine(scores[2]);
//System.Console.WriteLine(scores[3]);
//System.Console.WriteLine(scores[4]);

// if 判断句

//1.
//如果 我肚子饿
//     我就去吃饭

//bool hungry = false;
//if (hungry)
//{
//    System.Console.WriteLine("我就去吃饭");
//}

//2.
//如果 今天有下雨
//    我就开车去上班
//否则
//    我就走路去上班

//bool rainy = false;  
//if (rainy)
//{
//    System.Console.WriteLine("我就开车去上班");
//}
//else
//{
//    System.Console.WriteLine("我就走路去上班");
//}

/*
3.
如果 你考100分
    我给你1000元
或是如果 你考80分以上
    我给你500元
或是如果 你考60分以上
    我给你100元
否则
    你给我300元
*/

//int score = 99;
//if (score == 100)
//{
//    System.Console.WriteLine("我给你1000元");
//}
//else if (score >= 80)
//{
//    System.Console.WriteLine("我给你500元");
//}
//else if (score >= 60)
//{
//    System.Console.WriteLine("我给你100元");
//}
//else
//{
//    System.Console.WriteLine("你给我300元");
//}

/*
4. 
如果 你考100分 且 今天有下雨
    我给你1000元
否则
    我给你100元
 */

//int score = 100;
//bool rainy = true;
//if (score == 100 && rainy)
//{
//    System.Console.WriteLine("我给你1000元");
//}
//else
//{
//    System.Console.WriteLine("你给我100元");
//}

/*
5.
如果 你考100分 或 今天有下雨
    我给你1000分
否则
    我给你100元
 */

//int score = 10;
//bool rainy = true;
//if (score == 100 || rainy)// ||是 或 的意思
//{
//    System.Console.WriteLine("我给你1000元");
//}
//else
//{
//    System.Console.WriteLine("你给我100元");
//}

/*
6.
如果 你没有考100分 或 今天没有下雨
    我给你1000分
否则
    我给你100元
 */

//int score = 100;
//bool rainy = true;
//if (score != 100 || !rainy)// !是否定的意思
//{
//    System.Console.WriteLine("我给你1000元");
//}
//else
//{
//    System.Console.WriteLine("你给我100元");
//}

// 进阶计算机

//System.Console.Write("请输入第一个数：");
//double num1 = System.Convert.ToDouble(System.Console.ReadLine());
//System.Console.Write("请输入要做的运算：");
//string oper = System.Console.ReadLine();
//System.Console.Write("请输入第二个数字：");
//double num2 = System.Convert.ToDouble(System.Console.ReadLine());

//if (oper == "+")
//{
//    System.Console.WriteLine(num1 + num2);
//}
//else if (oper == "-")
//{
//    System.Console.WriteLine(num1 - num2);
//}
//else if (oper == "*")
//{
//    System.Console.WriteLine(num1 * num2);
//}
//else if (oper == "/")
//{
//    System.Console.WriteLine(num1 / num2);
//}
//else
//{
//    System.Console.WriteLine("不合法的运算符号");
//}


// while 迴圈

//int num = 1;
//while (num<=100)
//{
//    System.Console.WriteLine(num);
//    num++;
//}

//do
//{
//    System.Console.WriteLine(num);
//    num++;
//}
//while (num <= 5);


// 猜数字游戏

/*
int guess = 0;
int Key = 100;
int limit = 1;

while (guess != Key && limit != 5)
{
    
    System.Console.Write("请输入数字：");
    guess = System.Convert.ToInt32(System.Console.ReadLine());
    limit++;
    System.Console.WriteLine(limit);
    if (guess > Key)
    {
        System.Console.WriteLine("小一点");
    }
    else if (limit == 5)
    {
        System.Console.WriteLine("你已经输了");
    }
    else if(guess < Key)
    {
        System.Console.WriteLine("大一点");
    }
    else
    {
        System.Console.WriteLine("恭喜你答对了");
    }

}
*/

// for 迴圈

/*
int i = 1;
while (i <= 5)
{
    System.Console.WriteLine(i);
    i++;
}
*/
/*
for (int i = 1; i <= 5; i++)
{
    System.Console.WriteLine(i);
}
*/

/*
int[] nums = {1314, 87, 520, 666, 8964, 785, 12231};

for (int i = 0; i < nums.Length; i++)
{
    System.Console.WriteLine(nums[i]);
}
*/

// 二维阵列
// row 横排
//coluwn 直排

/*
int[,] nums = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int[,] num = new int[3, 4];
num[0,0] = 3;
num[0,1] = 4;

System.Console.WriteLine(num[0, 1]);
System.Console.WriteLine(nums[0 , 1]);
*/

//class类别  object 物件 
//namespace using
// method 方法
//main 方法
using Animal;
using System;

Person person1 = new Person();
person1.height = 169.5;
person1.age = 15;
person1.name = "林某";
//person1.Sayhi();
//person1.IsAdult();
//Console.WriteLine(person1.IsAdult());
Console.WriteLine(person1.Add( 2, 3 ,"qwd"));


Person person2 = new Person();
person2.height = 171.5;
person2.age = 18;
person2.name = "陈某";
//person2.Sayhi();
//person2.IsAdult();
//Console.WriteLine(person2.IsAdult());


//Console.WriteLine(person1.name);
//Console.WriteLine(person2.age);