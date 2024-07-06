// // // int myInt = 3;
// // // Console.WriteLine($"int: {myInt}");
// // // decimal myDecimal=myInt;
// // // Console.WriteLine($"decimal: {myDecimal}");

// // decimal myDecimal =3.24m;
// // Console.WriteLine($"decimal:{myDecimal}");
// // int myInt=(int)myDecimal;
// // Console.WriteLine($"int: {myInt}");

// // // ToStrin()
// // int first=4;
// // int second=5;
// // string message=first.ToString() + second.ToString();
// // Console.WriteLine(message);

// // string f="5";
// // string s="7";
// // int sum = int.Parse(f) + int.Parse(s);
// // Console.WriteLine(sum);
// // Console.WriteLine();
// // int result=Convert.ToInt32(f)*Convert.ToInt32(s);
// // Console.WriteLine(result);

// // int val=(int)1.5m;
// // Console.WriteLine(val);

// // int val1=Convert.ToInt32(1.5m);
// // Console.WriteLine(val1);


// string value="bad";
// int result = 0;
// if(int.TryParse(value, out result)){
//     Console.WriteLine($"Measurement: {result}");

// }
// else{
//     Console.WriteLine("Unable to report the measurement");
// }
// if(result>0)
//     Console.WriteLine($"Measurement(w/offset):{ 50+ result}");

// // Challenge 1
// string[] values={"12.3", "45", "ABC", "11", "DEF"};
// decimal total=0m;
// string message="";
//  foreach(var value in values){
//     decimal number;
//     if(decimal.TryParse(value, out number)){
//         total+=number;
//     }else{
//         message+=value;
//     }
//  }
// Console.WriteLine($"Mesaage: {message}");
// Console.WriteLine($"Total: {total}");
 
//Challenge 2
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1=Convert.ToInt32(value1/value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2=value2/(decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3=value3/value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
