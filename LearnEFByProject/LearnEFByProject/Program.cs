using LearnEFByProject.DataBase;
using LearnEFByProject.DataBase.Models;

var db = new DataBaseContext();

// adding some products

db.Add(new Product(){Name = "Pen", Price = 15});
db.Add(new Product(){Name = "Pencil", Price = 15});
db.Add(new Product(){Name = "Computer", Price = 15});
db.Add(new Product(){Name = "Laptop", Price = 15});
db.SaveChanges();
