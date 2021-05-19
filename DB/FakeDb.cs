using System.Collections.Generic;
using cSharpGregsList.Models;

namespace cSharpGregsList.DB
{
  public class FakeDb
  {
    public static List<Car> Cars { get; set; } = new List<Car>(){
            new Car("Ford", "Mustang", 2020, 42000, "Cool car!", "https://www.cnet.com/a/img/Sayyn1FzCsWXXgiGuQlUNS3O7cI=/470x264/2019/01/11/f32c9c61-0708-474f-ab73-4792fef0935c/2020-ford-shelby-mustang-gt500-1.jpg")
        };
  }
}