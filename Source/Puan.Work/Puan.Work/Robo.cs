using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puan.Work
{
    public class Robo
    {
        private Task[] _tasksRobo = new Task[1];
        public Robo()
        {
            _tasksRobo[0] = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("OI");
            });
        }
    }
}
