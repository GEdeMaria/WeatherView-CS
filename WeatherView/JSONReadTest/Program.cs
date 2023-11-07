// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json.Linq;

Console.WriteLine("Hello, World!");

string json = "{\"data\":{\"elevation\":-1030.40478515625},\"meta\":{\"cost\":1,\"dailyQuota\":10,\"distance\":0.33,\"elevation\":{\"source\":\"GEBCO Compilation Group (2019) GEBCO 2019 Grid (doi:10.5285/836f016a-33be-6ddc-e053-6c86abc0788e)\",\"unit\":\"m\"},\"lat\":0.0,\"lng\":0.0,\"requestCount\":3}}";

JObject obj = JObject.Parse(json);

Console.WriteLine(obj.ToString());

Console.WriteLine(obj["data"]["elevation"].Value<float>());