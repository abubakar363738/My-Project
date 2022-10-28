using Microsoft.AspNetCore.Hosting;
using My_Project.Modals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace My_Project.Services
{
    public class BookJsonFile
    {
        public BookJsonFile(IWebHostEnvironment webHostEnviornment)
        {
            WebHostEnvironment = webHostEnviornment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }

        public string Jsonfilepath { get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "books.json");

            } 
        }
        public IEnumerable<Book> Showbook_record()
        {
          using (var json_file = File.OpenText(Jsonfilepath))
            {
              return  JsonSerializer.Deserialize<Book[]>(json_file.ReadToEnd());
            }
        } 

    }
}
