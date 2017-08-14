using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Woods.Models;
using System.Windows.Input;

namespace Woods.Controllers
{
    public class HomeController : Controller
    {
        public List<Message> messages = new List<Message>();
        public Map new_map = new Map();
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.map = new_map;
            foreach(var message in messages){
                System.Console.WriteLine(message.Content);
            }
            ViewBag.messages = messages;
            return View();
        }

        [HttpPost]
        [Route("addmessage")]
        public IActionResult addMessage(string content, string user_name){
            Message new_msg = new Message {
                Content=content,
                PlayerName=user_name
            };
            // System.Console.WriteLine(new_msg.PlayerName +" says: " +new_msg.Content);
            messages.Add(new_msg);
            foreach(var message in messages){
                System.Console.WriteLine(message.Content);
            }
            return RedirectToAction("Index");
        }
    }
}
