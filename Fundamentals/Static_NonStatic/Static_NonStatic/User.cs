namespace Static_NonStatic
{
    public class User
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        private string MachineName = "";
        public User()
        {
            MachineName = CommonResource.GetComputerName();
        }

        public void Insert()
        {
            if (!CommonResource.IsEmpty(CustomerCode) && !CommonResource.IsEmpty(CustomerName))
            {
                //Insert the data
            }
        }
    }
}
