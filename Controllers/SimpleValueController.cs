using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using OrleansWebAPI7AppDemo.Models;

namespace OrleansWebAPI7AppDemo.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SimpleValueController : ControllerBase
    {

        public SimpleValueController()
        {
        }

        [HttpGet()]
        public String TestValue()
        {
            int sum = 0;
            for (int i = 0; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
            }
            return $"答えは {sum} です!";
        }


        [HttpGet()]
        public BankAccount TestArray()
        {
            BankAccount account = new BankAccount("kouji sano",0);
            account.Owner = "佐野浩司";
            return account;
        }

        [HttpGet()]
        public Animal TestObject()
        {
            Animal animal_1 = new Animal();
            animal_1.Name = "ねこぉぉ";
            return animal_1;
        }

        [HttpGet()]
        public IActionResult StatusCode()
        {
            return StatusCode(200);
        }

        [HttpPost()]
        public Animal TestPostObject(Animal animal)
        {
            animal.Age = 20;
            return animal;
        }
    }
}