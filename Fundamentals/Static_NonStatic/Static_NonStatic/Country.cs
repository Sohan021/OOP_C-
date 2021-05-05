namespace Static_NonStatic
{
    class Country
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        private string ComputerName
        {
            get
            {
                return CommonResource.GetComputerName();
            }
        }
        public void Insert()
        {
            if (!CommonResource.IsEmpty(CountryCode) && !CommonResource.IsEmpty(CountryName))
            {
                //Insert the data
            }
        }
    }
}
