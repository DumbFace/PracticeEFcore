using ConventionPractice.Core;
using GeneratorData.Helpers.Constaints;
using GeneratorData.Model;
using GeneratorData.ReadJson;
using GeneratorData.Services;

namespace UnitTestProject;

public class UnitTest1
{
    [Fact]
    public void Test_GetDataJsonName_Success()
    {
        IReadListJson<string> readJsonService = new NameServiceJson<string>();

        List<string> lstName = readJsonService.ReadListJson("F:\\Repo\\PracticeEFcore\\GeneratorData\\Json\\names.json");

        int count = 0;
        foreach (string name in lstName)
        {
            if (count > 10)
            {
                break;
            }
            Console.WriteLine($"Name: {name}");
            count++;
        }
    }

    [Fact]
    public void Test_GetDataJsonAddress_Success()
    {
        IReadJson<RootAddressJson> readJsonService = new AddressServiceJson<RootAddressJson>();

        RootAddressJson root = readJsonService.ReadJson("F:\\Repo\\PracticeEFcore\\GeneratorData\\Json\\addresses.json");

        int count = 0;
        if (root != null)
        {
            foreach (AddressModelJson address in root.Addressess)
            {
                if (count > 10)
                {
                    break;
                }
                Console.WriteLine($"Address: {address.Address1}");
                count++;
            }
        }
    }


    [Fact]
    public void Test_GetDataJsonCourse_Success()
    {
        IReadJson<RootCourseJson> readJsonService = new CourseServiceJson<RootCourseJson>();

        RootCourseJson root = readJsonService.ReadJson("F:\\Repo\\PracticeEFcore\\GeneratorData\\Json\\courses.json");

        int count = 0;

        foreach (CourseJsonModel course in root.Courses)
        {

            if (count > 10)
            {
                break;
            }
            Console.WriteLine($"Course: {course.Link_Name}");
            count++;
        }
    }

    [Fact]
    public void Test_GetRandomEmail_Success()
    {
        string email = Utils.GenerateRandomEmail(10);
        Console.WriteLine(email);
    }
}