//Project 1
string? readResult;
string valueEntered="";
int numValue=0;
bool validNum=false;
Console.WriteLine("Enter an integer value between 5 and 10");
do{
    readResult=Console.ReadLine();
    if (readResult!=null){
        valueEntered=readResult;
    }
    validNum=int.TryParse(valueEntered,out numValue);
    if (validNum==true){
        if (numValue<=5|| numValue>=10){
            validNum=false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
}while (validNum == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();

//Project 2
string?readResult;
string roleName;
bool validEntry=false;

do{
    Console.WriteLine("Enter your role(Administrator, Manager or User)");
    readResult= Console.ReadLine();
    if(readResult!=null){
        roleName=readResult.Trim();
    }
    if (roleName.ToLower() == "administrator"|| roleName.ToLower()=="manager"|| roleName.ToLower()=="user"){
        validEntry=true;
    }
    else{
        Console.Write($"The role name that you entered,\"{roleName}\" is not valid.");
    }
}while(validEntry==false);
Console.WriteLine($"Your input value({roleName} has been accepted.");
readResult=Console.ReadLine();

//Project 3
string[] myStrings=new string[2]{"I like pizza. I like roast chicken. I like salad","I like all three of the menu choices"}
int stringsCount=myStrings.Length;
string myString="";
for(int i=0;i<stringsCount;i++){
    myString+=myStrings[i];
    periodLocation=myStrings.IndexOf(".");
    string mySentence;
    while(periodLocation!=-1){
        mySentence=myStrings.Remove(periodLocation);
        myString=myString.Substring(periodLocation+1);
        myString=myString.TrimStart();
        periodLocation=myString.IndexOf(".");
        Console.WriteLine(mySentence);
    }
    mySentence=myStrings.Trim();
    Console.WriteLine(mySentence);
}