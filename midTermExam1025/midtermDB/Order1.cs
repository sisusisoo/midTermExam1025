using System;
using System.Collections.Generic;

namespace midTermExam1025.midtermDB;

public partial class Order1
{
    public DateTime Date { get; set; }

    public int Price { get; set; }

    public string OrderState { get; set; } = null!;
}
