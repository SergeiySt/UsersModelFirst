//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp14.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Financial_Indicators
    {
        public int EnterpriseId { get; set; }
        public System.DateTime AnalisysDate { get; set; }
        public double PropertyStatus { get; set; }
        public double FinancialStability { get; set; }
        public double LiquidityAndSolvency { get; set; }
        public double BusinessActivity { get; set; }
        public double Profitability { get; set; }
    
        public virtual Enterprise Enterprise { get; set; }
    }
}
