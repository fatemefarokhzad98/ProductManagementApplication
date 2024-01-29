using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagementApplication.Products
{
    public enum ProductStockState:byte
    {
        PreOrder,
        InStock,
        NotAvailable,
        Stopped

    }
}
