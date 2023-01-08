using IntegerWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegerWebApp.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {

            /*   var cars = new List<Car>();

               cars.Add(new Car()
               {
                   IdRegistrasi = 1,
                   Type = "Sport",
                   Brand = "Mustang",
                   Varian="RedCandy"

               });


               cars.Add(new Car()
               {
                   IdRegistrasi = 2,
                   Type = "MPV",
                   Brand = "Avanza",
                   Varian = "Silver"

               });


               cars.Add(new Car()
               {
                   IdRegistrasi = 3,
                   Type = "SUV",
                   Brand = "Pajero Sport Dakar",
                   Varian = "Black Mamba"

               });
               //ViewBag.Cars = cars;
               */

               var cars = new Car[]
               {
                   new Car {IdRegistrasi=0001, Type="Sedan",Brand="Toyota",Varian="FT86"},
                   new Car {IdRegistrasi=0002, Type="SUV",Brand="Toyota",Varian="RAV4"},
                   new Car {IdRegistrasi=0003, Type="Sedan",Brand="Honda",Varian="Accord"},
                   new Car {IdRegistrasi=0004, Type="SUV",Brand="Honda",Varian="CRV"},
                   new Car {IdRegistrasi=0005, Type="Sedan",Brand="Honda",Varian="City"},
               };
            ViewBag.Cars = cars;
           // var cari = cars.Single(x=> x.IdRegistrasi==2);
         
            

            
            var soal1 = cars.Where(x => x.Brand == "Honda").FirstOrDefault();
            ViewBag.satu = new List<Car>() { soal1 };


            var soal2 = cars.Where(x => (x.Brand == "Honda" && x.Type == "Sedan"));
            ViewBag.dua = soal2;

            
            var soal3 = cars.Where(x => (x.Brand == "Honda" && x.Varian == "City")).FirstOrDefault();
            ViewBag.tiga = new List<Car>() { soal3 };

            
            var soal4 = cars.Where(x => (x.Brand == "Toyota"));
            ViewBag.empat = soal4;


            var soal5 = cars.Where(x => x.Varian == "City");
            ViewBag.lima = soal5;

            //soal6
            var soal6 = cars.Where(x => x.Brand == "Honda");
            ViewBag.enam = soal6;

            return View();
        }
    }
}
