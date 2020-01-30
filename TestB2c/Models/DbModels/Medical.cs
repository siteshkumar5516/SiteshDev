using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DbModels
{
    public class Medical
    {
        public int Id { get; set; }
        public string MedicneName { get; set; }
        public int Number { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int cost { get; set; }
    }
}
