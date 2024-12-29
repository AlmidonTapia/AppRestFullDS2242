using DataTransferLayer.Objects;
using DataTransferLayer.OtherObject;
using ServiceLayer.Generic;

namespace ServiceLayer.ServiceObject
{
    public class SoPerson : SoGeneric
    {
        public Response dto { get; set; }
        

        public class Response
        {
            public List<PersonDto> listPerson { get; set; } 
            public PersonDto dtoPerson { get; set; }
            public MessageDto mo { get; set; }
        }
    }
}
