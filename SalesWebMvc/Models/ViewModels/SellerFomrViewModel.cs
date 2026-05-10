namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFomrViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
