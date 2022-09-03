using ALGORITMOS.Models;
using System.Linq;

var db = new netCoreContext();
var usuarios = db.Users.ToList();
foreach(var res in usuarios){
    System.Console.WriteLine($"NameUser: {res.Name} Email: {res.Email} Phone: {res.Phone}");
}
