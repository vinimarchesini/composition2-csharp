using System;
using System.Collections.Generic;
using System.Text;

namespace composition2_csharp.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
