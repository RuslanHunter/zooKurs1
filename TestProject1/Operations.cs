//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestProject1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operations
    {
        public Nullable<int> id_Animal { get; set; }
        public string TypeOfOperation { get; set; }
        public Nullable<int> id_Staff { get; set; }
        public int id_Operations { get; set; }
        public string timeOperations { get; set; }
    
        public virtual Animal Animal { get; set; }
        public virtual Staff Staff { get; set; }
    }
}