//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TablesFuel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fuel
    {
        public int id { get; set; }
        public int AZSid { get; set; }
        public string F_Name { get; set; }
        public Nullable<decimal> F_Price { get; set; }
    
        public virtual AZS AZS { get; set; }
    }
}
