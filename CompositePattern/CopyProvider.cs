namespace CompositePattern
{
    internal class CopyProvider
    {

        static public CustomDirectory Load()
        {
            var bin = new CustomDirectory("bin");
            var obj = (new CustomDirectory("obj"));
            var debug = (new CustomDirectory("Debug"));

            CustomFile[] files = new[] {

            new CustomFile(20, "Directory.cs"),
            new CustomFile(30, "Explorer.cs"),
            new CustomFile(40, "File.cs"),
            new CustomFile(40, "IComponent.cs"),
            new CustomFile(20, "Program.cs"),
            new CustomFile(50, "project.assets")

        };
            bin.Add(debug);

            obj.Add(debug);
            obj.Add(files[5]);

            CustomDirectory _directory = new("CompositePattern");

            _directory.Add(bin);
            _directory.Add(obj);

            foreach (var item in files)
            {
                _directory.Add(item);
            }

            return _directory;
        }


    }
}
