//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UchebPRAOA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int RequestID { get; set; }
        public int StatusID { get; set; }
        public int TechTypeID { get; set; }
        public Nullable<int> MasterID { get; set; }
        public int ClientID { get; set; }
        public string TechModel { get; set; }
        public string Description { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public string RepairParts { get; set; }
        public string MasterComment { get; set; }
        public Nullable<int> Cost { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
        public virtual Status Status { get; set; }
        public virtual TechType TechType { get; set; }
    }
}
