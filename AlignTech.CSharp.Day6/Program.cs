using AlignTech.CSharp.Day6;

//DelegateExample obj = new DelegateExample();

////Step 2: Assign or Reference a method
//MyDelegate del = obj.Message;

////Step 3: Call or Use Delegate
//del("Pradeep");

//MultiCast Delegate
var log = new LogError();

MyDelegate logError = log.LogToFile;
logError += log.LogToConsole;

logError += LogError.StaticMethod;

//logError += LogError.StaticMethod1;

logError("New Exception arised");