//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practice1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mebel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public Nullable<int> TypeId { get; set; }
        public string Style { get; set; }
        public Nullable<int> Amount { get; set; }
    
        public virtual MebelType MebelType { get; set; }
    }
}
