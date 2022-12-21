using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAPI.Entity
{
    public class Members
    {
        public class MemberRequest
        {
            private string name;
            private int age;
            private string address;

            public string memberName
            {
                get{ return name;}
                set { name = value; }
            }
            public int memberAge 
            {
                get { return age; }
                set{ age = value; }
            }
            public string memberAddress
            {
                get { return address; }
                set { address = value; }
            }
        }
        public class MemberResponse
        {
            private Boolean success;
            private string message;

            public Boolean isSucess
            {
                get { return success; }
                set { success = value; }
            }
            public string isMessage
            {
                get { return message; }
                set { message = value; }
            }
        }
    }
}
