using CompositePattern;


Client client = new(CopyProvider.Load());

var newFile = new CustomFile(50, "Test.txt");
var newFolder = new CustomDirectory("NewFolder", new CustomFile(300, "CompositePattern.csproj"));

client.Add(newFile);
client.Add(newFolder);

client.GetValue();

client.Remove(newFile);

client.GetValue();











