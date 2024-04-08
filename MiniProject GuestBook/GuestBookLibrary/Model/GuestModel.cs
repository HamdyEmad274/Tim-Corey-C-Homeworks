using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary.Model
{
    public class GuestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MessageToHost { get; set; }
        public int Companies { get; set; }
        public string Guestinfo
        {
            get
            {
                return $"{FirstName} {LastName} : {MessageToHost} i came with {Companies} persons.";
            }
        }
    }
}
