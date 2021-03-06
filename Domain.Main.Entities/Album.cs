//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain.Main.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Album
    {
        public int AlbumId { get; set; }
        public Nullable<short> GenreId { get; set; }
        public Nullable<short> ArtistId { get; set; }
        public string Title { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string AlbumArtURL { get; set; }
    
        public virtual Artist Artist { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
