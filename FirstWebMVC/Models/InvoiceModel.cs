namespace FirstWebMVC.Models
{
    public class InvoiceModel
    {
        public int Quantity { get; set; }  // Số lượng sản phẩm
        public double UnitPrice { get; set; }  // Đơn giá sản phẩm
        public double TotalPrice { get; set; }  // Tổng tiền hóa đơn
    }
}
