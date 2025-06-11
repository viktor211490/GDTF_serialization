// See https://aka.ms/new-console-template for more information

using ICSharpCode.SharpZipLib.Zip;
using System.Xml.Serialization;
using TestGDTF;
string compressedFile = @"../../../Files/Clay_Paky@Mini-B@1.5._out_for_real_for_Testing_-_updated_Mode_Basic_Basic-16bit_Extended.gdtf"; // сжатый файл

GDTF testClass = new();

await DZL();

Console.ReadLine();


async Task<GDTF> GetDataFrom(Stream xmlFileFromStream)
{
    XmlSerializer serializer = new(typeof(GDTF));
    GDTF? some = serializer.Deserialize(xmlFileFromStream) as GDTF;
    Console.WriteLine(some.FixtureType.Name);
    return some;
}

async Task DZL()
{
    using ZipFile zipFile = new(compressedFile);
    foreach (ZipEntry zip in zipFile)
    {
        Console.WriteLine(zip.Name);
        if (zip.Name.Contains(".xml"))
            testClass = await GetDataFrom(zipFile.GetInputStream(zip));
        using StreamReader reader = new(zipFile.GetInputStream(zip));
        //Console.WriteLine($"Content: {reader.ReadToEnd()}");
        reader.Close();
    }
}