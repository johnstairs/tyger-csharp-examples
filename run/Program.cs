using System.CommandLine;

var inputOption = new Option<string>("--input", "The input file") { IsRequired = true };
inputOption.AddAlias("-i");

var outputOption = new Option<string>("--output", "The output file") { IsRequired = true };
outputOption.AddAlias("-o");

var cmd = new RootCommand() { inputOption, outputOption };

cmd.SetHandler((input, output) =>
    {
        using var inputStream = File.OpenRead(input);
        using var outputStream = File.OpenWrite(output);

        inputStream.CopyTo(outputStream);
    },
    inputOption, outputOption);

return cmd.Invoke(args);